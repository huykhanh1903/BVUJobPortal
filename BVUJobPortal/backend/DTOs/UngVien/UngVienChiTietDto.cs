using BVUJobPortal.DTOs.SinhVien;

namespace BVUJobPortal.DTOs.UngVien
{
    public class UngVienChiTietDto
    {
        public string HoTen { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }
        public string? Email { get; set; }
        public string? DienThoai { get; set; }

        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }

        public string? MucTieuNgheNghiep { get; set; }
        public string? CapBacMongMuon { get; set; }
        public string? NganhNgheMongMuon { get; set; }
        public string? HinhThucLamViec { get; set; }

        public bool LuongThoaThuan { get; set; }
        public decimal? MucLuongTu { get; set; }
        public decimal? MucLuongDen { get; set; }

        public List<KinhNghiemSinhVienDto> KinhNghiems { get; set; } = [];
        public List<HocVanSinhVienDto> HocVans { get; set; } = [];
        public List<KyNangSinhVienDto> KyNangs { get; set; } = [];
        public List<ChungChiSinhVienDto> ChungChis { get; set; } = [];
        public List<NgoaiNguSinhVienDto> NgoaiNgus { get; set; } = [];
        public List<HoatDongSinhVienDto> HoatDongs { get; set; } = [];
    }
}
