namespace BVUJobPortal.DTOs.Admin
{
    public class AdminCongTyDto
    {
        public int Id { get; set; }
        public string Ma { get; set; } = string.Empty;
        public string TenCongTy { get; set; } = string.Empty;
        public string? GioiThieu { get; set; }
        public string? LogoUrl { get; set; }
        public string? DiaChiLamViec { get; set; }
        public int? TinhThanhId { get; set; }
        public string? TenTinhThanh { get; set; }
        public string? Website { get; set; }
        public string? EmailLienHe { get; set; }
        public string? SoDienThoaiLienHe { get; set; }
        public string? NguoiLienHe { get; set; }
        public string? ChucVuNguoiLienHe { get; set; }
        public int? NamThanhLap { get; set; }
        public string? QuyMoNhanSu { get; set; }

        public DateTime NgayTao { get; set; }
        public bool DaDuocAdminXacMinh { get; set; }
        public DateTime? NgayXacMinh { get; set; }
        public string? TenAdminXacMinh { get; set; }

        public string? HoTenNguoiDaiDien { get; set; }
        public string? EmailNguoiDaiDien { get; set; }
        public string? SDTNguoiDaiDien { get; set; }

        public int SoLuongHR { get; set; }
        public int SoLuongCongViec { get; set; }

        public int SoLuongLinhVuc { get; set; }


    }
}
