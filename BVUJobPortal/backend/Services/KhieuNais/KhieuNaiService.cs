using BVUJobPortal.Data;
using BVUJobPortal.DTOs.KhieuNais;
using BVUJobPortal.Services.ThongBao;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services
{
    public class KhieuNaiService : IKhieuNaiService
    {
        private readonly ApplicationDbContext _context;
        private readonly IThongBaoService _thongBaoService;

        public KhieuNaiService(
            ApplicationDbContext context,
            IThongBaoService thongBaoService)
        {
            _context = context;
            _thongBaoService = thongBaoService;
        }

        public async Task GuiKhieuNaiAsync(int nguoiDungId, GuiKhieuNaiDto dto)
        {
            var khieuNai = new KhieuNai
            {
                NguoiDungId = nguoiDungId,
                NoiDung = dto.NoiDung,
                TrangThai = "DangXuLy",
                NgayGui = DateTime.UtcNow
            };

            _context.KhieuNais.Add(khieuNai);
            await _context.SaveChangesAsync();
        }
        public async Task<List<KhieuNai>> DanhSachAsync()
        {
            return await _context.KhieuNais
                .Include(x => x.NguoiDung)
                .OrderByDescending(x => x.NgayGui)
                .ToListAsync();
        }

        public async Task XuLyAsync(int id, XuLyKhieuNaiDto dto, int adminId)
        {
            var kn = await _context.KhieuNais
                .Include(x => x.NguoiDung)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (kn == null)
                throw new Exception("Không tìm thấy khiếu nại");

            kn.TrangThai = dto.TrangThai;
            kn.PhanHoiAdmin = dto.PhanHoiAdmin;

            if (dto.TrangThai == "DaChapNhan")
            {
                kn.NguoiDung.BiKhoa = false;
                kn.NguoiDung.LyDoKhoa = null;
            }

            //await _thongBaoService.GuiThongBaoAsync(
            //    kn.NguoiDungId,
            //    "Kết quả khiếu nại tài khoản",
            //    dto.TrangThai == "DaChapNhan"
            //        ? "Khiếu nại của bạn đã được chấp nhận. Tài khoản đã được mở khóa."
            //        : "Khiếu nại của bạn đã bị từ chối.",
            //    "/dang-nhap",
            //    "KhieuNai"
            //);

            await _context.SaveChangesAsync();
        }
    }

}
