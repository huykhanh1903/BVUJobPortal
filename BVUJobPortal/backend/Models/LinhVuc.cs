namespace BVUJobPortal.Models
{
    public class LinhVuc
    {
        public int Id { get; set; }
        public string TenLinhVuc { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public ICollection<CongViec>? CongViecs { get; set; }
        public ICollection<NgheNghiep>? NgheNghieps { get; set; } = new List<NgheNghiep>();
    }
}
