using BVUJobPortal.DTOs;
using BVUJobPortal.Services.BaoCao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaoCaoController : ControllerBase
    {
        private readonly IBaoCaoService _service;

        public BaoCaoController(IBaoCaoService service)
        {
            _service = service;
        }

        [HttpPost("gui")]
        [Authorize]
        public async Task<IActionResult> GuiBaoCao([FromBody] BaoCaoNoiDungDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var bc = await _service.GuiBaoCaoAsync(userId, dto);

            return Ok(new
            {
                ThongBao = "Đã gửi báo cáo",
                BaoCao = new
                {
                    bc.Id,
                    bc.LyDo,
                    bc.TrangThai,
                    bc.NgayBaoCao
                }
            });
        }

        [HttpGet("danh-sach")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DanhSachBaoCao()
        {
            var ds = await _service.DanhSachBaoCaoAsync();
            return Ok(ds.Select(b => new
            {
                b.Id,
                b.LyDo,
                b.TrangThai,
                b.NgayBaoCao,
                NguoiBaoCao = b.NguoiBaoCao,
                CongViec = b.CongViec,
                CV = b.CV
            }));
        }

        [HttpPut("{id}/xu-ly")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> XuLyBaoCao(int id, [FromBody] AdminXuLyBaoCaoDto dto)
        {
            var bc = await _service.XuLyBaoCaoAsync(id, dto.TrangThai);
            if (bc == null) return NotFound(new { ThongBao = "Không tìm thấy báo cáo" });

            return Ok(new
            {
                ThongBao = "Đã xử lý báo cáo",
                BaoCao = new
                {
                    bc.Id,
                    bc.LyDo,
                    bc.TrangThai,
                    bc.NgayBaoCao
                }
            });
        }
    }
}
