namespace BVUJobPortal.DTOs.UngTuyen
{
    public class UngTuyenDto
    {
        public int CongViecId { get; set; }
        public string ThuGioiThieu { get; set; } = string.Empty;
        public IFormFile? CvFile { get; set; }

    }
}
