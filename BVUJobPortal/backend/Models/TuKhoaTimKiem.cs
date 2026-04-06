namespace BVUJobPortal.Models
{
    public class TuKhoaTimKiem
    {
        public int Id { get; set; }
        public string TuKhoa { get; set; } = string.Empty;
        public int SoLan { get; set; } = 0;
        public DateTime NgayCapNhat { get; set; } = DateTime.UtcNow;
        public int? LinhVucId { get; set; }
        public int? NganhNgheId { get; set; }
        public int? ChuyenNganhId { get; set; }
        public string Loai { get; set; } = "CongViec";

    }
}
