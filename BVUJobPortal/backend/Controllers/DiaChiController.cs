using BVUJobPortal.DTOs.DiaChi;
using BVUJobPortal.Services.DiaChi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiaChiController : ControllerBase
    {
        private readonly IDiaChiService _service;

        public DiaChiController(IDiaChiService service)
        {
            _service = service;
        }

        [HttpGet("tinh-thanh")]
        [AllowAnonymous]
        public async Task<IActionResult> DanhSachTinhThanh()
        {
            var ds = await _service.DanhSachTinhThanhAsync();
            return Ok(ds);
        }

        [HttpPost("tinh-thanh")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> TaoTinhThanh([FromBody] TinhThanhDto dto)
        {
            var result = await _service.TaoTinhThanhAsync(dto);
            return Ok(result);
        }
    }
}
