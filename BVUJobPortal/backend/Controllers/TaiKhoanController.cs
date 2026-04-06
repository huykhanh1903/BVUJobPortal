using BVUJobPortal.Data;
using BVUJobPortal.DTOs.TaiKhoan;
using BVUJobPortal.Services.TaiKhoan;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaiKhoanController : ControllerBase
    {
        private readonly ITaiKhoanService _taiKhoanService;
        private readonly ApplicationDbContext _context;

        public TaiKhoanController(ApplicationDbContext context, ITaiKhoanService taiKhoanService)
        {
            _taiKhoanService = taiKhoanService;
            _context = context;
        }

        [HttpPost("dang-ky")]
        [AllowAnonymous]
        public async Task<IActionResult> DangKy([FromBody] DangKyDto model)
        {
            var nguoiDung = await _taiKhoanService.DangKyAsync(model);
            if (nguoiDung == null)
                return BadRequest(new { ThongBao = "Email đã tồn tại hoặc vai trò không hợp lệ." });

            return Ok(new
            {
                ThongBao = "Đăng ký thành công",
                NguoiDung = new
                {
                    nguoiDung.Id,
                    nguoiDung.HoTen,
                    nguoiDung.Email,
                    nguoiDung.VaiTro
                }
            });
        }

        [HttpPost("xac-thuc-email")]
        [AllowAnonymous]
        public async Task<IActionResult> XacThucEmail(XacThucEmailDto model)
        {
            var result = await _taiKhoanService.XacThucEmailAsync(model);

            if (!result)
                return BadRequest(new { thongBao = "Mã OTP không hợp lệ hoặc đã hết hạn." });

            return Ok(new { thongBao = "Xác thực email thành công!" });
        }

        [HttpPost("gui-lai-otp")]
        [AllowAnonymous]
        public async Task<IActionResult> ResendOtp([FromBody] VerifyEmailDto dto)
        {
            var result = await _taiKhoanService.ResendOtpAsync(dto.Email);

            if (!result.Success)
                return BadRequest(new { thongBao = result.Message });

            return Ok(new { thongBao = result.Message });
        }

        [HttpPost("dang-nhap")]
        [AllowAnonymous]
        public async Task<IActionResult> DangNhap([FromBody] DangNhapDto model)
        {
            var resp = await _taiKhoanService.DangNhapAsync(model);

            if (resp == null)
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Sai email hoặc mật khẩu."
                });
            }

            if (resp.BiKhoa)
            {
                return Ok(new
                {
                    success = false,
                    biKhoa = true,
                    lyDo = resp.LyDoKhoa,
                    token = resp.AccessToken,
                    nguoiDung = resp.NguoiDung,
                    message = "Tài khoản đã bị khóa."
                });
            }

            if (resp.CanXacThucEmail)
            {
                return Ok(new
                {
                    success = false,
                    requireOtp = true,
                    email = resp.Email,
                    message = resp.Message
                });
            }

            return Ok(new
            {
                success = true,
                token = resp.AccessToken,
                nguoiDung = resp.NguoiDung,
                message = "Đăng nhập thành công."
            });
        }


        [HttpPost("quen-mat-khau")]
        [AllowAnonymous]
        public async Task<IActionResult> QuenMatKhau([FromBody] ForgotPasswordRequestDto dto)
        {
            var ok = await _taiKhoanService.GuiOtpQuenMatKhauAsync(dto.Email);

            if (!ok)
                return NotFound(new { thongBao = "Email không tồn tại trong hệ thống." });

            return Ok(new { thongBao = "OTP đặt lại mật khẩu đã gửi về email." });
        }

        [HttpPost("dat-lai-mat-khau")]
        [AllowAnonymous]
        public async Task<IActionResult> DatLaiMatKhau([FromBody] VerifyForgotPasswordDto dto)
        {
            var ok = await _taiKhoanService.DatLaiMatKhauAsync(dto.Email, dto.Otp, dto.MatKhauMoi);

            if (!ok)
                return BadRequest(new { thongBao = "OTP không hợp lệ hoặc đã hết hạn." });

            return Ok(new { thongBao = "Đặt lại mật khẩu thành công! Vui lòng đăng nhập bằng mật khẩu mới." });
        }


        [HttpPut("cap-nhat-doanh-nghiep")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> CapNhatThongTinDoanhNghiep([FromBody] CapNhatDoanhNghiepDto dto)
        {
            var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userIdStr))
                return Unauthorized(new { ThongBao = "Không xác định được người dùng." });

            int userId = int.Parse(userIdStr);

            try
            {
                var result = await _taiKhoanService.CapNhatThongTinDoanhNghiepAsync(userId, dto);
                if (result == null)
                    return NotFound(new { ThongBao = "Không tìm thấy tài khoản hoặc công ty." });

                return Ok(new { ThongBao = "✅ Cập nhật thông tin doanh nghiệp thành công." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ThongBao = ex.Message });
            }
        }

        [HttpGet("thong-tin")]
        [Authorize]
        public async Task<IActionResult> GetThongTin()
        {
            var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userIdStr))
                return Unauthorized(new { ThongBao = "Không xác định được người dùng." });

            int userId = int.Parse(userIdStr);

            var nguoiDung = await _context.NguoiDungs
                .Include(u => u.CongTy)
                    .ThenInclude(c => c.TinhThanh)
                .Include(u => u.CongTy)
                    .ThenInclude(c => c.NhaTuyenDungs)
                .Include(u => u.CongTy)
                    .ThenInclude(c => c.CongViecs)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (nguoiDung == null)
                return NotFound(new { ThongBao = "Không tìm thấy người dùng." });

            string? avatarFullUrl = null;
            if (!string.IsNullOrEmpty(nguoiDung.AvatarUrl))
            {
                avatarFullUrl = nguoiDung.AvatarUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase)
                    ? nguoiDung.AvatarUrl
                    : $"{Request.Scheme}://{Request.Host}{nguoiDung.AvatarUrl}";
            }

            if ((nguoiDung.VaiTro == "DoanhNghiep" || nguoiDung.VaiTro == "NhaTuyenDung")
                 && nguoiDung.CongTy != null)
            {
                var congTy = nguoiDung.CongTy;
                var adminCongTy = congTy.NhaTuyenDungs.FirstOrDefault(x => x.VaiTroCongTy == "CompanyAdmin");

                var soLuongHR = congTy.NhaTuyenDungs.Count(x => x.VaiTroCongTy == "HR");
                var soLuongCongViec = congTy.CongViecs.Count();

                if (nguoiDung.VaiTro == "NhaTuyenDung" && !nguoiDung.DaDuocCongTyXacThuc)
                {
                    return Ok(new
                    {
                        nguoiDung.Id,
                        nguoiDung.HoTen,
                        nguoiDung.Email,
                        nguoiDung.SDT,
                        nguoiDung.VaiTro,
                        nguoiDung.DaDuocCongTyXacThuc,
                        AvatarUrl = avatarFullUrl,
                        ThongBao = "Bạn đã gửi yêu cầu xác thực công ty. Vui lòng chờ phê duyệt.",
                        CongTyDangChoXacThuc = new
                        {
                            congTy.Ma,
                            congTy.TenCongTy,
                            TinhThanh = congTy.TinhThanh?.TenTinh,
                            congTy.EmailLienHe,
                            congTy.SoDienThoaiLienHe
                        }
                    });
                }

                return Ok(new
                {
                    nguoiDung.Id,
                    nguoiDung.HoTen,
                    nguoiDung.Email,
                    nguoiDung.SDT,
                    nguoiDung.VaiTro,
                    nguoiDung.DaDuocCongTyXacThuc,
                    AvatarUrl = avatarFullUrl,
                    ThongTinCongTy = new
                    {
                        congTy.Id,
                        congTy.Ma,
                        congTy.TenCongTy,
                        congTy.GioiThieu,
                        congTy.LogoUrl,
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
                        congTy.NguoiLienHe,
                        congTy.ChucVuNguoiLienHe,
                        congTy.NgayTao,
                        congTy.DaDuocAdminXacMinh,
                        congTy.NgayXacMinh,

                        HoTenNguoiDaiDien = adminCongTy?.HoTen,
                        EmailNguoiDaiDien = adminCongTy?.Email,
                        SDTNguoiDaiDien = adminCongTy?.SDT,

                        SoLuongHR = soLuongHR,
                        SoLuongCongViec = soLuongCongViec
                    }
                });
            }

            return Ok(new
            {
                nguoiDung.Id,
                nguoiDung.HoTen,
                nguoiDung.Email,
                nguoiDung.SDT,
                nguoiDung.VaiTro,
                AvatarUrl = avatarFullUrl,
                LopHoc = nguoiDung.LopHoc,
                KhoaHoc = nguoiDung.KhoaHoc
            });
        }

        [HttpPut("cap-nhat-nha-tuyen-dung")]
        [Authorize(Roles = "NhaTuyenDung")]
        public async Task<IActionResult> CapNhatNhaTuyenDung([FromBody] CapNhatNhaTuyenDungDto model)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var nguoiDung = await _taiKhoanService.CapNhatThongTinNhaTuyenDungAsync(userId, model);

            if (nguoiDung == null)
                return NotFound(new { ThongBao = "Không tìm thấy tài khoản hoặc bạn không phải nhà tuyển dụng" });

            return Ok(new
            {
                ThongBao = "Cập nhật thông tin công ty thành công",
                NhaTuyenDung = new
                {
                    nguoiDung.Id,
                    nguoiDung.AvatarUrl,
                    nguoiDung.HoTen,
                    nguoiDung.Email,
                    nguoiDung.SDT,
                    TenCongTy = nguoiDung.CongTy?.TenCongTy,
                    //MoTaCongTy = nguoiDung.CongTy?.MoTa,
                    //DiaChi = nguoiDung.CongTy?.DiaChi,
                    Website = nguoiDung.CongTy?.Website
                }
            });
        }

        [HttpPost("upload-avatar")]
        [Authorize]
        public async Task<IActionResult> UploadAvatar([FromForm] UploadAvatarDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var url = await _taiKhoanService.UploadAvatarAsync(userId, dto.File, wwwRootPath);

            if (url == null)
                return BadRequest(new { ThongBao = "Upload avatar thất bại" });

            return Ok(new { ThongBao = "Upload avatar thành công", AvatarUrl = url });
        }

        [HttpPost("upload-logo")]
        [Authorize(Roles = "DoanhNghiep")]
        public async Task<IActionResult> UploadLogo([FromForm] UploadAvatarDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var url = await _taiKhoanService.UploadLogoCongTyAsync(userId, dto.File, wwwRootPath);

            if (url == null)
                return BadRequest(new { ThongBao = "Upload logo công ty thất bại" });

            return Ok(new { ThongBao = "✅ Upload logo công ty thành công", LogoUrl = url });
        }

        [HttpPut("dat-lai-mat-khau/{email}")]
        [AllowAnonymous]
        public async Task<IActionResult> DatLaiMatKhau(string email)
        {
            var user = await _context.NguoiDungs.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
                return NotFound(new { ThongBao = "Không tìm thấy tài khoản." });

            user.MatKhauHash = BCrypt.Net.BCrypt.HashPassword("admincongty@123");
            await _context.SaveChangesAsync();

            return Ok(new { ThongBao = "✅ Đặt lại mật khẩu thành công!", MatKhauMoi = "admincongty@123" });
        }

        [HttpPost("google-login")]
        public async Task<IActionResult> GoogleLogin([FromBody] GoogleLoginDto dto)
        {
            var response = await _taiKhoanService.DangNhapGoogleAsync(dto);
            return Ok(response);
        }

        [Authorize]
        [HttpPut("chon-vai-tro")]
        public async Task<IActionResult> ChonVaiTro([FromBody] ChonVaiTroDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var ok = await _taiKhoanService.ChonVaiTroAsync(userId, dto.VaiTro);

            if (!ok)
                return BadRequest(new
                {
                    thanhCong = false,
                    thongBao = "Vai trò không hợp lệ hoặc không thể cập nhật."
                });

            return Ok(new
            {
                thanhCong = true,
                thongBao = "Cập nhật vai trò thành công!"
            });
        }


    }
}
