namespace BVUJobPortal.Models
{
    public class NgheNghiep
    {
        public int Id { get; set; }
        public string TenNghe { get; set; } = string.Empty;
        public string? MoTa { get; set; }

        public int LinhVucId { get; set; }
        public LinhVuc LinhVuc { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public ICollection<ChuyenNganh> ChuyenNganhs { get; set; } = new List<ChuyenNganh>();

    }
}