using BVUJobPortal.DTOs.SinhVien;

namespace BVUJobPortal.Services.SinhVien
{
    public interface ISinhVienProfileService
    {
        Task<SinhVienProfileDto?> GetAsync(int userId);
        Task<SinhVienProfileDto> UpsertAsync(int userId, SinhVienProfileDto dto);
        Task CapNhatTrangThaiTimViecAsync(int nguoiDungId,CapNhatTrangThaiTimViecDto dto);
    }
}
