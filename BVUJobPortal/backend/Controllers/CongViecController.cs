using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.Services.CongViec;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CongViecController : ControllerBase
    {
        private readonly ICongViecService _congViecService;

        public CongViecController(ICongViecService congViecService)
        {
            _congViecService = congViecService;
        }

        [HttpPost("dang-tin")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> DangTin([FromBody] DangTuyenDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { ThongBao = "Dữ liệu không hợp lệ", Loi = ModelState });

            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var dto = await _congViecService.DangTuyenAsync(userId, model);

            return Ok(new
            {
                ThongBao = "Đăng tuyển thành công",
                CongViec = dto
            });
        }

        [HttpPut("chinh-sua/{id}")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> ChinhSua(int id, [FromBody] CapNhatCongViecDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new
                {
                    ThongBao = "Dữ liệu không hợp lệ",
                    Loi = ModelState
                });

            try
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
                var job = await _congViecService.CapNhatCongViecAsync(id, userId, model);

                if (job == null)
                    return NotFound(new
                    {
                        ThongBao = "Không tìm thấy công việc hoặc bạn không có quyền chỉnh sửa"
                    });

                return Ok(new
                {
                    ThongBao = "Cập nhật công việc thành công",
                    CongViec = job
                });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new
                {
                    ThongBao = ex.Message
                });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new
                {
                    ThongBao = ex.Message
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    ThongBao = "Đã xảy ra lỗi hệ thống",
                    ChiTiet = ex.Message
                });
            }
        }

=
        [HttpDelete("xoa/{id}")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> Xoa(int id)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ok = await _congViecService.XoaCongViecAsync(id, userId);

            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy công việc hoặc bạn không có quyền xóa" });

            return Ok(new { ThongBao = "Đã thu hồi bài đăng thành công" });
        }

        //[AllowAnonymous]
        //[HttpPost("tim-kiem")]
        //public async Task<IActionResult> TimKiem([FromBody] CongViecSearchDto filter)
        //{
        //    var data = await _congViecService.TimKiemCongViecAsync(filter);
        //    return Ok(data);
        //}


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> XemChiTiet(int id)
        {
            var job = await _congViecService.LayChiTietCongViecAsync(id);
            if (job == null)
                return NotFound(new { ThongBao = "Không tìm thấy công việc" });

            return Ok(job);
        }

        [HttpGet("lich-su-dang-tuyen")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> LichSuDangTuyen()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ds = await _congViecService.DanhSachDangTuyenAsync(userId);

            return Ok(ds);
        }

        [HttpGet("tat-ca")]
        [AllowAnonymous]
        public async Task<IActionResult> DanhSachTatCa()
        {
            var ds = await _congViecService.DanhSachTatCaAsync();
            return Ok(ds);
        }
    }
}
