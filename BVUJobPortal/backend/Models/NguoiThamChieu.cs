namespace BVUJobPortal.Models
{
    public class NguoiThamChieu
    {
        public int Id { get; set; }
        public int CvId { get; set; }

        public string Ten { get; set; } = string.Empty;
        public string ChucVu { get; set; } = string.Empty;
        public string CongTy { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public CV Cv { get; set; }
    }

}
