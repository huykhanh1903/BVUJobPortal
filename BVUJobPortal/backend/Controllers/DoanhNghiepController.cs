using BVUJobPortal.DTOs.DoanhNghiep;
using BVUJobPortal.Models;
using BVUJobPortal.Services.DoanhNghiep;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BVUJobPortal.Data;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoanhNghiepController : ControllerBase
    {
        private readonly IDoanhNghiepService _service;
        private readonly ApplicationDbContext _context;

        public DoanhNghiepController(IDoanhNghiepService service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpPost("them-hr")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> TaoHR([FromBody] TaoHRDto dto)
        {
            var adminCongTyId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var hr = await _service.TaoHRAsync(adminCongTyId, dto);
            if (hr == null) return BadRequest(new { ThongBao = "Không thể tạo HR" });
            return Ok(new { ThongBao = "Đã thêm HR mới", DuLieu = hr });
        }

        [HttpGet("hr/{hrId}")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> ChiTietHR(int hrId)
        {
            try
            {
                var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

                var hr = await _service.ChiTietHRAsync(adminId, hrId);
                if (hr == null)
                    return NotFound(new { ThongBao = "Không tìm thấy HR hoặc HR không thuộc công ty của bạn." });

                return Ok(new { ThanhCong = true, DuLieu = hr });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ThanhCong = false, ThongBao = ex.Message });
            }
        }

        [HttpGet("kiem-tra-cong-ty/{maCongTy}")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> KiemTraCongTy(string maCongTy)
        {
            if (string.IsNullOrWhiteSpace(maCongTy))
                return BadRequest(new { ThongBao = "Vui lòng nhập mã công ty." });

            try
            {
                var congTy = await _context.CongTys
                    .Include(c => c.TinhThanh)
                    .Include(c => c.NhaTuyenDungs)
                    .Where(c => c.DaDuocAdminXacMinh)
                    .FirstOrDefaultAsync(c =>
                        (c.Ma ?? "").ToLower() == maCongTy.Trim().ToLower()
                    );

                if (congTy == null)
                    return NotFound(new
                    {
                        ThanhCong = false,
                        ThongBao = "❌ Không tìm thấy công ty có mã này hoặc công ty chưa được admin xác minh."
                    });

                var soCongViec = await _context.CongViecs.CountAsync(v => v.CongTyId == congTy.Id);

                return Ok(new
                {
                    ThanhCong = true,
                    ThongTinCongTy = new
                    {
                        congTy.Id,
                        congTy.Ma,
                        congTy.LogoUrl,
                        congTy.TenCongTy,
                        congTy.DiaChiLamViec,

                        TinhThanh = congTy.TinhThanh == null ? null : new
                        {
                            congTy.TinhThanh.Id,
                            congTy.TinhThanh.MaTinh,
                            congTy.TinhThanh.TenTinh
                        },

                        congTy.Website,
                        congTy.EmailLienHe,
                        congTy.SoDienThoaiLienHe,

                        SoLuongHR = congTy.NhaTuyenDungs.Count(x => x.VaiTroCongTy == "HR"),
                        SoLuongCongViec = soCongViec
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    ThongBao = "Lỗi khi kiểm tra công ty.",
                    ChiTiet = ex.Message
                });
            }
        }

        [HttpPost("hr/xin-xac-thuc")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> XinXacThuc([FromBody] XinXacThucHRDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.MaCongTy))
                return BadRequest(new { ThongBao = "Vui lòng nhập mã công ty hợp lệ." });

            try
            {
                var hrId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
                var ketQua = await _service.GuiYeuCauXacThucHRAsync(hrId, dto);

                if (!ketQua)
                    return BadRequest(new { ThanhCong = false, ThongBao = "Không thể gửi yêu cầu xác thực." });

                return Ok(new
                {
                    ThanhCong = true,
                    ThongBao = "✅ Đã gửi yêu cầu xác thực công ty thành công. Vui lòng chờ phản hồi từ công ty."
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    ThanhCong = false,
                    ThongBao = ex.Message
                });
            }
        }

        [HttpPut("xac-thuc-hr")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> XacThucHR([FromBody] XacThucHRDto dto)
        {
            var adminCongTyId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ok = await _service.XacThucHRAsync(adminCongTyId, dto);
            if (!ok) return BadRequest(new { ThongBao = "Không thể xác thực HR" });
            return Ok(new { ThongBao = "Đã cập nhật trạng thái xác thực" });
        }

        [HttpGet("hr-cho-xac-thuc")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> DanhSachHRChoXacThuc()
        {
            var adminCongTyId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ds = await _service.DanhSachHRChoXacThucAsync(adminCongTyId);

            if (ds == null || ds.Count == 0)
                return Ok(new { ThongBao = "Không có HR nào đang chờ xác thực." });

            return Ok(new { ThongBao = $"Tìm thấy {ds.Count} HR đang chờ xác thực.", DuLieu = ds });
        }

        [HttpGet("hr-da-xac-thuc")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> DanhSachHRDaXacThuc()
        {
            var adminCongTyId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ds = await _service.DanhSachHRDaXacThucAsync(adminCongTyId);

            if (ds == null || ds.Count == 0)
                return Ok(new { ThongBao = "Hiện chưa có HR nào được xác thực." });

            return Ok(new { ThongBao = $"Tìm thấy {ds.Count} HR đã được xác thực.", DuLieu = ds });
        }

        [HttpPut("hr/huy-xac-thuc")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> HuyXacThucHR([FromBody] HuyXacThucHRDto dto)
        {
            var adminCongTyId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ok = await _service.HuyXacThucHRAsync(adminCongTyId, dto);

            if (!ok)
                return BadRequest(new { ThongBao = "Không thể hủy xác thực HR này." });

            return Ok(new { ThongBao = "✅ Đã hủy xác thực HR thành công." });
        }

        [HttpPut("duyet-cong-viec")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> CongTyDuyetTin([FromBody] CongTyDuyetCongViecDto dto)
        {
            var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var result = await _service.CongTyDuyetCongViecAsync(adminId, dto);

            return Ok(new { thongBao = "Duyệt thành công" });
        }

        [HttpGet("cong-viec-cho-duyet")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> DanhSachCongViecChoDuyet()
        {
            var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var ds = await _service.DanhSachCongViecChoDuyetAsync(adminId);

            return Ok(new
            {
                thanhCong = true,
                tongSo = ds.Count,
                duLieu = ds
            });
        }

        [HttpGet("cong-viec-da-duyet")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> DanhSachCongViecDaDuyet()
        {
            var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var ds = await _service.DanhSachCongViecDaDuyetAsync(adminId);

            return Ok(new
            {
                thanhCong = true,
                tongSo = ds.Count,
                duLieu = ds
            });
        }

        [HttpPut("tu-choi-cong-viec")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> TuChoiCongViec([FromBody] TuChoiDuyetCongViecDto dto)
        {
            var adminId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var kq = await _service.TuChoiDuyetCongViecAsync(adminId, dto);

            return Ok(new
            {
                thanhCong = kq,
                thongBao = "❌ Đã từ chối duyệt tin tuyển dụng.",
                lyDo = dto.LyDo
            });
        }
    }
}
