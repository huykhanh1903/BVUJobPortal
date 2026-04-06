namespace BVUJobPortal.DTOs.UngVien
{
    public class UngVienDangTimViecDto
    {
        public int SinhVienId { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }
        public string? CapBacMongMuon { get; set; }
        public string? NganhNgheMongMuon { get; set; }
        public string? NoiLamViecMongMuon { get; set; }
        public List<string> KyNangs { get; set; } = new();
    }

}
