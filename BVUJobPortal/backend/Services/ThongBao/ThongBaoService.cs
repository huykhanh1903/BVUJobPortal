using AutoMapper;
using BVUJobPortal.Data;
using BVUJobPortal.DTOs.ThongBao;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.ThongBao
{
    public class ThongBaoService : IThongBaoService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ThongBaoService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ThongBaoDto>> LayThongBaoAsync(int userId)
        {
            var ds = await _context.ThongBaos
                .Where(t => t.NguoiDungId == userId)
                .OrderByDescending(t => t.NgayTao)
                .ToListAsync();

            return _mapper.Map<List<ThongBaoDto>>(ds);
        }

        public async Task<ThongBaoDto> GuiThongBaoAsync(
            int userId,
            string tieuDe,
            string noiDung,
            string? url = null,
            string loai = "HeThong"
        )
        {
            var tb = new Models.ThongBao
            {
                NguoiDungId = userId,
                TieuDe = tieuDe,
                NoiDung = noiDung,
                Url = url,
                Loai = loai,
                DaDoc = false,
                NgayTao = DateTime.UtcNow
            };

            _context.ThongBaos.Add(tb);
            await _context.SaveChangesAsync();

            return _mapper.Map<ThongBaoDto>(tb);
        }

        public async Task<bool> DanhDauDaDocAsync(int thongBaoId, int userId)
        {
            var tb = await _context.ThongBaos
                .FirstOrDefaultAsync(t => t.Id == thongBaoId && t.NguoiDungId == userId);

            if (tb == null) return false;

            tb.DaDoc = true;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<int> DemThongBaoChuaDocAsync(int userId)
        {
            return await _context.ThongBaos
                .CountAsync(t => t.NguoiDungId == userId && !t.DaDoc);
        }
    }
}
