using BVUJobPortal.Data;
using BVUJobPortal.DTOs.DiaChi;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.DiaChi
{
    public class DiaChiService : IDiaChiService
    {
        private readonly ApplicationDbContext _context;

        public DiaChiService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TinhThanhDto>> DanhSachTinhThanhAsync()
        {
            return await _context.TinhThanhs
                .OrderBy(t => t.TenTinh)
                .Select(t => new TinhThanhDto
                {
                    Id = t.Id,
                    TenTinh = t.TenTinh,
                    MaTinh = t.MaTinh
                })
                .ToListAsync();
        }

        public async Task<TinhThanhDto?> TaoTinhThanhAsync(TinhThanhDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.TenTinh))
                throw new ArgumentException("Tên tỉnh/thành không được để trống.");

            var tinh = new TinhThanh
            {
                TenTinh = dto.TenTinh.Trim(),
                MaTinh = dto.MaTinh?.Trim()
            };

            _context.TinhThanhs.Add(tinh);
            await _context.SaveChangesAsync();

            dto.Id = tinh.Id;
            return dto;
        }
    }
}
