using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Data.Seed
{
    public static class LoaiCongViecSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiCongViec>().HasData(
                new LoaiCongViec { Id = 1, Ten = "Full-Time" },
                new LoaiCongViec { Id = 2, Ten = "Part-Time" }
            );
        }
    }
}