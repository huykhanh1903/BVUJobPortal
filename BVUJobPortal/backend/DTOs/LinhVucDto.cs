namespace BVUJobPortal.DTOs
{
    public class LinhVucDto
    {
        public int Id { get; set; }
        public string TenLinhVuc { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
