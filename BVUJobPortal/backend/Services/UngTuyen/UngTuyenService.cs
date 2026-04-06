using AutoMapper;
using BVUJobPortal.Data;
using BVUJobPortal.DTOs.UngTuyen;
using BVUJobPortal.Models;
using BVUJobPortal.Services.SinhVien;
using BVUJobPortal.Services.ThongBao;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.UngTuyen
{
    public class UngTuyenService : IUngTuyenService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ISinhVienProfileService _profileService;
        private readonly IThongBaoService _thongBaoService;

        public UngTuyenService(ApplicationDbContext context, IMapper mapper, ISinhVienProfileService profileService, IThongBaoService thongBaoService)
        {
            _context = context;
            _mapper = mapper;
            _profileService = profileService;
            _thongBaoService = thongBaoService;
        }

        public async Task<(DonUngTuyenDto? Don, string? Error)> UngTuyenAsync(int userId, UngTuyenDto dto)
        {
            var job = await _context.CongViecs
                .Include(c => c.NguoiDung)
                .ThenInclude(nd => nd.CongTy)
                .FirstOrDefaultAsync(c => c.Id == dto.CongViecId);

            if (job == null)
                return (null, "JOB_NOT_FOUND");

            var daUngTuyen = await _context.DonUngTuyens
                .AnyAsync(x => x.NguoiDungId == userId && x.CongViecId == dto.CongViecId);

            if (daUngTuyen)
                return (null, "ALREADY_APPLIED");

            string? cvFileUrl = null;
            if (dto.CvFile != null && dto.CvFile.Length > 0)
            {
                var folder = Path.Combine("wwwroot", "uploads", "cv");
                Directory.CreateDirectory(folder);

                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.CvFile.FileName)}";
                var filePath = Path.Combine(folder, fileName);

                using var stream = new FileStream(filePath, FileMode.Create);
                await dto.CvFile.CopyToAsync(stream);

                cvFileUrl = $"/uploads/cv/{fileName}";
            }
            else
            {
                cvFileUrl = null;
            }

            var don = new DonUngTuyen
            {
                NguoiDungId = userId,
                CongViecId = dto.CongViecId,
                ThuGioiThieu = dto.ThuGioiThieu,
                TrangThai = "Đang chờ",
                NgayUngTuyen = DateTime.UtcNow,
                CvFileUrl = cvFileUrl
            };

            _context.DonUngTuyens.Add(don);
            await _context.SaveChangesAsync();

            await _thongBaoService.GuiThongBaoAsync(
                userId: job.NguoiDungId, 

                tieuDe: "Có ứng viên mới ứng tuyển",
                noiDung: $"Có một ứng viên vừa ứng tuyển vào vị trí \"{job.TieuDe}\".",
                url: $"/nha-tuyen-dung/ung-tuyen/{don.Id}",
                loai: "UngTuyen"
            );

            don = await _context.DonUngTuyens
                .Include(u => u.CongViec)
                .ThenInclude(c => c.NguoiDung)
                .ThenInclude(nd => nd.CongTy)
                .FirstAsync(u => u.Id == don.Id);

            var dtoDon = _mapper.Map<DonUngTuyenDto>(don);

            dtoDon.CvFileUrl = don.CvFileUrl;

            if (string.IsNullOrEmpty(don.CvFileUrl))
            {
                dtoDon.ProfileDetail = await _profileService.GetAsync(userId);
            }
            else
            {
                dtoDon.ProfileDetail = null;
            }

            return (dtoDon, null);

        }

        public async Task<List<DonUngTuyenDto>> DanhSachUngTuyenAsync(int userId)
        {
            var ds = await _context.DonUngTuyens
                .Include(u => u.CongViec)
                .ThenInclude(c => c.NguoiDung)
                .ThenInclude(nd => nd.CongTy)
                .Where(u => u.NguoiDungId == userId)
                .OrderByDescending(u => u.NgayUngTuyen)
                .ToListAsync();

            return _mapper.Map<List<DonUngTuyenDto>>(ds);
        }

        public async Task<List<DonUngTuyenDto>> LichSuUngTuyenAsync(int userId)
        {
            var ds = await _context.DonUngTuyens
                .Include(u => u.CongViec)
                .ThenInclude(c => c.NguoiDung)
                .ThenInclude(nd => nd.CongTy)
                .Where(u => u.NguoiDungId == userId)
                .OrderByDescending(u => u.NgayUngTuyen)
                .ToListAsync();

            return _mapper.Map<List<DonUngTuyenDto>>(ds);
        }

        public async Task<List<DonUngTuyenDto>> DanhSachDonChoNhaTuyenDungAsync(int nhaTuyenDungId)
        {
            var ds = await _context.DonUngTuyens
                .Include(u => u.NguoiDung)
                .Include(u => u.CongViec)
                .Where(u => u.CongViec.NguoiDungId == nhaTuyenDungId)
                .OrderByDescending(u => u.NgayUngTuyen)
                .ToListAsync();

            return _mapper.Map<List<DonUngTuyenDto>>(ds);
        }

        public async Task<DonUngTuyenDto?> ChiTietDonChoNhaTuyenDungAsync(
            int nhaTuyenDungId,
            int donId
        )
        {
            var don = await _context.DonUngTuyens
                .Include(u => u.NguoiDung)
                .Include(u => u.CongViec)
                .ThenInclude(c => c.NguoiDung)
                .ThenInclude(nd => nd.CongTy)
                .FirstOrDefaultAsync(u =>
                    u.Id == donId &&
                    u.CongViec.NguoiDungId == nhaTuyenDungId);

            if (don == null) return null;

            if (don.TrangThai == "Đang chờ")
            {
                don.TrangThai = "Đã xem";
                await _context.SaveChangesAsync();

                await _thongBaoService.GuiThongBaoAsync(
                    userId: don.NguoiDungId,
                    tieuDe: "Hồ sơ ứng tuyển đã được xem",
                    noiDung: $"Nhà tuyển dụng đã xem hồ sơ ứng tuyển của bạn cho vị trí \"{don.CongViec.TieuDe}\".",
                    url: "/lich-su-ung-tuyen",
                    loai: "UngTuyen"
                );
            }

            var dto = _mapper.Map<DonUngTuyenDto>(don);

            dto.CvFileUrl = don.CvFileUrl;

            if (string.IsNullOrEmpty(don.CvFileUrl))
            {
                dto.ProfileDetail = await _profileService.GetAsync(don.NguoiDungId);
            }
            else
            {
                dto.ProfileDetail = null;
            }

            return dto;

        }


        public async Task<(bool Success, string Message)> DuyetDonAsync(int nhaTuyenDungId, int donId)
        {
            var don = await _context.DonUngTuyens
                .Include(x => x.CongViec)
                .FirstOrDefaultAsync(x => x.Id == donId && x.CongViec.NguoiDungId == nhaTuyenDungId);

            if (don == null)
                return (false, "Không tìm thấy đơn ứng tuyển.");

            if (don.TrangThai == "Đã chấp nhận")
                return (false, "Đơn này đã được chấp nhận trước đó.");

            don.TrangThai = "Đã chấp nhận";
            await _context.SaveChangesAsync();
            await _thongBaoService.GuiThongBaoAsync(
                userId: don.NguoiDungId,
                tieuDe: "Đơn ứng tuyển được chấp nhận",
                noiDung: $"Đơn ứng tuyển cho vị trí \"{don.CongViec.TieuDe}\" đã được chấp nhận.",
                url: "/lich-su-ung-tuyen",
                loai: "UngTuyen"
            );


            return (true, "Đã chấp nhận đơn ứng tuyển.");
        }


        public async Task<(bool Success, string Message)> TuChoiDonAsync(int nhaTuyenDungId, int donId)
        {
            var don = await _context.DonUngTuyens
                .Include(x => x.CongViec)
                .FirstOrDefaultAsync(x => x.Id == donId && x.CongViec.NguoiDungId == nhaTuyenDungId);

            if (don == null)
                return (false, "Không tìm thấy đơn ứng tuyển.");

            if (don.TrangThai == "Từ chối")
                return (false, "Đơn này đã bị từ chối trước đó.");

            don.TrangThai = "Từ chối";
            await _context.SaveChangesAsync();
            await _thongBaoService.GuiThongBaoAsync(
                userId: don.NguoiDungId,
                tieuDe: "Đơn ứng tuyển bị từ chối",
                noiDung: $"Đơn ứng tuyển cho vị trí \"{don.CongViec.TieuDe}\" đã bị từ chối.",
                url: "/lich-su-ung-tuyen",
                loai: "UngTuyen"
            );


            return (true, "Đã từ chối đơn ứng tuyển.");
        }


        public async Task<(int? CvId, string? CvFileUrl, int UngVienId)?> GetCvInfoAsync(int nhaTuyenDungId, int donId)
        {
            var don = await _context.DonUngTuyens
                .Include(u => u.CongViec)
                .FirstOrDefaultAsync(u =>
                    u.Id == donId &&
                    u.CongViec.NguoiDungId == nhaTuyenDungId);

            if (don == null) return null;

            return (don.CvId, don.CvFileUrl, don.NguoiDungId);
        }


    }
}
