namespace BVUJobPortal.Models
{
    public class ChungChi
    {
        public int Id { get; set; }
        public string TenChungChi { get; set; } = string.Empty;
        public DateTime? NgayCap { get; set; }
        public string? NoiCap { get; set; }

        public int ThuTu { get; set; }
        public int CVId { get; set; }
        public CV CV { get; set; }
    }
}
