using BVUJobPortal.Data;
using BVUJobPortal.DTOs.KhieuNais;
using BVUJobPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/khieu-nai")]
    public class KhieuNaiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KhieuNaiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> GuiKhieuNai([FromBody] GuiKhieuNaiDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var daGui = await _context.KhieuNais.AnyAsync(x =>
                x.NguoiDungId == userId &&
                x.TrangThai == "DangXuLy"
            );

            if (daGui)
            {
                return BadRequest(new
                {
                    thongBao = "Bạn đã gửi khiếu nại trước đó. Vui lòng chờ quản trị viên xử lý."
                });
            }

            var khieuNai = new KhieuNai
            {
                NguoiDungId = userId,
                NoiDung = dto.NoiDung,
                TrangThai = "DangXuLy",
                NgayGui = DateTime.UtcNow
            };

            _context.KhieuNais.Add(khieuNai);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                thongBao = "Gửi khiếu nại thành công. Vui lòng chờ phản hồi từ quản trị viên."
            });
        }

        [HttpGet("trang-thai")]
        [Authorize]
        public async Task<IActionResult> TrangThaiKhieuNai()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var kn = await _context.KhieuNais
                .Where(x => x.NguoiDungId == userId)
                .OrderByDescending(x => x.NgayGui)
                .Select(x => new
                {
                    x.TrangThai,
                    x.PhanHoiAdmin
                })
                .FirstOrDefaultAsync();

            return Ok(kn);
        }


        [HttpGet("cua-toi")]
        [Authorize]
        public async Task<IActionResult> KhieuNaiCuaToi()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var ds = await _context.KhieuNais
                .Where(x => x.NguoiDungId == userId)
                .OrderByDescending(x => x.NgayGui)
                .Select(x => new
                {
                    x.Id,
                    x.NoiDung,
                    x.NgayGui,
                    x.TrangThai,
                    x.PhanHoiAdmin
                })
                .ToListAsync();

            return Ok(ds);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> DanhSachKhieuNai()
        {
            var ds = await _context.KhieuNais
                .Include(x => x.NguoiDung)
                .OrderByDescending(x => x.NgayGui)
                .Select(x => new
                {
                    x.Id,
                    NguoiDung = new
                    {
                        x.NguoiDung.Id,
                        x.NguoiDung.HoTen,
                        x.NguoiDung.Email,
                        x.NguoiDung.VaiTro
                    },
                    x.NoiDung,
                    x.NgayGui,
                    x.TrangThai,
                    x.PhanHoiAdmin
                })
                .ToListAsync();

            return Ok(ds);
        }

        [HttpPut("{id}/xu-ly")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> XuLyKhieuNai(int id,[FromBody] XuLyKhieuNaiDto dto)
        {
            if (dto.TrangThai != "DaChapNhan" && dto.TrangThai != "TuChoi")
            {
                return BadRequest(new
                {
                    thongBao = "Trạng thái không hợp lệ."
                });
            }

            var khieuNai = await _context.KhieuNais
                .Include(x => x.NguoiDung)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (khieuNai == null)
                return NotFound(new { thongBao = "Không tìm thấy khiếu nại." });

            khieuNai.TrangThai = dto.TrangThai;
            khieuNai.PhanHoiAdmin = dto.PhanHoiAdmin;

            if (dto.TrangThai == "DaChapNhan")
            {
                khieuNai.NguoiDung.BiKhoa = false;
                khieuNai.NguoiDung.LyDoKhoa = null;
            }

            await _context.SaveChangesAsync();

            return Ok(new
            {
                thongBao = "Đã xử lý khiếu nại thành công."
            });
        }
    }
}
