namespace BVUJobPortal.DTOs.Admin
{
    public class AdminChuyenNganhDto
    {
        public int Id { get; set; }
        public string TenChuyenNganh { get; set; } = string.Empty;
        public string? MoTa { get; set; }

        public DateTime NgayTao { get; set; }

        public int NgheNghiepId { get; set; }
        public string TenNghe { get; set; } = string.Empty;
    }
}