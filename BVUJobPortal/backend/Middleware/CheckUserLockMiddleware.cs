using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using BVUJobPortal.Data;


namespace BVUJobPortal.Middleware
{
    public class CheckUserLockMiddleware
    {
        private readonly RequestDelegate _next;

        public CheckUserLockMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ApplicationDbContext db)
        {
            if (context.Request.Path.StartsWithSegments("/api/khieu-nai"))
            {
                await _next(context);
                return;
            }
            if (context.User.Identity?.IsAuthenticated == true)
            {
                var userId = int.Parse(context.User.FindFirstValue(ClaimTypes.NameIdentifier)!);
                var user = await db.NguoiDungs.FirstOrDefaultAsync(u => u.Id == userId);

                if (user != null && user.BiKhoa)
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsJsonAsync(new
                    {
                        ThongBao = "Tài khoản đã bị khóa",
                        LyDo = user.LyDoKhoa ?? "Không có lý do"
                    });
                    return;
                }
            }

            await _next(context);
        }
    }
}
