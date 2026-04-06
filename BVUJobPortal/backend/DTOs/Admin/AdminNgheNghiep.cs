namespace BVUJobPortal.DTOs.Admin
{
    public class AdminNgheNghiepDto
    {
        public int Id { get; set; }
        public string TenNghe { get; set; } = string.Empty;
        public string? MoTa { get; set; }

        public int LinhVucId { get; set; }
        public string TenLinhVuc { get; set; } = string.Empty;
        public DateTime NgayTao { get; set; }
        public int SoLuongChuyenNganh { get; set; }
    }
}