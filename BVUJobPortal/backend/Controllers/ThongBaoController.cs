using BVUJobPortal.DTOs.ThongBao;
using BVUJobPortal.Services.ThongBao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ThongBaoController : ControllerBase
    {
        private readonly IThongBaoService _thongBaoService;

        public ThongBaoController(IThongBaoService thongBaoService)
        {
            _thongBaoService = thongBaoService;
        }

        [HttpGet("danh-sach")]
        public async Task<IActionResult> DanhSach()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ds = await _thongBaoService.LayThongBaoAsync(userId);
            return Ok(ds);
        }

        [HttpGet("chua-doc")]
        public async Task<IActionResult> DemChuaDoc()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var soLuong = await _thongBaoService.DemThongBaoChuaDocAsync(userId);
            return Ok(soLuong);
        }

        [HttpPost("danh-dau-doc/{id}")]
        public async Task<IActionResult> DanhDauDaDoc(int id)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ok = await _thongBaoService.DanhDauDaDocAsync(id, userId);

            if (!ok)
                return NotFound(new { message = "Không tìm thấy thông báo" });

            return Ok(new { message = "Đã đánh dấu là đã đọc" });
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPost("gui")]
        public async Task<IActionResult> GuiThongBao([FromBody] GuiThongBaoRequest dto)
        {
            var tb = await _thongBaoService.GuiThongBaoAsync(
                dto.UserId,
                dto.TieuDe,
                dto.NoiDung,
                dto.Url,
                dto.Loai
            );

            return Ok(tb);
        }
    }

}
