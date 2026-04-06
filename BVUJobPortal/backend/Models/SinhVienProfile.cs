using BVUJobPortal.Models;
using BVUJobPortal.Models.SinhVien;

public class SinhVienProfile
{
    public int Id { get; set; }
    public int NguoiDungId { get; set; }
    public NguoiDung? NguoiDung { get; set; }
    public bool DangTimViec { get; set; } = true;
    public bool ChoPhepNhaTuyenDungTim { get; set; } = true;

    public string? GioiTinh { get; set; }
    public DateTime? NgaySinh { get; set; }
    public int? TinhThanhId { get; set; }
    public TinhThanh? TinhThanh { get; set; }
    public string? DiaChi { get; set; }
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

    public List<KinhNghiemSinhVien>? KinhNghiems { get; set; }
    public List<HocVanSinhVien>? HocVans { get; set; }
    public List<ChungChiSinhVien>? ChungChis { get; set; }
    public List<NgoaiNguSinhVien>? NgoaiNgus { get; set; }
    public List<KyNangSinhVien>? KyNangs { get; set; }
    public List<HoatDongSinhVien>? HoatDongs { get; set; }
    public List<NguoiThamChieuSinhVien>? NguoiThamChieus { get; set; }
    public string? ThanhTichNoiBat { get; set; }
}
