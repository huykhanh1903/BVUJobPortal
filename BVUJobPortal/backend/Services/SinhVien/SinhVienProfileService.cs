using BVUJobPortal.Data;
using BVUJobPortal.DTOs.SinhVien;
using BVUJobPortal.Models;
using BVUJobPortal.Models.SinhVien;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.SinhVien
{
    public class SinhVienProfileService : ISinhVienProfileService
    {
        private readonly ApplicationDbContext _context;

        public SinhVienProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SinhVienProfileDto?> GetAsync(int userId)
        {
            var user = await _context.NguoiDungs.FirstOrDefaultAsync(x => x.Id == userId);
            if (user == null) return null;

            var profile = await _context.SinhVienProfiles
                .Include(x => x.KinhNghiems)
                .Include(x => x.HocVans)
                .Include(x => x.ChungChis)
                .Include(x => x.NgoaiNgus)
                .Include(x => x.KyNangs)
                .Include(x => x.HoatDongs)
                .Include(x => x.NguoiThamChieus)
                .FirstOrDefaultAsync(x => x.NguoiDungId == userId);

            if (profile == null)
            {
                return new SinhVienProfileDto
                {
                    Id = 0,
                    HoTen = user.HoTen,
                    DienThoai = user.SDT,
                    EmailLienHe = user.Email,
                    AvatarUrl = user.AvatarUrl,
                    LopHoc = user.LopHoc,
                    KhoaHoc = user.KhoaHoc
                };
            }

            return new SinhVienProfileDto
            {
                Id = profile.Id,
                GioiTinh = profile.GioiTinh,
                NgaySinh = profile.NgaySinh,
                TinhThanhId = profile.TinhThanhId,
                DiaChi = profile.DiaChi,

                MucTieuNgheNghiep = profile.MucTieuNgheNghiep,
                CapBacMongMuon = profile.CapBacMongMuon,
                LuongThoaThuan = profile.LuongThoaThuan,
                MucLuongTu = profile.MucLuongTu,
                MucLuongDen = profile.MucLuongDen,
                DonViTienTe = profile.DonViTienTe,
                HinhThucLamViec = profile.HinhThucLamViec,
                NganhNgheMongMuon = profile.NganhNgheMongMuon,
                NoiLamViecMongMuon = profile.NoiLamViecMongMuon,

                PhucLoiMongMuon = profile.PhucLoiMongMuon,
                ThanhTichNoiBat = profile.ThanhTichNoiBat,

                HoTen = user.HoTen,
                DienThoai = user.SDT,
                EmailLienHe = user.Email,
                AvatarUrl = user.AvatarUrl,
                LopHoc = user.LopHoc,
                KhoaHoc = user.KhoaHoc,

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
                    MoTaChiTiet = x.MoTaChiTiet,//
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

                KyNangs = profile.KyNangs.Select(x => new KyNangSinhVienDto
                {
                    Id = x.Id,
                    TenKyNang = x.TenKyNang,
                    MoTaKyNang = x.MoTaKyNang,
                    MucDo = x.MucDo,
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
                }).ToList(),

                NguoiThamChieus = profile.NguoiThamChieus.Select(x => new NguoiThamChieuSinhVienDto
                {
                    Id = x.Id,
                    HoVaTen = x.HoVaTen,
                    ChucVu = x.ChucVu,
                    CongTy = x.CongTy,
                    DienThoai = x.DienThoai,
                    Email = x.Email,
                    ThuTu = x.ThuTu
                }).ToList()
            };
        }
        public async Task<SinhVienProfileDto> UpsertAsync(int userId, SinhVienProfileDto dto)
        {
            var profile = await _context.SinhVienProfiles
                .FirstOrDefaultAsync(x => x.NguoiDungId == userId);

            if (profile == null)
            {
                profile = new SinhVienProfile { NguoiDungId = userId };
                _context.SinhVienProfiles.Add(profile);
            }

            profile.GioiTinh = dto.GioiTinh;
            profile.NgaySinh = dto.NgaySinh;
            profile.TinhThanhId = dto.TinhThanhId;
            profile.DiaChi = dto.DiaChi;

            profile.MucTieuNgheNghiep = dto.MucTieuNgheNghiep;
            profile.CapBacMongMuon = dto.CapBacMongMuon;

            profile.LuongThoaThuan = dto.LuongThoaThuan;
            profile.MucLuongTu = dto.MucLuongTu;
            profile.MucLuongDen = dto.MucLuongDen;
            profile.DonViTienTe = dto.DonViTienTe;

            profile.HinhThucLamViec = dto.HinhThucLamViec;
            profile.NganhNgheMongMuon = dto.NganhNgheMongMuon;
            profile.NoiLamViecMongMuon = dto.NoiLamViecMongMuon;

            profile.PhucLoiMongMuon = dto.PhucLoiMongMuon ?? new List<string>();
            profile.ThanhTichNoiBat = dto.ThanhTichNoiBat;

            await _context.SaveChangesAsync();

            await Upsert_KinhNghiem(profile.Id, dto.KinhNghiems);
            await Upsert_HocVan(profile.Id, dto.HocVans);
            await Upsert_ChungChi(profile.Id, dto.ChungChis);
            await Upsert_NgoaiNgu(profile.Id, dto.NgoaiNgus);
            await Upsert_KyNang(profile.Id, dto.KyNangs);
            await Upsert_HoatDong(profile.Id, dto.HoatDongs);
            await Upsert_NguoiThamChieu(profile.Id, dto.NguoiThamChieus);

            await _context.SaveChangesAsync();

            return await GetAsync(userId);
        }

        private async Task Upsert_KinhNghiem(int profileId, List<KinhNghiemSinhVienDto> items)
        {
            var old = await _context.KinhNghiemSinhViens.Where(x => x.SinhVienProfileId == profileId).ToListAsync();

            foreach (var dto in items)
            {
                if (!dto.Id.HasValue || dto.Id == 0)
                {
                    _context.KinhNghiemSinhViens.Add(new KinhNghiemSinhVien
                    {
                        SinhVienProfileId = profileId,
                        ViTriChucDanh = dto.ViTriChucDanh,
                        TenCongTy = dto.TenCongTy,
                        PhuongThucCongViec = dto.PhuongThucCongViec,
                        NgayBatDau = dto.NgayBatDau,
                        NgayKetThuc = dto.NgayKetThuc,
                        DangLamHienTai = dto.DangLamHienTai,
                        MoTaCongViec = dto.MoTaCongViec,
                        ThuTu = dto.ThuTu
                    });
                }
                else
                {
                    var entity = old.FirstOrDefault(x => x.Id == dto.Id);
                    if (entity != null)
                    {
                        entity.ViTriChucDanh = dto.ViTriChucDanh;
                        entity.TenCongTy = dto.TenCongTy;
                        entity.PhuongThucCongViec = dto.PhuongThucCongViec;
                        entity.NgayBatDau = dto.NgayBatDau;
                        entity.NgayKetThuc = dto.NgayKetThuc;
                        entity.DangLamHienTai = dto.DangLamHienTai;
                        entity.MoTaCongViec = dto.MoTaCongViec;
                        entity.ThuTu = dto.ThuTu;
                    }
                }
            }

            var dtoIds = items.Select(x => x.Id).ToList();
            var remove = old.Where(x => !dtoIds.Contains(x.Id)).ToList();
            _context.KinhNghiemSinhViens.RemoveRange(remove);
        }


        private async Task Upsert_HocVan(int profileId, List<HocVanSinhVienDto> items)
        {
            var old = await _context.HocVanSinhViens.Where(x => x.SinhVienProfileId == profileId).ToListAsync();

            foreach (var dto in items)
            {
                if (dto.Id == 0)
                {
                    _context.HocVanSinhViens.Add(new HocVanSinhVien
                    {
                        SinhVienProfileId = profileId,
                        TruongHoacKhoaHoc = dto.TruongHoacKhoaHoc,
                        BangCap = dto.BangCap,
                        ThangNamTotNghiep = dto.ThangNamTotNghiep,
                        NgayTotNghiep = dto.NgayTotNghiep,
                        MoTaChiTiet = dto.MoTaChiTiet,
                        ThuTu = dto.ThuTu
                    });
                }
                else
                {
                    var entity = old.FirstOrDefault(x => x.Id == dto.Id);
                    if (entity != null)
                    {
                        entity.TruongHoacKhoaHoc = dto.TruongHoacKhoaHoc;
                        entity.BangCap = dto.BangCap;
                        entity.ThangNamTotNghiep = dto.ThangNamTotNghiep;
                        entity.NgayTotNghiep = dto.NgayTotNghiep;
                        entity.MoTaChiTiet = dto.MoTaChiTiet;
                        entity.ThuTu = dto.ThuTu;
                    }
                }
            }

            var dtoIds = items.Select(x => x.Id).ToList();
            var remove = old.Where(x => !dtoIds.Contains(x.Id)).ToList();
            _context.HocVanSinhViens.RemoveRange(remove);
        }


        private async Task Upsert_ChungChi(int profileId, List<ChungChiSinhVienDto> items)
        {
            var old = await _context.ChungChiSinhViens.Where(x => x.SinhVienProfileId == profileId).ToListAsync();

            foreach (var dto in items)
            {
                if (dto.Id == 0)
                {
                    _context.ChungChiSinhViens.Add(new ChungChiSinhVien
                    {
                        SinhVienProfileId = profileId,
                        TenChungChi = dto.TenChungChi,
                        CapBoi = dto.CapBoi,
                        NgayCap = dto.NgayCap,
                        NgayHetHan = dto.NgayHetHan,
                        KhongHetHan = dto.KhongHetHan,
                        ThuTu = dto.ThuTu
                    });
                }
                else
                {
                    var entity = old.FirstOrDefault(x => x.Id == dto.Id);
                    if (entity != null)
                    {
                        entity.TenChungChi = dto.TenChungChi;
                        entity.CapBoi = dto.CapBoi;
                        entity.NgayCap = dto.NgayCap;
                        entity.NgayHetHan = dto.NgayHetHan;
                        entity.KhongHetHan = dto.KhongHetHan;
                        entity.ThuTu = dto.ThuTu;
                    }
                }
            }

            var dtoIds = items.Select(x => x.Id).ToList();
            var remove = old.Where(x => !dtoIds.Contains(x.Id)).ToList();
            _context.ChungChiSinhViens.RemoveRange(remove);
        }


        private async Task Upsert_NgoaiNgu(int profileId, List<NgoaiNguSinhVienDto> items)
        {
            var old = await _context.NgoaiNguSinhViens.Where(x => x.SinhVienProfileId == profileId).ToListAsync();

            foreach (var dto in items)
            {
                if (dto.Id == 0)
                {
                    _context.NgoaiNguSinhViens.Add(new NgoaiNguSinhVien
                    {
                        SinhVienProfileId = profileId,
                        TenNgoaiNgu = dto.TenNgoaiNgu,
                        TrinhDo = dto.TrinhDo,
                        ChungChiNgoaiNgu = dto.ChungChiNgoaiNgu,
                        ThuTu = dto.ThuTu
                    });
                }
                else
                {
                    var entity = old.FirstOrDefault(x => x.Id == dto.Id);
                    if (entity != null)
                    {
                        entity.TenNgoaiNgu = dto.TenNgoaiNgu;
                        entity.TrinhDo = dto.TrinhDo;
                        entity.ChungChiNgoaiNgu = dto.ChungChiNgoaiNgu;
                        entity.ThuTu = dto.ThuTu;
                    }
                }
            }

            var dtoIds = items.Select(x => x.Id).ToList();
            var remove = old.Where(x => !dtoIds.Contains(x.Id)).ToList();
            _context.NgoaiNguSinhViens.RemoveRange(remove);
        }


        private async Task Upsert_KyNang(int profileId, List<KyNangSinhVienDto> items)
        {
            var old = await _context.KyNangChuyenMonSinhViens.Where(x => x.SinhVienProfileId == profileId).ToListAsync();

            foreach (var dto in items)
            {
                if (dto.Id == 0)
                {
                    _context.KyNangChuyenMonSinhViens.Add(new KyNangSinhVien
                    {
                        SinhVienProfileId = profileId,
                        TenKyNang = dto.TenKyNang,
                        MoTaKyNang = dto.MoTaKyNang,
                        MucDo = dto.MucDo,
                        ThuTu = dto.ThuTu
                    });
                }
                else
                {
                    var entity = old.FirstOrDefault(x => x.Id == dto.Id);
                    if (entity != null)
                    {
                        entity.TenKyNang = dto.TenKyNang;
                        entity.MoTaKyNang = dto.MoTaKyNang;
                        entity.MucDo = dto.MucDo;
                        entity.ThuTu = dto.ThuTu;
                    }
                }
            }

            var dtoIds = items.Select(x => x.Id).ToList();
            var remove = old.Where(x => !dtoIds.Contains(x.Id)).ToList();
            _context.KyNangChuyenMonSinhViens.RemoveRange(remove);
        }


        private async Task Upsert_HoatDong(int profileId, List<HoatDongSinhVienDto> items)
        {
            var old = await _context.HoatDongSinhViens.Where(x => x.SinhVienProfileId == profileId).ToListAsync();

            foreach (var dto in items)
            {
                if (dto.Id == 0)
                {
                    _context.HoatDongSinhViens.Add(new HoatDongSinhVien
                    {
                        SinhVienProfileId = profileId,
                        ToChuc = dto.ToChuc,
                        VaiTro = dto.VaiTro,
                        NgayBatDau = dto.NgayBatDau,
                        NgayKetThuc = dto.NgayKetThuc,
                        DangHoatDong = dto.DangHoatDong,
                        MoTaHoatDong = dto.MoTaHoatDong,
                        ThuTu = dto.ThuTu
                    });
                }
                else
                {
                    var entity = old.FirstOrDefault(x => x.Id == dto.Id);
                    if (entity != null)
                    {
                        entity.ToChuc = dto.ToChuc;
                        entity.VaiTro = dto.VaiTro;
                        entity.NgayBatDau = dto.NgayBatDau;
                        entity.NgayKetThuc = dto.NgayKetThuc;
                        entity.DangHoatDong = dto.DangHoatDong;
                        entity.MoTaHoatDong = dto.MoTaHoatDong;
                        entity.ThuTu = dto.ThuTu;
                    }
                }
            }

            var dtoIds = items.Select(x => x.Id).ToList();
            var remove = old.Where(x => !dtoIds.Contains(x.Id)).ToList();
            _context.HoatDongSinhViens.RemoveRange(remove);
        }


        private async Task Upsert_NguoiThamChieu(int profileId, List<NguoiThamChieuSinhVienDto> items)
        {
            var old = await _context.NguoiThamChieuSinhViens.Where(x => x.SinhVienProfileId == profileId).ToListAsync();

            foreach (var dto in items)
            {
                if (dto.Id == 0)
                {
                    _context.NguoiThamChieuSinhViens.Add(new NguoiThamChieuSinhVien
                    {
                        SinhVienProfileId = profileId,
                        HoVaTen = dto.HoVaTen,
                        ChucVu = dto.ChucVu,
                        CongTy = dto.CongTy,
                        DienThoai = dto.DienThoai,
                        Email = dto.Email,
                        ThuTu = dto.ThuTu
                    });
                }
                else
                {
                    var entity = old.FirstOrDefault(x => x.Id == dto.Id);
                    if (entity != null)
                    {
                        entity.HoVaTen = dto.HoVaTen;
                        entity.ChucVu = dto.ChucVu;
                        entity.CongTy = dto.CongTy;
                        entity.DienThoai = dto.DienThoai;
                        entity.Email = dto.Email;
                        entity.ThuTu = dto.ThuTu;
                    }
                }
            }

            var dtoIds = items.Select(x => x.Id).ToList();
            var remove = old.Where(x => !dtoIds.Contains(x.Id)).ToList();
            _context.NguoiThamChieuSinhViens.RemoveRange(remove);
        }

        public async Task CapNhatTrangThaiTimViecAsync(
       int nguoiDungId,
       CapNhatTrangThaiTimViecDto dto)
        {
            var profile = await _context.SinhVienProfiles
                .FirstOrDefaultAsync(x => x.NguoiDungId == nguoiDungId);

            if (profile == null)
                throw new Exception("Không tìm thấy hồ sơ sinh viên");

            profile.DangTimViec = dto.DangTimViec;
            profile.ChoPhepNhaTuyenDungTim = dto.ChoPhepNhaTuyenDungTim;

            await _context.SaveChangesAsync();
        }
    }
}
