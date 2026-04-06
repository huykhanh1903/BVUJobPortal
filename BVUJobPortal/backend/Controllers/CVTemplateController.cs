using BVUJobPortal.Models;
using BVUJobPortal.Services.CvModule;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class CVTemplateController : ControllerBase
    {
        private readonly ICVTemplateService _templateService;

        public CVTemplateController(ICVTemplateService templateService)
        {
            _templateService = templateService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> LayDanhSachTemplate()
        {
            var templates = await _templateService.LayDanhSachTemplateAsync();
            return Ok(templates);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> LayTemplateTheoId(int id)
        {
            var template = await _templateService.LayTemplateTheoIdAsync(id);
            if (template == null)
                return NotFound(new { ThongBao = "Không tìm thấy template" });
            return Ok(template);
        }

        [HttpPost("Tao-Template")]
        public async Task<IActionResult> CreateTemplate([FromBody] CVTemplate model)
        {
            await _templateService.ThemTemplateAsync(model);
            return Ok(new { ThongBao = "Đã thêm template mới" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTemplate(int id, [FromBody] CVTemplate model)
        {
            var ok = await _templateService.CapNhatTemplateAsync(id, model);
            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy template để cập nhật" });
            return Ok(new { ThongBao = "Đã cập nhật template thành công" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTemplate(int id)
        {
            var ok = await _templateService.XoaTemplateAsync(id);
            if (!ok)
                return NotFound(new { ThongBao = "Không tìm thấy template để xoá" });
            return Ok(new { ThongBao = "Đã xoá template" });
        }

    }
}
