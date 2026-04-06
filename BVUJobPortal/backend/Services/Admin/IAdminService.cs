using BVUJobPortal.DTOs;
using BVUJobPortal.DTOs.Admin;
using BVUJobPortal.DTOs.Chung;
using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.DTOs.TaiKhoan;

namespace BVUJobPortal.Services.Admin
{
    public interface IAdminService
    {
        Task<TaiKhoanDto?> TaoNguoiDungTheoVaiTroAsync(AdminCapNhatNguoiDungDto dto, string vaiTro);
        Task<AdminNhaTuyenDungDto?> TaoNhaTuyenDungAsync(AdminNhaTuyenDungDto dto);
        Task<object> TaoTaiKhoanCongTyAsync(AdminTaoTaiKhoanCongTyDto dto);

        Task<TaiKhoanDto?> CapNhatNguoiDungAsync(int id, AdminCapNhatNguoiDungDto dto);
        Task<KetQuaPhanTrang<TaiKhoanDto>> DanhSachNguoiDungAsync(int trang = 1, int soLuongMoiTrang = 10,
            string sapXepTheo = "NgayTao", string thuTu = "desc", string? vaiTro = null,
            DateTime? tuNgay = null, DateTime? denNgay = null, bool? biKhoa = null);

        Task<KetQuaPhanTrang<AdminCapNhatNguoiDungDto>> TimKiemNguoiDungAsync(
            string tuKhoa, int trang = 1, int soLuongMoiTrang = 10);

        Task<object?> LayThongTinNguoiDungTheoIdAsync(int id);
        Task<bool> KhoaNguoiDungAsync(int id, string lyDo);
        Task<bool> MoKhoaNguoiDungAsync(int id);
        Task<bool> XoaNguoiDungAsync(int id);

        Task<List<AdminCongTyDto>> DanhSachCongTyAsync();
        Task<AdminCongTyDto?> LayChiTietCongTyAsync(int id);
        Task<AdminCongTyDto?> TaoCongTyAsync(AdminCongTyDto dto);
        Task<AdminCongTyDto?> CapNhatCongTyAsync(int id, AdminCongTyDto dto);
        Task<bool> XoaCongTyAsync(int id);


        Task<List<CongViecDto>> DanhSachCongViecAsync();
        Task<List<CongViecDto>> LayCongViecTheoCongTyAsync(int congTyId);
        Task<bool> DuyetCongViecAsync(int congViecId, int adminId);
        Task<bool> HuyDuyetCongViecAsync(int congViecId);
        Task<CongViecDto?> CapNhatCongViecAsync(int id, AdminCapNhatCongViecDto dto);
        Task<bool> XoaCongViecAsync(int id);

        Task<List<AdminLinhVucDto>> DanhSachLinhVucAsync();
        Task<AdminLinhVucDto?> TaoLinhVucAsync(AdminLinhVucDto dto);
        Task<AdminLinhVucDto?> CapNhatLinhVucAsync(int id, AdminLinhVucDto dto);
        Task<bool> XoaLinhVucAsync(int id);

        Task<List<AdminNgheNghiepDto>> DanhSachNgheNghiepAsync();
        Task<List<AdminNgheNghiepDto>> LayNgheTheoLinhVucAsync(int linhVucId);
        Task<AdminNgheNghiepDto?> TaoNgheNghiepAsync(AdminNgheNghiepDto dto);
        Task<AdminNgheNghiepDto?> CapNhatNgheNghiepAsync(int id, AdminNgheNghiepDto dto);
        Task<bool> XoaNgheNghiepAsync(int id);

        Task<List<AdminChuyenNganhDto>> DanhSachChuyenNganhAsync();
        Task<List<AdminChuyenNganhDto>> LayChuyenNganhTheoNgheAsync(int ngheId);
        Task<AdminChuyenNganhDto?> TaoChuyenNganhAsync(AdminChuyenNganhDto dto);
        Task<AdminChuyenNganhDto?> CapNhatChuyenNganhAsync(int id, AdminChuyenNganhDto dto);
        Task<bool> XoaChuyenNganhAsync(int id);

        Task<List<AdminMucKinhNghiemDto>> LayDanhSachMucKinhNghiemAsync();
        Task<AdminMucKinhNghiemDto> TaoMucKinhNghiemAsync(AdminMucKinhNghiemDto dto);
        Task<AdminMucKinhNghiemDto> CapNhatMucKinhNghiemAsync(int id, AdminMucKinhNghiemDto dto);
        Task<bool> XoaMucKinhNghiemAsync(int id);

        Task<List<AdminLoaiCongViecDto>> LayDanhSachLoaiCongViecAsync();
        Task<AdminLoaiCongViecDto?> TaoLoaiCongViecAsync(AdminLoaiCongViecDto dto);
        Task<AdminLoaiCongViecDto?> CapNhatLoaiCongViecAsync(int id, AdminLoaiCongViecDto dto);
        Task<bool> XoaLoaiCongViecAsync(int id);

        Task<List<AdminCapBacDto>> LayDanhSachCapBacAsync();
        Task<AdminCapBacDto?> TaoCapBacAsync(AdminCapBacDto dto);
        Task<AdminCapBacDto?> CapNhatCapBacAsync(int id, AdminCapBacDto dto);
        Task<bool> XoaCapBacAsync(int id);

        Task<bool> TaoThongBaoAsync(AdminGuiThongBaoDto dto, int adminId);
        Task<bool> GuiThongBaoTheoVaiTroAsync(AdminGuiThongBaoDto dto);
        Task<bool> GuiThongBaoToanHeThongAsync(AdminGuiThongBaoDto dto);
        Task<List<AdminThongBaoDto>> DanhSachThongBaoAsync();
        Task<ThongKeDto> ThongKeHeThongAsync();
    }
}