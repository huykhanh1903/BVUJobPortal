using BVUJobPortal.DTOs.UngTuyen;
using BVUJobPortal.DTOs.UngVien;
using BVUJobPortal.Services.UngTuyen;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UngTuyenController : ControllerBase
    {
        private readonly IUngTuyenService _ungTuyenService;

        public UngTuyenController(IUngTuyenService ungTuyenService)
        {
            _ungTuyenService = ungTuyenService;
        }
        [HttpPost("nop-don")]
        [Authorize(Roles = "SinhVien")]
        public async Task<IActionResult> NopDon([FromForm] UngTuyenDto model)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _ungTuyenService.UngTuyenAsync(userId, model);

            if (result.Error == "JOB_NOT_FOUND")
                return Ok(new
                {
                    success = false,
                    message = "Không tìm thấy công việc."
                });

            if (result.Error == "ALREADY_APPLIED")
                return Ok(new
                {
                    success = false,
                    message = "Bạn đã ứng tuyển công việc này rồi."
                });

            return Ok(new
            {
                success = true,
                message = "Ứng tuyển thành công",
                data = result.Don
            });
        }

        [HttpGet("danh-sach")]
        [Authorize(Roles = "SinhVien")]
        public async Task<IActionResult> DanhSachSinhVien()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ds = await _ungTuyenService.DanhSachUngTuyenAsync(userId);
            return Ok(ds);
        }

        [HttpGet("lich-su")]
        [Authorize(Roles = "SinhVien")]
        public async Task<IActionResult> LichSuUngTuyen()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ds = await _ungTuyenService.LichSuUngTuyenAsync(userId);
            return Ok(ds);
        }

        [HttpGet("ntd/danh-sach")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> DanhSachChoNTD()
        {
            var ntdId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ds = await _ungTuyenService.DanhSachDonChoNhaTuyenDungAsync(ntdId);

            return Ok(ds);
        }

        [HttpGet("ntd/chi-tiet/{donId}")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> ChiTietDonNTD(int donId)
        {
            var ntdId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var don = await _ungTuyenService.ChiTietDonChoNhaTuyenDungAsync(ntdId, donId);

            if (don == null)
                return NotFound(new { ThongBao = "Không tìm thấy đơn ứng tuyển" });

            return Ok(don);
        }

        [HttpPost("ntd/chap-nhan/{donId}")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> ChapNhan(int donId)
        {
            var ntdId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _ungTuyenService.DuyetDonAsync(ntdId, donId);

            return Ok(new
            {
                success = result.Success,
                message = result.Message
            });
        }


        [HttpPost("ntd/tu-choi/{donId}")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> TuChoi(int donId)
        {
            var ntdId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _ungTuyenService.TuChoiDonAsync(ntdId, donId);

            return Ok(new
            {
                success = result.Success,
                message = result.Message
            });
        }


        [HttpGet("ntd/cv/{donId}")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> TaiCv(int donId)
        {
            var ntdId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var cvInfo = await _ungTuyenService.GetCvInfoAsync(ntdId, donId);

            if (cvInfo == null)
                return NotFound(new { ThongBao = "Không tìm thấy CV của ứng viên" });

            return Ok(cvInfo);
        }
    }
}
