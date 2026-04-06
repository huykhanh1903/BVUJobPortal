using BVUJobPortal.DTOs.CV;

namespace BVUJobPortal.Services.CvModule
{
    public interface ICVService
    {
        Task<CVDto> TaoCVAsync(int userId, CVDto dto);
        Task<CVDto?> LayCVAsync(int userId, int cvId);
        Task<List<CVDto>> LayDanhSachCVAsync(int userId);
        Task<CVDto?> CapNhatCVAsync(int userId, int cvId, CVDto dto);
        Task<bool> XoaCVAsync(int userId, int cvId);
        Task<byte[]> XuatCVPdfAsync(int userId, int cvId);
        Task<byte[]> XuatTemplatePdfAsync(ExportHtmlPdfDto dto);
        Task<byte[]> XuatCVTheoTemplatePdfAsync(int userId, int cvId);
    }
}
