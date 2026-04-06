namespace BVUJobPortal.Models.SinhVien
{
    public class ChungChiSinhVien
    {
        public int Id { get; set; }

        public int SinhVienProfileId { get; set; }
        public SinhVienProfile Profile { get; set; } = default!;

        public string? TenChungChi { get; set; }

        public string? CapBoi { get; set; }

        public DateTime? NgayCap { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public bool KhongHetHan { get; set; }

        public int ThuTu { get; set; } = 0;
    }
}
