namespace BVUJobPortal.DTOs.TaiKhoan
{
    public class DangKyDto
    {
        public string HoTen { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public string VaiTro { get; set; } = "SinhVien";


        // Sinh vien
        public string? LopHoc { get; set; }
        public string? KhoaHoc { get; set; }



        // Nha tuyen dung
        public string? TenCongTy { get; set; }
        public string? MoTaCongTy { get; set; }
        public string? DiaChi { get; set; }
        public string? Website { get; set; }
    }

}
