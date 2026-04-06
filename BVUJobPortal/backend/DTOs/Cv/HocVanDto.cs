namespace BVUJobPortal.DTOs.CV
{
    public class HocVanDto
    {
        public int Id { get; set; }
        public string Truong { get; set; } = string.Empty;
        public string ChuyenNganh { get; set; } = string.Empty;
        public string ThoiGian { get; set; } = string.Empty;
        public string? MoTa { get; set; }
        public int ThuTu { get; set; }
    }

}
