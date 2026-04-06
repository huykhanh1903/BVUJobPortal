namespace BVUJobPortal.DTOs
{
    public class BaoCaoNoiDungDto
    {
        public int Id { get; set; }
        public int? CongViecId { get; set; }
        public int? CVDaNopId { get; set; }
        public string LyDo { get; set; } = string.Empty;
        public string TrangThai { get; set; } = "Chua xu ly";
        public DateTime NgayBaoCao { get; set; } = DateTime.UtcNow;

        public string? NguoiBaoCao { get; set; }
        public string? CongViec { get; set; }
        public string? CV { get; set; }
    }

    public class AdminXuLyBaoCaoDto
    {
        public string TrangThai { get; set; } = "DaXuLy"; 
    }
}
