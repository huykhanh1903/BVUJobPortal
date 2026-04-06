namespace BVUJobPortal.Models
{
    public class KhieuNai
    {
        public int Id { get; set; }

        public int NguoiDungId { get; set; }
        public NguoiDung NguoiDung { get; set; } = null!;

        public string NoiDung { get; set; } = string.Empty;
        public DateTime NgayGui { get; set; } = DateTime.UtcNow;

        public string TrangThai { get; set; } = "DangXuLy";
        public string? PhanHoiAdmin { get; set; }   
    }
}
