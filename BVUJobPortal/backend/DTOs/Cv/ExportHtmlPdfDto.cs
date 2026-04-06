namespace BVUJobPortal.DTOs.CV
{
    public class ExportHtmlPdfDto
    {
        public string Html { get; set; } = "";
        public string Css { get; set; } = "";
        public int Width { get; set; } = 794;
        public int Height { get; set; } = 1123;
    }
}
