namespace BVUJobPortal.DTOs.Admin
{
    public class AdminLinhVucDto
    {
        public int Id { get; set; }
        public string TenLinhVuc { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public DateTime NgayTao { get; set; }
        public int SoLuongCongViec { get; set; }
    }
}
