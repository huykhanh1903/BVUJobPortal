namespace BVUJobPortal.DTOs.TaiKhoan
{
    public class CapNhatDoanhNghiepDto
    {
        //Thong tin nguoi dai dien
        public string? HoTen { get; set; }
        public string? Email { get; set; }
        public string? SDT { get; set; }

        public string? MatKhauCu { get; set; }
        public string? MatKhauMoi { get; set; }

        public string? TenCongTy { get; set; }
        public string? GioiThieu { get; set; }
        public string? LogoUrl { get; set; }
        public string? DiaChiLamViec { get; set; }
        public int? TinhThanhId { get; set; }
        public string? Website { get; set; }
        public string? EmailLienHe { get; set; }
        public string? SoDienThoaiLienHe { get; set; }
        public string? NguoiLienHe { get; set; }
        public string? ChucVuNguoiLienHe { get; set; }

        public bool? DaDuocAdminXacMinh { get; set; }
    }
}
