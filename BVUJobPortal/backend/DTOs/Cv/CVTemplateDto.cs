namespace BVUJobPortal.DTOs.CV
{
    public class CVTemplateCreateDto
    {
        public string TenTemplate { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;

        public string MauChuDao { get; set; } = "#0057B8";
        public string Font { get; set; } = "Arial";

        public string PreviewUrl { get; set; } = string.Empty;

        public string? LayoutJson { get; set; }
        public string? StyleJson { get; set; }      

        public string? SupportedBlocksJson { get; set; }
        public bool IsDefaultLayout { get; set; } = false; 
        public int Version { get; set; } = 1;        

        public bool IsPublished { get; set; } = true;
    }


    public class CVTemplateUpdateDto : CVTemplateCreateDto { }
)
    public class CVTemplateListItemDto
    {
        public int Id { get; set; }
        public string TenTemplate { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public string PreviewUrl { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
    }
    public class CVTemplateDetailDto : CVTemplateCreateDto
    {
        public int Id { get; set; }
    }
}