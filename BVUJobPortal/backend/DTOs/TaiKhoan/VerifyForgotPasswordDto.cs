namespace BVUJobPortal.DTOs.TaiKhoan
{
    public class VerifyForgotPasswordDto
    {
        public string Email { get; set; } = string.Empty;
        public string Otp { get; set; } = string.Empty;
        public string MatKhauMoi { get; set; } = string.Empty;
    }
}
