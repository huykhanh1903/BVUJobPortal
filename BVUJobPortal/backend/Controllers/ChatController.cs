using BVUJobPortal.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Controllers
{
    [ApiController]
    [Route("api/chat")]
    [Authorize(Roles = "SinhVien,NhaTuyenDung,DoanhNghiep")]
    public class ChatController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ChatController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("messages")]
        public async Task<IActionResult> GetUserMessages()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var msgs = await _context.ChatMessages
                .Where(x => x.SenderId == userId || x.ReceiverId == userId)
                .OrderBy(x => x.Timestamp)
                .ToListAsync();

            return Ok(msgs);
        }
    }

}
