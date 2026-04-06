using Microsoft.AspNetCore.Mvc;
using BVUJobPortal.Services.TuKhoa;
using BVUJobPortal.DTOs.TuKhoa;
using BVUJobPortal.DTOs.CongTy;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TuKhoaController : ControllerBase
    {
        private readonly ITuKhoaService _service;

        public TuKhoaController(ITuKhoaService service)
        {
            _service = service;
        }

        [HttpPost("ghi-nhan")]
        public async Task<IActionResult> GhiNhan([FromQuery] string tuKhoa)
        {
            await _service.LuuTuKhoaAsync(tuKhoa);
            return Ok(new { message = "Đã ghi nhận từ khóa" });
        }

        [HttpGet("top")]
        public async Task<IActionResult> Top([FromQuery] int top = 10)
        {
            return Ok(await _service.LayTopTuKhoaHeThongAsync(top));
        }

        [HttpGet("top-linhvuc/{id}")]
        public async Task<IActionResult> TopTheoLinhVuc(int id, [FromQuery] int top = 10)
        {
            return Ok(await _service.LayTopTuKhoaTheoLinhVucAsync(id, top));
        }

        [HttpGet("top-nganhnghe/{id}")]
        public async Task<IActionResult> TopTheoNganhNghe(int id, [FromQuery] int top = 10)
        {
            return Ok(await _service.LayTopTuKhoaTheoNganhNgheAsync(id, top));
        }

        [HttpGet("top-chuyennganh/{id}")]
        public async Task<IActionResult> TopTheoChuyenNganh(int id, [FromQuery] int top = 10)
        {
            return Ok(await _service.LayTopTuKhoaTheoChuyenNganhAsync(id, top));
        }

        [HttpPost("tim-kiem-cong-ty")]
        public async Task<IActionResult> TimKiemCongTy([FromBody] CongTySearchDto filter)
        {
            var result = await _service.TimKiemCongTyAsync(filter);
            return Ok(result);
        }

        [HttpPost("tim-kiem-cong-viec")]
        public async Task<IActionResult> TimKiemCongViec([FromBody] CongViecSearchDto filter)
        {
            var result = await _service.TimKiemCongViecAsync(filter);
            return Ok(result);
        }
}
}
