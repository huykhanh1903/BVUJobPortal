namespace BVUJobPortal.DTOs.Admin
{
    public class AdminThongBaoDto 
    {
        public int Id { get; set; }
        public string TieuDe { get; set; } = string.Empty;
        public string NoiDung { get; set; } = string.Empty;
        public string? Url { get; set; }
        public string Loai { get; set; } = string.Empty;

        public DateTime NgayTao { get; set; }

        public int NguoiDungId { get; set; }
        public string TenNguoiNhan { get; set; } = string.Empty;
    }
}
