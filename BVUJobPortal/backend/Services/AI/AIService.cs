using OpenAI;
using OpenAI.Chat;
using Microsoft.Extensions.Configuration;
using BVUJobPortal.Services.System;
using BVUJobPortal.Data;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace BVUJobPortal.Services.AI
{
    public class AIService : IAIService
    {
        private readonly OpenAIClient _client;
        private readonly SystemConfigService _configService;
        private readonly ApplicationDbContext _context;

        public AIService(
            IConfiguration config,
            SystemConfigService configService,
            ApplicationDbContext context)
        {
            _client = new OpenAIClient(config["OpenAI:ApiKey"]);
            _configService = configService;
            _context = context;
        }

        public async Task<string> AskAsync(string message, int userId)
        {
            _context.ChatMessages.Add(new AppChatMessage
            {
                SenderId = userId,
                ReceiverId = 0,
                Message = message,
                IsFromAI = false
            });
            await _context.SaveChangesAsync();

            bool isOn = await _configService.IsAiEnabledAsync();

            if (!isOn)
            {
                var admin = await _context.NguoiDungs
                    .Where(x => x.VaiTro == "SuperAdmin" || x.VaiTro == "Admin")
                    .FirstAsync();

                _context.ChatMessages.Add(new AppChatMessage
                {
                    SenderId = userId,
                    ReceiverId = admin.Id,
                    Message = message,
                    IsFromAI = false
                });

                await _context.SaveChangesAsync();

                return "🤖 AI hiện đang tắt. Tin nhắn của bạn đã được chuyển đến quản trị viên.";
            }

            var context = await BuildContextAsync(message);

            var prompt = $"""
                Bạn là trợ lý AI của hệ thống BVU Job Portal.
                Hãy trả lời ngắn gọn, rõ ràng, đúng dữ liệu hệ thống.

                DỮ LIỆU HỆ THỐNG:
                {context}

                CÂU HỎI NGƯỜI DÙNG:
                {message}
                """;

            var chatClient = _client.GetChatClient("gpt-4o-mini");

            var response = await chatClient.CompleteChatAsync(
                new ChatMessage[]
                {
                    new SystemChatMessage("Bạn là trợ lý tuyển dụng thông minh của BVU."),
                    new UserChatMessage(prompt)
                }
            );

            var answer = response.Value.Content[0].Text;

            _context.ChatMessages.Add(new AppChatMessage
            {
                SenderId = 0,
                ReceiverId = userId,
                Message = answer,
                IsFromAI = true
            });

            await _context.SaveChangesAsync();

            return answer;
        }

        private async Task<string> BuildContextAsync(string message)
        {
            message = message.ToLower();

            if (message.Contains("tổng quan")
                || message.Contains("toàn bộ")
                || message.Contains("hệ thống"))
            {
                var tongSinhVien = await _context.NguoiDungs
                    .CountAsync(x => x.VaiTro == "SinhVien");

                var tongNhaTuyenDung = await _context.NguoiDungs
                    .CountAsync(x => x.VaiTro == "NhaTuyenDung");

                var tongCongViec = await _context.CongViecs.CountAsync();

                var dangTimViec = await _context.SinhVienProfiles
                    .CountAsync(x => x.DangTimViec && x.ChoPhepNhaTuyenDungTim);

                return $"""
        TỔNG QUAN HỆ THỐNG BVU JOB PORTAL:
        - Tổng sinh viên: {tongSinhVien}
        - Sinh viên đang tìm việc: {dangTimViec}
        - Nhà tuyển dụng: {tongNhaTuyenDung}
        - Công việc đang đăng: {tongCongViec}
        """;
            }

            if (message.Contains("ứng viên")
                || message.Contains("tìm việc"))
            {
                var ungViens = await _context.SinhVienProfiles
                    .Include(x => x.NguoiDung)
                    .Include(x => x.KyNangs)
                    .Where(x => x.DangTimViec && x.ChoPhepNhaTuyenDungTim)
                    .Take(5)
                    .ToListAsync();

                if (!ungViens.Any())
                    return "Hiện tại không có sinh viên nào đang tìm việc.";

                var sb = new StringBuilder();
                sb.AppendLine("Một số sinh viên đang tìm việc:");

                int i = 1;
                foreach (var sv in ungViens)
                {
                    sb.AppendLine($"{i}. {sv.NguoiDung!.HoTen}");
                    sb.AppendLine($"   Ngành nghề mong muốn: {sv.NganhNgheMongMuon}");
                    sb.AppendLine($"   Kỹ năng: {string.Join(", ", sv.KyNangs.Select(k => k.TenKyNang))}");
                    i++;
                }

                return sb.ToString();
            }
            if (message.Contains("công việc")
                || message.Contains("tuyển dụng"))
            {
                var count = await _context.CongViecs.CountAsync();
                return $"Hiện tại hệ thống có {count} công việc đang được đăng tuyển.";
            }

            if (message.Contains("sinh viên"))
            {
                var count = await _context.NguoiDungs
                    .CountAsync(x => x.VaiTro == "SinhVien");

                return $"Hiện tại hệ thống có {count} sinh viên.";
            }

            if (message.Contains("kỹ năng"))
            {
                var skills = await _context.KyNangChuyenMonSinhViens
                    .GroupBy(x => x.TenKyNang)
                    .Select(g => new { Ten = g.Key, SoLuong = g.Count() })
                    .OrderByDescending(x => x.SoLuong)
                    .Take(5)
                    .ToListAsync();

                if (!skills.Any())
                    return "Hiện tại chưa có dữ liệu kỹ năng.";

                var sb = new StringBuilder();
                sb.AppendLine("Các kỹ năng phổ biến trong hệ thống:");

                foreach (var s in skills)
                {
                    sb.AppendLine($"- {s.Ten}: {s.SoLuong} sinh viên");
                }

                return sb.ToString();
            }
            return """
                Xin lỗi, hiện tại tôi chỉ có thể trả lời các câu hỏi liên quan đến:
                - Sinh viên
                - Ứng viên đang tìm việc
                - Công việc tuyển dụng
                - Kỹ năng
                - Tổng quan hệ thống
                """;
                    }

    }
}
