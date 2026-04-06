namespace BVUJobPortal.DTOs.CV
{
    public class ChungChiDto
    {
        public int Id { get; set; }
        public string TenChungChi { get; set; } = string.Empty;
        public DateTime? NgayCap { get; set; }
        public string? NoiCap { get; set; }

        public int ThuTu { get; set; }
    }
}
