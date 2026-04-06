using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Data.Seed
{
    public static class MucKinhNghiemSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MucKinhNghiem>().HasData(
                new MucKinhNghiem { Id = 1, Ten = "Chưa kinh nghiệm" },
                new MucKinhNghiem { Id = 2, Ten = "Dưới 1 năm" },
                new MucKinhNghiem { Id = 3, Ten = "1-3 năm" }
            );
        }
    }
}