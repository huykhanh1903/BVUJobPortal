namespace BVUJobPortal.DTOs.DoanhNghiep
{
    public class HRResponseDto
    {
        public int Id { get; set; }
        public string Ma { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;

        public bool DaDuocCongTyXacThuc { get; set; } = false;
        public DateTime? NgayXacThuc { get; set; }
        public string? NguoiXacThuc { get; set; }
        public string? TenCongTy { get; set; }
    }
}
