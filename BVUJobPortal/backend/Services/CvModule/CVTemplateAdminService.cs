using BVUJobPortal.Data;
using BVUJobPortal.DTOs.CV;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.CvModule
{
    public class CVTemplateAdminService : ICVTemplateAdminService
    {
        private readonly ApplicationDbContext _context;

        public CVTemplateAdminService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CVTemplateListItemDto>> GetAllAsync(string? keyword = null, bool? published = null)
        {
            var query = _context.CVTemplates.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    x.TenTemplate.Contains(keyword) ||
                    x.MoTa.Contains(keyword)
                );
            }

            if (published.HasValue)
            {
                query = query.Where(x => x.IsPublished == published.Value);
            }

            return await query
                .OrderByDescending(x => x.Id)
                .Select(x => new CVTemplateListItemDto
                {
                    Id = x.Id,
                    TenTemplate = x.TenTemplate,
                    MoTa = x.MoTa,
                    PreviewUrl = x.PreviewUrl,
                    IsPublished = x.IsPublished
                })
                .ToListAsync();
        }

        public async Task<CVTemplateDetailDto?> GetByIdAsync(int id)
        {
            var t = await _context.CVTemplates.FindAsync(id);
            if (t == null) return null;

            return new CVTemplateDetailDto
            {
                Id = t.Id,
                TenTemplate = t.TenTemplate,
                MoTa = t.MoTa,
                MauChuDao = t.MauChuDao,
                Font = t.Font,
                PreviewUrl = t.PreviewUrl,
                LayoutJson = t.LayoutJson,
                StyleJson = t.StyleJson,
                IsPublished = t.IsPublished
            };
        }

        public async Task<int> CreateAsync(CVTemplateCreateDto dto)
        {
            var template = new CVTemplate
            {
                TenTemplate = dto.TenTemplate,
                MoTa = dto.MoTa,
                MauChuDao = dto.MauChuDao,
                Font = dto.Font,
                PreviewUrl = dto.PreviewUrl,
                LayoutJson = dto.LayoutJson?.Trim(),
                StyleJson = dto.StyleJson?.Trim(),
                IsPublished = dto.IsPublished
            };

            _context.CVTemplates.Add(template);
            await _context.SaveChangesAsync();
            return template.Id;
        }

        public async Task<bool> UpdateAsync(int id, CVTemplateUpdateDto dto)
        {
            var t = await _context.CVTemplates.FindAsync(id);
            if (t == null) return false;

            t.TenTemplate = dto.TenTemplate;
            t.MoTa = dto.MoTa;
            t.MauChuDao = dto.MauChuDao;
            t.Font = dto.Font;
            t.PreviewUrl = dto.PreviewUrl;

            t.LayoutJson = dto.LayoutJson?.Trim();
            t.StyleJson = dto.StyleJson?.Trim();

            t.IsPublished = dto.IsPublished;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var t = await _context.CVTemplates.FindAsync(id);
            if (t == null) return false;

            _context.CVTemplates.Remove(t);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> SetPublishAsync(int id, bool isPublished)
        {
            var t = await _context.CVTemplates.FindAsync(id);
            if (t == null) return false;

            t.IsPublished = isPublished;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
