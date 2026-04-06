namespace BVUJobPortal.DTOs.TuKhoa
{
    public class CongViecSearchDto
    {
        public string? Keyword { get; set; }

        public int? LinhVucId { get; set; }
        public int? NgheNghiepId { get; set; }

        public List<int>? ChuyenNganhIds { get; set; }

        public int? TinhThanhId { get; set; }
    }
}
