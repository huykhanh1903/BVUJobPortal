namespace BVUJobPortal.Models
{
    public class KyNang
    {
        public int Id { get; set; }
        public string TenKyNang { get; set; } = string.Empty;
        public string? Loai { get; set; } = "Chuyên môn";

        public int ThuTu { get; set; }
        public int CVId { get; set; }
        public CV CV { get; set; }
    }
}
