using BVUJobPortal.DTOs.CongTy;
using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.DTOs.DoanhNghiep;

public interface IDoanhNghiepService
{
    Task<HRResponseDto?> TaoHRAsync(int adminCongTyId, TaoHRDto dto);
    Task<HRChiTietDto?> ChiTietHRAsync(int adminCongTyId, int hrId);
    Task<bool> GuiYeuCauXacThucHRAsync(int hrId, XinXacThucHRDto dto);
    Task<bool> XacThucHRAsync(int adminCongTyId, XacThucHRDto dto);
    Task<List<HRResponseDto>> DanhSachHRChoXacThucAsync(int adminCongTyId);
    Task<List<HRResponseDto>> DanhSachHRDaXacThucAsync(int adminCongTyId);
    Task<bool> HuyXacThucHRAsync(int adminCongTyId, HuyXacThucHRDto dto);
    Task<CongTyDto?> LayThongTinCongTyAsync(int congTyId);
    Task<List<CongViecThuocCongTyDto>> LayJobTheoCongTyAsync(int congTyId);
    Task<HoSoCongTyDto?> LayHoSoCongTyAsync(int congTyId);
    Task<bool> CongTyDuyetCongViecAsync(int adminCongTyId, CongTyDuyetCongViecDto dto);
    Task<bool> TuChoiDuyetCongViecAsync(int adminCongTyId, TuChoiDuyetCongViecDto dto);
    Task<List<CongViecDto>> DanhSachCongViecChoDuyetAsync(int adminCongTyId);
    Task<List<CongViecDto>> DanhSachCongViecDaDuyetAsync(int adminCongTyId);
}
