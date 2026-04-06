using AutoMapper;
using BVUJobPortal.Data;
using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;
using BVUJobPortal.Services.ThongBao;

namespace BVUJobPortal.Services.CongViec
{
    public class CongViecService : ICongViecService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IThongBaoService _thongBaoService;

        public CongViecService(ApplicationDbContext context, IMapper mapper, IThongBaoService thongBaoService)
        {
            _context = context;
            _mapper = mapper;
            _thongBaoService = thongBaoService;
        }

        public async Task<CongViecDto?> DangTuyenAsync(int userId, DangTuyenDto dto)
        {
            var user = await _context.NguoiDungs
                .Include(u => u.CongTy)
                    .ThenInclude(ct => ct.TinhThanh)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                throw new Exception("Không tìm thấy người dùng.");

            var job = _mapper.Map<Models.CongViec>(dto);
            job.NguoiDungId = userId;
            job.NgayDang = DateTime.UtcNow;
            job.NgayCapNhat = DateTime.UtcNow;
            job.DaDuyet = false;

            if (user.CongTyId != null && user.DaDuocCongTyXacThuc)
            {
                job.CongTyId = user.CongTyId;
            }

            _context.CongViecs.Add(job);
            await _context.SaveChangesAsync();

            if (dto.ChuyenNganhIds != null)
            {
                foreach (var cnId in dto.ChuyenNganhIds)
                {
                    _context.CongViecChuyenNganhs.Add(new CongViecChuyenNganh
                    {
                        CongViecId = job.Id,
                        ChuyenNganhId = cnId
                    });
                }
            } 
            if (dto.KhuVucs != null)
            {
                foreach (var kv in dto.KhuVucs)
                {
                    _context.CongViecKhuVucs.Add(new CongViecKhuVuc
                    {
                        CongViecId = job.Id,
                        TinhThanhId = kv.TinhThanhId,
                        DiaChiCuThe = kv.DiaChiCuThe
                    });
                }
            }

            await _context.SaveChangesAsync();

            if (job.CongTyId != null)
            {
                var doanhNghiepAdminId = await _context.NguoiDungs
                    .Where(u =>
                        u.CongTyId == job.CongTyId &&
                        u.VaiTroCongTy == "CompanyAdmin"
                    )
                    .Select(u => u.Id)
                    .FirstOrDefaultAsync();

                if (doanhNghiepAdminId != 0)
                {
                    await _thongBaoService.GuiThongBaoAsync(
                        userId: doanhNghiepAdminId,
                        tieuDe: "Tin tuyển dụng mới chờ duyệt",
                        noiDung: $"Nhà tuyển dụng vừa đăng tin \"{job.TieuDe}\".",
                        url: $"/doanh-nghiep/duyet-tin/{job.Id}",
                        loai: "DangTin"
                    );
                }
            }


            await _context.Entry(job).Reference(j => j.CongTy).LoadAsync();
            if (job.CongTy != null)
                await _context.Entry(job.CongTy).Reference(ct => ct.TinhThanh).LoadAsync();

            return await BuildCongViecDto(job.Id);
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

        public async Task<CongViecDto?> CapNhatCongViecAsync(int congViecId, int userId, CapNhatCongViecDto dto)
        {
            var job = await _context.CongViecs
                .Include(c => c.CongViecChuyenNganhs)
                .Include(c => c.KhuVucLamViecs)
                .FirstOrDefaultAsync(c => c.Id == congViecId && c.NguoiDungId == userId);

            if (job == null)
                throw new Exception("Không tìm thấy công việc.");

            if (job.DaDuyet)
                throw new Exception("Công việc đã được duyệt, không thể sửa.");

            _mapper.Map(dto, job);
            job.NgayCapNhat = DateTime.UtcNow;

            _context.CongViecChuyenNganhs.RemoveRange(job.CongViecChuyenNganhs);

            if (dto.ChuyenNganhIds != null)
            {
                foreach (var cnId in dto.ChuyenNganhIds)
                {
                    _context.CongViecChuyenNganhs.Add(new CongViecChuyenNganh
                    {
                        CongViecId = job.Id,
                        ChuyenNganhId = cnId
                    });
                }
            }

            _context.CongViecKhuVucs.RemoveRange(job.KhuVucLamViecs);

            if (dto.KhuVucs != null)
            {
                foreach (var kv in dto.KhuVucs)
                {
                    _context.CongViecKhuVucs.Add(new CongViecKhuVuc
                    {
                        CongViecId = job.Id,
                        TinhThanhId = kv.TinhThanhId,
                        DiaChiCuThe = kv.DiaChiCuThe
                    });
                }
            }

            await _context.SaveChangesAsync();

            return await BuildCongViecDto(job.Id);
        }

        public async Task<bool> XoaCongViecAsync(int congViecId, int userId)
        {
            var user = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null) return false;

            var job = await _context.CongViecs
                .Include(c => c.NguoiDung)
                .FirstOrDefaultAsync(c => c.Id == congViecId);

            if (job == null) return false;

            if (user.CongTyId == null)
            {
                if (job.NguoiDungId != userId)
                    return false; 

                _context.CongViecs.Remove(job);
                await _context.SaveChangesAsync();
                return true;
            }

            if (user.CongTyId != null && user.VaiTro == "NhaTuyenDung")
            {
                if (job.NguoiDungId != userId)
                    return false;

                _context.CongViecs.Remove(job);
                await _context.SaveChangesAsync();
                return true;
            }

            if (user.VaiTroCongTy == "CompanyAdmin")
            {
                if (job.CongTyId != user.CongTyId)
                    return false;

                _context.CongViecs.Remove(job);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<CongViecChiTietDto?> LayChiTietCongViecAsync(int id)
        {
            var job = await _context.CongViecs
                .Include(c => c.CongTy)
                    .ThenInclude(ct => ct.TinhThanh)
                .Include(c => c.LoaiCongViec)
                .Include(c => c.CapBac)
                .Include(c => c.MucKinhNghiem)

                .Include(c => c.CongViecChuyenNganhs)
                    .ThenInclude(cn => cn.ChuyenNganh)
                        .ThenInclude(cn => cn.NgheNghiep)
                            .ThenInclude(nn => nn.LinhVuc)

                .Include(c => c.KhuVucLamViecs)
                    .ThenInclude(kv => kv.TinhThanh)

                .FirstOrDefaultAsync(c => c.Id == id);

            if (job == null)
                return null;

            var dto = _mapper.Map<CongViecChiTietDto>(job);

            dto.ChuyenNganhs = job.CongViecChuyenNganhs?
                .Select(x => x.ChuyenNganh.TenChuyenNganh)
                .Distinct()
                .ToList();

            dto.NganhNghieps = job.CongViecChuyenNganhs?
                .Select(x => x.ChuyenNganh.NgheNghiep.TenNghe)
                .Distinct()
                .ToList();

            dto.LinhVucs = job.CongViecChuyenNganhs?
                .Select(x => x.ChuyenNganh.NgheNghiep.LinhVuc.TenLinhVuc)
                .Distinct()
                .ToList();

            dto.MucKinhNghiemId = job.MucKinhNghiemId;
            dto.CapBacId = job.CapBacId;
            dto.LoaiCongViecId = job.LoaiCongViecId;
            dto.GioiTinh = job.GioiTinh;

            dto.KhuVucs = job.KhuVucLamViecs?
                .Select(kv => new KhuVucItemDto
                {
                    TinhThanhId = kv.TinhThanhId,
                    DiaChiCuThe = kv.DiaChiCuThe
                }).ToList();



            return dto;
        }

        public async Task<List<CongViecDto>> DanhSachDangTuyenAsync(int userId)
        {
            var jobs = await _context.CongViecs
                .Where(c => c.NguoiDungId == userId)
                .OrderByDescending(c => c.NgayDang)
                .Select(c => c.Id)
                .ToListAsync();

            var result = new List<CongViecDto>();

            foreach (var id in jobs)
            {
                var dto = await BuildCongViecDto(id);
                if (dto != null)
                    result.Add(dto);
            }

            return result;
        }

        public async Task<List<CongViecDto>> DanhSachTatCaAsync()
        {
            var jobIds = await _context.CongViecs
                .Where(c =>
                    c.CongTyId == null ||
                    (c.CongTyId != null && c.DaDuyet == true)
                )
                .OrderByDescending(c => c.NgayDang)
                .Select(c => c.Id)
                .ToListAsync();

            var result = new List<CongViecDto>();

            foreach (var id in jobIds)
            {
                var dto = await BuildCongViecDto(id);
                if (dto != null)
                    result.Add(dto);
            }

            return result;
        }

    }
}
