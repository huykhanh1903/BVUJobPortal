namespace BVUJobPortal.Models.SinhVien
{
    public class NgoaiNguSinhVien
    {
        public int Id { get; set; }

        public int SinhVienProfileId { get; set; }
        public SinhVienProfile Profile { get; set; } = default!;

        public string? TenNgoaiNgu { get; set; }

        public string? TrinhDo { get; set; }

        public string? ChungChiNgoaiNgu { get; set; }

        public int ThuTu { get; set; } = 0;
    }
}
