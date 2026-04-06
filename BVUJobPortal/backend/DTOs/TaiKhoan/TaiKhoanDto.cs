namespace BVUJobPortal.DTOs.TaiKhoan
{
    public class TaiKhoanDto
    {
        public int Id { get; set; }
        public string? Ma { get; set; }
        public string? HoTen { get; set; }
        public string? Email { get; set; }
        public string? SDT { get; set; }
        public string VaiTro { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }

        public string? LopHoc { get; set; }
        public string? KhoaHoc { get; set; }

        public string? LogoCongTyUrl { get; set; }
        public int? CongTyId { get; set; }
        public string? TenCongTy { get; set; }
        public string? EmailLienHe { get; set; }
        public string? SoDienThoaiLienHe { get; set; }
        public string? Website { get; set; }
        public string? DiaChiLamViec { get; set; }
        public string? TinhThanhPho { get; set; }

        public string? GioiThieuCongTy { get; set; }
        public int? SoLuongHR { get; set; }

        public int? SoLuongCV { get; set; }
        public int? SoLuongDonUngTuyen { get; set; }

        public bool BiKhoa { get; set; }
        public string? LyDoKhoa { get; set; }
        public DateTime NgayTao { get; set; }

        public bool DaDuocCongTyXacThuc { get; set; }

        public bool DaGuiYeuCau { get; set; }
    }

}
