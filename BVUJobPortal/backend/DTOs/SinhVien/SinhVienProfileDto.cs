using System;
using System.Collections.Generic;

namespace BVUJobPortal.DTOs.SinhVien
{
    public class SinhVienProfileDto
    {
        public int? Id { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? TinhThanhId { get; set; }
        public string? DiaChi { get; set; }

        public string? HoTen { get; set; }
        public string? DienThoai { get; set; }
        public string? EmailLienHe { get; set; }
        public string? AvatarUrl { get; set; }
        public string? LopHoc { get; set; }
        public string? KhoaHoc { get; set; }

        public string? MucTieuNgheNghiep { get; set; }
        public string? CapBacMongMuon { get; set; }
        public bool LuongThoaThuan { get; set; }
        public decimal? MucLuongTu { get; set; }
        public decimal? MucLuongDen { get; set; }
        public string? DonViTienTe { get; set; }

        public string? HinhThucLamViec { get; set; }
        public string? NganhNgheMongMuon { get; set; }
        public string? NoiLamViecMongMuon { get; set; }

        public List<string>? PhucLoiMongMuon { get; set; }

        public string? ThanhTichNoiBat { get; set; }

        public List<KinhNghiemSinhVienDto> KinhNghiems { get; set; } = new();
        public List<HocVanSinhVienDto> HocVans { get; set; } = new();
        public List<ChungChiSinhVienDto> ChungChis { get; set; } = new();
        public List<NgoaiNguSinhVienDto> NgoaiNgus { get; set; } = new();
        public List<KyNangSinhVienDto> KyNangs { get; set; } = new();
        public List<HoatDongSinhVienDto> HoatDongs { get; set; } = new();
        public List<NguoiThamChieuSinhVienDto> NguoiThamChieus { get; set; } = new();
    }

    public class KinhNghiemSinhVienDto
    {
        public int? Id { get; set; }
        public string? ViTriChucDanh { get; set; }
        public string? TenCongTy { get; set; }
        public string? PhuongThucCongViec { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool DangLamHienTai { get; set; }
        public string? MoTaCongViec { get; set; }
        public int ThuTu { get; set; }
    }

    public class HocVanSinhVienDto
    {
        public int? Id { get; set; }
        public string? TruongHoacKhoaHoc { get; set; }
        public string? BangCap { get; set; }
        public string? ThangNamTotNghiep { get; set; }
        public DateTime? NgayTotNghiep { get; set; }
        public string? MoTaChiTiet { get; set; }
        public int ThuTu { get; set; }
    }

    public class ChungChiSinhVienDto
    {
        public int? Id { get; set; }
        public string? TenChungChi { get; set; }
        public string? CapBoi { get; set; }
        public DateTime? NgayCap { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public bool KhongHetHan { get; set; }
        public int ThuTu { get; set; }
    }

    public class NgoaiNguSinhVienDto
    {
        public int? Id { get; set; }
        public string? TenNgoaiNgu { get; set; }
        public string? TrinhDo { get; set; }
        public string? ChungChiNgoaiNgu { get; set; }
        public int ThuTu { get; set; }
    }

    public class KyNangSinhVienDto
    {
        public int? Id { get; set; }
        public string? TenKyNang { get; set; }
        public string? MoTaKyNang { get; set; }
        public int MucDo { get; set; }
        public int ThuTu { get; set; }
    }

    public class HoatDongSinhVienDto
    {
        public int? Id { get; set; }
        public string? ToChuc { get; set; }
        public string? VaiTro { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool DangHoatDong { get; set; }
        public string? MoTaHoatDong { get; set; }
        public int ThuTu { get; set; }
    }

    public class NguoiThamChieuSinhVienDto
    {
        public int? Id { get; set; }
        public string HoVaTen { get; set; } = string.Empty;
        public string? ChucVu { get; set; }
        public string? CongTy { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public int ThuTu { get; set; }
    }
}
