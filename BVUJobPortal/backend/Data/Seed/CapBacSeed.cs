using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Data.Seed
{
    public static class CapBacSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CapBac>().HasData(
                new CapBac { Id = 1, Ten = "Nhân viên" },
                new CapBac { Id = 2, Ten = "Trưởng nhóm" },
                new CapBac { Id = 3, Ten = "Quản lý" },
                new CapBac { Id = 4, Ten = "Giám đốc" },
                new CapBac { Id = 5, Ten = "Phó giám đốc" },
                new CapBac { Id = 6, Ten = "Thực tập sinh" },
                new CapBac { Id = 7, Ten = "Khác" }
            );
        }
    }
}