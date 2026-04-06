using BVUJobPortal.Data;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.CvModule
{
    public class CVTemplateService : ICVTemplateService
    {
        private readonly ApplicationDbContext _context;
        public CVTemplateService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CVTemplate>> LayDanhSachTemplateAsync()
        {
            return await _context.CVTemplates.ToListAsync();
        }

        public async Task<CVTemplate?> LayTemplateTheoIdAsync(int id)
        {
            return await _context.CVTemplates.FindAsync(id);
        }

        public async Task ThemTemplateAsync(CVTemplate model)
        {
            _context.CVTemplates.Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CapNhatTemplateAsync(int id, CVTemplate model)
        {
            var existing = await _context.CVTemplates.FindAsync(id);
            if (existing == null) return false;

            existing.TenTemplate = model.TenTemplate;
            existing.MoTa = model.MoTa;
            existing.MauChuDao = model.MauChuDao;
            existing.Font = model.Font;
            existing.PreviewUrl = model.PreviewUrl;

            _context.CVTemplates.Update(existing);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> XoaTemplateAsync(int id)
        {
            var template = await _context.CVTemplates.FindAsync(id);
            if (template == null) return false;

            _context.CVTemplates.Remove(template);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
