using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BVUJobPortal.Data.Seed;
using BVUJobPortal.Models.SinhVien;

namespace BVUJobPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<CVTemplate> CVTemplates { get; set; }
        public DbSet<HocVan> HocVans { get; set; }
        public DbSet<KinhNghiem> KinhNghiems { get; set; }
        public DbSet<KyNang> KyNangs { get; set; }
        public DbSet<ChungChi> ChungChis { get; set; }
        public DbSet<DuAn> DuAns { get; set; }
        public DbSet<CongViec> CongViecs { get; set; }
        public DbSet<DonUngTuyen> DonUngTuyens { get; set; }
        public DbSet<ThongBao> ThongBaos { get; set; }
        public DbSet<CongTy> CongTys { get; set; }
        public DbSet<LinhVuc> LinhVucs { get; set; }
        public DbSet<BaoCaoNoiDung> BaoCaoNoiDungs { get; set; }
        public DbSet<KhieuNai> KhieuNais { get; set; }
        public DbSet<TinhThanh> TinhThanhs { get; set; }
        public DbSet<NgheNghiep> NgheNghieps { get; set; }
        public DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public DbSet<TuKhoaTimKiem> TuKhoaTimKiems { get; set; }
        public DbSet<CongViecChuyenNganh> CongViecChuyenNganhs { get; set; }
        public DbSet<CongViecKhuVuc> CongViecKhuVucs { get; set; }
        public DbSet<LoaiCongViec> LoaiCongViecs { get; set; }
        public DbSet<CapBac> CapBacs { get; set; }
        public DbSet<MucKinhNghiem> MucKinhNghiems { get; set; }
        public DbSet<HoatDong> HoatDongs { get; set; }
        public DbSet<GiaiThuong> GiaiThuongs { get; set; }
        public DbSet<NguoiThamChieu> NguoiThamChieus { get; set; }
        public DbSet<SoThich> SoThichs { get; set; }
        public DbSet<SinhVienProfile> SinhVienProfiles { get; set; }
        public DbSet<KinhNghiemSinhVien> KinhNghiemSinhViens { get; set; }
        public DbSet<HocVanSinhVien> HocVanSinhViens { get; set; }
        public DbSet<ChungChiSinhVien> ChungChiSinhViens { get; set; }
        public DbSet<NgoaiNguSinhVien> NgoaiNguSinhViens { get; set; }
        public DbSet<KyNangSinhVien> KyNangChuyenMonSinhViens { get; set; }
        public DbSet<HoatDongSinhVien> HoatDongSinhViens { get; set; }
        public DbSet<NguoiThamChieuSinhVien> NguoiThamChieuSinhViens { get; set; }
        public DbSet<HeThongCauHinh> HeThongCauHinhs { get; set; }
        public DbSet<AppChatMessage> ChatMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            LinhVucSeed.Seed(modelBuilder);
            NgheNghiepSeed.Seed(modelBuilder);
            ChuyenNganhSeed.Seed(modelBuilder);
            CapBacSeed.Seed(modelBuilder);
            LoaiCongViecSeed.Seed(modelBuilder);
            MucKinhNghiemSeed.Seed(modelBuilder);

            new HeThongCauHinh { Id = 1, Key = "EnableAI", Value = "true" };

            var superAdmin = new NguoiDung 
            {
                Id = 1,
                Ma = "SA-1",
                HoTen = "Siêu Quản Trị Viên hệ thống",
                Email = "superadmin@bvu.edu.vn",
                SDT = "0910000000",
                VaiTro = "SuperAdmin",
                MatKhauHash = BCrypt.Net.BCrypt.HashPassword("Super@123"),
                NgayTao = DateTime.UtcNow,
                BiKhoa = false
            };

            var admin = new NguoiDung
            {
                Id = 2,
                Ma = "AD-1",
                HoTen = "Quản Trị Viên",
                Email = "admin@bvu.edu.vn",
                SDT = "0920000000",
                VaiTro = "Admin",
                MatKhauHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                NgayTao = DateTime.UtcNow,
                BiKhoa = false
            };

            var nhaTuyenDung = new NguoiDung
            {
                Id = 4,
                Ma = "NTD-1",
                HoTen = "Nguyễn Văn Nhà Tuyển Dụng",
                Email = "ntd@abc.com",
                SDT = "0933111222",
                VaiTro = "NhaTuyenDung",
                MatKhauHash = BCrypt.Net.BCrypt.HashPassword("NTD@123"),
                NgayTao = DateTime.UtcNow,
                BiKhoa = false
            };

            var sinhVien = new NguoiDung
            {
                Id = 3,
                Ma = "SV-1",
                HoTen = "Trần Thị Sinh Viên",
                Email = "sinhvien@bvu.edu.vn",
                SDT = "0944000000",
                VaiTro = "SinhVien",
                MatKhauHash = BCrypt.Net.BCrypt.HashPassword("SV@123"),
                NgayTao = DateTime.UtcNow,
                BiKhoa = false,
                LopHoc = "D20KTPM01",
                KhoaHoc = "K20"
            };

            modelBuilder.Entity<NguoiDung>().HasData(superAdmin, admin, nhaTuyenDung, sinhVien);

            modelBuilder.Entity<CVTemplate>().HasData(
                new CVTemplate
                {
                    Id = 1,
                    TenTemplate = "Classic",
                    MoTa = "Mẫu truyền thống đơn giản, phù hợp mọi ngành nghề.",
                    MauChuDao = "#0057B8",
                    Font = "Arial",
                    PreviewUrl = "/images/templates/classic.png"
                },
                new CVTemplate
                {
                    Id = 2,
                    TenTemplate = "Modern",
                    MoTa = "Mẫu hiện đại, màu sắc nổi bật, bố cục 2 cột.",
                    MauChuDao = "#2E8B57",
                    Font = "Segoe UI",
                    PreviewUrl = "/images/templates/modern.png"
                },
                new CVTemplate
                {
                    Id = 3,
                    TenTemplate = "Creative",
                    MoTa = "Mẫu sáng tạo, thích hợp cho ngành thiết kế và truyền thông.",
                    MauChuDao = "#FF6347",
                    Font = "Calibri",
                    PreviewUrl = "/images/templates/creative.png"
                }
                );

            modelBuilder.Entity<TinhThanh>().HasData(
                new() { Id = 1, MaTinh = "HNI", TenTinh = "Thành phố Hà Nội" },
                new() { Id = 2, MaTinh = "HUE", TenTinh = "Thành phố Huế" },
                new() { Id = 3, MaTinh = "LCH", TenTinh = "Tỉnh Lai Châu" },
                new() { Id = 4, MaTinh = "DBN", TenTinh = "Tỉnh Điện Biên" },
                new() { Id = 5, MaTinh = "SLA", TenTinh = "Tỉnh Sơn La" },
                new() { Id = 6, MaTinh = "LSN", TenTinh = "Tỉnh Lạng Sơn" },
                new() { Id = 7, MaTinh = "QNI", TenTinh = "Tỉnh Quảng Ninh" },
                new() { Id = 8, MaTinh = "THA", TenTinh = "Tỉnh Thanh Hoá" },
                new() { Id = 9, MaTinh = "NAN", TenTinh = "Tỉnh Nghệ An" },
                new() { Id = 10, MaTinh = "HTH", TenTinh = "Tỉnh Hà Tĩnh" },
                new() { Id = 11, MaTinh = "CBG", TenTinh = "Tỉnh Cao Bằng" },
                new() { Id = 12, MaTinh = "TTQ", TenTinh = "Tỉnh Tuyên Quang" },
                new() { Id = 13, MaTinh = "LCA", TenTinh = "Tỉnh Lào Cai" },
                new() { Id = 14, MaTinh = "TNG", TenTinh = "Tỉnh Thái Nguyên" },
                new() { Id = 15, MaTinh = "PTO", TenTinh = "Tỉnh Phú Thọ" },
                new() { Id = 16, MaTinh = "BNH", TenTinh = "Tỉnh Bắc Ninh" },
                new() { Id = 17, MaTinh = "HYE", TenTinh = "Tỉnh Hưng Yên" },
                new() { Id = 18, MaTinh = "HPG", TenTinh = "Thành phố Hải Phòng" },
                new() { Id = 19, MaTinh = "NBI", TenTinh = "Tỉnh Ninh Bình" },
                new() { Id = 20, MaTinh = "QTR", TenTinh = "Tỉnh Quảng Trị" },
                new() { Id = 21, MaTinh = "DNG", TenTinh = "Thành phố Đà Nẵng" },
                new() { Id = 22, MaTinh = "QNG", TenTinh = "Tỉnh Quảng Ngãi" },
                new() { Id = 23, MaTinh = "GLI", TenTinh = "Tỉnh Gia Lai" },
                new() { Id = 24, MaTinh = "KHA", TenTinh = "Tỉnh Khánh Hoà" },
                new() { Id = 25, MaTinh = "LDG", TenTinh = "Tỉnh Lâm Đồng" },
                new() { Id = 26, MaTinh = "DLK", TenTinh = "Tỉnh Đắk Lắk" },
                new() { Id = 27, MaTinh = "HCM", TenTinh = "Thành phố Hồ Chí Minh" },
                new() { Id = 28, MaTinh = "DNI", TenTinh = "Tỉnh Đồng Nai" },
                new() { Id = 29, MaTinh = "TNI", TenTinh = "Tỉnh Tây Ninh" },
                new() { Id = 30, MaTinh = "CTO", TenTinh = "Thành phố Cần Thơ" },
                new() { Id = 31, MaTinh = "VLG", TenTinh = "Tỉnh Vĩnh Long" },
                new() { Id = 32, MaTinh = "DTP", TenTinh = "Tỉnh Đồng Tháp" },
                new() { Id = 33, MaTinh = "CMU", TenTinh = "Tỉnh Cà Mau" },
                new() { Id = 34, MaTinh = "AGG", TenTinh = "Tỉnh An Giang" }
            );

            modelBuilder.Entity<DonUngTuyen>()
                .HasOne(d => d.NguoiDung)
                .WithMany()
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DonUngTuyen>()
                .HasOne(d => d.CongViec)
                .WithMany()
                .HasForeignKey(d => d.CongViecId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<NgheNghiep>()
                .HasMany(n => n.ChuyenNganhs)
                .WithOne(c => c.NgheNghiep)
                .HasForeignKey(c => c.NgheNghiepId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.NguoiDung)
                .WithMany(nd => nd.CVs)
                .HasForeignKey(cv => cv.NguoiDungId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HocVan>()
                .HasOne(h => h.CV)
                .WithMany(cv => cv.HocVans)
                .HasForeignKey(h => h.CVId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<KinhNghiem>()
                .HasOne(k => k.CV)
                .WithMany(cv => cv.KinhNghiems)
                .HasForeignKey(k => k.CVId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<KyNang>()
                .HasOne(k => k.CV)
                .WithMany(cv => cv.KyNangs)
                .HasForeignKey(k => k.CVId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChungChi>()
                .HasOne(c => c.CV)
                .WithMany(cv => cv.ChungChis)
                .HasForeignKey(c => c.CVId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DuAn>()
                .HasOne(d => d.CV)
                .WithMany(cv => cv.DuAns)
                .HasForeignKey(d => d.CVId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.Template)
                .WithMany(t => t.CVs)
                .HasForeignKey(cv => cv.TemplateId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<CongTy>()
                .HasOne(c => c.DaXacMinhBoiAdmin)
                .WithMany()
                .HasForeignKey(c => c.AdminXacMinhId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<NguoiDung>()
                .HasOne(n => n.NguoiXacThuc)
                .WithMany()
                .HasForeignKey(n => n.NguoiXacThucId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NguoiDung>()
                .HasOne(u => u.CongTy)
                .WithMany(c => c.NhaTuyenDungs)
                .HasForeignKey(u => u.CongTyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CongViec>()
                .HasOne(cv => cv.CongTy)
                .WithMany(c => c.CongViecs)
                .HasForeignKey(cv => cv.CongTyId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<CongTy>()
                .HasOne(c => c.TinhThanh)
                .WithMany()
                .HasForeignKey(c => c.TinhThanhId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<CongViecChuyenNganh>()
                .HasOne(x => x.CongViec)
                .WithMany(x => x.CongViecChuyenNganhs)
                .HasForeignKey(x => x.CongViecId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CongViecChuyenNganh>()
                .HasOne(x => x.ChuyenNganh)
                .WithMany()
                .HasForeignKey(x => x.ChuyenNganhId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CongViecKhuVuc>()
                .HasOne(x => x.CongViec)
                .WithMany(x => x.KhuVucLamViecs)
                .HasForeignKey(x => x.CongViecId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CongViecKhuVuc>()
                .HasOne(x => x.TinhThanh)
                .WithMany()
                .HasForeignKey(x => x.TinhThanhId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
