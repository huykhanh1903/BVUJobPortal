using BVUJobPortal.DTOs.DiaChi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BVUJobPortal.Services.DiaChi
{
    public interface IDiaChiService
    {
        Task<List<TinhThanhDto>> DanhSachTinhThanhAsync();
        Task<TinhThanhDto?> TaoTinhThanhAsync(TinhThanhDto dto);
    }
}
