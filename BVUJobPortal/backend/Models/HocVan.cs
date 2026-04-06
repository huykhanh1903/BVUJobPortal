namespace BVUJobPortal.Models
{
    public class HocVan
    {
        public int Id { get; set; }
        public string Truong { get; set; } = string.Empty;
        public string NganhHoc { get; set; } = string.Empty;
        public string ThoiGianHoc { get; set; } = string.Empty;
        public string? ThanhTich { get; set; }
        public int ThuTu { get; set; }
        public int CVId { get; set; }
        public CV CV { get; set; }
    }
}
