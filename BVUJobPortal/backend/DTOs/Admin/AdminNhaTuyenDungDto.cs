namespace BVUJobPortal.DTOs.Admin
{
    public class AdminNhaTuyenDungDto
    {
        public string HoTen { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;
        public string MatKhau { get; set; } = "123456";
        public string TenCongTy { get; set; } = string.Empty;
        public string? MoTaCongTy { get; set; }
        public string? DiaChi { get; set; }
        public string? Website { get; set; }
    }
}
