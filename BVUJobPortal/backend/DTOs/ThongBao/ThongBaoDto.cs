namespace BVUJobPortal.DTOs.ThongBao
{
    public class ThongBaoDto
    {
        public int Id { get; set; }
        public string TieuDe { get; set; } = string.Empty;
        public string NoiDung { get; set; } = string.Empty;
        public bool DaDoc { get; set; }
        public DateTime NgayGui { get; set; }


        public int NguoiDungId { get; set; }
        public string? TenNguoiGui { get; set; }
    }
}
