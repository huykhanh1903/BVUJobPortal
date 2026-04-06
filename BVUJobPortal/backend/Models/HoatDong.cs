namespace BVUJobPortal.Models
{
    public class HoatDong
    {
        public int Id { get; set; }
        public int CvId { get; set; }

        public string TenHoatDong { get; set; } = string.Empty;
        public string ViTri { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public string ThoiGian { get; set; } = string.Empty;
        public int ThuTu { get; set; }

        public CV Cv { get; set; }
    }
}
