using BVUJobPortal.DTOs.TaiKhoan;
using BVUJobPortal.Models;

namespace BVUJobPortal.Services.TaiKhoan
{
    public interface ITaiKhoanService
    {
        Task<NguoiDung?> DangKyAsync(DangKyDto dto);
        Task<bool> XacThucEmailAsync(XacThucEmailDto dto);
        Task<(bool Success, string Message)> ResendOtpAsync(string email);
        Task<DangNhapResponse?> DangNhapAsync(DangNhapDto dto);
        Task<bool> GuiOtpQuenMatKhauAsync(string email);
        Task<bool> DatLaiMatKhauAsync(string email, string otp, string matKhauMoi);
        Task<NguoiDung?> CapNhatThongTinAsync(int idNguoiDung, CapNhatSinhVienDto dto);
        Task<NguoiDung?> LayThongTinAsync(int userId);
        Task<NguoiDung?> CapNhatThongTinNhaTuyenDungAsync(int idNguoiDung, CapNhatNhaTuyenDungDto dto);
        Task<NguoiDung?> CapNhatThongTinDoanhNghiepAsync(int idNguoiDung, CapNhatDoanhNghiepDto dto);
        Task<string?> UploadAvatarAsync(int userId, IFormFile file, string wwwRootPath);
        Task<string?> UploadLogoCongTyAsync(int userId, IFormFile file, string wwwRootPath);
        Task<DangNhapResponse> DangNhapGoogleAsync(GoogleLoginDto dto);
        Task<bool> ChonVaiTroAsync(int userId, string vaiTro);


    }
}
