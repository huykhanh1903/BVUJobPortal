namespace BVUJobPortal.Models.SinhVien
{
    public class HoatDongSinhVien
    {
        public int Id { get; set; }

        public int SinhVienProfileId { get; set; }
        public SinhVienProfile Profile { get; set; } = default!;

        public string? ToChuc { get; set; }

        public string? VaiTro { get; set; }

        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public bool DangHoatDong { get; set; }

        public string? MoTaHoatDong { get; set; }

        public int ThuTu { get; set; } = 0;
    }
}
