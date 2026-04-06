using BVUJobPortal.DTOs.CV;
using BVUJobPortal.Services.CvModule;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/admin/cv-templates")]
    //[Authorize(Roles = "Admin,SuperAdmin")]
    public class AdminCVTemplateController : ControllerBase
    {
        private readonly ICVTemplateAdminService _svc;
        public AdminCVTemplateController(ICVTemplateAdminService svc) => _svc = svc;

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? keyword, [FromQuery] bool? published)
        {
            var data = await _svc.GetAllAsync(keyword, published);
            return Ok(data);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _svc.GetByIdAsync(id);
            return item == null ? NotFound(new { ThongBao = "Không tìm thấy template" }) : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CVTemplateCreateDto dto)
        {
            var id = await _svc.CreateAsync(dto);
            return Ok(new { ThongBao = "Đã thêm template mới", Id = id });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] CVTemplateUpdateDto dto)
        {
            var ok = await _svc.UpdateAsync(id, dto);
            return ok ? Ok(new { ThongBao = "Đã cập nhật template thành công" })
                      : NotFound(new { ThongBao = "Không tìm thấy template để cập nhật" });
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ok = await _svc.DeleteAsync(id);
            return ok ? Ok(new { ThongBao = "Đã xoá template" })
                      : NotFound(new { ThongBao = "Không tìm thấy template để xoá" });
        }

        [HttpPatch("{id:int}/publish")]
        public async Task<IActionResult> SetPublish(int id, [FromQuery] bool isPublished = true)
        {
            var ok = await _svc.SetPublishAsync(id, isPublished);
            return ok ? Ok(new { ThongBao = isPublished ? "Đã public template" : "Đã ẩn template" })
                      : NotFound(new { ThongBao = "Không tìm thấy template" });
        }
    }
}