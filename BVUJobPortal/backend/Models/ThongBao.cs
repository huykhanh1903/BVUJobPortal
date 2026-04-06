namespace BVUJobPortal.Models
{
    public class ThongBao
    {
        public int Id { get; set; }

        public int NguoiDungId { get; set; }
        public NguoiDung NguoiDung { get; set; }
        public string TieuDe { get; set; } = string.Empty;
        public string NoiDung { get; set; } = string.Empty;

        public string? Url { get; set; } 
        public string Loai { get; set; } = "HeThong";
        public bool DaDoc { get; set; } = false;

        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
    }

}
