namespace BVUJobPortal.Models.SinhVien
{
    public class KinhNghiemSinhVien
    {
        public int Id { get; set; }

        public int SinhVienProfileId { get; set; }
        public SinhVienProfile Profile { get; set; } = default!;

        public string? ViTriChucDanh { get; set; }

        public string? TenCongTy { get; set; }

        public string? PhuongThucCongViec { get; set; }

        public string? ThoiGianLamViec { get; set; }

        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public bool DangLamHienTai { get; set; }

        public string? MoTaCongViec { get; set; }

        public int ThuTu { get; set; } = 0;
    }
}
