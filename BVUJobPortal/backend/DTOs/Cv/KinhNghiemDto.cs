namespace BVUJobPortal.DTOs.CV
{
    public class KinhNghiemDto
    {
        public int Id { get; set; }
        public string CongTy { get; set; } = string.Empty;
        public string ViTri { get; set; } = string.Empty;
        public string ThoiGianLamViec { get; set; } = string.Empty;
        public string? MoTaCongViec { get; set; }
        public int ThuTu { get; set; }
    }

}
