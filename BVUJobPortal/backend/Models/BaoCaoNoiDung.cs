namespace BVUJobPortal.Models
{
    public class BaoCaoNoiDung
    {
        public int Id { get; set; }
        public int NguoiDungId { get; set; } 
        public int? CongViecId { get; set; }
        public int? CVDaNopId { get; set; }
        public string LyDo { get; set; } = string.Empty;
        public string? TrangThai { get; set; } = "ChuaXuLy"; 
        public DateTime NgayBaoCao { get; set; } = DateTime.UtcNow;

        public NguoiDung? NguoiDung { get; set; }
        public CongViec? CongViec { get; set; }
        public CV? CV { get; set; }
    }
}
