namespace BVUJobPortal.Models.SinhVien
{
    public class KyNangSinhVien
    {
        public int Id { get; set; }

        public int SinhVienProfileId { get; set; }
        public SinhVienProfile Profile { get; set; } = default!;

        public string? TenKyNang { get; set; }

        public string? MoTaKyNang { get; set; }

        public int MucDo { get; set; }

        public int ThuTu { get; set; } = 0;
    }
}
