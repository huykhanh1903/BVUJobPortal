using BVUJobPortal.DTOs.CV;
using BVUJobPortal.Services.CvModule;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CVController : ControllerBase
    {
        private readonly ICVService _cvService;

        public CVController(ICVService cvService)
        {
            _cvService = cvService;
        }

        private int GetUserId()
        {
            var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(userIdStr!);
        }

        [HttpPost("tao")]
        public async Task<IActionResult> TaoCV([FromBody] CVDto model)
        {
            var userId = GetUserId();
            var cv = await _cvService.TaoCVAsync(userId, model);
            return Ok(new { ThongBao = "CV đã được tạo", CV = cv });
        }

        [HttpGet("list")]
        public async Task<IActionResult> DanhSachCV()
        {
            var userId = GetUserId();
            var cvs = await _cvService.LayDanhSachCVAsync(userId);
            return Ok(cvs);
        }

        [HttpGet("{cvId}")]
        public async Task<IActionResult> XemCV(int cvId)
        {
            var userId = GetUserId();
            var cv = await _cvService.LayCVAsync(userId, cvId);
            if (cv == null)
                return NotFound(new { ThongBao = "Không tìm thấy CV" });
            return Ok(cv);
        }

        [HttpPut("{cvId}")]
        public async Task<IActionResult> CapNhatCV(int cvId, [FromBody] CVDto dto)
        {
            var userId = GetUserId();

            var result = await _cvService.CapNhatCVAsync(userId, cvId, dto);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{cvId}")]
        public async Task<IActionResult> XoaCV(int cvId)
        {
            var userId = GetUserId();
            var ok = await _cvService.XoaCVAsync(userId, cvId);
            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy CV để xoá" });

            return Ok(new { ThongBao = "Đã xoá CV" });
        }

        [HttpGet("{cvId}/tai-pdf")]
        public async Task<IActionResult> TaiCVPdf(int cvId)
        {
            var userId = GetUserId();
            try
            {
                var pdfBytes = await _cvService.XuatCVPdfAsync(userId, cvId);
                return File(pdfBytes, "application/pdf", $"CV-{cvId}.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(new { ThongBao = ex.Message });
            }
        }

        [HttpGet("{id}/export-template")]
        public async Task<IActionResult> ExportTemplateCV(int id)
        {
            var userId = GetUserId();
            var pdf = await _cvService.XuatCVTheoTemplatePdfAsync(userId, id);

            return File(pdf, "application/pdf", $"cv-{id}.pdf");
        }

        [HttpPost("export-html")]
        public async Task<IActionResult> ExportHtml([FromBody] ExportHtmlPdfDto dto)
        {
            try
            {
                var pdf = await _cvService.XuatTemplatePdfAsync(dto);
                return File(pdf, "application/pdf", "cv-export.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        //private int GetUserIdFromToken()
        //{
        //    // 1. Ưu tiên claim "sub"
        //    var sub = User.FindFirst("sub")?.Value;
        //    if (!string.IsNullOrEmpty(sub))
        //        return int.Parse(sub);

        //    // 2. fallback: ClaimTypes.NameIdentifier
        //    var nameId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        //    if (!string.IsNullOrEmpty(nameId))
        //        return int.Parse(nameId);

        //    // 3. fallback: claim "id"
        //    var id = User.FindFirst("id")?.Value;
        //    if (!string.IsNullOrEmpty(id))
        //        return int.Parse(id);

        //    throw new Exception("Token không chứa userId hợp lệ!");
        //}



    }
}
