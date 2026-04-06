namespace BVUJobPortal.DTOs.Chung
{
    public class KetQuaPhanTrang<T>
    {
        public int TongSo { get; set; }
        public int Trang { get; set; } 
        public int SoLuongMoiTrang { get; set; }
        public List<T> DuLieu { get; set; } = new();
    }
}
