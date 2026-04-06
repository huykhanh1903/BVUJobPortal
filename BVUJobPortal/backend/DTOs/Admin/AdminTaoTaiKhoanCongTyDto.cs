namespace BVUJobPortal.DTOs.Admin
{
    public class AdminTaoTaiKhoanCongTyDto
    {
        //Thong tin cong ty
        public string TenCongTy { get; set; } = null!;
        public string? GioiThieu { get; set; }
        public string? DiaChiLamViec { get; set; }
        public string? TinhThanhPho { get; set; }
        public string? Website { get; set; }
        public string? EmailLienHe { get; set; }
        public string? SoDienThoaiLienHe { get; set; }

        //Thong tin nguoi dai dien (admin cong ty)
        public string HoTenNguoiDaiDien { get; set; } = string.Empty;
        public string EmailNguoiDaiDien { get; set; } = string.Empty;
        public string SDTNguoiDaiDien { get; set; } = string.Empty;

    }
}
