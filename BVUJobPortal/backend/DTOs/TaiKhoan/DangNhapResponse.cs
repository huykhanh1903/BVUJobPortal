namespace BVUJobPortal.DTOs.TaiKhoan
{
    public class DangNhapResponse
    {
        public string AccessToken { get; set; } = string.Empty;
        public DateTime HetHan { get; set; }
        public object? NguoiDung { get; set; }

        public bool BiKhoa { get; set; } = false;
        public string? LyDoKhoa { get; set; }

        public string? Message { get; set; }
        public bool CanXacThucEmail { get; set; } = false;
        public bool Success { get; set; }
        public string? Email { get; set; }
    }
}
