namespace BVUJobPortal.DTOs.TaiKhoan
{
    public class DangNhapDto
    {
        public string Email { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public string? Message { get; set; }
        public bool CanXacThucEmail { get; set; } = false;
    }
}
