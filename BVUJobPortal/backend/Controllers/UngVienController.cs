using BVUJobPortal.DTOs.UngVien;
using BVUJobPortal.Services.UngVien;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/ung-vien")]
    [Authorize(Roles = "NhaTuyenDung")]
    public class UngVienController : ControllerBase
    {
        private readonly IUngVienService _ungVienService;

        public UngVienController(IUngVienService ungVienService)
        {
            _ungVienService = ungVienService;
        }

        [HttpPost("tim-kiem")]
        public async Task<IActionResult> TimKiem([FromBody] TimUngVienDto dto)
        {
            var result = await _ungVienService.TimUngVienAsync(dto);
            return Ok(result);
        }

        [HttpGet("dang-tim-viec")]
        public async Task<IActionResult> LayDanhSachDangTimViec()
        {
            var result = await _ungVienService.LayDanhSachDangTimViecAsync();
            return Ok(result);
        }

        [HttpGet("{id}/chi-tiet")]
        public async Task<IActionResult> LayChiTietUngVien(int id)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _ungVienService.LayChiTietUngVienAsync(id, userId);

            if (result == null)
                return NotFound(new { message = "Không tìm thấy ứng viên" });

            return Ok(result);
        }

    }
}
