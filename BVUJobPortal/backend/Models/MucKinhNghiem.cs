namespace BVUJobPortal.Models
{
    public class MucKinhNghiem
    {
        public int Id { get; set; }
        public string Ten { get; set; } = string.Empty;

        public ICollection<CongViec>? CongViecs { get; set; }
    }
}