namespace BVUJobPortal.DTOs.TaiKhoan
{
    public class CapNhatSinhVienDto
    {
        public string HoTen { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;
        public string LopHoc { get; set; } = string.Empty;
        public string KhoaHoc { get; set; } = string.Empty;
        public string TenCongTy { get; set; } = string.Empty;
        public string? MatKhauCu { get; set; }
        public string? MatKhauMoi { get; set; }

        public string? AvatarUrl { get; set; }
    }
}
