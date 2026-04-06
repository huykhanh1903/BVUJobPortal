namespace BVUJobPortal.Models
{
    public class DonUngTuyen
    {
        public int Id { get; set; }
        public int CongViecId { get; set; }
        public CongViec CongViec { get; set; }

        public int NguoiDungId { get; set; }
        public NguoiDung NguoiDung { get; set; }

        public string ThuGioiThieu { get; set; } = string.Empty;
        public string TrangThai { get; set; } = "Đang chờ";

        public DateTime NgayUngTuyen { get; set; } = DateTime.UtcNow;

        public int? CvId { get; set; }
        public CV? Cv { get; set; }

        public string? CvFileUrl { get; set; }
        public string? ProfileSnapshotJson { get; set; }

    }
}
