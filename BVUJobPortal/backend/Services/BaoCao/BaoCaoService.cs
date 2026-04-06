using AutoMapper;
using BVUJobPortal.Data;
using BVUJobPortal.DTOs;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.BaoCao
{
    public class BaoCaoService : IBaoCaoService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BaoCaoService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BaoCaoNoiDungDto> GuiBaoCaoAsync(int userId, BaoCaoNoiDungDto dto)
        {
            var bc = _mapper.Map<BaoCaoNoiDung>(dto);
            bc.NguoiDungId = userId;
            bc.TrangThai = "Chưa xử lý";
            bc.NgayBaoCao = DateTime.UtcNow;

            _context.BaoCaoNoiDungs.Add(bc);
            await _context.SaveChangesAsync();

            bc = await _context.BaoCaoNoiDungs
                .Include(b => b.NguoiDung)
                .Include(b => b.CongViec)
                .Include(b => b.CV)
                .FirstAsync(b => b.Id == bc.Id);

            return _mapper.Map<BaoCaoNoiDungDto>(bc);
        }

        // Ds bao cao
        public async Task<List<BaoCaoNoiDungDto>> DanhSachBaoCaoAsync()
        {
            var ds = await _context.BaoCaoNoiDungs
                .Include(b => b.NguoiDung)
                .Include(b => b.CongViec)
                .Include(b => b.CV)
                .OrderByDescending(b => b.NgayBaoCao)
                .ToListAsync();

            return _mapper.Map<List<BaoCaoNoiDungDto>>(ds);
        }

        // Xu ly bao cao
        public async Task<BaoCaoNoiDungDto?> XuLyBaoCaoAsync(int id, string trangThai)
        {
            var bc = await _context.BaoCaoNoiDungs
                .Include(b => b.NguoiDung)
                .Include(b => b.CongViec)
                .Include(b => b.CV)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (bc == null) return null;

            bc.TrangThai = trangThai;
            _context.BaoCaoNoiDungs.Update(bc);
            await _context.SaveChangesAsync();

            return _mapper.Map<BaoCaoNoiDungDto>(bc);
        }
    }
}
