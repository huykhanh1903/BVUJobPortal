using BVUJobPortal.DTOs.Admin;
using BVUJobPortal.DTOs.CongTy;
using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.DTOs.TuKhoa;

namespace BVUJobPortal.Services.TuKhoa
{
    public interface ITuKhoaService
    {
        Task LuuTuKhoaAsync(string tuKhoa);
        Task<List<TuKhoaThongKeDto>> LayTopTuKhoaHeThongAsync(int top = 10);
        Task<List<TuKhoaThongKeDto>> LayTopTuKhoaTheoLinhVucAsync(int linhVucId, int top = 10);
        Task<List<TuKhoaThongKeDto>> LayTopTuKhoaTheoNganhNgheAsync(int nganhNgheId, int top = 10);
        Task<List<TuKhoaThongKeDto>> LayTopTuKhoaTheoChuyenNganhAsync(int chuyenNganhId, int top = 10);
        Task<List<AdminCongTyDto>> TimKiemCongTyAsync(CongTySearchDto filter);
        Task<List<CongViecDto>> TimKiemCongViecAsync(CongViecSearchDto filter);
    }
}
