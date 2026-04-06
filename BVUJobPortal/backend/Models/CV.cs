using System;
using System.Collections.Generic;

namespace BVUJobPortal.Models
{
    public class CV
    {
        public int Id { get; set; }
        public int NguoiDungId { get; set; }
        public NguoiDung NguoiDung { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public string ViTriUngTuyen { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }
        public string? Email { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? Website { get; set; }

        public string? MucTieuNgheNghiep { get; set; }
        public int? TemplateId { get; set; }
        public CVTemplate? Template { get; set; }
        public List<HocVan> HocVans { get; set; } = new();
        public List<KinhNghiem> KinhNghiems { get; set; } = new();
        public List<DuAn> DuAns { get; set; } = new();
        public List<KyNang> KyNangs { get; set; } = new();
        public List<ChungChi> ChungChis { get; set; } = new();
        public List<HoatDong> HoatDongs { get; set; } = new();
        public List<GiaiThuong> GiaiThuongs { get; set; } = new();
        public List<NguoiThamChieu> NguoiThamChieus { get; set; } = new();
        public List<SoThich> SoThichs { get; set; } = new();
        public string? ThongTinThem { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
        public DateTime NgayCapNhat { get; set; } = DateTime.Now;
    }
}
