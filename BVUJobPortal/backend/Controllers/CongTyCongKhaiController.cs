using BVUJobPortal.Services.DoanhNghiep;
using Microsoft.AspNetCore.Mvc;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/cong-ty")]
    public class CongTyCongKhaiController : ControllerBase
    {
        private readonly IDoanhNghiepService _service;

        public CongTyCongKhaiController(IDoanhNghiepService service)
        {
            _service = service;
        }

        [HttpGet("{id}/ho-so")]
        public async Task<IActionResult> LayHoSoCongTy(int id)
        {
            var result = await _service.LayHoSoCongTyAsync(id);
            return result != null ? Ok(result) : NotFound();
        }
    }

}
