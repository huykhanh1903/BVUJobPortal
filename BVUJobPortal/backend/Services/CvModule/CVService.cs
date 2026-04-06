using BVUJobPortal.Data;
using BVUJobPortal.DTOs.CV;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;
using PuppeteerSharp;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using PuppeteerSharp;
using System.Net;
using System.Text;
using System.Text.Json;
using PuppeteerSharp.Media;


namespace BVUJobPortal.Services.CvModule
{
    public class CVService : ICVService
    {
        private readonly ApplicationDbContext _context;

        public CVService(ApplicationDbContext context)
        {
            _context = context;
        }

        // =================== TẠO CV ===================
        public async Task<CVDto> TaoCVAsync(int userId, CVDto dto)
        {
            var cv = new CV
            {
                NguoiDungId = userId,

                // DANH THIẾP
                HoTen = dto.HoTen ?? "",
                ViTriUngTuyen = dto.ViTriUngTuyen ?? "",

                // AVATAR
                AvatarUrl = dto.AvatarUrl,

                // LIÊN HỆ
                Email = dto.Email,
                SoDienThoai = dto.SoDienThoai,
                DiaChi = dto.DiaChi,
                Website = dto.Website,

                // MỤC TIÊU
                MucTieuNgheNghiep = dto.MucTieuNgheNghiep,

                // TEMPLATE
                TemplateId = dto.TemplateId,

                // THÔNG TIN THÊM
                ThongTinThem = dto.ThongTinThem,

                NgayTao = DateTime.UtcNow,
                NgayCapNhat = DateTime.UtcNow
            };

            MapToEntity(cv, dto);

            _context.CVs.Add(cv);
            await _context.SaveChangesAsync();

            return MapToDto(cv);
        }

        // =================== LẤY DANH SÁCH CV ===================
        public async Task<List<CVDto>> LayDanhSachCVAsync(int userId)
        {
            var cvs = await _context.CVs
                .Where(x => x.NguoiDungId == userId)
                .Include(x => x.HocVans)
                .Include(x => x.KinhNghiems)
                .Include(x => x.KyNangs)
                .Include(x => x.ChungChis)
                .Include(x => x.DuAns)
                .Include(x => x.HoatDongs)
                .Include(x => x.GiaiThuongs)
                .Include(x => x.NguoiThamChieus)
                .Include(x => x.SoThichs)
                .ToListAsync();

            return cvs.Select(MapToDto).ToList();
        }
        // =================== CẬP NHẬT CV ===================
        public async Task<CVDto?> CapNhatCVAsync(int userId, int cvId, CVDto dto)
        {
            var cv = await _context.CVs
                .Include(x => x.HocVans)
                .Include(x => x.KinhNghiems)
                .Include(x => x.KyNangs)
                .Include(x => x.ChungChis)
                .Include(x => x.DuAns)
                .Include(x => x.HoatDongs)
                .Include(x => x.GiaiThuongs)
                .Include(x => x.NguoiThamChieus)
                .Include(x => x.SoThichs)
                .FirstOrDefaultAsync(x => x.Id == cvId && x.NguoiDungId == userId);

            if (cv == null)
                return null;

            // Map dữ liệu mới vào entity
            MapToEntity(cv, dto);

            cv.NgayCapNhat = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return MapToDto(cv);
        }


        // =================== LẤY CHI TIẾT CV ===================
        public async Task<CVDto?> LayCVAsync(int userId, int cvId)
        {
            var cv = await _context.CVs
                .Include(x => x.HocVans)
                .Include(x => x.KinhNghiems)
                .Include(x => x.KyNangs)
                .Include(x => x.ChungChis)
                .Include(x => x.DuAns)
                .Include(x => x.HoatDongs)
                .Include(x => x.GiaiThuongs)
                .Include(x => x.NguoiThamChieus)
                .Include(x => x.SoThichs)
                .Include(x => x.Template)
                .FirstOrDefaultAsync(x => x.Id == cvId && x.NguoiDungId == userId);

            if (cv == null) return null;

            return MapToDto(cv);
        }

        // =================== XOÁ CV ===================
        public async Task<bool> XoaCVAsync(int userId, int cvId)
        {
            var cv = await _context.CVs
                .FirstOrDefaultAsync(x => x.Id == cvId && x.NguoiDungId == userId);

            if (cv == null) return false;

            _context.CVs.Remove(cv);
            await _context.SaveChangesAsync();
            return true;
        }


        // =================== EXPORT PDF ===================
        public async Task<byte[]> XuatCVPdfAsync(int userId, int cvId)
        {
            var cv = await _context.CVs
                .Include(x => x.HocVans)
                .Include(x => x.KinhNghiems)
                .Include(x => x.KyNangs)
                .Include(x => x.ChungChis)
                .Include(x => x.DuAns)
                .Include(x => x.HoatDongs)
                .Include(x => x.GiaiThuongs)
                .Include(x => x.NguoiThamChieus)
                .Include(x => x.SoThichs)
                .Include(x => x.NguoiDung)
                .FirstOrDefaultAsync(x => x.Id == cvId && x.NguoiDungId == userId);

            if (cv == null)
                throw new Exception("Không tìm thấy CV");

            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(40);

                    page.Header()
                        .Text($"{cv.HoTen} - {cv.ViTriUngTuyen}")
                        .SemiBold().FontSize(22).FontColor(Colors.Blue.Medium);

                    page.Content().Column(col =>
                    {
                        col.Item().Text($"📧 Email: {cv.Email}");
                        col.Item().Text($"📱 SĐT: {cv.SoDienThoai}");
                        col.Item().Text($"📍 Địa chỉ: {cv.DiaChi}");
                        col.Item().Text($"🌐 Website: {cv.Website}");

                        col.Item().PaddingTop(10).Text($"🎯 Mục tiêu nghề nghiệp: {cv.MucTieuNgheNghiep}");

                        // Học vấn
                        if (cv.HocVans.Any())
                        {
                            col.Item().PaddingTop(10).Text("🎓 Học vấn").Bold().FontSize(16);
                            foreach (var h in cv.HocVans)
                                col.Item().Text($"- {h.Truong} | {h.NganhHoc} | {h.ThoiGianHoc}");
                        }

                        // Kinh nghiệm
                        if (cv.KinhNghiems.Any())
                        {
                            col.Item().PaddingTop(10).Text("💼 Kinh nghiệm").Bold().FontSize(16);
                            foreach (var k in cv.KinhNghiems)
                                col.Item().Text($"- {k.CongTy} ({k.ViTri}) - {k.ThoiGianLamViec}");
                        }

                        // Kỹ năng
                        if (cv.KyNangs.Any())
                        {
                            col.Item().PaddingTop(10).Text("🛠 Kỹ năng").Bold().FontSize(16);
                            col.Item().Text(string.Join(", ", cv.KyNangs.Select(x => x.TenKyNang)));
                        }

                        // Dự án
                        if (cv.DuAns.Any())
                        {
                            col.Item().PaddingTop(10).Text("📂 Dự án").Bold().FontSize(16);
                            foreach (var d in cv.DuAns)
                                col.Item().Text($"- {d.Ten}: {d.MoTa}");
                        }

                        // Chứng chỉ
                        if (cv.ChungChis.Any())
                        {
                            col.Item().PaddingTop(10).Text("📜 Chứng chỉ").Bold().FontSize(16);
                            foreach (var c in cv.ChungChis)
                                col.Item().Text($"- {c.TenChungChi} ({c.NgayCap})");
                        }

                        // Hoạt động
                        if (cv.HoatDongs.Any())
                        {
                            col.Item().PaddingTop(10).Text("🤝 Hoạt động").Bold().FontSize(16);
                            foreach (var hd in cv.HoatDongs)
                                col.Item().Text($"- {hd.TenHoatDong} - {hd.ViTri}");
                        }

                        // Giải thưởng
                        if (cv.GiaiThuongs.Any())
                        {
                            col.Item().PaddingTop(10).Text("🏆 Giải thưởng").Bold().FontSize(16);
                            foreach (var gt in cv.GiaiThuongs)
                                col.Item().Text($"- {gt.TenGiaiThuong} ({gt.ThoiGian})");
                        }

                        // Tham chiếu
                        if (cv.NguoiThamChieus.Any())
                        {
                            col.Item().PaddingTop(10).Text("📞 Người tham chiếu").Bold().FontSize(16);
                            foreach (var ntc in cv.NguoiThamChieus)
                                col.Item().Text($"- {ntc.Ten} ({ntc.ChucVu}) - {ntc.SoDienThoai} - {ntc.Email}");
                        }

                        // Sở thích
                        if (cv.SoThichs.Any())
                        {
                            col.Item().PaddingTop(10).Text("🎯 Sở thích").Bold().FontSize(16);
                            col.Item().Text(string.Join(", ", cv.SoThichs.Select(x => x.NoiDung)));
                        }

                        // Thông tin thêm
                        if (!string.IsNullOrEmpty(cv.ThongTinThem))
                        {
                            col.Item().PaddingTop(10).Text("ℹ️ Thông tin thêm").Bold().FontSize(16);
                            col.Item().Text(cv.ThongTinThem);
                        }
                    });

                });
            }).GeneratePdf();

            return pdf;
        }

        public async Task<byte[]> XuatCVTheoTemplatePdfAsync(int userId, int cvId)
        {
            var cv = await _context.CVs
                .Include(x => x.HocVans)
                .Include(x => x.KinhNghiems)
                .Include(x => x.KyNangs)
                .Include(x => x.ChungChis)
                .Include(x => x.DuAns)
                .Include(x => x.HoatDongs)
                .Include(x => x.GiaiThuongs)
                .Include(x => x.NguoiThamChieus)
                .Include(x => x.SoThichs)
                .Include(x => x.Template)
                .FirstOrDefaultAsync(x => x.Id == cvId && x.NguoiDungId == userId);

            if (cv == null)
                throw new Exception("Không tìm thấy CV");

            if (cv.Template == null)
                throw new Exception("CV chưa gắn template");

            if (string.IsNullOrWhiteSpace(cv.Template.LayoutJson))
                throw new Exception("Template chưa có layoutHtml (LayoutJson)");

            // 1) Build HTML từ LayoutJson + data CV
            var bodyHtml = BuildHtmlFromLayout(cv);

            // 2) Lấy CSS từ StyleJson (có thể null)
            var css = cv.Template.StyleJson ?? "";

            // 3) Gói thành full HTML document
            var fullHtml = $@"
<html>
<head>
    <meta charset='utf-8' />
    <style>
        body {{
            margin: 0;
            padding: 0;
        }}
        {css}
    </style>
</head>
<body>
    {bodyHtml}
</body>
</html>";

            // 4) Dùng Puppeteer để render PDF (em có sẵn logic tương tự trong XuatTemplatePdfAsync)
            await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true,
                Args = new[] { "--no-sandbox", "--disable-setuid-sandbox" }
                // Nếu cần: ExecutablePath = GetChromeExecutable()
            });

            await using var page = await browser.NewPageAsync();
            await page.SetContentAsync(fullHtml, new NavigationOptions
            {
                WaitUntil = new[] { WaitUntilNavigation.Load }
            });

            var pdf = await page.PdfDataAsync(new PdfOptions
            {
                PrintBackground = true,
                Format = PaperFormat.A4
            });

            return pdf;
        }

        private string BuildHtmlFromLayout(CV cv)
        {
            // layoutJson lưu HTML có placeholder: {{HoTen}}, {{Email}}, {{HocVan}}, ...
            var html = cv.Template!.LayoutJson!;

            // ====== 1. Thay các field đơn giản ======
            html = html.Replace("{{HoTen}}", cv.HoTen ?? "");
            html = html.Replace("{{ViTriUngTuyen}}", cv.ViTriUngTuyen ?? "");
            html = html.Replace("{{Email}}", cv.Email ?? "");
            html = html.Replace("{{SoDienThoai}}", cv.SoDienThoai ?? "");
            html = html.Replace("{{DiaChi}}", cv.DiaChi ?? "");
            html = html.Replace("{{Website}}", cv.Website ?? "");
            html = html.Replace("{{MucTieuNgheNghiep}}", cv.MucTieuNgheNghiep ?? "");

            // ====== 2. Render các block danh sách ======

            // Học vấn
            var hocVanHtml = string.Join("", cv.HocVans
                .OrderBy(h => h.ThuTu)
                .Select(h => $@"
            <div class='hocvan-item'>
                <div class='hocvan-truong'><b>{h.Truong}</b> - {h.ThoiGianHoc}</div>
                <div class='hocvan-chuyennganh'>{h.NganhHoc}</div>
                <div class='hocvan-mota'>{h.ThanhTich}</div>
            </div>
        "));

            html = html.Replace("{{HocVan}}", hocVanHtml);

            // Kinh nghiệm
            var kinhNghiemHtml = string.Join("", cv.KinhNghiems
                .OrderBy(k => k.ThuTu)
                .Select(k => $@"
            <div class='exp-item'>
                <div class='exp-header'><b>{k.CongTy}</b> - {k.ViTri}</div>
                <div class='exp-time'>{k.ThoiGianLamViec}</div>
                <div class='exp-desc'>{k.MoTaCongViec}</div>
            </div>
        "));

            html = html.Replace("{{KinhNghiem}}", kinhNghiemHtml);

            // Dự án
            var duAnHtml = string.Join("", cv.DuAns
                .OrderBy(d => d.ThuTu)
                .Select(d => $@"
            <div class='project-item'>
                <div class='project-title'><b>{d.Ten}</b> - {d.VaiTro}</div>
                <div class='project-tech'><i>{d.CongNghe}</i></div>
                <div class='project-desc'>{d.MoTa}</div>
            </div>
        "));
            html = html.Replace("{{DuAn}}", duAnHtml);

            // Kỹ năng => render thành list hoặc chip
            var kyNangHtml = string.Join("", cv.KyNangs
                .OrderBy(k => k.ThuTu)
                .Select(k => $@"<span class='skill-item'>{k.TenKyNang}</span>"));
            html = html.Replace("{{KyNang}}", kyNangHtml);

            // Chứng chỉ
            var chungChiHtml = string.Join("", cv.ChungChis
                .OrderBy(c => c.ThuTu)
                .Select(c => $@"
            <div class='certificate-item'>
                <div><b>{c.TenChungChi}</b> - {c.NoiCap}</div>
                <div>{c.NgayCap:dd/MM/yyyy}</div>
            </div>
        "));
            html = html.Replace("{{ChungChi}}", chungChiHtml);

            // Hoạt động
            var hoatDongHtml = string.Join("", cv.HoatDongs
                .OrderBy(h => h.ThuTu)
                .Select(h => $@"
            <div class='activity-item'>
                <div><b>{h.TenHoatDong}</b> - {h.ViTri}</div>
                <div>{h.MoTa}</div>
            </div>
        "));
            html = html.Replace("{{HoatDong}}", hoatDongHtml);

            // Giải thưởng
            var giaiThuongHtml = string.Join("", cv.GiaiThuongs
                .OrderBy(g => g.ThuTu)
                .Select(g => $@"
            <div class='award-item'>
                <div><b>{g.TenGiaiThuong}</b> - {g.ThoiGian}</div>
            </div>
        "));
            html = html.Replace("{{GiaiThuong}}", giaiThuongHtml);

            // Người tham chiếu
            var nguoiThamChieuHtml = string.Join("", cv.NguoiThamChieus
                .Select(n => $@"
            <div class='ref-item'>
                <div><b>{n.Ten}</b> - {n.ChucVu} @ {n.CongTy}</div>
                <div>📱 {n.SoDienThoai} | 📧 {n.Email}</div>
            </div>
        "));
            html = html.Replace("{{NguoiThamChieu}}", nguoiThamChieuHtml);

            // Sở thích
            var soThichHtml = string.Join(", ", cv.SoThichs.Select(s => s.NoiDung));
            html = html.Replace("{{SoThich}}", soThichHtml);

            return html;
        }

        public async Task<byte[]> XuatTemplatePdfAsync(ExportHtmlPdfDto dto)
        {
            // Launch Chromium
            await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true,
                Args = new[] { "--no-sandbox", "--disable-setuid-sandbox" }
            });

            await using var page = await browser.NewPageAsync();

            var fullHtml = $@"
<html>
<head>
    <meta charset='utf-8' />
    <style>
        body {{
            margin: 0;
            padding: 0;
            width: {dto.Width}px;
            height: {dto.Height}px;
            -webkit-print-color-adjust: exact;
            print-color-adjust: exact;
        }}
        {dto.Css}
    </style>
</head>
<body>
    {dto.Html}
</body>
</html>";

            await page.SetContentAsync(fullHtml, new NavigationOptions
            {
                WaitUntil = new[] { WaitUntilNavigation.Load }
            });

            var pdf = await page.PdfDataAsync(new PdfOptions
            {
                PrintBackground = true,
                Width = $"{dto.Width}px",
                Height = $"{dto.Height}px"
            });

            return pdf;
        }

        // =================== MAP MODEL → DTO ===================
        private CVDto MapToDto(CV cv)
        {
            return new CVDto
            {
                Id = cv.Id,
                NguoiDungId = cv.NguoiDungId,

                HoTen = cv.HoTen,
                ViTriUngTuyen = cv.ViTriUngTuyen,

                AvatarUrl = cv.AvatarUrl,

                Email = cv.Email,
                SoDienThoai = cv.SoDienThoai,
                DiaChi = cv.DiaChi,
                Website = cv.Website,

                MucTieuNgheNghiep = cv.MucTieuNgheNghiep,

                TemplateId = cv.TemplateId,
                TenTemplate = cv.Template?.TenTemplate,

                ThongTinThem = cv.ThongTinThem,

                HocVan = cv.HocVans.Select(h => new HocVanDto
                {
                    Truong = h.Truong,
                    ChuyenNganh = h.NganhHoc,
                    ThoiGian = h.ThoiGianHoc,
                    MoTa = h.ThanhTich
                }).ToList(),

                KinhNghiem = cv.KinhNghiems.Select(k => new KinhNghiemDto
                {
                    CongTy = k.CongTy,
                    ViTri = k.ViTri,
                    ThoiGianLamViec = k.ThoiGianLamViec,
                    MoTaCongViec = k.MoTaCongViec
                }).ToList(),

                DuAn = cv.DuAns.Select(d => new DuAnDto
                {
                    Ten = d.Ten,
                    MoTa = d.MoTa,
                    VaiTro = d.VaiTro,
                    CongNghe = d.CongNghe
                }).ToList(),

                KyNang = cv.KyNangs.Select(k => new KyNangDto
                {
                    TenKyNang = k.TenKyNang,
                    Loai = k.Loai
                }).ToList(),

                ChungChi = cv.ChungChis.Select(c => new ChungChiDto
                {
                    TenChungChi = c.TenChungChi,
                    NgayCap = c.NgayCap,
                    NoiCap = c.NoiCap
                }).ToList(),

                HoatDong = cv.HoatDongs.Select(hd => new HoatDongDto
                {
                    TenHoatDong = hd.TenHoatDong,
                    ViTri = hd.ViTri,
                    MoTa = hd.MoTa
                }).ToList(),

                GiaiThuong = cv.GiaiThuongs.Select(gt => new GiaiThuongDto
                {
                    TenGiaiThuong = gt.TenGiaiThuong,
                    ThoiGian = gt.ThoiGian
                }).ToList(),

                NguoiThamChieu = cv.NguoiThamChieus.Select(ntc => new NguoiThamChieuDto
                {
                    Ten = ntc.Ten,
                    ChucVu = ntc.ChucVu,
                    CongTy = ntc.CongTy,
                    SoDienThoai = ntc.SoDienThoai,
                    Email = ntc.Email
                }).ToList(),

                SoThich = cv.SoThichs.Select(st => new SoThichDto
                {
                    NoiDung = st.NoiDung
                }).ToList(),

                NgayTao = cv.NgayTao,
                NgayCapNhat = cv.NgayCapNhat
            };
        }


        private void MapToEntity(CV cv, CVDto dto)
        {
            cv.HoTen = dto.HoTen;
            cv.ViTriUngTuyen = dto.ViTriUngTuyen;

            cv.AvatarUrl = dto.AvatarUrl;

            cv.Email = dto.Email;
            cv.SoDienThoai = dto.SoDienThoai;
            cv.DiaChi = dto.DiaChi;
            cv.Website = dto.Website;

            cv.MucTieuNgheNghiep = dto.MucTieuNgheNghiep;
            cv.TemplateId = dto.TemplateId;

            cv.ThongTinThem = dto.ThongTinThem;

            cv.HocVans.Clear();
            cv.KinhNghiems.Clear();
            cv.DuAns.Clear();
            cv.KyNangs.Clear();
            cv.ChungChis.Clear();
            cv.HoatDongs.Clear();
            cv.GiaiThuongs.Clear();
            cv.NguoiThamChieus.Clear();
            cv.SoThichs.Clear();

            cv.HocVans.AddRange(dto.HocVan.Select(h => new HocVan
            {
                Truong = h.Truong,
                NganhHoc = h.ChuyenNganh,
                ThoiGianHoc = h.ThoiGian,
                ThanhTich = h.MoTa
            }));

            cv.KinhNghiems.AddRange(dto.KinhNghiem.Select(k => new KinhNghiem
            {
                CongTy = k.CongTy,
                ViTri = k.ViTri,
                ThoiGianLamViec = k.ThoiGianLamViec,
                MoTaCongViec = k.MoTaCongViec
            }));

            cv.DuAns.AddRange(dto.DuAn.Select(d => new DuAn
            {
                Ten = d.Ten,
                MoTa = d.MoTa,
                VaiTro = d.VaiTro,
                CongNghe = d.CongNghe
            }));

            cv.KyNangs.AddRange(dto.KyNang.Select(k => new KyNang
            {
                TenKyNang = k.TenKyNang,
                Loai = k.Loai
            }));

            cv.ChungChis.AddRange(dto.ChungChi.Select(c => new ChungChi
            {
                TenChungChi = c.TenChungChi,
                NgayCap = c.NgayCap,
                NoiCap = c.NoiCap
            }));

            cv.HoatDongs.AddRange(dto.HoatDong.Select(h => new HoatDong
            {
                TenHoatDong = h.TenHoatDong,
                ViTri = h.ViTri,
                MoTa = h.MoTa
            }));

            cv.GiaiThuongs.AddRange(dto.GiaiThuong.Select(g => new GiaiThuong
            {
                TenGiaiThuong = g.TenGiaiThuong,
                ThoiGian = g.ThoiGian
            }));

            cv.NguoiThamChieus.AddRange(dto.NguoiThamChieu.Select(n => new NguoiThamChieu
            {
                Ten = n.Ten,
                ChucVu = n.ChucVu,
                CongTy = n.CongTy,
                SoDienThoai = n.SoDienThoai,
                Email =n.Email

            }));

            cv.SoThichs.AddRange(dto.SoThich.Select(st => new SoThich
            {
                NoiDung = st.NoiDung
            }));

            cv.NgayCapNhat = DateTime.UtcNow;
        }
    }
}
