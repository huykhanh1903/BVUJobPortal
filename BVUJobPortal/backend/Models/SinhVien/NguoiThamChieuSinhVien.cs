namespace BVUJobPortal.Models.SinhVien
{
    public class NguoiThamChieuSinhVien
    {
        public int Id { get; set; }

        public int SinhVienProfileId { get; set; }
        public SinhVienProfile Profile { get; set; } = default!;

        public string? HoVaTen { get; set; }

        public string? ChucVu { get; set; }

        public string? CongTy { get; set; }

        public string? DienThoai { get; set; }

        public string? Email { get; set; }

        public int ThuTu { get; set; } = 0;
    }
}
