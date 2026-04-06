namespace BVUJobPortal.DTOs.Admin
{
    public class AdminGuiThongBaoDto
    {
        public string TieuDe { get; set; } = string.Empty;
        public string NoiDung { get; set; } = string.Empty;
        public string? Url { get; set; }
        public string Loai { get; set; } = "HeThong";

        public int? NguoiDungId { get; set; }
        public string? VaiTro { get; set; }
        public bool GuiToanHeThong { get; set; }
    }
}
