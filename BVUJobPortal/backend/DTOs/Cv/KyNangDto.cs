namespace BVUJobPortal.DTOs.CV
{
    public class KyNangDto
    {
        public int Id { get; set; }
        public string TenKyNang { get; set; } = string.Empty;
        public string? Loai { get; set; } = "Chuyên môn";

        public int ThuTu { get; set; }
    }
}
