using AutoMapper;
using BVUJobPortal.Data;
using BVUJobPortal.DTOs;
using BVUJobPortal.DTOs.Admin;
using BVUJobPortal.DTOs.Chung;
using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.DTOs.TaiKhoan;
using BVUJobPortal.Models;
using BVUJobPortal.Services.ThongBao;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BVUJobPortal.Services.Admin
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AdminService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TaiKhoanDto?> TaoNguoiDungTheoVaiTroAsync(AdminCapNhatNguoiDungDto dto, string vaiTro)
        {
            var exist = await _context.NguoiDungs.AnyAsync(u => u.Email == dto.Email);
            if (exist) return null;

            var user = _mapper.Map<NguoiDung>(dto);
            user.VaiTro = vaiTro;
            user.MatKhauHash = BCrypt.Net.BCrypt.HashPassword(dto.SDT ?? "123456"); 
            user.NgayTao = DateTime.UtcNow;
            user.Ma = await TaoMaNguoiDungAsync(vaiTro);

            _context.NguoiDungs.Add(user);
            await _context.SaveChangesAsync();

            return _mapper.Map<TaiKhoanDto>(user);
        }

        public async Task<AdminNhaTuyenDungDto?> TaoNhaTuyenDungAsync(AdminNhaTuyenDungDto dto)
        {
            var exist = await _context.NguoiDungs.AnyAsync(u => u.Email == dto.Email);
            if (exist) return null;

            var congTy = await _context.CongTys.FirstOrDefaultAsync(c => c.TenCongTy == dto.TenCongTy);
            if (congTy == null)
            {
                congTy = _mapper.Map<CongTy>(dto);
                congTy.NgayTao = DateTime.UtcNow;
                _context.CongTys.Add(congTy);
                await _context.SaveChangesAsync();
            }

            var user = _mapper.Map<NguoiDung>(dto);
            user.VaiTro = "NhaTuyenDung";
            user.CongTyId = congTy.Id;
            user.Ma = await TaoMaNguoiDungAsync("NhaTuyenDung");
            user.MatKhauHash = BCrypt.Net.BCrypt.HashPassword(dto.MatKhau ?? "123456");
            user.NgayTao = DateTime.UtcNow;

            _context.NguoiDungs.Add(user);
            await _context.SaveChangesAsync();

            return _mapper.Map<AdminNhaTuyenDungDto>(user);
        }

        public async Task<object> TaoTaiKhoanCongTyAsync(AdminTaoTaiKhoanCongTyDto dto)
        {
            if (await _context.NguoiDungs.AnyAsync(x => x.Email == dto.EmailNguoiDaiDien))
                throw new Exception("Email người đại diện đã tồn tại trong hệ thống.");

            if (await _context.CongTys.AnyAsync(c => c.TenCongTy == dto.TenCongTy))
                throw new Exception($"Tên công ty \"{dto.TenCongTy}\" đã tồn tại trong hệ thống.");

            var maCongTy = await TaoMaNguoiDungAsync("CongTy");

            var congTy = new CongTy
            {
                Ma = maCongTy,
                TenCongTy = dto.TenCongTy,
                GioiThieu = dto.GioiThieu,
                DiaChiLamViec = dto.DiaChiLamViec,
                //TinhThanhPho = dto.TinhThanhPho,
                Website = dto.Website,
                EmailLienHe = dto.EmailLienHe,
                SoDienThoaiLienHe = dto.SoDienThoaiLienHe,
                DaDuocAdminXacMinh = true,
                NgayXacMinh = DateTime.UtcNow,
                NgayTao = DateTime.UtcNow
            };

            _context.CongTys.Add(congTy);
            await _context.SaveChangesAsync();

            var maDoanhNghiep = await TaoMaNguoiDungAsync("DoanhNghiep");

            var adminCongTy = new NguoiDung
            {
                Ma = maDoanhNghiep,
                HoTen = dto.HoTenNguoiDaiDien,
                Email = dto.EmailNguoiDaiDien,
                SDT = dto.SDTNguoiDaiDien,
                MatKhauHash = BCrypt.Net.BCrypt.HashPassword("admincongty@123"),
                VaiTro = "DoanhNghiep",
                VaiTroCongTy = "CompanyAdmin",
                CongTyId = congTy.Id,
                DaDuocCongTyXacThuc = true,
                NgayXacThuc = DateTime.UtcNow,
                NgayTao = DateTime.UtcNow
            };

            _context.NguoiDungs.Add(adminCongTy);
            await _context.SaveChangesAsync();

            return new
            {
                ThanhCong = true,
                ThongBao = "✅ Đã tạo tài khoản công ty thành công.",
                MaCongTy = congTy.Ma,
                MaNguoiDung = adminCongTy.Ma,
                TenCongTy = congTy.TenCongTy,
                EmailDangNhap = adminCongTy.Email,
                MatKhauMacDinh = "admincongty@123"
            };
        }

        private async Task<string> TaoMaNguoiDungAsync(string vaiTro)
        {
            string prefix = vaiTro switch
            {
                "SuperAdmin" => "SA",
                "Admin" => "AD",
                "NhaTuyenDung" => "NTD",
                "SinhVien" => "SV",
                "DoanhNghiep" => "DN",
                "CongTy" => "CT",
                _ => "USR"
            };

            int count = vaiTro switch
            {
                "CongTy" => await _context.CongTys.CountAsync(),
                _ => await _context.NguoiDungs.CountAsync(u => u.VaiTro == vaiTro)
            };
            return $"{prefix}-{count + 1}";
        }

        public async Task<TaiKhoanDto?> CapNhatNguoiDungAsync(int id, AdminCapNhatNguoiDungDto dto)
        {
            var user = await _context.NguoiDungs.FindAsync(id);
            if (user == null) return null;

            _mapper.Map(dto, user);
            _context.NguoiDungs.Update(user);
            await _context.SaveChangesAsync();

            return _mapper.Map<TaiKhoanDto>(user);
        }

        public async Task<KetQuaPhanTrang<TaiKhoanDto>> DanhSachNguoiDungAsync(
            int trang = 1,
            int soLuongMoiTrang = 10,
            string sapXepTheo = "NgayTao",
            string thuTu = "desc",
            string? vaiTro = null,
            DateTime? tuNgay = null,
            DateTime? denNgay = null,
            bool? biKhoa = null)
        {
            var query = _context.NguoiDungs
                .Include(u => u.CongTy)
                .AsQueryable();

            if (!string.IsNullOrEmpty(vaiTro))
                query = query.Where(u => u.VaiTro == vaiTro);

            if (tuNgay.HasValue)
                query = query.Where(u => u.NgayTao >= tuNgay.Value);

            if (denNgay.HasValue)
                query = query.Where(u => u.NgayTao <= denNgay.Value);

            if (biKhoa.HasValue)
                query = query.Where(u => u.BiKhoa == biKhoa.Value);

            query = (sapXepTheo, thuTu.ToLower()) switch
            {
                ("HoTen", "asc") => query.OrderBy(u => u.HoTen),
                ("HoTen", "desc") => query.OrderByDescending(u => u.HoTen),
                ("Email", "asc") => query.OrderBy(u => u.Email),
                ("Email", "desc") => query.OrderByDescending(u => u.Email),
                ("VaiTro", "asc") => query.OrderBy(u => u.VaiTro),
                ("VaiTro", "desc") => query.OrderByDescending(u => u.VaiTro),
                ("NgayTao", "asc") => query.OrderBy(u => u.NgayTao),
                _ => query.OrderByDescending(u => u.NgayTao)
            };

            var tongSo = await query.CountAsync();
            var users = await query
                .Skip((trang - 1) * soLuongMoiTrang)
                .Take(soLuongMoiTrang)
                .ToListAsync();

            return new KetQuaPhanTrang<TaiKhoanDto>
            {
                TongSo = tongSo,
                Trang = trang,
                SoLuongMoiTrang = soLuongMoiTrang,
                DuLieu = users.Select(u => new TaiKhoanDto
                {
                    Id = u.Id,
                    Ma = u.Ma,
                    HoTen = u.HoTen,
                    Email = u.Email,
                    VaiTro = u.VaiTro,
                    SDT = u.SDT,
                    BiKhoa = u.BiKhoa,
                    NgayTao = u.NgayTao,
                    AvatarUrl = u.AvatarUrl,
                    SoDienThoaiLienHe = u.CongTy != null
                        ? u.CongTy.SoDienThoaiLienHe
                        : u.SDT
                }).ToList()
            };

        }

        public async Task<KetQuaPhanTrang<AdminCapNhatNguoiDungDto>> TimKiemNguoiDungAsync(
            string tuKhoa,
            int trang = 1,
            int soLuongMoiTrang = 10)
        {
            var query = _context.NguoiDungs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                tuKhoa = tuKhoa.ToLower().Trim();
                query = query.Where(u =>
                    u.HoTen.ToLower().Contains(tuKhoa) ||
                    u.Email.ToLower().Contains(tuKhoa) ||
                    u.Ma.ToLower().Contains(tuKhoa));
            }

            var tongSo = await query.CountAsync();
            var users = await query
                .OrderByDescending(u => u.NgayTao)
                .Skip((trang - 1) * soLuongMoiTrang)
                .Take(soLuongMoiTrang)
                .ToListAsync();

            return new KetQuaPhanTrang<AdminCapNhatNguoiDungDto>
            {
                TongSo = tongSo,
                Trang = trang,
                SoLuongMoiTrang = soLuongMoiTrang,
                DuLieu = _mapper.Map<List<AdminCapNhatNguoiDungDto>>(users)
            };
        }

        public async Task<object?> LayThongTinNguoiDungTheoIdAsync(int id)
        {
            var user = await _context.NguoiDungs
                .Include(u => u.CongTy)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null) return null;

            string? avatarFullUrl = null;
            if (!string.IsNullOrEmpty(user.AvatarUrl))
            {
                avatarFullUrl = user.AvatarUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase)
                    ? user.AvatarUrl
                    : $"{Environment.GetEnvironmentVariable("ASPNETCORE_URLS")?.Split(';').FirstOrDefault() ?? "https://localhost:7248"}/uploads/avatars/{user.AvatarUrl}";
            }

            var result = new
            {
                user.Id,
                user.Ma,
                user.HoTen,
                user.Email,
                user.SDT,
                user.VaiTro,
                user.LopHoc,
                user.KhoaHoc,
                user.NgayTao,
                user.BiKhoa,
                user.LyDoKhoa,
                AvatarUrl = avatarFullUrl,
                ChiTietSinhVien = user.VaiTro == "SinhVien"
                    ? new
                    {

                        SoLuongCV = _context.CVs.Count(x => x.NguoiDungId == user.Id),
                        SoLuongDonUngTuyen = _context.DonUngTuyens.Count(x => x.NguoiDungId == user.Id)
                    }
                    : null,
                CongTy = user.CongTy == null ? null : new
                {
                    user.CongTy.Id,
                    user.CongTy.TenCongTy,
                    user.CongTy.DiaChiLamViec,
                    //user.CongTy.TinhThanhPho,
                    user.CongTy.EmailLienHe,
                    user.CongTy.SoDienThoaiLienHe,
                    user.CongTy.Website
                }
            };

            return result;
        }


        public async Task<bool> KhoaNguoiDungAsync(int id, string lyDo)
        {
            var user = await _context.NguoiDungs.FindAsync(id);
            if (user == null) return false;

            user.BiKhoa = true;
            user.LyDoKhoa = lyDo;

            _context.NguoiDungs.Update(user);

            //_context.ThongBaos.Add(new BVUJobPortal.Models.ThongBao
            //{
            //    TieuDe = "Tài khoản bị khóa",
            //    NoiDung = $"Tài khoản của bạn đã bị khóa. Lý do: {lyDo}",
            //    NguoiDungId = user.Id,
            //    NgayTao = DateTime.UtcNow
            //});

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> MoKhoaNguoiDungAsync(int id)
        {
            var user = await _context.NguoiDungs.FindAsync(id);
            if (user == null) return false;

            user.BiKhoa = false;
            user.LyDoKhoa = null;
            _context.NguoiDungs.Update(user);

            var tb = new BVUJobPortal.Models.ThongBao
            {
                TieuDe = "Mở khóa tài khoản",
                NoiDung = "Tài khoản của bạn đã được mở khóa. Bạn có thể đăng nhập lại.",
                NguoiDungId = user.Id,
                NgayTao = DateTime.UtcNow
            };
            _context.ThongBaos.Add(tb);

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> XoaNguoiDungAsync(int id)
        {
            var user = await _context.NguoiDungs.FindAsync(id);
            if (user == null) return false;

            _context.NguoiDungs.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<AdminCongTyDto>> DanhSachCongTyAsync()
        {
            return await _context.CongTys
                .Include(c => c.TinhThanh)
                .Include(c => c.NhaTuyenDungs)
                .Include(c => c.CongViecs)
                .Include(c => c.DaXacMinhBoiAdmin)
                .Select(c => new AdminCongTyDto
                {
                    Id = c.Id,
                    Ma = c.Ma,
                    TenCongTy = c.TenCongTy,
                    GioiThieu = c.GioiThieu,
                    LogoUrl = c.LogoUrl,
                    DiaChiLamViec = c.DiaChiLamViec,

                    TinhThanhId = c.TinhThanhId,
                    TenTinhThanh = c.TinhThanh != null
                        ? c.TinhThanh.TenTinh
                        : "",

                    Website = c.Website,
                    EmailLienHe = c.EmailLienHe,
                    SoDienThoaiLienHe = c.SoDienThoaiLienHe,
                    NguoiLienHe = c.NguoiLienHe,
                    ChucVuNguoiLienHe = c.ChucVuNguoiLienHe,

                    NamThanhLap = c.NamThanhLap,
                    QuyMoNhanSu = c.QuyMoNhanSu,

                    NgayTao = c.NgayTao,
                    DaDuocAdminXacMinh = c.DaDuocAdminXacMinh,
                    NgayXacMinh = c.NgayXacMinh,

                    TenAdminXacMinh = c.DaXacMinhBoiAdmin != null
                        ? c.DaXacMinhBoiAdmin.HoTen
                        : "",

                    SoLuongHR = c.NhaTuyenDungs.Count(x => x.VaiTroCongTy == "HR"),
                    SoLuongCongViec = c.CongViecs.Count(),

                    SoLuongLinhVuc = _context.CongViecs
                    .Where(cv => cv.CongTyId == c.Id)
                    .Where(cv => cv.CongTyId == c.Id && cv.DaDuyet)
                    .SelectMany(cv => cv.CongViecChuyenNganhs)
                    .Select(cvcn => cvcn.ChuyenNganh.NgheNghiep.LinhVucId)
                    .Distinct()
                    .Count(),
                })
                .ToListAsync();
        }
        public async Task<AdminCongTyDto?> LayChiTietCongTyAsync(int id)
        {
            var c = await _context.CongTys
                .Include(x => x.TinhThanh)
                .Include(x => x.NhaTuyenDungs)
                .Include(x => x.CongViecs)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (c == null) return null;

            return new AdminCongTyDto
            {
                Id = c.Id,
                Ma = c.Ma,
                TenCongTy = c.TenCongTy,
                GioiThieu = c.GioiThieu,
                LogoUrl = c.LogoUrl,
                DiaChiLamViec = c.DiaChiLamViec,

                TinhThanhId = c.TinhThanhId,
                TenTinhThanh = c.TinhThanh?.TenTinh ?? "",

                Website = c.Website,
                EmailLienHe = c.EmailLienHe,
                SoDienThoaiLienHe = c.SoDienThoaiLienHe,
                NguoiLienHe = c.NguoiLienHe,
                ChucVuNguoiLienHe = c.ChucVuNguoiLienHe,

                NamThanhLap = c.NamThanhLap,
                QuyMoNhanSu = c.QuyMoNhanSu,

                NgayTao = c.NgayTao,
                DaDuocAdminXacMinh = c.DaDuocAdminXacMinh,
                NgayXacMinh = c.NgayXacMinh,

                SoLuongHR = c.NhaTuyenDungs.Count(x => x.VaiTroCongTy == "HR"),
                SoLuongCongViec = c.CongViecs.Count(),
                SoLuongLinhVuc = _context.CongViecs
                    .Where(cv => cv.CongTyId == c.Id)
                    .Where(cv => cv.CongTyId == c.Id && cv.DaDuyet)
                    .SelectMany(cv => cv.CongViecChuyenNganhs)
                    .Select(cvcn => cvcn.ChuyenNganh.NgheNghiep.LinhVucId)
                    .Distinct()
                    .Count(),
            };
        }


        public async Task<AdminCongTyDto?> TaoCongTyAsync(AdminCongTyDto dto)
        {
            var congTy = new CongTy
            {
                Ma = await TaoMaNguoiDungAsync("CongTy"),
                TenCongTy = dto.TenCongTy,
                GioiThieu = dto.GioiThieu,
                LogoUrl = dto.LogoUrl,
                DiaChiLamViec = dto.DiaChiLamViec,
                TinhThanhId = dto.TinhThanhId,
                Website = dto.Website,
                EmailLienHe = dto.EmailLienHe,
                SoDienThoaiLienHe = dto.SoDienThoaiLienHe,
                NguoiLienHe = dto.NguoiLienHe,
                ChucVuNguoiLienHe = dto.ChucVuNguoiLienHe,
                NamThanhLap = dto.NamThanhLap,
                QuyMoNhanSu = dto.QuyMoNhanSu,
                NgayTao = DateTime.UtcNow,
                DaDuocAdminXacMinh = false
            };

            _context.CongTys.Add(congTy);
            await _context.SaveChangesAsync();

            var congTyDaLoad = await _context.CongTys
                .Include(x => x.TinhThanh)
                .FirstAsync(x => x.Id == congTy.Id);

            return new AdminCongTyDto
            {
                Id = congTyDaLoad.Id,
                Ma = congTyDaLoad.Ma,
                TenCongTy = congTyDaLoad.TenCongTy,
                GioiThieu = congTyDaLoad.GioiThieu,
                LogoUrl = congTyDaLoad.LogoUrl,
                DiaChiLamViec = congTyDaLoad.DiaChiLamViec,

                TinhThanhId = congTyDaLoad.TinhThanhId,
                TenTinhThanh = congTyDaLoad.TinhThanh != null
                    ? congTyDaLoad.TinhThanh.TenTinh
                    : "",

                Website = congTyDaLoad.Website,
                EmailLienHe = congTyDaLoad.EmailLienHe,
                SoDienThoaiLienHe = congTyDaLoad.SoDienThoaiLienHe,
                NguoiLienHe = congTyDaLoad.NguoiLienHe,
                ChucVuNguoiLienHe = congTyDaLoad.ChucVuNguoiLienHe,
                NamThanhLap = congTyDaLoad.NamThanhLap,
                QuyMoNhanSu = congTyDaLoad.QuyMoNhanSu,


                NgayTao = congTyDaLoad.NgayTao,
                DaDuocAdminXacMinh = congTyDaLoad.DaDuocAdminXacMinh,

                NgayXacMinh = null,
                TenAdminXacMinh = "",

                HoTenNguoiDaiDien = "",
                EmailNguoiDaiDien = "",
                SDTNguoiDaiDien = "",

                SoLuongHR = 0,
                SoLuongCongViec = 0
            };
        }


        public async Task<AdminCongTyDto?> CapNhatCongTyAsync(int id, AdminCongTyDto dto)
        {
            var congTy = await _context.CongTys
                .Include(x => x.TinhThanh)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (congTy == null)
                return null;

            congTy.TenCongTy = dto.TenCongTy;
            congTy.GioiThieu = dto.GioiThieu;
            congTy.LogoUrl = dto.LogoUrl;
            congTy.DiaChiLamViec = dto.DiaChiLamViec;
            congTy.TinhThanhId = dto.TinhThanhId;
            congTy.Website = dto.Website;
            congTy.EmailLienHe = dto.EmailLienHe;
            congTy.SoDienThoaiLienHe = dto.SoDienThoaiLienHe;
            congTy.NguoiLienHe = dto.NguoiLienHe;
            congTy.ChucVuNguoiLienHe = dto.ChucVuNguoiLienHe;
            congTy.NamThanhLap = dto.NamThanhLap;
            congTy.QuyMoNhanSu = dto.QuyMoNhanSu;

            await _context.SaveChangesAsync();

            return new AdminCongTyDto
            {
                Id = congTy.Id,
                Ma = congTy.Ma,
                TenCongTy = congTy.TenCongTy,
                GioiThieu = congTy.GioiThieu,
                LogoUrl = congTy.LogoUrl,
                DiaChiLamViec = congTy.DiaChiLamViec,

                TinhThanhId = congTy.TinhThanhId,
                TenTinhThanh = congTy.TinhThanh != null
                    ? congTy.TinhThanh.TenTinh
                    : "",

                Website = congTy.Website,
                EmailLienHe = congTy.EmailLienHe,
                SoDienThoaiLienHe = congTy.SoDienThoaiLienHe,
                NguoiLienHe = congTy.NguoiLienHe,
                ChucVuNguoiLienHe = congTy.ChucVuNguoiLienHe,

                NamThanhLap = congTy.NamThanhLap,
                QuyMoNhanSu = congTy.QuyMoNhanSu,

                NgayTao = congTy.NgayTao,
                DaDuocAdminXacMinh = congTy.DaDuocAdminXacMinh,
                NgayXacMinh = congTy.NgayXacMinh,

                TenAdminXacMinh = "",

                HoTenNguoiDaiDien = "",
                EmailNguoiDaiDien = "",
                SDTNguoiDaiDien = "",

                SoLuongHR = 0,
                SoLuongCongViec = 0,
                SoLuongLinhVuc = 0
            };
        }


        public async Task<bool> XoaCongTyAsync(int id)
        {
            var congTy = await _context.CongTys
                .Include(c => c.NhaTuyenDungs)
                .Include(c => c.CongViecs)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (congTy == null)
                return false;

            if (congTy.CongViecs != null && congTy.CongViecs.Any())
                _context.CongViecs.RemoveRange(congTy.CongViecs);

            if (congTy.NhaTuyenDungs != null && congTy.NhaTuyenDungs.Any())
                _context.NguoiDungs.RemoveRange(congTy.NhaTuyenDungs);

            _context.CongTys.Remove(congTy);

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<List<CongViecDto>> DanhSachCongViecAsync()
        {
            var jobs = await _context.CongViecs
                .Include(c => c.NguoiDung)
                .ThenInclude(u => u.CongTy)
                .ToListAsync();

            return _mapper.Map<List<CongViecDto>>(jobs);
        }

        public async Task<List<CongViecDto>> LayCongViecTheoCongTyAsync(int congTyId)
        {
            var jobs = await _context.CongViecs
                .Where(cv => cv.CongTyId == congTyId)
                .Include(cv => cv.CongTy)
                .Include(cv => cv.CongViecChuyenNganhs)
                    .ThenInclude(x => x.ChuyenNganh)
                .OrderByDescending(cv => cv.NgayDang)
                .ToListAsync();

            return jobs.Select(cv => new CongViecDto
            {
                Id = cv.Id,
                TieuDe = cv.TieuDe,
                SoLuongTuyen = cv.SoLuongTuyen,
                LuongTu = cv.LuongTu,
                LuongDen = cv.LuongDen,
                NgayDang = cv.NgayDang,
                DaDuyet = cv.DaDuyet,

                TenCongTy = cv.CongTy!.TenCongTy,
                LogoUrl = cv.CongTy.LogoUrl,

                ChuyenNganhs = cv.CongViecChuyenNganhs
                    .Select(x => x.ChuyenNganh.TenChuyenNganh)
                    .Cast<object>()
                    .ToList()
            }).ToList();
        }


        public async Task<bool> DuyetCongViecAsync(int congViecId, int adminId)
        {
            var job = await _context.CongViecs.FirstOrDefaultAsync(c => c.Id == congViecId);
            if (job == null || job.DaDuyet) return false;

            job.DaDuyet = true;
            job.NgayDuyet = DateTime.UtcNow;
            job.NguoiDuyetId = adminId;

            _context.CongViecs.Update(job);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> HuyDuyetCongViecAsync(int congViecId)
        {
            var job = await _context.CongViecs.FirstOrDefaultAsync(c => c.Id == congViecId);
            if (job == null || !job.DaDuyet) return false;

            job.DaDuyet = false;
            job.NgayDuyet = null;
            job.NguoiDuyetId = null;

            _context.CongViecs.Update(job);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<CongViecDto?> CapNhatCongViecAsync(int id, AdminCapNhatCongViecDto dto)
        {
            var job = await _context.CongViecs.FindAsync(id);
            if (job == null) return null;

            _mapper.Map(dto, job);
            _context.CongViecs.Update(job);
            await _context.SaveChangesAsync();

            return _mapper.Map<CongViecDto>(job);
        }

        public async Task<bool> XoaCongViecAsync(int id)
        {
            var job = await _context.CongViecs.FindAsync(id);
            if (job == null) return false;

            _context.CongViecs.Remove(job);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<AdminLinhVucDto>> DanhSachLinhVucAsync()
        {
            var linhVucs = await _context.LinhVucs
                .OrderByDescending(x => x.NgayTao)
                .Select(x => new AdminLinhVucDto
                {
                    Id = x.Id,
                    TenLinhVuc = x.TenLinhVuc,
                    MoTa = x.MoTa,
                    NgayTao = x.NgayTao,
                })
                .ToListAsync();

            return linhVucs;
        }

        public async Task<AdminLinhVucDto?> TaoLinhVucAsync(AdminLinhVucDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.TenLinhVuc))
                throw new ArgumentException("Tên lĩnh vực không được để trống.");

            var linhVuc = new LinhVuc
            {
                TenLinhVuc = dto.TenLinhVuc.Trim(),
                MoTa = dto.MoTa?.Trim(),
                NgayTao = DateTime.Now
            };

            _context.LinhVucs.Add(linhVuc);
            await _context.SaveChangesAsync();

            return new AdminLinhVucDto
            {
                Id = linhVuc.Id,
                TenLinhVuc = linhVuc.TenLinhVuc,
                MoTa = linhVuc.MoTa,
                NgayTao = linhVuc.NgayTao,
                SoLuongCongViec = 0
            };
        }
        public async Task<bool> XoaLinhVucAsync(int id)
        {
            var lv = await _context.LinhVucs.FindAsync(id);
            if (lv == null) return false;

            _context.LinhVucs.Remove(lv);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<AdminLinhVucDto?> CapNhatLinhVucAsync(int id, AdminLinhVucDto dto)
        {
            var linhVuc = await _context.LinhVucs.FirstOrDefaultAsync(x => x.Id == id);
            if (linhVuc == null)
                return null;

            if (!string.IsNullOrWhiteSpace(dto.TenLinhVuc))
                linhVuc.TenLinhVuc = dto.TenLinhVuc.Trim();

            linhVuc.MoTa = string.IsNullOrWhiteSpace(dto.MoTa)
                ? linhVuc.MoTa
                : dto.MoTa.Trim();

            _context.LinhVucs.Update(linhVuc);
            await _context.SaveChangesAsync();

            return new AdminLinhVucDto
            {
                Id = linhVuc.Id,
                TenLinhVuc = linhVuc.TenLinhVuc,
                MoTa = linhVuc.MoTa,
            };
        }
        public async Task<List<AdminMucKinhNghiemDto>> LayDanhSachMucKinhNghiemAsync()
        {
            return await _context.MucKinhNghiems
                .Select(x => new AdminMucKinhNghiemDto
                {
                    Id = x.Id,
                    Ten = x.Ten
                })
                .ToListAsync();
        }

        public async Task<AdminMucKinhNghiemDto> TaoMucKinhNghiemAsync(AdminMucKinhNghiemDto dto)
        {
            var entity = new MucKinhNghiem
            {
                Ten = dto.Ten
            };

            _context.MucKinhNghiems.Add(entity);
            await _context.SaveChangesAsync();

            dto.Id = entity.Id;
            return dto;
        }

        public async Task<AdminMucKinhNghiemDto> CapNhatMucKinhNghiemAsync(int id, AdminMucKinhNghiemDto dto)
        {
            var item = await _context.MucKinhNghiems.FindAsync(id);

            if (item == null)
                throw new Exception("Không tìm thấy mục kinh nghiệm.");

            item.Ten = dto.Ten;

            await _context.SaveChangesAsync();

            dto.Id = id;
            return dto;
        }

        public async Task<bool> XoaMucKinhNghiemAsync(int id)
        {
            var item = await _context.MucKinhNghiems
                .Include(x => x.CongViecs)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
                return false;

            if (item.CongViecs != null && item.CongViecs.Any())
                throw new Exception("Không thể xóa vì đang được sử dụng.");

            _context.MucKinhNghiems.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<AdminLoaiCongViecDto>> LayDanhSachLoaiCongViecAsync()
        {
            return await _context.LoaiCongViecs
                .Select(x => new AdminLoaiCongViecDto
                {
                    Id = x.Id,
                    Ten = x.Ten
                })
                .ToListAsync();
        }

        public async Task<AdminLoaiCongViecDto?> TaoLoaiCongViecAsync(AdminLoaiCongViecDto dto)
        {
            var item = new LoaiCongViec { Ten = dto.Ten };
            _context.LoaiCongViecs.Add(item);
            await _context.SaveChangesAsync();

            dto.Id = item.Id;
            return dto;
        }

        public async Task<AdminLoaiCongViecDto?> CapNhatLoaiCongViecAsync(int id, AdminLoaiCongViecDto dto)
        {
            var item = await _context.LoaiCongViecs.FindAsync(id);
            if (item == null) return null;

            item.Ten = dto.Ten;
            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<bool> XoaLoaiCongViecAsync(int id)
        {
            var item = await _context.LoaiCongViecs
                .Include(l => l.CongViecs)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (item == null) return false;

            if (item.CongViecs != null && item.CongViecs.Any())
                throw new Exception("Không thể xóa! Loại công việc đang được sử dụng bởi các tin tuyển dụng.");

            _context.LoaiCongViecs.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<AdminCapBacDto>> LayDanhSachCapBacAsync()
        {
            return await _context.CapBacs
                .Select(x => new AdminCapBacDto
                {
                    Id = x.Id,
                    Ten = x.Ten
                })
                .ToListAsync();
        }

        public async Task<AdminCapBacDto?> TaoCapBacAsync(AdminCapBacDto dto)
        {
            var item = new CapBac { Ten = dto.Ten };
            _context.CapBacs.Add(item);
            await _context.SaveChangesAsync();

            dto.Id = item.Id;
            return dto;
        }

        public async Task<AdminCapBacDto?> CapNhatCapBacAsync(int id, AdminCapBacDto dto)
        {
            var item = await _context.CapBacs.FindAsync(id);
            if (item == null) return null;

            item.Ten = dto.Ten;
            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<bool> XoaCapBacAsync(int id)
        {
            var item = await _context.CapBacs
                .Include(l => l.CongViecs)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (item == null) return false;

            if (item.CongViecs != null && item.CongViecs.Any())
                throw new Exception("Không thể xóa! Cấp bậc đang được sử dụng bởi tin tuyển dụng.");

            _context.CapBacs.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> TaoThongBaoAsync(AdminGuiThongBaoDto dto, int adminId)
        {
            if (dto.GuiToanHeThong == true)
            {
                var userIds = await _context.NguoiDungs
                    .Select(u => u.Id)
                    .ToListAsync();

                var tbs = userIds.Select(id => new Models.ThongBao
                {
                    TieuDe = dto.TieuDe,
                    NoiDung = dto.NoiDung,
                    Url = dto.Url,
                    Loai = dto.Loai,
                    NguoiDungId = id,
                    DaDoc = false,
                    NgayTao = DateTime.UtcNow
                });

                _context.ThongBaos.AddRange(tbs);
                await _context.SaveChangesAsync();
                return true;
            }

            if (!string.IsNullOrEmpty(dto.VaiTro))
            {
                var userIds = await _context.NguoiDungs
                    .Where(u => u.VaiTro == dto.VaiTro)
                    .Select(u => u.Id)
                    .ToListAsync();

                if (!userIds.Any())
                    throw new Exception("Không có người dùng thuộc vai trò này.");

                var tbs = userIds.Select(id => new Models.ThongBao
                {
                    TieuDe = dto.TieuDe,
                    NoiDung = dto.NoiDung,
                    Url = dto.Url,
                    Loai = dto.Loai,
                    NguoiDungId = id,
                    DaDoc = false,
                    NgayTao = DateTime.UtcNow
                });

                _context.ThongBaos.AddRange(tbs);
                await _context.SaveChangesAsync();
                return true;
            }

            if (dto.NguoiDungId.HasValue)
            {
                var tb = new Models.ThongBao
                {
                    TieuDe = dto.TieuDe,
                    NoiDung = dto.NoiDung,
                    Url = dto.Url,
                    Loai = dto.Loai,
                    NguoiDungId = dto.NguoiDungId.Value,
                    DaDoc = false,
                    NgayTao = DateTime.UtcNow
                };

                _context.ThongBaos.Add(tb);
                await _context.SaveChangesAsync();
                return true;
            }

            throw new Exception("Chưa chọn người nhận thông báo.");
        }


        public async Task<bool> GuiThongBaoTheoVaiTroAsync(AdminGuiThongBaoDto dto)
        {
            if (string.IsNullOrEmpty(dto.VaiTro))
                throw new Exception("Vai trò không hợp lệ.");

            var users = await _context.NguoiDungs
                .Where(u => u.VaiTro == dto.VaiTro)
                .Select(u => u.Id)
                .ToListAsync();

            var tb = new Models.ThongBao
            {
                TieuDe = dto.TieuDe,
                NoiDung = dto.NoiDung,
                Url = dto.Url,
                Loai = dto.Loai,
                NguoiDungId = dto.NguoiDungId.Value,
                DaDoc = false,
                NgayTao = DateTime.UtcNow
            };

            _context.ThongBaos.AddRange(tb);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> GuiThongBaoToanHeThongAsync(AdminGuiThongBaoDto dto)
        {
            var userIds = await _context.NguoiDungs
                .Select(u => u.Id)
                .ToListAsync();

            var tb = new Models.ThongBao
            {
                TieuDe = dto.TieuDe,
                NoiDung = dto.NoiDung,
                Url = dto.Url,
                Loai = dto.Loai,
                NguoiDungId = dto.NguoiDungId.Value,
                DaDoc = false,
                NgayTao = DateTime.UtcNow
            };

            _context.ThongBaos.AddRange(tb);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<AdminThongBaoDto>> DanhSachThongBaoAsync()
        {
            return await _context.ThongBaos
                .Include(t => t.NguoiDung)
                .OrderByDescending(t => t.NgayTao)
                .Select(t => new AdminThongBaoDto
                {
                    Id = t.Id,
                    TieuDe = t.TieuDe,
                    NoiDung = t.NoiDung,
                    Url = t.Url,
                    Loai = t.Loai,
                    NgayTao = t.NgayTao,
                    NguoiDungId = t.NguoiDungId,
                    TenNguoiNhan = t.NguoiDung.HoTen
                })
                .ToListAsync();
        }
        public async Task<ThongKeDto> ThongKeHeThongAsync()
        {
            var dto = new ThongKeDto();

            dto.TongNguoiDung = await _context.NguoiDungs.CountAsync();
            dto.SinhVien = await _context.NguoiDungs.CountAsync(u => u.VaiTro == "SinhVien");
            dto.NhaTuyenDung = await _context.NguoiDungs.CountAsync(u => u.VaiTro == "NhaTuyenDung");
            dto.Admin = await _context.NguoiDungs.CountAsync(u => u.VaiTro == "Admin");
            dto.SuperAdmin = await _context.NguoiDungs.CountAsync(u => u.VaiTro == "SuperAdmin");
            dto.DangHoatDong = await _context.NguoiDungs.CountAsync(u => !u.BiKhoa);
            dto.BiKhoa = await _context.NguoiDungs.CountAsync(u => u.BiKhoa);

            dto.TongCongTy = await _context.CongTys.CountAsync();

            dto.TongCongViec = await _context.CongViecs.CountAsync();
            dto.CongViecDaDuyet = await _context.CongViecs.CountAsync(c => c.DaDuyet);
            dto.CongViecChuaDuyet = await _context.CongViecs.CountAsync(c => !c.DaDuyet);
            dto.CongViecMoi7Ngay = await _context.CongViecs.CountAsync(c => c.NgayDang >= DateTime.UtcNow.AddDays(-7));

            dto.TongUngTuyen = await _context.DonUngTuyens.CountAsync();
            dto.UngTuyenCho = await _context.DonUngTuyens.CountAsync(d => d.TrangThai == "Đang chờ");
            dto.UngTuyenDuyet = await _context.DonUngTuyens.CountAsync(d => d.TrangThai == "Đã duyệt");
            dto.UngTuyenTuChoi = await _context.DonUngTuyens.CountAsync(d => d.TrangThai == "Từ chối");

            dto.TongBaoCao = await _context.BaoCaoNoiDungs.CountAsync();
            dto.TongKhieuNai = await _context.KhieuNais.CountAsync();

            return dto;
        }

        public async Task<List<AdminNgheNghiepDto>> DanhSachNgheNghiepAsync()
        {
            return await _context.NgheNghieps
                .Include(x => x.LinhVuc)
                .Include(x => x.ChuyenNganhs)
                .OrderByDescending(x => x.NgayTao)
                .Select(x => new AdminNgheNghiepDto
                {
                    Id = x.Id,
                    TenNghe = x.TenNghe,
                    MoTa = x.MoTa,
                    LinhVucId = x.LinhVucId,
                    TenLinhVuc = x.LinhVuc.TenLinhVuc,
                    NgayTao = x.NgayTao,
                    SoLuongChuyenNganh = x.ChuyenNganhs.Count
                })
                .ToListAsync();
        }

        public async Task<List<AdminNgheNghiepDto>> LayNgheTheoLinhVucAsync(int linhVucId)
        {
            return await _context.NgheNghieps
                .Where(n => n.LinhVucId == linhVucId)
                .Select(n => new AdminNgheNghiepDto
                {
                    Id = n.Id,
                    TenNghe = n.TenNghe,
                    MoTa = n.MoTa,
                    LinhVucId = n.LinhVucId,
                    TenLinhVuc = n.LinhVuc.TenLinhVuc,
                    NgayTao = n.NgayTao,
                    SoLuongChuyenNganh = n.ChuyenNganhs.Count
                })
                .ToListAsync();
        }

        public async Task<AdminNgheNghiepDto?> TaoNgheNghiepAsync(AdminNgheNghiepDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.TenNghe))
                throw new ArgumentException("Tên nghề không được để trống.");

            var model = new NgheNghiep
            {
                TenNghe = dto.TenNghe.Trim(),
                MoTa = dto.MoTa?.Trim(),
                LinhVucId = dto.LinhVucId
            };

            _context.NgheNghieps.Add(model);
            await _context.SaveChangesAsync();

            var linhVuc = await _context.LinhVucs.FindAsync(dto.LinhVucId);

            return new AdminNgheNghiepDto
            {
                Id = model.Id,
                TenNghe = model.TenNghe,
                MoTa = model.MoTa,
                LinhVucId = model.LinhVucId,
                TenLinhVuc = linhVuc?.TenLinhVuc ?? "",
                NgayTao = model.NgayTao,
                SoLuongChuyenNganh = 0
            };
        }

        public async Task<AdminNgheNghiepDto?> CapNhatNgheNghiepAsync(int id, AdminNgheNghiepDto dto)
        {
            var model = await _context.NgheNghieps
                .Include(x => x.LinhVuc)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model == null) return null;

            model.TenNghe = dto.TenNghe?.Trim() ?? model.TenNghe;
            model.MoTa = dto.MoTa?.Trim() ?? model.MoTa;

            if (dto.LinhVucId > 0)
                model.LinhVucId = dto.LinhVucId;

            await _context.SaveChangesAsync();

            return new AdminNgheNghiepDto
            {
                Id = model.Id,
                TenNghe = model.TenNghe,
                MoTa = model.MoTa,
                LinhVucId = model.LinhVucId,
                TenLinhVuc = model.LinhVuc?.TenLinhVuc ?? "",
                NgayTao = model.NgayTao
            };
        }

        public async Task<bool> XoaNgheNghiepAsync(int id)
        {
            var model = await _context.NgheNghieps
                .Include(x => x.ChuyenNganhs)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model == null)
                return false;
            if (model.ChuyenNganhs.Any())
            {
                _context.ChuyenNganhs.RemoveRange(model.ChuyenNganhs);
            }

            _context.NgheNghieps.Remove(model);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<AdminChuyenNganhDto>> DanhSachChuyenNganhAsync()
        {
            return await _context.ChuyenNganhs
                .Include(x => x.NgheNghiep)
                .OrderByDescending(x => x.NgayTao)
                .Select(x => new AdminChuyenNganhDto
                {
                    Id = x.Id,
                    TenChuyenNganh = x.TenChuyenNganh,
                    MoTa = x.MoTa,
                    NgayTao = x.NgayTao,
                    NgheNghiepId = x.NgheNghiepId,
                    TenNghe = x.NgheNghiep.TenNghe
                })
                .ToListAsync();
        }

        public async Task<List<AdminChuyenNganhDto>> LayChuyenNganhTheoNgheAsync(int ngheId)
        {
            return await _context.ChuyenNganhs
                .Where(c => c.NgheNghiepId == ngheId)
                .Select(c => new AdminChuyenNganhDto
                {
                    Id = c.Id,
                    TenChuyenNganh = c.TenChuyenNganh,
                    MoTa = c.MoTa,
                    NgheNghiepId = c.NgheNghiepId,
                    TenNghe = c.NgheNghiep.TenNghe,
                    NgayTao = c.NgayTao
                })
                .ToListAsync();
        }

        public async Task<AdminChuyenNganhDto?> TaoChuyenNganhAsync(AdminChuyenNganhDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.TenChuyenNganh))
                throw new Exception("Tên chuyên ngành không được để trống.");

            var model = new ChuyenNganh
            {
                TenChuyenNganh = dto.TenChuyenNganh.Trim(),
                NgheNghiepId = dto.NgheNghiepId
            };

            _context.ChuyenNganhs.Add(model);
            await _context.SaveChangesAsync();

            return new AdminChuyenNganhDto
            {
                Id = model.Id,
                TenChuyenNganh = model.TenChuyenNganh,
                NgheNghiepId = model.NgheNghiepId,
                TenNghe = (await _context.NgheNghieps.FindAsync(dto.NgheNghiepId))?.TenNghe ?? "",
                NgayTao = DateTime.UtcNow
            };
        }

        public async Task<AdminChuyenNganhDto?> CapNhatChuyenNganhAsync(int id, AdminChuyenNganhDto dto)
        {
            var model = await _context.ChuyenNganhs.FindAsync(id);
            if (model == null) return null;

            model.TenChuyenNganh = dto.TenChuyenNganh?.Trim() ?? model.TenChuyenNganh;
            model.NgheNghiepId = dto.NgheNghiepId;

            await _context.SaveChangesAsync();

            return new AdminChuyenNganhDto
            {
                Id = model.Id,
                TenChuyenNganh = model.TenChuyenNganh,
                NgheNghiepId = model.NgheNghiepId,
                TenNghe = (await _context.NgheNghieps.FindAsync(dto.NgheNghiepId))?.TenNghe ?? "",
            };
        }

        public async Task<bool> XoaChuyenNganhAsync(int id)
        {
            var model = await _context.ChuyenNganhs.FindAsync(id);
            if (model == null) return false;

            _context.ChuyenNganhs.Remove(model);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
