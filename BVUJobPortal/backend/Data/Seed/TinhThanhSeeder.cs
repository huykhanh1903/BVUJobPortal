using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BVUJobPortal.Data.Seed
{
    public static class TinhThanhSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TinhThanh>().HasData(
                new() { MaTinh = "HNI", TenTinh = "Thành phố Hà Nội" },
                new() { MaTinh = "HUE", TenTinh = "Thành phố Huế" },
                new() { MaTinh = "LCH", TenTinh = "Tỉnh Lai Châu" },
                new() { MaTinh = "DBN", TenTinh = "Tỉnh Điện Biên" },
                new() { MaTinh = "SLA", TenTinh = "Tỉnh Sơn La" },
                new() { MaTinh = "LSN", TenTinh = "Tỉnh Lạng Sơn" },
                new() { MaTinh = "QNI", TenTinh = "Tỉnh Quảng Ninh" },
                new() { MaTinh = "THA", TenTinh = "Tỉnh Thanh Hoá" },
                new() { MaTinh = "NAN", TenTinh = "Tỉnh Nghệ An" },
                new() { MaTinh = "HTH", TenTinh = "Tỉnh Hà Tĩnh" },
                new() { MaTinh = "CBG", TenTinh = "Tỉnh Cao Bằng" },
                new() { MaTinh = "TTQ", TenTinh = "Tỉnh Tuyên Quang" },
                new() { MaTinh = "LCA", TenTinh = "Tỉnh Lào Cai" },
                new() { MaTinh = "TNG", TenTinh = "Tỉnh Thái Nguyên" },
                new() { MaTinh = "PTO", TenTinh = "Tỉnh Phú Thọ" },
                new() { MaTinh = "BNH", TenTinh = "Tỉnh Bắc Ninh" },
                new() { MaTinh = "HYE", TenTinh = "Tỉnh Hưng Yên" },
                new() { MaTinh = "HPG", TenTinh = "Thành phố Hải Phòng" },
                new() { MaTinh = "NBI", TenTinh = "Tỉnh Ninh Bình" },
                new() { MaTinh = "QTR", TenTinh = "Tỉnh Quảng Trị" },
                new() { MaTinh = "DNG", TenTinh = "Thành phố Đà Nẵng" },
                new() { MaTinh = "QNG", TenTinh = "Tỉnh Quảng Ngãi" },
                new() { MaTinh = "GLI", TenTinh = "Tỉnh Gia Lai" },
                new() { MaTinh = "KHA", TenTinh = "Tỉnh Khánh Hoà" },
                new() { MaTinh = "LDG", TenTinh = "Tỉnh Lâm Đồng" },
                new() { MaTinh = "DLK", TenTinh = "Tỉnh Đắk Lắk" },
                new() { MaTinh = "HCM", TenTinh = "Thành phố Hồ Chí Minh" },
                new() { MaTinh = "DNI", TenTinh = "Tỉnh Đồng Nai" },
                new() { MaTinh = "TNI", TenTinh = "Tỉnh Tây Ninh" },
                new() { MaTinh = "CTO", TenTinh = "Thành phố Cần Thơ" },
                new() { MaTinh = "VLG", TenTinh = "Tỉnh Vĩnh Long" },
                new() { MaTinh = "DTP", TenTinh = "Tỉnh Đồng Tháp" },
                new() { MaTinh = "CMU", TenTinh = "Tỉnh Cà Mau" },
                new() { MaTinh = "AGG", TenTinh = "Tỉnh An Giang" }
            );
        }
    }
}
