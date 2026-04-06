using Microsoft.EntityFrameworkCore;
using BVUJobPortal.Data;
using BVUJobPortal.DTOs.DoanhNghiep;
using BVUJobPortal.Models;
using BVUJobPortal.DTOs.CongTy;
using BVUJobPortal.DTOs.CongViec;
using AutoMapper;
using BVUJobPortal.Services.CongViec;
using BVUJobPortal.Services.ThongBao;


namespace BVUJobPortal.Services.DoanhNghiep
{
    public class DoanhNghiepService : IDoanhNghiepService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICongViecService _congViecService;
        private readonly IThongBaoService _thongBaoService;

        public DoanhNghiepService(ApplicationDbContext context, IMapper mapper, ICongViecService congViecService, IThongBaoService thongBaoService)
        {
            _context = context;
            _mapper = mapper;
            _congViecService = congViecService;
            _thongBaoService = thongBaoService;
        }


        public async Task<HRResponseDto?> TaoHRAsync(int adminCongTyId, TaoHRDto dto)
        {
            var admin = await _context.NguoiDungs
                .Include(x => x.CongTy)
                .FirstOrDefaultAsync(x => x.Id == adminCongTyId && x.VaiTro == "DoanhNghiep");

            if (admin?.CongTy == null)
                return null;

            if (await _context.NguoiDungs.AnyAsync(x => x.Email == dto.Email))
                throw new Exception("Email đã được sử.");

            var maNtd = await TaoMaNhaTuyenDungAsync();

            var hr = new NguoiDung
            {
                Ma = maNtd,
                HoTen = dto.HoTen,
                Email = dto.Email,
                SDT = dto.SDT,
                MatKhauHash = BCrypt.Net.BCrypt.HashPassword(dto.MatKhau),
                VaiTro = "NhaTuyenDung",
                CongTyId = admin.CongTy.Id,
                DaDuocCongTyXacThuc = true,
                NguoiXacThucId = admin.Id,
                NgayXacThuc = DateTime.UtcNow,
            };

            _context.NguoiDungs.Add(hr);
            await _context.SaveChangesAsync();

            return new HRResponseDto
            {
                Id = hr.Id,
                HoTen = hr.HoTen,
                Email = hr.Email,
                SDT = hr.SDT,
                DaDuocCongTyXacThuc = hr.DaDuocCongTyXacThuc,
                NgayXacThuc = hr.NgayXacThuc,
                NguoiXacThuc = admin.HoTen,
                TenCongTy = admin.CongTy.TenCongTy,
                 Ma = hr.Ma
            };
        }

        private async Task<string> TaoMaNhaTuyenDungAsync()
        {
            var allCodes = await _context.NguoiDungs
                .Where(x => x.VaiTro == "NhaTuyenDung" && x.Ma != null && x.Ma.StartsWith("NTD-"))
                .Select(x => x.Ma)
                .ToListAsync();

            int maxNumber = 0;

            foreach (var code in allCodes)
            {
                var numberPart = code!.Substring(4);
                if (int.TryParse(numberPart, out int n))
                {
                    if (n > maxNumber)
                        maxNumber = n;
                }
            }

            return $"NTD-{maxNumber + 1}";
        }

        public async Task<HRChiTietDto?> ChiTietHRAsync(int adminCongTyId, int hrId)
        {
            var admin = await _context.NguoiDungs
                .Include(x => x.CongTy)
                .FirstOrDefaultAsync(x => x.Id == adminCongTyId && x.VaiTro == "DoanhNghiep");

            if (admin?.CongTy == null)
                return null; 

            var hr = await _context.NguoiDungs
                .Include(x => x.NguoiXacThuc)
                .FirstOrDefaultAsync(x =>
                    x.Id == hrId &&
                    x.VaiTro == "NhaTuyenDung" &&
                    x.CongTyId == admin.CongTy.Id
                );

            if (hr == null)
                return null;

            string? lyDo = hr.LyDoXinXacThuc;

            return new HRChiTietDto
            {
                Id = hr.Id,
                HoTen = hr.HoTen,
                Email = hr.Email,
                SDT = hr.SDT,
                TenCongTy = admin.CongTy.TenCongTy,

                DaDuocCongTyXacThuc = hr.DaDuocCongTyXacThuc,
                NgayXacThuc = hr.NgayXacThuc,
                NguoiXacThuc = hr.NguoiXacThuc?.HoTen,

                LyDoXinXacThuc = lyDo,

                AvatarUrl = hr.AvatarUrl,
                NgayTao = hr.NgayTao
            };
        }

        public async Task<bool> GuiYeuCauXacThucHRAsync(int hrId, XinXacThucHRDto dto)
        {
            var hr = await _context.NguoiDungs
                .FirstOrDefaultAsync(x => x.Id == hrId && x.VaiTro == "NhaTuyenDung");
            if (hr == null)
                throw new Exception("Không tìm thấy tài khoản nhà tuyển dụng.");

            var congTy = await _context.CongTys
                .FirstOrDefaultAsync(c =>
                    c.DaDuocAdminXacMinh &&
                    (c.Ma ?? "").ToLower() == (dto.MaCongTy ?? "").ToLower()
                );

            if (congTy == null)
                throw new Exception("Mã công ty không tồn tại hoặc công ty chưa được admin xác minh.");

            if (hr.CongTyId == congTy.Id && hr.DaDuocCongTyXacThuc == false)
                throw new Exception("Bạn đã gửi yêu cầu xác thực công ty này trước đó.");

            hr.CongTyId = congTy.Id;
            hr.DaDuocCongTyXacThuc = false;
            hr.NguoiXacThucId = null;
            hr.NgayXacThuc = null;

            _context.NguoiDungs.Update(hr);

            var adminCongTy = await _context.NguoiDungs
                .FirstOrDefaultAsync(x => x.CongTyId == congTy.Id && x.VaiTroCongTy == "CompanyAdmin");

            if (adminCongTy != null)
            {
                await _thongBaoService.GuiThongBaoAsync(
                    userId: adminCongTy.Id,
                    tieuDe: "📩 Yêu cầu xác thực HR mới",
                    noiDung: $"Nhà tuyển dụng {hr.HoTen} đã gửi yêu cầu xác thực tham gia công ty {congTy.TenCongTy}.",
                    url: "/doanh-nghiep/quan-ly-hr",
                    loai: "XacThucHR"
                );
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool>XacThucHRAsync (int adminCongTyId, XacThucHRDto dto)
        {
            var hr = await _context.NguoiDungs.FirstOrDefaultAsync(x =>x.Id == dto.HrId && x.VaiTro == "NhaTuyenDung");
            if (hr == null) return false; 

            if (dto.XacThuc)
            {
                hr.DaDuocCongTyXacThuc = true;
                hr.NguoiXacThucId = adminCongTyId;
                hr.NgayXacThuc = DateTime.UtcNow;
            }

            else
            {
                hr.DaDuocCongTyXacThuc =false;
                hr.NguoiXacThucId = null;
                hr.CongTyId = null;
            }

            await _context.SaveChangesAsync();

            if (dto.XacThuc)
            {
                await _thongBaoService.GuiThongBaoAsync(
                    userId: hr.Id,
                    tieuDe: "Xác thực tài khoản thành công",
                    noiDung: "Tài khoản nhà tuyển dụng của bạn đã được doanh nghiệp xác thực.",
                    url: "/nha-tuyen-dung/dashboard",
                    loai: "XacThucHR"
                );
            }
            else
            {
                await _thongBaoService.GuiThongBaoAsync(
                    userId: hr.Id,
                    tieuDe: "Yêu cầu xác thực bị từ chối",
                    noiDung: "Yêu cầu xác thực công ty của bạn đã bị từ chối.",
                    url: "/nha-tuyen-dung/yeu-cau-xac-thuc",
                    loai: "TuChoiXacThucHR"
                );
            }

            return true;
        }

        public async Task<List<HRResponseDto>> DanhSachHRChoXacThucAsync(int adminCongTyId)
        {

            var admin = await _context.NguoiDungs
                .Include(x => x.CongTy)
                .FirstOrDefaultAsync(x => x.Id == adminCongTyId && x.VaiTro == "DoanhNghiep");

            if (admin?.CongTy == null)
                return new List<HRResponseDto>();

            var hrChoDuyet = await _context.NguoiDungs
                .Where(x => x.VaiTro == "NhaTuyenDung"
                         && x.CongTyId == admin.CongTy.Id
                         && x.DaDuocCongTyXacThuc == false)
                .Select(x => new HRResponseDto
                {
                    Id = x.Id,
                    HoTen = x.HoTen,
                    Email = x.Email,
                    SDT = x.SDT,
                    TenCongTy = admin.CongTy.TenCongTy,
                    DaDuocCongTyXacThuc = x.DaDuocCongTyXacThuc,
                    NgayXacThuc = x.NgayXacThuc,
                    NguoiXacThuc = x.NguoiXacThuc != null ? x.NguoiXacThuc.HoTen : null
                })
                .OrderBy(x => x.HoTen)
                .ToListAsync();

            return hrChoDuyet;
        }

        public async Task<List<HRResponseDto>> DanhSachHRDaXacThucAsync(int adminCongTyId)
        {
            var admin = await _context.NguoiDungs
                .Include(x => x.CongTy)
                .FirstOrDefaultAsync(x => x.Id == adminCongTyId && x.VaiTro == "DoanhNghiep");

            if (admin?.CongTy == null)
                return new List<HRResponseDto>();

            var hrDaXacThuc = await _context.NguoiDungs
                .Where(x => x.VaiTro == "NhaTuyenDung"
                         && x.CongTyId == admin.CongTy.Id
                         && x.DaDuocCongTyXacThuc == true)
                .Select(x => new HRResponseDto
                {
                    Id = x.Id,
                    HoTen = x.HoTen,
                    Email = x.Email,
                    SDT = x.SDT,
                    TenCongTy = admin.CongTy.TenCongTy,
                    DaDuocCongTyXacThuc = x.DaDuocCongTyXacThuc,
                    NgayXacThuc = x.NgayXacThuc,
                    NguoiXacThuc = x.NguoiXacThuc != null ? x.NguoiXacThuc.HoTen : null
                })
                .OrderBy(x => x.HoTen)
                .ToListAsync();

            return hrDaXacThuc;
        }

        public async Task<bool> HuyXacThucHRAsync(int adminCongTyId, HuyXacThucHRDto dto)
        {
            var admin = await _context.NguoiDungs
                .Include(x => x.CongTy)
                .FirstOrDefaultAsync(x => x.Id == adminCongTyId && x.VaiTro == "DoanhNghiep");

            if (admin?.CongTy == null)
                return false;

            var hr = await _context.NguoiDungs
                .FirstOrDefaultAsync(x => x.Id == dto.HrId
                                       && x.VaiTro == "NhaTuyenDung"
                                       && x.CongTyId == admin.CongTy.Id);

            if (hr == null)
                return false;

            hr.DaDuocCongTyXacThuc = false;
            hr.NguoiXacThucId = null;
            hr.NgayXacThuc = null;

            if (dto.XoaKhoiCongTy)
                hr.CongTyId = null; 

            await _context.SaveChangesAsync();
            await _thongBaoService.GuiThongBaoAsync(
                userId: hr.Id,
                tieuDe: "Tài khoản HR đã bị hủy xác thực",
                noiDung: "Doanh nghiệp đã hủy xác thực tài khoản HR của bạn. Bạn sẽ không thể đăng tin tuyển dụng.",
                url: "/ho-so-ca-nhan",
                loai: "XacThucHR"
            );
            return true;
        }

        public async Task<CongTyDto?> LayThongTinCongTyAsync(int congTyId)
        {
            return await _context.CongTys
                .Where(c => c.Id == congTyId)
                .Select(c => new CongTyDto
                {
                    Id = c.Id,
                    TenCongTy = c.TenCongTy,
                    LogoUrl = c.LogoUrl,
                    GioiThieu = c.GioiThieu,
                    DiaChiLamViec = c.DiaChiLamViec,

                    TinhThanhId = c.TinhThanhId,
                    TenTinhThanh = c.TinhThanh != null ? c.TinhThanh.TenTinh : null,

                    Website = c.Website,
                    EmailLienHe = c.EmailLienHe,
                    SoDienThoaiLienHe = c.SoDienThoaiLienHe,
                    NguoiLienHe = c.NguoiLienHe,
                    ChucVuNguoiLienHe = c.ChucVuNguoiLienHe
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<CongViecThuocCongTyDto>> LayJobTheoCongTyAsync(int congTyId)
        {
            return await _context.CongViecs
                .Where(j => j.CongTyId == congTyId && j.DaDuyet == true)
                .OrderByDescending(j => j.NgayDang)
                .Select(j => new CongViecThuocCongTyDto
                {
                    Id = j.Id,
                    TieuDe = j.TieuDe,
                    DiaDiem = j.CongTy!.DiaChiLamViec,
                    MucLuongTu = null,
                    MucLuongDen = null,
                    HanNopHoSo = j.HanNopHoSo ?? DateTime.MaxValue,

                    TenNhaTuyenDung = j.NguoiDung!.HoTen,
                    AvatarNhaTuyenDung = j.NguoiDung!.AvatarUrl
                })
                .ToListAsync();
        }

        public async Task<HoSoCongTyDto?> LayHoSoCongTyAsync(int congTyId)
        {
            var congTy = await LayThongTinCongTyAsync(congTyId);
            if (congTy == null) return null;

            var jobs = await LayJobTheoCongTyAsync(congTyId);

            return new HoSoCongTyDto
            {
                CongTy = congTy,
                DanhSachCongViec = jobs
            };
        }

        public async Task<bool> CongTyDuyetCongViecAsync(int adminCongTyId, CongTyDuyetCongViecDto dto)
        {
            var admin = await _context.NguoiDungs
                .Include(x => x.CongTy)
                .FirstOrDefaultAsync(x =>
                    x.Id == adminCongTyId &&
                    x.VaiTroCongTy == "CompanyAdmin");

            if (admin?.CongTy == null)
                throw new Exception("Bạn không phải quản trị công ty.");

            var job = await _context.CongViecs
                .Include(c => c.NguoiDung)
                .FirstOrDefaultAsync(c =>
                    c.Id == dto.CongViecId &&
                    c.CongTyId == admin.CongTy.Id);

            if (job == null)
                throw new Exception("Tin tuyển dụng không thuộc công ty của bạn.");

            if (dto.DongY)
            {
                job.DaDuyet = true;
                job.NgayDuyet = DateTime.UtcNow;
                job.NguoiDuyetId = adminCongTyId;
            }
            else
            {
                job.DaDuyet = false;
                job.NgayDuyet = null;
                job.NguoiDuyetId = null;
            }

            _context.CongViecs.Update(job);
            await _context.SaveChangesAsync();
            if (dto.DongY)
            {
                await _thongBaoService.GuiThongBaoAsync(
                    userId: job.NguoiDungId,
                    tieuDe: "Tin tuyển dụng đã được duyệt",
                    noiDung: $"Tin \"{job.TieuDe}\" của bạn đã được doanh nghiệp phê duyệt.",
                    url: $"/nha-tuyen-dung/cong-viec/{job.Id}",
                    loai: "DuyetTin"
                );
            }
            else
            {
                await _thongBaoService.GuiThongBaoAsync(
                    userId: job.NguoiDungId,
                    tieuDe: "Tin tuyển dụng bị từ chối",
                    noiDung: $"Tin \"{job.TieuDe}\" chưa được duyệt. Vui lòng chỉnh sửa và gửi lại.",
                    url: $"/nha-tuyen-dung/cong-viec/{job.Id}/chinh-sua",
                    loai: "TuChoiTin"
                );
            }
            return true;
        }

        public async Task<List<CongViecDto>> DanhSachCongViecDaDuyetAsync(int adminCongTyId)
        {
            var admin = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u =>
                    u.Id == adminCongTyId &&
                    u.VaiTroCongTy == "CompanyAdmin");

            if (admin?.CongTy == null)
                return new List<CongViecDto>();

            var jobIds = await _context.CongViecs
                .Where(c => c.CongTyId == admin.CongTy.Id && c.DaDuyet == true)
                .OrderByDescending(c => c.NgayDuyet)
                .Select(c => c.Id)
                .ToListAsync();

            var dtos = new List<CongViecDto>();

            foreach (var id in jobIds)
            {
                var dto = await _congViecService.BuildCongViecDto(id);
                if (dto != null)
                    dtos.Add(dto);
            }

            return dtos;
        }

        public async Task<List<CongViecDto>> DanhSachCongViecChoDuyetAsync(int adminCongTyId)
        {
            var admin = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u =>
                    u.Id == adminCongTyId &&
                    u.VaiTroCongTy == "CompanyAdmin");

            if (admin?.CongTy == null)
                return new List<CongViecDto>();

            var jobIds = await _context.CongViecs
                .Where(c => c.CongTyId == admin.CongTy.Id && c.DaDuyet == false)
                .OrderByDescending(c => c.NgayDang)
                .Select(c => c.Id)
                .ToListAsync();

            var dtos = new List<CongViecDto>();

            foreach (var id in jobIds)
            {
                var dto = await _congViecService.BuildCongViecDto(id);
                if (dto != null)
                    dtos.Add(dto);
            }

            return dtos;
        }

        public async Task<bool> TuChoiDuyetCongViecAsync(int adminCongTyId, TuChoiDuyetCongViecDto dto)
        {
            var admin = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u =>
                    u.Id == adminCongTyId && u.VaiTroCongTy == "CompanyAdmin");

            if (admin?.CongTy == null)
                throw new Exception("Bạn không phải quản trị công ty.");

            var job = await _context.CongViecs
                .Include(c => c.NguoiDung)
                .FirstOrDefaultAsync(c =>
                    c.Id == dto.CongViecId &&
                    c.CongTyId == admin.CongTy.Id);

            if (job == null)
                throw new Exception("Tin tuyển dụng không thuộc công ty của bạn.");

            job.DaDuyet = false;
            job.NgayDuyet = null;
            job.NguoiDuyetId = null;

            _context.CongViecs.Update(job);
            await _context.SaveChangesAsync();
            await _thongBaoService.GuiThongBaoAsync(
                userId: job.NguoiDungId,
                tieuDe: "Tin tuyển dụng bị từ chối",
                noiDung: "Tin tuyển dụng của bạn đã bị từ chối. Vui lòng chỉnh sửa và gửi lại.",
                url: $"/nha-tuyen-dung/cong-viec/{job.Id}/chinh-sua",
                loai: "TuChoiTin"
            );

            return true;
        }
    }
}
