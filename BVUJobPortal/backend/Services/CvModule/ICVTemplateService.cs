using BVUJobPortal.Models;

namespace BVUJobPortal.Services.CvModule
{
    public interface ICVTemplateService
    {
        Task<List<CVTemplate>> LayDanhSachTemplateAsync();
        Task<CVTemplate?> LayTemplateTheoIdAsync(int id);
        Task ThemTemplateAsync(CVTemplate model);
        Task<bool> CapNhatTemplateAsync(int id, CVTemplate model);
        Task<bool> XoaTemplateAsync(int id);
    }
}
