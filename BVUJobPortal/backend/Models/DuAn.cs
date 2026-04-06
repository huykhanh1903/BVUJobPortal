namespace BVUJobPortal.Models
{
    public class DuAn
    {
        public int Id { get; set; }
        public string Ten { get; set; } = string.Empty;
        public string VaiTro { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public string? CongNghe { get; set; }
        public int ThuTu { get; set; }
        public int CVId { get; set; }
        public CV CV { get; set; }
    }
}
