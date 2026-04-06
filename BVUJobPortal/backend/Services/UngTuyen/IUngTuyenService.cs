using BVUJobPortal.DTOs.UngTuyen;
using BVUJobPortal.Models;

namespace BVUJobPortal.Services.UngTuyen
{
    public interface IUngTuyenService
    {
        Task<(DonUngTuyenDto? Don, string? Error)> UngTuyenAsync(int userId, UngTuyenDto dto);
        Task<List<DonUngTuyenDto>> DanhSachUngTuyenAsync(int userId);
        Task<List<DonUngTuyenDto>> LichSuUngTuyenAsync(int userId);
        Task<List<DonUngTuyenDto>> DanhSachDonChoNhaTuyenDungAsync(int nhaTuyenDungId);
        Task<DonUngTuyenDto?> ChiTietDonChoNhaTuyenDungAsync(int nhaTuyenDungId, int donId);
        Task<(bool Success, string Message)> DuyetDonAsync(int nhaTuyenDungId, int donId);

        Task<(bool Success, string Message)> TuChoiDonAsync(int nhaTuyenDungId, int donId);
        Task<(int? CvId, string? CvFileUrl, int UngVienId)?> GetCvInfoAsync(int nhaTuyenDungId, int donId);
    }

}
