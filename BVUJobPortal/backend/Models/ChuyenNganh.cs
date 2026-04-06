namespace BVUJobPortal.Models
{
    public class ChuyenNganh
    {
        public int Id { get; set; }
        public string TenChuyenNganh { get; set; }
        public string? MoTa { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.UtcNow;

        public int NgheNghiepId { get; set; }
        public NgheNghiep NgheNghiep { get; set; }

        public ICollection<CongViec> CongViecs { get; set; }

    }
}
