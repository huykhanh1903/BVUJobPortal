using BVUJobPortal.DTOs;
using BVUJobPortal.Models;

namespace BVUJobPortal.Services.BaoCao
{
    public interface IBaoCaoService
    {
        Task<BaoCaoNoiDungDto> GuiBaoCaoAsync(int userId, BaoCaoNoiDungDto dto);
        Task<List<BaoCaoNoiDungDto>> DanhSachBaoCaoAsync();
        Task<BaoCaoNoiDungDto?> XuLyBaoCaoAsync(int id, string trangThai);
    }
}

