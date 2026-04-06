namespace BVUJobPortal.Models
{
    public class CapBac
    {
        public int Id { get; set; }
        public string Ten { get; set; } = string.Empty;

        public ICollection<CongViec>? CongViecs { get; set; }
    }
}