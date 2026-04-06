using BVUJobPortal.DTOs.CV;

namespace BVUJobPortal.Services.CvModule
{
    public interface ICVTemplateAdminService
    {
        Task<List<CVTemplateListItemDto>> GetAllAsync(string? keyword = null, bool? published = null);
        Task<CVTemplateDetailDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(CVTemplateCreateDto dto);
        Task<bool> UpdateAsync(int id, CVTemplateUpdateDto dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> SetPublishAsync(int id, bool isPublished);
    }
}