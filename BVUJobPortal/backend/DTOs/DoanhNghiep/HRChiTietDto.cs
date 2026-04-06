namespace BVUJobPortal.DTOs.DoanhNghiep
{
    public class HRChiTietDto
    {
        public int Id { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;

        public bool DaDuocCongTyXacThuc { get; set; }
        public DateTime? NgayXacThuc { get; set; }
        public string? NguoiXacThuc { get; set; }

        public string? LyDoXinXacThuc { get; set; }

        public string TenCongTy { get; set; } = string.Empty;

        public string? AvatarUrl { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
