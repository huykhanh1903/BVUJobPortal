using BVUJobPortal.DTOs.CV;

namespace BVUJobPortal.DTOs.CV
{
    public class CVDto
    {
        public int Id { get; set; }
        public int NguoiDungId { get; set; }

        public string HoTen { get; set; } = string.Empty;
        public string ViTriUngTuyen { get; set; } = string.Empty;

        public string? AvatarUrl { get; set; }

        public string? Email { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? Website { get; set; }

        public string? MucTieuNgheNghiep { get; set; }

        public int? TemplateId { get; set; }
        public string? TenTemplate { get; set; }

        public List<HocVanDto> HocVan { get; set; } = new();
        public List<KinhNghiemDto> KinhNghiem { get; set; } = new();
        public List<DuAnDto> DuAn { get; set; } = new();
        public List<KyNangDto> KyNang { get; set; } = new();
        public List<ChungChiDto> ChungChi { get; set; } = new();
        public List<HoatDongDto> HoatDong { get; set; } = new();
        public List<GiaiThuongDto> GiaiThuong { get; set; } = new();
        public List<NguoiThamChieuDto> NguoiThamChieu { get; set; } = new();
        public List<SoThichDto> SoThich { get; set; } = new();

        public string? ThongTinThem { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}
