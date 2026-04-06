namespace BVUJobPortal.Models
{
    public class CVTemplate
    {
        public int Id { get; set; }
        public string TenTemplate { get; set; } = string.Empty; 
        public string MoTa { get; set; } = string.Empty;
        public string MauChuDao { get; set; } = "#0057B8";  
        public string Font { get; set; } = "Arial";
        public string PreviewUrl { get; set; } = string.Empty;

        public string? LayoutJson { get; set; }
        public string? StyleJson { get; set; }
        public bool IsPublished { get; set; } = true; 

        public ICollection<CV> CVs { get; set; } = new List<CV>();
    }
}
