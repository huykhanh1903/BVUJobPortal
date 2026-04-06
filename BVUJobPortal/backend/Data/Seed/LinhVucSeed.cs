using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Data.Seed
{
    public static class LinhVucSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LinhVuc>().HasData(
                new LinhVuc { Id = 1, TenLinhVuc = "Kinh Doanh - Bán hàng", MoTa = "Các công việc liên quan đến bán hàng, quản lý kinh doanh, chăm sóc khách hàng, phát triển thị trường." },
                new LinhVuc { Id = 2, TenLinhVuc = "Marketing - PR - Quảng cáo", MoTa = "Xây dựng thương hiệu, truyền thông, digital marketing, nghiên cứu thị trường và chiến lược quảng bá." },
                new LinhVuc { Id = 3, TenLinhVuc = "Chăm sóc khách hàng (Customer Service) - Vận hành", MoTa = "Hỗ trợ khách hàng, xử lý dịch vụ, vận hành hệ thống và quy trình doanh nghiệp." },
                new LinhVuc { Id = 4, TenLinhVuc = "Nhân sự - Hành chính - Pháp chế", MoTa = "Quản lý nhân sự, tuyển dụng, đào tạo, hành chính văn phòng và tuân thủ pháp lý." },
                new LinhVuc { Id = 5, TenLinhVuc = "Công nghệ Thông tin", MoTa = "Phát triển phần mềm, hệ thống mạng, quản trị dữ liệu, an ninh mạng và hỗ trợ kỹ thuật CNTT." },
                new LinhVuc { Id = 6, TenLinhVuc = "Lao động phổ thông", MoTa = "Công việc không yêu cầu bằng cấp cao, công nhân sản xuất, lao động trong nhà máy/xí nghiệp." },
                new LinhVuc { Id = 7, TenLinhVuc = "Tài chính - Ngân hàng - Bảo hiểm", MoTa = "Tư vấn tài chính, giao dịch ngân hàng, phân tích rủi ro, thẩm định đầu tư và bảo hiểm." },
                new LinhVuc { Id = 8, TenLinhVuc = "Bất động sản", MoTa = "Tư vấn, môi giới nhà đất, quản lý dự án, đầu tư và phát triển bất động sản." },
                new LinhVuc { Id = 9, TenLinhVuc = "Xây dựng", MoTa = "Thiết kế, giám sát và thi công công trình dân dụng/ công nghiệp, quản lý dự án xây dựng." },
                new LinhVuc { Id = 10, TenLinhVuc = "Kế toán - Kiểm toán - Thuế", MoTa = "Ghi nhận tài chính, lập báo cáo, kiểm toán, tư vấn thuế và tuân thủ các chuẩn mực kế toán." },
                new LinhVuc { Id = 11, TenLinhVuc = "Sản xuất", MoTa = "Vận hành dây chuyền sản xuất, quản lý vật tư, kiểm soát chất lượng và quy trình sản xuất." },
                new LinhVuc { Id = 12, TenLinhVuc = "Giáo dục - Đào tạo", MoTa = "Giảng dạy, hướng dẫn kỹ năng, nghiên cứu giáo dục và phát triển chương trình đào tạo." },
                new LinhVuc { Id = 13, TenLinhVuc = "Bán lẻ - Dịch vụ đời sống", MoTa = "Các hoạt động bán lẻ, siêu thị, dịch vụ chăm sóc và đáp ứng nhu cầu đời sống hàng ngày." },
                new LinhVuc { Id = 14, TenLinhVuc = "Phim và truyền hình - Báo chí - Xuất bản", MoTa = "Sản xuất nội dung đa phương tiện, biên tập, truyền tải thông tin và xuất bản." },
                new LinhVuc { Id = 15, TenLinhVuc = "Điện - Điện tử - Viễn thông", MoTa = "Thiết kế và vận hành hệ thống điện, bảo trì thiết bị điện tử và mạng lưới viễn thông." },
                new LinhVuc { Id = 16, TenLinhVuc = "Logistics - Thu mua - Kho - Vận tải", MoTa = "Chuỗi cung ứng, quản lý kho bãi, vận tải hàng hóa và thu mua vật tư doanh nghiệp." },
                new LinhVuc { Id = 17, TenLinhVuc = "Tư vấn chuyên môn", MoTa = "Cung cấp giải pháp chuyên môn, tư vấn chiến lược và hỗ trợ nghiệp vụ cho doanh nghiệp." },
                new LinhVuc { Id = 18, TenLinhVuc = "Dược - Y tế - Sức khoẻ - Công nghệ sinh học", MoTa = "Khám chữa bệnh, phát triển dược phẩm, xét nghiệm và nghiên cứu chăm sóc sức khỏe." },
                new LinhVuc { Id = 19, TenLinhVuc = "Thiết kế", MoTa = "Thiết kế đồ họa, UI/UX, thiết kế sản phẩm, không gian và sáng tạo nghệ thuật." },
                new LinhVuc { Id = 20, TenLinhVuc = "Du lịch - Nhà hàng - Khách sạn", MoTa = "Dịch vụ lưu trú, ẩm thực, tổ chức tour và chăm sóc trải nghiệm khách du lịch." },
                new LinhVuc { Id = 21, TenLinhVuc = "Năng lượng - Môi trường - Nông nghiệp", MoTa = "Phát triển năng lượng, quản lý môi trường bền vững và sản xuất nông nghiệp/vật nuôi." },
                new LinhVuc { Id = 22, TenLinhVuc = "Tài xế", MoTa = "Lái xe cá nhân, taxi, vận tải hàng hóa và điều phối phương tiện giao thông." },
                new LinhVuc { Id = 23, TenLinhVuc = "Biên phiên dịch", MoTa = "Dịch thuật tài liệu, thông dịch hội thoại và hỗ trợ giao tiếp đa ngôn ngữ." },
                new LinhVuc { Id = 24, TenLinhVuc = "Luật", MoTa = "Tư vấn pháp lý, đại diện pháp luật, giải quyết tranh chấp và tuân thủ quy định." },
                new LinhVuc { Id = 25, TenLinhVuc = "Ngành nghề khác", MoTa = "Các vị trí và công việc thuộc các ngành nghề khác không nằm trong các danh mục đã liệt kê." }
            );
        }
    }
}