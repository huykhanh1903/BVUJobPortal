using BVUJobPortal.Data;
using BVUJobPortal.DTOs.SinhVien;
using BVUJobPortal.DTOs.UngVien;
using BVUJobPortal.Services.ThongBao;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.UngVien
{
    public class UngVienService : IUngVienService
    {
        private readonly ApplicationDbContext _context;
        private readonly IThongBaoService _thongBaoService;

        public UngVienService(ApplicationDbContext context, IThongBaoService thongBaoService)
        {
            _context = context;
            _thongBaoService = thongBaoService;
        }

        public async Task<List<UngVienDto>> TimUngVienAsync(TimUngVienDto dto)
        {
            var query = _context.SinhVienProfiles
                .Include(x => x.NguoiDung)
                .Include(x => x.KyNangs)
                .Where(x =>
                    x.DangTimViec &&
                    x.ChoPhepNhaTuyenDungTim
                );

            if (!string.IsNullOrWhiteSpace(dto.Keyword))
            {
                query = query.Where(x =>
                    x.NguoiDung!.HoTen.Contains(dto.Keyword) ||
                    x.KyNangs!.Any(k => k.TenKyNang.Contains(dto.Keyword))
                );
            }

            if (dto.TinhThanhId.HasValue)
                query = query.Where(x => x.TinhThanhId == dto.TinhThanhId);

            if (!string.IsNullOrEmpty(dto.CapBac))
                query = query.Where(x => x.CapBacMongMuon == dto.CapBac);

            if (dto.LuongToiDa.HasValue)
            {
                query = query.Where(x =>
                    x.LuongThoaThuan ||
                    x.MucLuongTu <= dto.LuongToiDa
                );
            }

            return await query.Select(x => new UngVienDto
            {
                SinhVienId = x.Id,
                HoTen = x.NguoiDung!.HoTen,
                AvatarUrl = x.NguoiDung.AvatarUrl,
                CapBac = x.CapBacMongMuon,
                NganhNghe = x.NganhNgheMongMuon,
                MucLuongTu = x.MucLuongTu,
                MucLuongDen = x.MucLuongDen,
                KyNangs = x.KyNangs!
                    .Select(k => k.TenKyNang)
                    .ToList()
            }).ToListAsync();
        }
        public async Task<List<UngVienDangTimViecDto>> LayDanhSachDangTimViecAsync()
        {
            return await _context.SinhVienProfiles
                .Include(x => x.NguoiDung)
                .Include(x => x.KyNangs)
                .Where(x => x.DangTimViec && x.ChoPhepNhaTuyenDungTim)
                .Select(x => new UngVienDangTimViecDto
                {
                    SinhVienId = x.Id,
                    HoTen = x.NguoiDung!.HoTen,
                    AvatarUrl = x.NguoiDung.AvatarUrl,
                    CapBacMongMuon = x.CapBacMongMuon,
                    NganhNgheMongMuon = x.NganhNgheMongMuon,
                    NoiLamViecMongMuon = x.NoiLamViecMongMuon,
                    KyNangs = x.KyNangs
                        .OrderBy(k => k.ThuTu)
                        .Select(k => k.TenKyNang)
                        .ToList()
                })
                .ToListAsync();
        }

        public async Task<UngVienChiTietDto?> LayChiTietUngVienAsync(int sinhVienId, int nhaTuyenDungId)
        {
            var profile = await _context.SinhVienProfiles
                .Include(x => x.NguoiDung)
                .Include(x => x.KinhNghiems)
                .Include(x => x.HocVans)
                .Include(x => x.KyNangs)
                .Include(x => x.ChungChis)
                .Include(x => x.NgoaiNgus)
                .Include(x => x.HoatDongs)
                .FirstOrDefaultAsync(x =>
                    x.Id == sinhVienId &&
                    x.DangTimViec &&
                    x.ChoPhepNhaTuyenDungTim
                );

            if (profile == null) return null;

            var nhaTuyenDung = await _context.NguoiDungs
                .FirstOrDefaultAsync(u => u.Id == nhaTuyenDungId);

            if (nhaTuyenDung != null)
            {
                await _thongBaoService.GuiThongBaoAsync(
                    userId: profile.NguoiDungId,
                    tieuDe: "Hồ sơ của bạn vừa được xem",
                    noiDung: $"Nhà tuyển dụng \"{nhaTuyenDung.HoTen}\" vừa xem hồ sơ của bạn.",
                    url: "/ho-so-ca-nhan",
                    loai: "XemHoSo"
                );
            }

            return new UngVienChiTietDto
            {
                HoTen = profile.NguoiDung!.HoTen,
                AvatarUrl = profile.NguoiDung.AvatarUrl,
                Email = profile.NguoiDung.Email,
                DienThoai = profile.NguoiDung.SDT,

                GioiTinh = profile.GioiTinh,
                NgaySinh = profile.NgaySinh,
                DiaChi = profile.DiaChi,

                MucTieuNgheNghiep = profile.MucTieuNgheNghiep,
                CapBacMongMuon = profile.CapBacMongMuon,
                NganhNgheMongMuon = profile.NganhNgheMongMuon,
                HinhThucLamViec = profile.HinhThucLamViec,

                LuongThoaThuan = profile.LuongThoaThuan,
                MucLuongTu = profile.MucLuongTu,
                MucLuongDen = profile.MucLuongDen,

                KinhNghiems = profile.KinhNghiems.Select(x => new KinhNghiemSinhVienDto
                {
                    Id = x.Id,
                    ViTriChucDanh = x.ViTriChucDanh,
                    TenCongTy = x.TenCongTy,
                    PhuongThucCongViec = x.PhuongThucCongViec,
                    NgayBatDau = x.NgayBatDau,
                    NgayKetThuc = x.NgayKetThuc,
                    DangLamHienTai = x.DangLamHienTai,
                    MoTaCongViec = x.MoTaCongViec,
                    ThuTu = x.ThuTu
                }).ToList(),

                HocVans = profile.HocVans.Select(x => new HocVanSinhVienDto
                {
                    Id = x.Id,
                    TruongHoacKhoaHoc = x.TruongHoacKhoaHoc,
                    BangCap = x.BangCap,
                    ThangNamTotNghiep = x.ThangNamTotNghiep,
                    NgayTotNghiep = x.NgayTotNghiep,
                    MoTaChiTiet = x.MoTaChiTiet,
                    ThuTu = x.ThuTu
                }).ToList(),

                KyNangs = profile.KyNangs.Select(x => new KyNangSinhVienDto
                {
                    Id = x.Id,
                    TenKyNang = x.TenKyNang,
                    MoTaKyNang = x.MoTaKyNang,
                    MucDo = x.MucDo,
                    ThuTu = x.ThuTu
                }).ToList(),

                ChungChis = profile.ChungChis.Select(x => new ChungChiSinhVienDto
                {
                    Id = x.Id,
                    TenChungChi = x.TenChungChi,
                    CapBoi = x.CapBoi,
                    NgayCap = x.NgayCap,
                    NgayHetHan = x.NgayHetHan,
                    KhongHetHan = x.KhongHetHan,
                    ThuTu = x.ThuTu
                }).ToList(),

                NgoaiNgus = profile.NgoaiNgus.Select(x => new NgoaiNguSinhVienDto
                {
                    Id = x.Id,
                    TenNgoaiNgu = x.TenNgoaiNgu,
                    TrinhDo = x.TrinhDo,
                    ChungChiNgoaiNgu = x.ChungChiNgoaiNgu,
                    ThuTu = x.ThuTu
                }).ToList(),

                HoatDongs = profile.HoatDongs.Select(x => new HoatDongSinhVienDto
                {
                    Id = x.Id,
                    ToChuc = x.ToChuc,
                    VaiTro = x.VaiTro,
                    NgayBatDau = x.NgayBatDau,
                    NgayKetThuc = x.NgayKetThuc,
                    DangHoatDong = x.DangHoatDong,
                    MoTaHoatDong = x.MoTaHoatDong,
                    ThuTu = x.ThuTu
                }).ToList()
            };
        }



    }

}
