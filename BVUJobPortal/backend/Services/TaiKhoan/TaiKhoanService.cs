using AutoMapper;
using Google.Apis.Auth;
using BVUJobPortal.Data;
using BVUJobPortal.DTOs.TaiKhoan;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BVUJobPortal.Helpers;
using System.Text.Json;
using BVUJobPortal.Services.Email;
using Microsoft.Extensions.Options;

namespace BVUJobPortal.Services.TaiKhoan
{
    public class TaiKhoanService : ITaiKhoanService
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly JwtSettings _jwtSettings;
        private readonly IEmailService _emailService;

        private readonly List<string> EmailBypassOtp = new()
        {
            "superadmin@bvu.edu.vn",
            "admin@bvu.edu.vn",
            "ntd@abc.com",
            "sinhvien@bvu.edu.vn",
            "NguyenTruongAn123@gmail.com",
            "TruongTuanAnh456@gmail.com",
            "TrinhQuang7@gmail.com",
            "nailing23@gmail.com",
            "phuongthao12@gmail.com",
            "tanhminh6@gmail.com",
            "nguyenhoa5@gmail.com",
            "baotran63@gmail.com",
            "dinhtung896@gmail.com",
            "vduyduong456@gmail.com",

            //Doanh nghiep 
            "truetech123@gmail.com", "tv.luatnamson@gmail.com", "vingroup6@gmail.com","nhg33@gmail.com", "info@bitexco.com.vn", "ptsc72@gmail.com", "info@cattiensa.com", "prm@hoaphat.com.vn", "investorrelation@masangroup.com", "tcm@thanhcong.com.vn",
            "",


        };

        private static readonly HashSet<string> VaiTroChoPhep = new(StringComparer.OrdinalIgnoreCase)
        {
            "SinhVien", "NhaTuyenDung"
        };

        public TaiKhoanService(ApplicationDbContext context, IConfiguration config, IMapper mapper, JwtSettings jwtSettings, IEmailService emailService)
        {
            _context = context;
            _config = config;
            _mapper = mapper;
            _jwtSettings = jwtSettings;
            _emailService = emailService;
        }

        public async Task<NguoiDung?> DangKyAsync(DangKyDto dto)
        {
            var vaiTro = string.IsNullOrWhiteSpace(dto.VaiTro) ? "SinhVien" : dto.VaiTro.Trim();
            if (!VaiTroChoPhep.Contains(vaiTro))
                vaiTro = "SinhVien";

            var tonTai = await _context.NguoiDungs.AnyAsync(x => x.Email == dto.Email);
            if (tonTai) return null;

            int? congTyId = null;
            if (vaiTro == "NhaTuyenDung" && !string.IsNullOrWhiteSpace(dto.TenCongTy))
            {
                var congTy = await _context.CongTys.FirstOrDefaultAsync(c => c.TenCongTy == dto.TenCongTy);
                if (congTy == null)
                {
                    congTy = _mapper.Map<CongTy>(dto);
                    congTy.NgayTao = DateTime.UtcNow;

                    _context.CongTys.Add(congTy);
                    await _context.SaveChangesAsync();
                }

                congTyId = congTy.Id;
            }

            var nguoiDung = _mapper.Map<NguoiDung>(dto);
            nguoiDung.VaiTro = vaiTro;
            nguoiDung.CongTyId = congTyId;

            nguoiDung.Ma = await TaoMaNguoiDungAsync(vaiTro);

            if (EmailBypassOtp.Contains(dto.Email.Trim().ToLower()))
            {
                nguoiDung.IsEmailConfirmed = true;
                nguoiDung.EmailVerificationToken = null;
                nguoiDung.EmailVerificationExpiry = null;

                _context.NguoiDungs.Add(nguoiDung);
                await _context.SaveChangesAsync();

                return nguoiDung;
            }

            var otp = new Random().Next(100000, 999999).ToString();

            nguoiDung.IsEmailConfirmed = false;
            nguoiDung.EmailVerificationToken = otp;
            nguoiDung.EmailVerificationExpiry = DateTime.UtcNow.AddMinutes(10);

            _context.NguoiDungs.Add(nguoiDung);
            await _context.SaveChangesAsync();

            await _emailService.SendEmailAsync(
                 to: nguoiDung.Email,
                 subject: "Mã xác thực tài khoản BVU Job Portal",
                 htmlContent: $@"
                <h2>Xin chào {nguoiDung.HoTen},</h2>
                <p>Mã xác thực email của bạn là:</p>
                <h1 style='color:blue'>{otp}</h1>
                <p>Mã có hiệu lực trong 10 phút.</p>
         "
            );

            return nguoiDung;
        }


        public async Task<bool> XacThucEmailAsync(XacThucEmailDto dto)
        {
            var user = await _context.NguoiDungs
                .FirstOrDefaultAsync(x => x.Email == dto.Email);

            if (user == null) return false;
            if (user.EmailVerificationToken != dto.Otp) return false;
            if (user.EmailVerificationExpiry < DateTime.UtcNow) return false;

            user.IsEmailConfirmed = true;
            user.EmailVerificationToken = null;
            user.EmailVerificationExpiry = null;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<(bool Success, string Message)> ResendOtpAsync(string email)
        {
            var user = await _context.NguoiDungs.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null)
                return (false, "Email không tồn tại.");

            if (user.IsEmailConfirmed)
                return (false, "Email đã được xác thực, không cần gửi OTP.");

            if (user.EmailVerificationExpiry.HasValue && DateTime.UtcNow < user.EmailVerificationExpiry.Value)
            {
                return (false, "OTP hiện tại vẫn còn hiệu lực. Vui lòng kiểm tra email.");
            }

            string newOtp = new Random().Next(100000, 999999).ToString();
            user.EmailVerificationToken = newOtp;
            user.EmailVerificationExpiry = DateTime.UtcNow.AddMinutes(10);

            await _context.SaveChangesAsync();

            await _emailService.SendEmailAsync(
                to: user.Email,
                subject: "Mã OTP mới - BVU Job Portal",
                htmlContent: $@"
            <h2>Xin chào {user.HoTen},</h2>
            <p>Mã OTP mới để xác thực email của bạn là:</p>
            <h1 style='color:blue'>{newOtp}</h1>
            <p>Mã có hiệu lực trong 10 phút.</p>
        "
            );

            return (true, "OTP mới đã được gửi về email của bạn!");
        }


        private async Task<string> TaoMaNguoiDungAsync(string vaiTro)
        {
            string prefix = vaiTro switch
            {
                "SuperAdmin" => "SA",
                "Admin" => "AD",
                "NhaTuyenDung" => "NTD",
                "SinhVien" => "SV",
                _ => "USR"
            };

            var count = await _context.NguoiDungs.CountAsync(u => u.VaiTro == vaiTro);

            return $"{prefix}-{count + 1}";
        }

        public async Task<DangNhapResponse> DangNhapAsync(DangNhapDto dto)
        {
            var nguoiDung = await _context.NguoiDungs
                .Include(x => x.CongTy)
                .FirstOrDefaultAsync(x => x.Email == dto.Email);

            if (nguoiDung == null)
            {
                return new DangNhapResponse
                {
                    Success = false,
                    Message = "Email hoặc mật khẩu không đúng."
                };
            }

            if (!BCrypt.Net.BCrypt.Verify(dto.MatKhau, nguoiDung.MatKhauHash))
            {
                return new DangNhapResponse
                {
                    Success = false,
                    Message = "Email hoặc mật khẩu không đúng."
                };
            }

            //if (nguoiDung.BiKhoa)
            //{
            //    return new DangNhapResponse
            //    {
            //        Success = true,
            //        BiKhoa = true,
            //        LyDoKhoa = nguoiDung.LyDoKhoa ??
            //            "Tài khoản đã bị khóa. Vui lòng liên hệ quản trị viên.",
            //        NguoiDung = _mapper.Map<TaiKhoanDto>(nguoiDung)
            //    };
            //}

            var isBiKhoa = nguoiDung.BiKhoa;
            var lyDoKhoa = nguoiDung.LyDoKhoa;


            var email = nguoiDung.Email ?? string.Empty;
            if (!nguoiDung.IsEmailConfirmed && !EmailBypassOtp.Contains(email))
            {
                return new DangNhapResponse
                {
                    Success = false,
                    CanXacThucEmail = true,
                    Email = email,
                    Message = "Email chưa được xác thực. Vui lòng nhập mã OTP."
                };
            }

            var jwtSection = _config.GetSection("Jwt");
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(jwtSection["Key"]!)
            );
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiresMinutes = int.TryParse(jwtSection["ExpiresMinutes"], out var m) ? m : 120;
            var expires = DateTime.UtcNow.AddMinutes(expiresMinutes);

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, nguoiDung.Id.ToString()),
                new(JwtRegisteredClaimNames.Email, email),
                new(ClaimTypes.NameIdentifier, nguoiDung.Id.ToString()),
                new(ClaimTypes.Name, nguoiDung.HoTen ?? string.Empty),
                new(ClaimTypes.Role, nguoiDung.VaiTro ?? string.Empty)
            };

            var token = new JwtSecurityToken(
                issuer: jwtSection["Issuer"],
                audience: jwtSection["Audience"],
                claims: claims,
                expires: expires,
                signingCredentials: creds
            );

            //return new DangNhapResponse
            //{
            //    Success = true,
            //    AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
            //    HetHan = expires,
            //    NguoiDung = _mapper.Map<TaiKhoanDto>(nguoiDung),
            //    BiKhoa = false
            //};

            return new DangNhapResponse
            {
                Success = !isBiKhoa,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                HetHan = expires,
                NguoiDung = _mapper.Map<TaiKhoanDto>(nguoiDung),

                BiKhoa = isBiKhoa,
                LyDoKhoa = isBiKhoa
                ? lyDoKhoa ?? "Tài khoản đã bị khóa. Vui lòng liên hệ quản trị viên."
                : null, Message = isBiKhoa
                ? "Tài khoản đã bị khóa."
                : "Đăng nhập thành công."
                    };

        }


        public async Task<bool> GuiOtpQuenMatKhauAsync(string email)
        {
            var user = await _context.NguoiDungs.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null) return false;

            var otp = new Random().Next(100000, 999999).ToString();

            user.ResetPasswordOtp = otp;
            user.ResetPasswordExpiry = DateTime.UtcNow.AddMinutes(10);

            await _context.SaveChangesAsync();

            await _emailService.SendEmailAsync(
                to: email,
                subject: "Mã đặt lại mật khẩu BVU Job Portal",
                htmlContent: $@"
            <h2>Mã đặt lại mật khẩu của bạn:</h2>
            <h1 style='color:red'>{otp}</h1>
            <p>Mã có hiệu lực trong 10 phút.</p>
        "
            );

            return true;
        }

        public async Task<bool> DatLaiMatKhauAsync(string email, string otp, string matKhauMoi)
        {
            var user = await _context.NguoiDungs.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null) return false;

            if (user.ResetPasswordOtp != otp) return false;

            if (user.ResetPasswordExpiry < DateTime.UtcNow) return false;

            user.MatKhauHash = BCrypt.Net.BCrypt.HashPassword(matKhauMoi);

            user.ResetPasswordOtp = null;
            user.ResetPasswordExpiry = null;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<NguoiDung?> CapNhatThongTinAsync(int idNguoiDung, CapNhatSinhVienDto dto)
        {
            var nguoiDung = await _context.NguoiDungs.FindAsync(idNguoiDung);
            if (nguoiDung == null) return null;

            _mapper.Map(dto, nguoiDung);

            if (!string.IsNullOrWhiteSpace(dto.MatKhauCu) && !string.IsNullOrWhiteSpace(dto.MatKhauMoi))
            {
                if (!BCrypt.Net.BCrypt.Verify(dto.MatKhauCu, nguoiDung.MatKhauHash))
                    throw new Exception("Mật khẩu cũ không chính xác");

                nguoiDung.MatKhauHash = BCrypt.Net.BCrypt.HashPassword(dto.MatKhauMoi);
            }

            _context.NguoiDungs.Update(nguoiDung);
            await _context.SaveChangesAsync();
            return nguoiDung;
        }

        public async Task<NguoiDung?> CapNhatThongTinDoanhNghiepAsync(int idNguoiDung, CapNhatDoanhNghiepDto dto)
        {
            var nguoiDung = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u => u.Id == idNguoiDung && u.VaiTro == "DoanhNghiep");

            if (nguoiDung == null)
                return null;

            if (!string.IsNullOrWhiteSpace(dto.HoTen)) nguoiDung.HoTen = dto.HoTen;
            if (!string.IsNullOrWhiteSpace(dto.Email)) nguoiDung.Email = dto.Email;
            if (!string.IsNullOrWhiteSpace(dto.SDT)) nguoiDung.SDT = dto.SDT;

            if (!string.IsNullOrWhiteSpace(dto.MatKhauCu) && !string.IsNullOrWhiteSpace(dto.MatKhauMoi))
            {
                if (!BCrypt.Net.BCrypt.Verify(dto.MatKhauCu, nguoiDung.MatKhauHash))
                    throw new Exception("Mật khẩu cũ không chính xác.");

                nguoiDung.MatKhauHash = BCrypt.Net.BCrypt.HashPassword(dto.MatKhauMoi);
            }

            if (nguoiDung.CongTy != null)
            {
                var congTy = nguoiDung.CongTy;

                if (!string.IsNullOrWhiteSpace(dto.TenCongTy)) congTy.TenCongTy = dto.TenCongTy;
                if (!string.IsNullOrWhiteSpace(dto.GioiThieu)) congTy.GioiThieu = dto.GioiThieu;
                if (!string.IsNullOrWhiteSpace(dto.LogoUrl)) congTy.LogoUrl = dto.LogoUrl;
                if (!string.IsNullOrWhiteSpace(dto.DiaChiLamViec)) congTy.DiaChiLamViec = dto.DiaChiLamViec;
                if (!string.IsNullOrWhiteSpace(dto.Website)) congTy.Website = dto.Website;
                if (!string.IsNullOrWhiteSpace(dto.EmailLienHe)) congTy.EmailLienHe = dto.EmailLienHe;
                if (!string.IsNullOrWhiteSpace(dto.SoDienThoaiLienHe)) congTy.SoDienThoaiLienHe = dto.SoDienThoaiLienHe;
                if (!string.IsNullOrWhiteSpace(dto.NguoiLienHe)) congTy.NguoiLienHe = dto.NguoiLienHe;
                if (!string.IsNullOrWhiteSpace(dto.ChucVuNguoiLienHe)) congTy.ChucVuNguoiLienHe = dto.ChucVuNguoiLienHe;

                if (dto.TinhThanhId.HasValue)
                {
                    var tt = await _context.TinhThanhs.FindAsync(dto.TinhThanhId.Value);
                    if (tt == null)
                        throw new Exception("Mã tỉnh thành không hợp lệ.");

                    congTy.TinhThanhId = dto.TinhThanhId.Value;
                }

                _context.CongTys.Update(congTy);
            }

            _context.NguoiDungs.Update(nguoiDung);
            await _context.SaveChangesAsync();

            return nguoiDung;
        }

        public async Task<NguoiDung?> LayThongTinAsync(int userId)
        {
            return await _context.NguoiDungs.FindAsync(userId);
        }

        public async Task<NguoiDung?> CapNhatThongTinNhaTuyenDungAsync(int idNguoiDung, CapNhatNhaTuyenDungDto dto)
        {
            var nguoiDung = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u => u.Id == idNguoiDung);

            if (nguoiDung == null || nguoiDung.VaiTro != "NhaTuyenDung") return null;

            if (nguoiDung.CongTy != null)
            {
                _mapper.Map(dto, nguoiDung.CongTy);
            }
            else if (!string.IsNullOrWhiteSpace(dto.TenCongTy))
            {
                var congTy = _mapper.Map<CongTy>(dto);
                congTy.NgayTao = DateTime.UtcNow;

                _context.CongTys.Add(congTy);
                await _context.SaveChangesAsync();

                nguoiDung.CongTyId = congTy.Id;
            }

            nguoiDung.SDT = dto.SDT ?? nguoiDung.SDT;

            _context.NguoiDungs.Update(nguoiDung);
            await _context.SaveChangesAsync();
            return nguoiDung;
        }

        public async Task<string?> UploadAvatarAsync(int userId, IFormFile file, string wwwRootPath)
        {
            var user = await _context.NguoiDungs.FindAsync(userId);
            if (user == null) return null;

            if (file == null || file.Length == 0) return null;

            if (!string.IsNullOrEmpty(user.AvatarUrl))
            {
                var oldPath = Path.Combine(wwwRootPath, user.AvatarUrl.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString()));
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            }

            var uploadFolder = Path.Combine(wwwRootPath, "uploads", "avatars");
            if (!Directory.Exists(uploadFolder))
                Directory.CreateDirectory(uploadFolder);

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(uploadFolder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            user.AvatarUrl = $"/uploads/avatars/{fileName}";
            _context.NguoiDungs.Update(user);
            await _context.SaveChangesAsync();

            return user.AvatarUrl;
        }

        public async Task<string?> UploadLogoCongTyAsync(int userId, IFormFile file, string wwwRootPath)
        {
            var user = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u => u.Id == userId && u.VaiTro == "DoanhNghiep");

            if (user == null || user.CongTy == null)
                return null;

            if (file == null || file.Length == 0)
                return null;

            var congTy = user.CongTy;

            if (!string.IsNullOrEmpty(congTy.LogoUrl))
            {
                var oldPath = Path.Combine(
                    wwwRootPath,
                    congTy.LogoUrl.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString())
                );

                if (File.Exists(oldPath))
                    File.Delete(oldPath);
            }

            var uploadFolder = Path.Combine(wwwRootPath, "uploads", "logos");
            if (!Directory.Exists(uploadFolder))
                Directory.CreateDirectory(uploadFolder);

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(uploadFolder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            congTy.LogoUrl = $"/uploads/logos/{fileName}";
            _context.CongTys.Update(congTy);
            await _context.SaveChangesAsync();

            return congTy.LogoUrl;
        }

        public async Task<DangNhapResponse> DangNhapGoogleAsync(GoogleLoginDto dto)
        {
            var accessToken = dto.GoogleToken;

            var http = new HttpClient();
            var response = await http.GetAsync(
                $"https://www.googleapis.com/oauth2/v3/userinfo?access_token={accessToken}"
            );

            if (!response.IsSuccessStatusCode)
                throw new Exception("Không thể xác minh Google Token.");

            var json = await response.Content.ReadAsStringAsync();
            var googleUser = JsonSerializer.Deserialize<GoogleUserInfo>(json);

            if (googleUser == null)
                throw new Exception("Lỗi khi đọc thông tin Google.");

            string email = googleUser.email;
            string name = googleUser.name;
            string avatar = googleUser.picture;

            var user = await _context.NguoiDungs.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null)
            {
                user = new NguoiDung
                {
                    Email = email,
                    HoTen = name,
                    AvatarUrl = avatar,
                    VaiTro = "Guest",
                    DangNhapBangGoogle = true,
                    NgayTao = DateTime.Now
                };

                _context.NguoiDungs.Add(user);
                await _context.SaveChangesAsync();
            }

            var token = TaoJwtToken(user);

            return new DangNhapResponse
            {
                AccessToken = token,
                HetHan = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiresMinutes),
                NguoiDung = new
                {
                    user.Id,
                    user.HoTen,
                    user.Email,
                    user.VaiTro,
                    user.AvatarUrl
                },
                BiKhoa = user.BiKhoa,
                LyDoKhoa = user.LyDoKhoa
            };
        }

        public async Task<bool> ChonVaiTroAsync(int userId, string vaiTro)
        {
            var user = await _context.NguoiDungs.FindAsync(userId);
            if (user == null) return false;

            if (vaiTro != "SinhVien" && vaiTro != "NhaTuyenDung")
                return false;

            user.VaiTro = vaiTro;

            if (string.IsNullOrEmpty(user.Ma))
            {
                user.Ma = await TaoMaNguoiDungAsync(vaiTro);
            }

            await _context.SaveChangesAsync();
            return true;
        }

        private string TaoJwtToken(NguoiDung user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email ?? ""),
                new Claim(ClaimTypes.Name, user.HoTen ?? ""),
                new Claim(ClaimTypes.Role, user.VaiTro ?? "")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
