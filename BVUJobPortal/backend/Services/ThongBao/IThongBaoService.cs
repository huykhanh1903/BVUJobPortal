using BVUJobPortal.DTOs.ThongBao;

namespace BVUJobPortal.Services.ThongBao
{
    public interface IThongBaoService
    {
        Task<List<ThongBaoDto>> LayThongBaoAsync(int userId);
        Task<ThongBaoDto> GuiThongBaoAsync(
            int userId,
            string tieuDe,
            string noiDung,
            string? url = null,
            string loai = "HeThong"
        );
        Task<bool> DanhDauDaDocAsync(int thongBaoId, int userId);

        Task<int> DemThongBaoChuaDocAsync(int userId);
    }
}
