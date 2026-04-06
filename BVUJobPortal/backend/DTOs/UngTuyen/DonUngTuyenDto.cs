using BVUJobPortal.DTOs.SinhVien;

namespace BVUJobPortal.DTOs.UngTuyen
{
    public class DonUngTuyenDto
    {
        public int Id { get; set; }
        public int CongViecId { get; set; }
        public string TieuDeCongViec { get; set; } = string.Empty;
        public string? TenCongTy { get; set; }
        public string? ThuGioiThieu { get; set; }
        public string TrangThai { get; set; } = "Chờ duyệt";
        public DateTime NgayUngTuyen { get; set; }
        public string? CvFileUrl { get; set; }
        public SinhVienProfileDto? ProfileDetail { get; set; }
    }
}
