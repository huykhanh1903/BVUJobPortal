namespace BVUJobPortal.Models.SinhVien
{
    public class HocVanSinhVien
    {
        public int Id { get; set; }

        public int SinhVienProfileId { get; set; }
        public SinhVienProfile Profile { get; set; } = default!;

        public string? TruongHoacKhoaHoc { get; set; }

        public string? BangCap { get; set; }

        public string? ThangNamTotNghiep { get; set; }

        public DateTime? NgayTotNghiep { get; set; }

        public string? MoTaChiTiet { get; set; }

        public int ThuTu { get; set; } = 0;
    }
}
