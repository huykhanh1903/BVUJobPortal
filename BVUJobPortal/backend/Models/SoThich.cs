namespace BVUJobPortal.Models
{
    public class SoThich
    {
        public int Id { get; set; }
        public int CvId { get; set; }
        public string NoiDung { get; set; } = string.Empty;

        public CV Cv { get; set; }
    }

}
