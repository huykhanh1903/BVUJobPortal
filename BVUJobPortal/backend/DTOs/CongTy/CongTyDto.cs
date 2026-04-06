using BVUJobPortal.Models;

namespace BVUJobPortal.DTOs.CongTy
{
    public class CongTyDto
    {
        public int Id { get; set; }
        public string TenCongTy { get; set; } = string.Empty;
        public string? LogoUrl { get; set; }
        public string? GioiThieu { get; set; }
        public string? DiaChiLamViec { get; set; }
        public int? TinhThanhId { get; set; }
        public string? TenTinhThanh { get; set; }
        public string? Website { get; set; }
        public string? EmailLienHe { get; set; }
        public string? SoDienThoaiLienHe { get; set; }
        public string? NguoiLienHe { get; set; }
        public string? ChucVuNguoiLienHe { get; set; }
    }
}
