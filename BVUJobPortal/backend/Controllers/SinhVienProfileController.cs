using BVUJobPortal.DTOs.SinhVien;
using BVUJobPortal.Services.SinhVien;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/sinhvien/profile")]
    public class SinhVienProfileController : ControllerBase
    {
        private readonly ISinhVienProfileService _service;

        public SinhVienProfileController(ISinhVienProfileService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var data = await _service.GetAsync(userId);
            return Ok(data);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update([FromBody] SinhVienProfileDto dto)
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var result = await _service.UpsertAsync(userId, dto);
            return Ok(result);
        }

        [HttpPut("tim-viec")]
        public async Task<IActionResult> CapNhatTrangThaiTimViec(
        [FromBody] CapNhatTrangThaiTimViecDto dto)
        {
            var nguoiDungId = int.Parse(
                User.FindFirstValue(ClaimTypes.NameIdentifier)!
            );

            await _service
                .CapNhatTrangThaiTimViecAsync(nguoiDungId, dto);

            return Ok(new
            {
                message = "Cập nhật trạng thái tìm việc thành công"
            });
        }
    }
}
