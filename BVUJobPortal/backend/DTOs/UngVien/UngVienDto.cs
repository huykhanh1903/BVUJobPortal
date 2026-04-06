namespace BVUJobPortal.DTOs.UngVien
{
    public class UngVienDto
    {
        public int SinhVienId { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }
        public string? CapBac { get; set; }
        public string? NganhNghe { get; set; }
        public decimal? MucLuongTu { get; set; }
        public decimal? MucLuongDen { get; set; }
        public List<string> KyNangs { get; set; } = [];
    }

}
