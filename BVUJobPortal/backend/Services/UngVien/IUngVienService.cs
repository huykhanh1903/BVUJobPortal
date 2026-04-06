using BVUJobPortal.DTOs.UngVien;

namespace BVUJobPortal.Services.UngVien
{
    public interface IUngVienService
    {
        Task<List<UngVienDto>> TimUngVienAsync(TimUngVienDto dto);
        Task<List<UngVienDangTimViecDto>> LayDanhSachDangTimViecAsync();
        Task<UngVienChiTietDto?> LayChiTietUngVienAsync(int sinhVienId, int nhaTuyenDungId);
    }

}
