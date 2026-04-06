namespace BVUJobPortal.DTOs.ThongBao
{
    public class GuiThongBaoRequest
    {
        public int UserId { get; set; }
        public string TieuDe { get; set; } = string.Empty;
        public string NoiDung { get; set; } = string.Empty;
        public string? Url { get; set; }
        public string Loai { get; set; } = "HeThong";
    }
}
