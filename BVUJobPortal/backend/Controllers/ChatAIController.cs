using Microsoft.AspNetCore.Mvc;
using BVUJobPortal.Services.AI;
using BVUJobPortal.DTOs.AI;
using System.Security.Claims;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/ai")]
    public class AIController : ControllerBase
    {
        private readonly IAIService _ai;

        public AIController(IAIService ai)
        {
            _ai = ai;
        }

        [HttpPost("chat")]
        public async Task<IActionResult> Chat([FromBody] ChatRequestDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var ans = await _ai.AskAsync(dto.Message, userId);
            return Ok(new { reply = ans });
        }
    }
}
