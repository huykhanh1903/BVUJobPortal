using BVUJobPortal.Data;
using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Services.System
{
    public class SystemConfigService
    {
        private readonly ApplicationDbContext _context;

        public SystemConfigService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsAiEnabledAsync()
        {
            var config = await _context.HeThongCauHinhs
                .FirstOrDefaultAsync(x => x.Key == "EnableAI");

            if (config == null)
            {
                config = new HeThongCauHinh
                {
                    Key = "EnableAI",
                    Value = "true"
                };

                _context.HeThongCauHinhs.Add(config);
                await _context.SaveChangesAsync();
            }

            return config.Value == "true";
        }

        public async Task SetAiStateAsync(bool enable)
        {
            var config = await _context.HeThongCauHinhs
                .FirstOrDefaultAsync(x => x.Key == "EnableAI");

            if (config == null)
            {
                config = new HeThongCauHinh
                {
                    Key = "EnableAI",
                    Value = enable ? "true" : "false"
                };

                _context.HeThongCauHinhs.Add(config);
            }
            else
            {
                config.Value = enable ? "true" : "false";
            }

            await _context.SaveChangesAsync();
        }
    }
}
