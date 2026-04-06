using BVUJobPortal.DTOs.KhieuNais;
using BVUJobPortal.Models;

namespace BVUJobPortal.Services
{
    public interface IKhieuNaiService
    {
        Task GuiKhieuNaiAsync(int nguoiDungId, GuiKhieuNaiDto dto);
        Task<List<KhieuNai>> DanhSachAsync();
        Task XuLyAsync(int id, XuLyKhieuNaiDto dto, int adminId);
    }
}
