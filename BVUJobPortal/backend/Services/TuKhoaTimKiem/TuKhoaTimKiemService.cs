using BVUJobPortal.Data;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;
using BVUJobPortal.DTOs.TuKhoa;
using BVUJobPortal.DTOs.Admin;
using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.DTOs.CongTy;

namespace BVUJobPortal.Services.TuKhoa
{
    public class TuKhoaService : ITuKhoaService
    {
        private readonly ApplicationDbContext _context;

        public TuKhoaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task LuuTuKhoaAsync(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return;

            tuKhoa = tuKhoa.Trim().ToLower();

            var nghe = await _context.NgheNghieps
                .FirstOrDefaultAsync(n => tuKhoa.Contains(n.TenNghe.ToLower()));

            var cn = await _context.ChuyenNganhs
                .Include(c => c.NgheNghiep)
                .FirstOrDefaultAsync(c => tuKhoa.Contains(c.TenChuyenNganh.ToLower()));

            var exist = await _context.TuKhoaTimKiems
                .FirstOrDefaultAsync(x => x.TuKhoa == tuKhoa);

            if (exist == null)
            {
                exist = new TuKhoaTimKiem
                {
                    TuKhoa = tuKhoa,
                    SoLan = 1,
                    NgayCapNhat = DateTime.UtcNow,
                    LinhVucId = cn?.NgheNghiep?.LinhVucId ?? nghe?.LinhVucId,
                    NganhNgheId = nghe?.Id ?? cn?.NgheNghiepId,
                    ChuyenNganhId = cn?.Id
                };

                _context.TuKhoaTimKiems.Add(exist);
            }
            else
            {
                exist.SoLan++;
                exist.NgayCapNhat = DateTime.UtcNow;

                if (exist.LinhVucId == null)
                    exist.LinhVucId = cn?.NgheNghiep?.LinhVucId ?? nghe?.LinhVucId;

                if (exist.NganhNgheId == null)
                    exist.NganhNgheId = nghe?.Id ?? cn?.NgheNghiepId;

                if (exist.ChuyenNganhId == null)
                    exist.ChuyenNganhId = cn?.Id;
            }

            await _context.SaveChangesAsync();
        }

        public async Task<List<TuKhoaThongKeDto>> LayTopTuKhoaHeThongAsync(int top = 10)
        {
            return await _context.TuKhoaTimKiems
                .OrderByDescending(x => x.SoLan)
                .Take(top)
                .Select(x => new TuKhoaThongKeDto
                {
                    TuKhoa = x.TuKhoa,
                    SoLan = x.SoLan
                })
                .ToListAsync();
        }


        public async Task<List<TuKhoaThongKeDto>> LayTopTuKhoaTheoLinhVucAsync(int linhVucId, int top = 10)
        {
            return await _context.TuKhoaTimKiems
                .Where(x => x.LinhVucId == linhVucId)
                .OrderByDescending(x => x.SoLan)
                .Take(top)
                .Select(x => new TuKhoaThongKeDto
                {
                    TuKhoa = x.TuKhoa,
                    SoLan = x.SoLan
                })
                .ToListAsync();
        }

        public async Task<List<TuKhoaThongKeDto>> LayTopTuKhoaTheoNganhNgheAsync(int nganhNgheId, int top = 10)
        {
            return await _context.TuKhoaTimKiems
                .Where(x => x.NganhNgheId == nganhNgheId)
                .OrderByDescending(x => x.SoLan)
                .Take(top)
                .Select(x => new TuKhoaThongKeDto
                {
                    TuKhoa = x.TuKhoa,
                    SoLan = x.SoLan
                })
                .ToListAsync();
        }


        public async Task<List<TuKhoaThongKeDto>> LayTopTuKhoaTheoChuyenNganhAsync(int chuyenNganhId, int top = 10)
        {
            return await _context.TuKhoaTimKiems
                .Where(x => x.ChuyenNganhId == chuyenNganhId)
                .OrderByDescending(x => x.SoLan)
                .Take(top)
                .Select(x => new TuKhoaThongKeDto
                {
                    TuKhoa = x.TuKhoa,
                    SoLan = x.SoLan
                })
                .ToListAsync();
        }
        public async Task<List<AdminCongTyDto>> TimKiemCongTyAsync(CongTySearchDto filter)
        {
            if (!string.IsNullOrWhiteSpace(filter.Keyword))
            {
                await LuuTuKhoaAsync(filter.Keyword);
            }

            var query = _context.CongTys
                .Include(c => c.CongViecs)
                    .ThenInclude(cv => cv.CongViecChuyenNganhs)
                        .ThenInclude(x => x.ChuyenNganh)
                            .ThenInclude(cn => cn.NgheNghiep)
                                .ThenInclude(nn => nn.LinhVuc)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.Keyword))
            {
                var keyword = filter.Keyword.Trim();
                query = query.Where(c => c.TenCongTy.Contains(keyword));
            }

            if (filter.TinhThanhId.HasValue)
                query = query.Where(c => c.TinhThanhId == filter.TinhThanhId);

            if (!string.IsNullOrEmpty(filter.QuyMoNhanSu))
                query = query.Where(c => c.QuyMoNhanSu == filter.QuyMoNhanSu);

            return await query.Select(c => new AdminCongTyDto
            {
                Id = c.Id,
                TenCongTy = c.TenCongTy,
                LogoUrl = c.LogoUrl,
                DiaChiLamViec = c.DiaChiLamViec,

                SoLuongCongViec = c.CongViecs.Count(),

                SoLuongLinhVuc = c.CongViecs
                    .SelectMany(cv => cv.CongViecChuyenNganhs)
                    .Select(x => x.ChuyenNganh.NgheNghiep.LinhVuc.Id)
                    .Distinct()
                    .Count()
            }).ToListAsync();
        }
        public async Task<List<CongViecDto>> TimKiemCongViecAsync(CongViecSearchDto filter)
        {
            if (!string.IsNullOrWhiteSpace(filter.Keyword))
                await LuuTuKhoaAsync(filter.Keyword);

            var query = _context.CongViecs
                .AsNoTracking()
                .Include(cv => cv.CongTy)
                .Include(cv => cv.CongViecChuyenNganhs)
                    .ThenInclude(x => x.ChuyenNganh)
                        .ThenInclude(cn => cn.NgheNghiep)
                            .ThenInclude(nn => nn.LinhVuc)
                .Where(cv => cv.DaDuyet);

            if (!string.IsNullOrWhiteSpace(filter.Keyword))
            {
                var kw = filter.Keyword.ToLower();
                query = query.Where(cv =>
                    cv.TieuDe.ToLower().Contains(kw) ||
                    (cv.MoTaCongViec != null && cv.MoTaCongViec.ToLower().Contains(kw)) ||
                    (cv.CongTy != null && cv.CongTy.TenCongTy.ToLower().Contains(kw))
                );
            }

            if (filter.LinhVucId.HasValue)
            {
                query = query.Where(cv =>
                    cv.CongViecChuyenNganhs.Any(cn =>
                        cn.ChuyenNganh.NgheNghiep.LinhVucId == filter.LinhVucId));
            }

            if (filter.NgheNghiepId.HasValue)
            {
                query = query.Where(cv =>
                    cv.CongViecChuyenNganhs.Any(cn =>
                        cn.ChuyenNganh.NgheNghiepId == filter.NgheNghiepId));
            }

            var jobs = await query
                .OrderByDescending(x => x.NgayDang)
                .ToListAsync();

            if (filter.ChuyenNganhIds != null && filter.ChuyenNganhIds.Any())
            {
                jobs = jobs.Where(cv =>
                    cv.CongViecChuyenNganhs.Any(cn =>
                        filter.ChuyenNganhIds.Contains(cn.ChuyenNganhId)
                    )
                ).ToList();
            }

            return jobs.Select(cv => new CongViecDto
            {
                Id = cv.Id,
                TieuDe = cv.TieuDe,
                LuongTu = cv.LuongTu,
                LuongDen = cv.LuongDen,
                LoaiTienTe = cv.LoaiTienTe,
                NgayDang = cv.NgayDang,
                DaDuyet = cv.DaDuyet,

                TenCongTy = cv.CongTy?.TenCongTy,
                LogoUrl = cv.CongTy?.LogoUrl,

                ChuyenNganhs = cv.CongViecChuyenNganhs
                    .Select(x => (object)x.ChuyenNganh.TenChuyenNganh)
                    .Distinct()
                    .ToList()
            }).ToList();
        }


        public async Task<CongViecDto?> BuildCongViecDto(int id)
        {
            var job = await _context.CongViecs
                .Include(c => c.CongTy)
                    .ThenInclude(ct => ct.TinhThanh)

                .Include(c => c.LoaiCongViec)
                .Include(c => c.CapBac)
                .Include(c => c.MucKinhNghiem)

                .Include(c => c.CongViecChuyenNganhs)
                    .ThenInclude(cvcn => cvcn.ChuyenNganh)
                        .ThenInclude(cn => cn.NgheNghiep)
                            .ThenInclude(nn => nn.LinhVuc)

                .Include(c => c.KhuVucLamViecs)
                    .ThenInclude(kv => kv.TinhThanh)

                .FirstOrDefaultAsync(c => c.Id == id);

            if (job == null)
                return null;

            var dto = new CongViecDto
            {
                Id = job.Id,
                TieuDe = job.TieuDe,

                ChuyenNganhs = job.CongViecChuyenNganhs
                    .Select(x => new {
                        id = x.ChuyenNganh.Id,
                        ten = x.ChuyenNganh.TenChuyenNganh
                    })
                    .Distinct()
                    .ToList<object>(),

                NganhNghieps = job.CongViecChuyenNganhs
                    .Select(x => new {
                        id = x.ChuyenNganh.NgheNghiep.Id,
                        ten = x.ChuyenNganh.NgheNghiep.TenNghe
                    })
                    .Distinct()
                    .ToList<object>(),

                LinhVucs = job.CongViecChuyenNganhs
                    .Select(x => new {
                        id = x.ChuyenNganh.NgheNghiep.LinhVuc.Id,
                        ten = x.ChuyenNganh.NgheNghiep.LinhVuc.TenLinhVuc
                    })
                    .Distinct()
                    .ToList<object>(),

                KhuVucLamViec = job.KhuVucLamViecs
                    .Select(x => x.TinhThanh.TenTinh)
                    .ToList(),

                SoLuongTuyen = job.SoLuongTuyen,

                LoaiCongViecId = job.LoaiCongViecId,
                TenLoaiCongViec = job.LoaiCongViec?.Ten,

                CapBacId = job.CapBacId,
                TenCapBac = job.CapBac?.Ten,

                MucKinhNghiemId = job.MucKinhNghiemId,
                TenKinhNghiem = job.MucKinhNghiem?.Ten ?? "Không yêu cầu",

                GioiTinh = job.GioiTinh,
                LoaiTienTe = job.LoaiTienTe,
                KieuLuong = job.KieuLuong,
                LuongTu = job.LuongTu,
                LuongDen = job.LuongDen,

                HanNopHoSo = job.HanNopHoSo,
                NgayDang = job.NgayDang,
                DaDuyet = job.DaDuyet,

                TenCongTy = job.CongTy?.TenCongTy,
                LogoUrl = job.CongTy?.LogoUrl
            };

            return dto;
        }
    }
}
