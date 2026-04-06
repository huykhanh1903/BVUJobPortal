namespace BVUJobPortal.DTOs.CongTy
{
    public class CongViecThuocCongTyDto
    {
        public int Id { get; set; }
        public string TieuDe { get; set; } = string.Empty;
        public string? DiaDiem { get; set; }
        public decimal? MucLuongTu { get; set; }
        public decimal? MucLuongDen { get; set; }
        public string HinhThucLamViec { get; set; } = string.Empty;
        public string TenNhaTuyenDung { get; set; } = string.Empty;
        public string AvatarNhaTuyenDung { get; set; }
        public DateTime HanNopHoSo { get; set; }
    }
}
