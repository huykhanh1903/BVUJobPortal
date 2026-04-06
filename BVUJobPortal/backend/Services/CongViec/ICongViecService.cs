using BVUJobPortal.DTOs.CongViec;

namespace BVUJobPortal.Services.CongViec
{
    public interface ICongViecService
    {
        Task<CongViecDto?> DangTuyenAsync(int nhaTuyenDungId, DangTuyenDto dto);
        Task<CongViecDto?> CapNhatCongViecAsync(int congViecId, int userId, CapNhatCongViecDto dto);
        Task<bool> XoaCongViecAsync(int congViecId, int userId);
        Task<List<CongViecDto>> DanhSachDangTuyenAsync(int nhaTuyenDungId);

        //Task<List<CongViecDto>> TimKiemCongViecAsync(CongViecSearchDto filter);
        Task<CongViecChiTietDto?> LayChiTietCongViecAsync(int id);

        Task<List<CongViecDto>> DanhSachTatCaAsync();
        Task<CongViecDto?> BuildCongViecDto(int id);
    }
}
