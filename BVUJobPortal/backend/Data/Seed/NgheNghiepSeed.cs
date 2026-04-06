using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Data.Seed
{
    public static class NgheNghiepSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NgheNghiep>().HasData(
                //Linh vuc 1: Kinh Doanh - Bán hàng
                new NgheNghiep { Id = 1, TenNghe = "Sales Xuất nhập khẩu/Logistics", MoTa = "Kinh doanh dịch vụ logistics, vận tải và xuất nhập khẩu.", LinhVucId = 1 },
                new NgheNghiep { Id = 2, TenNghe = "Sales Bất động sản", MoTa = "Tư vấn, môi giới và kinh doanh sản phẩm/dịch vụ bất động sản.", LinhVucId = 1 },
                new NgheNghiep { Id = 3, TenNghe = "Sales Xây dựng", MoTa = "Kinh doanh thiết bị, vật tư và dịch vụ trong ngành xây dựng.", LinhVucId = 1 },
                new NgheNghiep { Id = 4, TenNghe = "Sales Giáo dục - Khoá học", MoTa = "Tư vấn khoá học, tuyển sinh và kinh doanh dịch vụ giáo dục.", LinhVucId = 1 },
                new NgheNghiep { Id = 5, TenNghe = "Sales Admin - Sales Support", MoTa = "Hỗ trợ kinh doanh, xử lý đơn hàng và vận hành bán hàng.", LinhVucId = 1 },
                new NgheNghiep { Id = 6, TenNghe = "Sales Tài chính - Ngân hàng - Bảo hiểm", MoTa = "Tư vấn tài chính, tín dụng, bảo hiểm và sản phẩm ngân hàng.", LinhVucId = 1 },
                new NgheNghiep { Id = 7, TenNghe = "Sales Bán lẻ - Dịch vụ tiêu dùng", MoTa = "Kinh doanh sản phẩm bán lẻ, FMCG và dịch vụ tiêu dùng.", LinhVucId = 1 },
                new NgheNghiep { Id = 8, TenNghe = "Sales Sản xuất", MoTa = "Kinh doanh sản phẩm công nghiệp, sản xuất và phụ tùng.", LinhVucId = 1 },
                new NgheNghiep { Id = 9, TenNghe = "Sales Kỹ thuật (Sales Engineer)", MoTa = "Kinh doanh thiết bị kỹ thuật, phần mềm và giải pháp công nghệ.", LinhVucId = 1 },
                new NgheNghiep { Id = 10, TenNghe = "Sales Nhà hàng - Khách sạn - Du lịch", MoTa = "Kinh doanh phòng khách sạn, tour và dịch vụ F&B.", LinhVucId = 1 },
                new NgheNghiep { Id = 11, TenNghe = "Sales Dược - Y tế - Sức khoẻ - Làm đẹp", MoTa = "Kinh doanh thuốc, thiết bị y tế và dịch vụ chăm sóc sắc đẹp.", LinhVucId = 1 },
                new NgheNghiep { Id = 12, TenNghe = "Sales IT Phần mềm", MoTa = "Kinh doanh phần mềm, hosting, server và giải pháp CNTT.", LinhVucId = 1 },
                new NgheNghiep { Id = 13, TenNghe = "Sales Điện - Điện tử - Viễn thông", MoTa = "Kinh doanh thiết bị điện, điện tử, viễn thông và công nghiệp.", LinhVucId = 1 },
                new NgheNghiep { Id = 14, TenNghe = "Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện", MoTa = "Kinh doanh dịch vụ quảng cáo, media, event và triển lãm.", LinhVucId = 1 },
                new NgheNghiep { Id = 15, TenNghe = "Sales Thương mại điện tử", MoTa = "Kinh doanh trên sàn thương mại điện tử và vận hành cửa hàng online.", LinhVucId = 1 },
                new NgheNghiep { Id = 16, TenNghe = "Quản lý kinh doanh", MoTa = "Quản lý đội ngũ kinh doanh, xây dựng chiến lược và vận hành bán hàng.", LinhVucId = 1 },
                new NgheNghiep { Id = 17, TenNghe = "Kinh doanh - Bán hàng khác", MoTa = "Các nghề kinh doanh và bán hàng khác không thuộc nhóm cụ thể.", LinhVucId = 1 },


                //Lĩnh vực 2: Marketing - PR - Quảng cáo
                new NgheNghiep { Id = 18, TenNghe = "Marketing", MoTa = "Triển khai chiến dịch marketing, phát triển thương hiệu và nội dung truyền thông.", LinhVucId = 2 },
                new NgheNghiep { Id = 19, TenNghe = "Quảng cáo - Sáng tạo", MoTa = "Sáng tạo nội dung, sản xuất media và triển khai chiến dịch quảng cáo.", LinhVucId = 2 },
                new NgheNghiep { Id = 20, TenNghe = "Quan hệ Công chúng", MoTa = "Xây dựng hình ảnh doanh nghiệp, PR, truyền thông và xử lý khủng hoảng.", LinhVucId = 2 },
                new NgheNghiep { Id = 21, TenNghe = "Quan hệ Chính phủ", MoTa = "Làm việc với cơ quan Nhà nước, chính sách và đối ngoại doanh nghiệp.", LinhVucId = 2 },
                new NgheNghiep { Id = 22, TenNghe = "Market Research and Analysis", MoTa = "Phân tích dữ liệu, nghiên cứu thị trường và hành vi người tiêu dùng.", LinhVucId = 2 },
                new NgheNghiep { Id = 23, TenNghe = "Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện", MoTa = "Kinh doanh dịch vụ quảng cáo, truyền thông, sự kiện và triển lãm.", LinhVucId = 2 },
                new NgheNghiep { Id = 24, TenNghe = "Marketing-PR-Quảng cáo khác", MoTa = "Các công việc khác liên quan đến marketing, PR và quảng cáo.", LinhVucId = 2 },


                //Lĩnh vực 3: Chăm sóc khách hàng (Customer Service) - Vận hành
                new NgheNghiep { Id = 25, TenNghe = "Chăm sóc khách hàng (Customer Service)", MoTa = "Hỗ trợ khách hàng, xử lý yêu cầu, cải thiện trải nghiệm và duy trì quan hệ khách hàng.", LinhVucId = 3 },
                new NgheNghiep { Id = 26, TenNghe = "Vận hành Thương mại điện tử", MoTa = "Quản lý đơn hàng, gian hàng, sản phẩm và vận hành hoạt động TMĐT.", LinhVucId = 3 },
                new NgheNghiep { Id = 27, TenNghe = "Business Operation (Vận hành kinh doanh)", MoTa = "Quản lý quy trình, dữ liệu và vận hành các hoạt động kinh doanh.", LinhVucId = 3 },
                new NgheNghiep { Id = 28, TenNghe = "Quản lý vận hành", MoTa = "Điều phối và quản lý hoạt động vận hành của doanh nghiệp.", LinhVucId = 3 },
                new NgheNghiep { Id = 29, TenNghe = "Dịch vụ khách hàng - Vận hành khác", MoTa = "Các công việc khác liên quan đến chăm sóc khách hàng và vận hành.", LinhVucId = 3 },

                //Lĩnh vực 4: Nhân sự - Hành chính - Pháp chế
                new NgheNghiep { Id = 30, TenNghe = "Nhân sự (Human Resources)", MoTa = "Tuyển dụng, đào tạo, C&B, quan hệ lao động và phát triển tổ chức.", LinhVucId = 4 },
                new NgheNghiep { Id = 31, TenNghe = "Hành chính Văn phòng", MoTa = "Quản lý hồ sơ, văn thư, lễ tân, hậu cần và hỗ trợ vận hành văn phòng.", LinhVucId = 4 },
                new NgheNghiep { Id = 32, TenNghe = "Dịch vụ pháp chế (In-house)", MoTa = "Soạn thảo hợp đồng, tư vấn pháp lý và đảm bảo tuân thủ pháp luật trong doanh nghiệp.", LinhVucId = 4 },
                new NgheNghiep { Id = 33, TenNghe = "Nhân sự - Hành chính - Pháp chế khác", MoTa = "Các vị trí khác thuộc nhóm nhân sự, hành chính và pháp chế.", LinhVucId = 4 },

                //Lĩnh vực 5: Công nghệ Thông tin
                new NgheNghiep { Id = 34, TenNghe = "Software Engineering", MoTa = "Phát triển phần mềm, lập trình ứng dụng và xây dựng hệ thống.", LinhVucId = 5 },
                new NgheNghiep { Id = 35, TenNghe = "Software Testing", MoTa = "Kiểm thử phần mềm, đảm bảo chất lượng và tự động hóa kiểm thử.", LinhVucId = 5 },
                new NgheNghiep { Id = 36, TenNghe = "Artificial Intelligence (AI)", MoTa = "Phát triển hệ thống AI, machine learning, deep learning và gán nhãn dữ liệu.", LinhVucId = 5 },
                new NgheNghiep { Id = 37, TenNghe = "Data Science & Big Data", MoTa = "Phân tích dữ liệu, xây dựng mô hình và xử lý dữ liệu lớn.", LinhVucId = 5 },
                new NgheNghiep { Id = 38, TenNghe = "IT Infrastructure and Operations", MoTa = "Quản trị hệ thống, mạng, máy chủ, cloud và vận hành CNTT.", LinhVucId = 5 },
                new NgheNghiep { Id = 39, TenNghe = "Information Security", MoTa = "Bảo mật hệ thống, kiểm thử bảo mật và phòng chống tấn công mạng.", LinhVucId = 5 },
                new NgheNghiep { Id = 40, TenNghe = "IoT - Embedded Engineer", MoTa = "Phát triển hệ thống IoT, lập trình nhúng và phần cứng.", LinhVucId = 5 },
                new NgheNghiep { Id = 41, TenNghe = "IT Project Management", MoTa = "Quản lý dự án phần mềm, agile, scrum và điều phối kỹ thuật.", LinhVucId = 5 },
                new NgheNghiep { Id = 42, TenNghe = "IT Management - Specialist", MoTa = "Quản lý kỹ thuật, kiến trúc hệ thống và vận hành CNTT cấp cao.", LinhVucId = 5 },
                new NgheNghiep { Id = 43, TenNghe = "Software Design", MoTa = "Thiết kế UX/UI, giao diện, đồ họa và trải nghiệm người dùng.", LinhVucId = 5 },
                new NgheNghiep { Id = 44, TenNghe = "Product Management", MoTa = "Quản lý sản phẩm, phân tích nghiệp vụ và phát triển chiến lược sản phẩm.", LinhVucId = 5 },
                new NgheNghiep { Id = 45, TenNghe = "Game Development", MoTa = "Lập trình game, thiết kế game và phát triển đồ họa/gameplay.", LinhVucId = 5 },
                new NgheNghiep { Id = 46, TenNghe = "Sales IT Phần mềm", MoTa = "Kinh doanh phần mềm, dịch vụ công nghệ và giải pháp CNTT.", LinhVucId = 5 },
                new NgheNghiep { Id = 47, TenNghe = "Công nghệ Thông tin khác", MoTa = "Các công việc CNTT khác không thuộc nhóm đã liệt kê.", LinhVucId = 5 },


                //Lĩnh vực 6: Lao động phổ thông
                new NgheNghiep { Id = 48, TenNghe = "Công nhân", MoTa = "Lao động phổ thông trong nhà máy, xưởng sản xuất và dây chuyền công nghiệp.", LinhVucId = 6 },
                new NgheNghiep { Id = 49, TenNghe = "Tài xế", MoTa = "Lái xe vận tải, giao nhận, đưa đón và vận chuyển hàng hoá.", LinhVucId = 6 },
                new NgheNghiep { Id = 50, TenNghe = "Kho vận - Giao hàng", MoTa = "Quản lý kho, phân loại hàng, đóng gói và giao nhận.", LinhVucId = 6 },
                new NgheNghiep { Id = 51, TenNghe = "Bảo vệ - Bảo trì - Sửa chữa", MoTa = "Bảo vệ tài sản, bảo trì thiết bị và sửa chữa hệ thống.", LinhVucId = 6 },
                new NgheNghiep { Id = 52, TenNghe = "Vệ sinh - Giúp việc - Bảo mẫu", MoTa = "Dọn dẹp, chăm trẻ, hỗ trợ gia đình và dịch vụ vệ sinh.", LinhVucId = 6 },
                new NgheNghiep { Id = 53, TenNghe = "Chăm sóc sức khoẻ - Làm đẹp", MoTa = "Thẩm mỹ, spa, massage và chăm sóc cá nhân.", LinhVucId = 6 },
                new NgheNghiep { Id = 54, TenNghe = "Nhà hàng - Dịch vụ ăn uống", MoTa = "Phục vụ, bếp, pha chế và vận hành nhà hàng/quán ăn.", LinhVucId = 6 },
                new NgheNghiep { Id = 55, TenNghe = "Khách sạn - Dịch vụ cư trú", MoTa = "Buồng phòng, lễ tân, vận hành và hỗ trợ khách lưu trú.", LinhVucId = 6 },
                new NgheNghiep { Id = 56, TenNghe = "Tiếp thị - Bán hàng", MoTa = "Bán hàng trực tiếp, PG, thu ngân và hỗ trợ bán lẻ.", LinhVucId = 6 },
                new NgheNghiep { Id = 57, TenNghe = "Thợ thủ công", MoTa = "Làm thủ công mỹ nghệ, may mặc, cắt vải và sản phẩm handmade.", LinhVucId = 6 },
                new NgheNghiep { Id = 58, TenNghe = "Gia công cơ khí", MoTa = "Hàn, tiện, phay, mài và vận hành máy cơ khí.", LinhVucId = 6 },
                new NgheNghiep { Id = 59, TenNghe = "Thợ xây dựng", MoTa = "Xây dựng, sửa chữa, sơn, mộc, nhôm kính và thi công công trình.", LinhVucId = 6 },

                //Lĩnh vực 7: Tài chính - Ngân hàng - Bảo hiểm
                new NgheNghiep { Id = 60, TenNghe = "Tài chính", MoTa = "Phân tích tài chính, hoạch định, kiểm soát và tư vấn tài chính doanh nghiệp.", LinhVucId = 7 },
                new NgheNghiep { Id = 61, TenNghe = "Ngân hàng", MoTa = "Giao dịch, tín dụng, xử lý nợ, quan hệ khách hàng và vận hành ngân hàng.", LinhVucId = 7 },
                new NgheNghiep { Id = 62, TenNghe = "Chứng khoán", MoTa = "Tư vấn, phân tích đầu tư và quản lý danh mục chứng khoán.", LinhVucId = 7 },
                new NgheNghiep { Id = 63, TenNghe = "Thẩm định và quản trị rủi ro", MoTa = "Đánh giá rủi ro, tuân thủ, thẩm định tín dụng và kiểm soát rủi ro.", LinhVucId = 7 },
                new NgheNghiep { Id = 64, TenNghe = "Đầu tư và Tài trợ", MoTa = "Phân tích đầu tư, M&A, tài trợ thương mại và quản lý tài sản.", LinhVucId = 7 },
                new NgheNghiep { Id = 65, TenNghe = "Bảo hiểm", MoTa = "Thẩm định, tư vấn, xử lý bồi thường và quản lý hợp đồng bảo hiểm.", LinhVucId = 7 },
                new NgheNghiep { Id = 66, TenNghe = "Sales Tài chính - Ngân hàng - Bảo hiểm", MoTa = "Kinh doanh sản phẩm tài chính, ngân hàng, bảo hiểm và đầu tư.", LinhVucId = 7 },
                new NgheNghiep { Id = 67, TenNghe = "Tài chính - Ngân hàng - Bảo hiểm khác", MoTa = "Các công việc khác trong nhóm tài chính, ngân hàng và bảo hiểm.", LinhVucId = 7 },

                //Lĩnh vực 8: Bất động sản
                new NgheNghiep { Id = 68, TenNghe = "Quản lý vận hành bất động sản", MoTa = "Vận hành tòa nhà, bảo trì, an ninh và dịch vụ khách thuê.", LinhVucId = 8 },
                new NgheNghiep { Id = 69, TenNghe = "Quy hoạch và phát triển bất động sản", MoTa = "Quy hoạch, phát triển dự án, đấu thầu và thẩm định bất động sản.", LinhVucId = 8 },
                new NgheNghiep { Id = 70, TenNghe = "Sales Bất động sản", MoTa = "Môi giới, tư vấn và kinh doanh sản phẩm bất động sản.", LinhVucId = 8 },
                new NgheNghiep { Id = 71, TenNghe = "Bất động sản khác", MoTa = "Các công việc khác liên quan đến lĩnh vực bất động sản.", LinhVucId = 8 },

                //Lĩnh vực 9: Xây dựng
                new NgheNghiep { Id = 72, TenNghe = "Quản lý dự án xây dựng", MoTa = "Quản lý tiến độ, chất lượng, hồ sơ và thi công dự án xây dựng.", LinhVucId = 9 },
                new NgheNghiep { Id = 73, TenNghe = "Thiết kế và Kiến trúc", MoTa = "Thiết kế công trình, kiến trúc, nội thất và hệ thống kỹ thuật.", LinhVucId = 9 },
                new NgheNghiep { Id = 74, TenNghe = "Công nhân Xây dựng - Cải tạo", MoTa = "Thi công xây dựng, cải tạo, sửa chữa và lắp đặt công trình.", LinhVucId = 9 },
                new NgheNghiep { Id = 75, TenNghe = "Sales Xây dựng", MoTa = "Kinh doanh vật liệu, thiết bị và giải pháp trong ngành xây dựng.", LinhVucId = 9 },
                new NgheNghiep { Id = 76, TenNghe = "Xây dựng khác", MoTa = "Các công việc khác thuộc lĩnh vực xây dựng và thi công.", LinhVucId = 9 },

                //Lĩnh vực 10: Kế toán - Kiểm toán - Thuế
                new NgheNghiep { Id = 77, TenNghe = "Kế toán", MoTa = "Hạch toán, báo cáo tài chính, quản lý chi phí và xử lý nghiệp vụ kế toán.", LinhVucId = 10 },
                new NgheNghiep { Id = 78, TenNghe = "Kiểm toán", MoTa = "Kiểm tra báo cáo tài chính, đánh giá tuân thủ và kiểm toán nội bộ.", LinhVucId = 10 },
                new NgheNghiep { Id = 79, TenNghe = "Thuế", MoTa = "Khai báo, quyết toán, lập hồ sơ và tư vấn chính sách thuế.", LinhVucId = 10 },
                new NgheNghiep { Id = 80, TenNghe = "Kế toán - Kiểm toán - Thuế khác", MoTa = "Các công việc khác liên quan đến kế toán, kiểm toán và thuế.", LinhVucId = 10 },

                //Lĩnh vực 11: Sản xuất
                new NgheNghiep { Id = 81, TenNghe = "Gia công cơ khí", MoTa = "Hàn, tiện, phay, mài và gia công chi tiết cơ khí theo yêu cầu.", LinhVucId = 11 },
                new NgheNghiep { Id = 82, TenNghe = "Thiết kế - chế tạo máy", MoTa = "Thiết kế, chế tạo, lắp ráp và cải tiến máy móc thiết bị.", LinhVucId = 11 },
                new NgheNghiep { Id = 83, TenNghe = "Hoá chất - Hoá mỹ phẩm", MoTa = "Sản xuất, kiểm nghiệm và nghiên cứu các sản phẩm hoá chất và mỹ phẩm.", LinhVucId = 11 },
                new NgheNghiep { Id = 84, TenNghe = "May mặc - Dệt may - Da", MoTa = "Thiết kế, sản xuất và gia công sản phẩm may mặc, dệt may và da giày.", LinhVucId = 11 },
                new NgheNghiep { Id = 85, TenNghe = "R & D - Sản xuất ô tô", MoTa = "Nghiên cứu, thiết kế, lắp ráp và phát triển linh kiện ô tô.", LinhVucId = 11 },
                new NgheNghiep { Id = 86, TenNghe = "Thợ kỹ thuật", MoTa = "Sửa chữa, lắp đặt, vận hành và hỗ trợ kỹ thuật trong nhà máy.", LinhVucId = 11 },
                new NgheNghiep { Id = 87, TenNghe = "Vận hành thiết bị vận tải - thiết bị nặng", MoTa = "Vận hành xe nâng, máy công trình, thiết bị nặng và phương tiện vận tải.", LinhVucId = 11 },
                new NgheNghiep { Id = 88, TenNghe = "Quản lý chất lượng", MoTa = "Đảm bảo, kiểm soát chất lượng sản phẩm và quy trình sản xuất.", LinhVucId = 11 },
                new NgheNghiep { Id = 89, TenNghe = "Vận hành sản xuất", MoTa = "Giám sát dây chuyền, điều phối sản xuất và quản lý thiết bị.", LinhVucId = 11 },
                new NgheNghiep { Id = 90, TenNghe = "Bảo trì, sửa chữa", MoTa = "Bảo trì máy móc, sửa chữa thiết bị và xử lý sự cố kỹ thuật.", LinhVucId = 11 },
                new NgheNghiep { Id = 91, TenNghe = "Sales Sản xuất", MoTa = "Kinh doanh sản phẩm công nghiệp, máy móc và vật tư sản xuất.", LinhVucId = 11 },
                new NgheNghiep { Id = 92, TenNghe = "Sản xuất khác", MoTa = "Các công việc khác liên quan đến lĩnh vực sản xuất và công nghiệp.", LinhVucId = 11 },

                //Lĩnh vực 12: Giáo dục - Đào tạo
                new NgheNghiep { Id = 93, TenNghe = "Giáo viên - Giảng viên - Gia sư", MoTa = "Giảng dạy, đào tạo học viên và hỗ trợ học tập theo chuyên môn.", LinhVucId = 12 },
                new NgheNghiep { Id = 94, TenNghe = "Văn hoá - Nghệ thuật - Khoa học", MoTa = "Dạy và đào tạo các môn nghệ thuật, mỹ thuật, khoa học và kỹ năng sáng tạo.", LinhVucId = 12 },
                new NgheNghiep { Id = 95, TenNghe = "Thể chất - Thể hình", MoTa = "Huấn luyện thể thao, thể hình, yoga, bơi lội và các bộ môn vận động.", LinhVucId = 12 },
                new NgheNghiep { Id = 96, TenNghe = "Quản lý giáo dục", MoTa = "Quản lý học vụ, điều phối giáo viên và vận hành hệ thống giáo dục.", LinhVucId = 12 },
                new NgheNghiep { Id = 97, TenNghe = "Trợ giảng", MoTa = "Hỗ trợ giảng viên, hướng dẫn học viên và quản lý lớp học.", LinhVucId = 12 },
                new NgheNghiep { Id = 98, TenNghe = "Quản lý - Hỗ trợ lớp học", MoTa = "Hỗ trợ vận hành lớp học, chăm sóc học viên và điều phối học tập.", LinhVucId = 12 },
                new NgheNghiep { Id = 99, TenNghe = "Sales Giáo dục - Khoá học", MoTa = "Tư vấn khoá học, tuyển sinh và kinh doanh dịch vụ giáo dục.", LinhVucId = 12 },
                new NgheNghiep { Id = 100, TenNghe = "Giáo dục - Đào tạo khác", MoTa = "Các công việc khác trong lĩnh vực giáo dục và đào tạo.", LinhVucId = 12 },

                //Lĩnh vực 13: Bán lẻ - Dịch vụ đời sống
                new NgheNghiep { Id = 101, TenNghe = "Bán lẻ", MoTa = "Bán hàng siêu thị, cửa hàng tiện lợi, thời trang và thương mại tiêu dùng.", LinhVucId = 13 },
                new NgheNghiep { Id = 102, TenNghe = "Dịch vụ làm đẹp", MoTa = "Spa, phun xăm, nail, tóc và các dịch vụ thẩm mỹ.", LinhVucId = 13 },
                new NgheNghiep { Id = 103, TenNghe = "Dịch vụ chăm sóc sức khoẻ", MoTa = "Massage, vật lý trị liệu, chăm sóc sức khoẻ cá nhân.", LinhVucId = 13 },
                new NgheNghiep { Id = 104, TenNghe = "Dịch vụ vệ sinh - nhà cửa", MoTa = "Dọn vệ sinh, giúp việc, sắp xếp nhà cửa và vệ sinh công trình.", LinhVucId = 13 },
                new NgheNghiep { Id = 105, TenNghe = "Tài xế - Lái xe", MoTa = "Lái xe taxi, xe tải, giao hàng và đưa đón.", LinhVucId = 13 },
                new NgheNghiep { Id = 106, TenNghe = "Dịch vụ an ninh và bảo trì", MoTa = "Bảo vệ, giám sát an ninh và bảo trì thiết bị.", LinhVucId = 13 },
                new NgheNghiep { Id = 107, TenNghe = "Dịch vụ bà mẹ trẻ em", MoTa = "Chăm sóc mẹ và bé, bảo mẫu và hỗ trợ trẻ nhỏ.", LinhVucId = 13 },
                new NgheNghiep { Id = 108, TenNghe = "Dịch vụ ô tô - xe máy - xe điện", MoTa = "Sửa chữa, rửa xe, bảo trì và chăm sóc xe.", LinhVucId = 13 },
                new NgheNghiep { Id = 109, TenNghe = "Dịch vụ thú cưng", MoTa = "Chăm sóc, spa, nuôi dưỡng và điều trị thú cưng.", LinhVucId = 13 },
                new NgheNghiep { Id = 110, TenNghe = "Bán lẻ - Dịch vụ đời sống khác", MoTa = "Các công việc khác trong nhóm bán lẻ và dịch vụ đời sống.", LinhVucId = 13 },

                //Lĩnh vực 14: Phim và Truyền hình - Báo chí - Xuất bản
                new NgheNghiep { Id = 111, TenNghe = "Biên tập - Viết - Xuất bản", MoTa = "Biên tập nội dung, viết bài, xuất bản sách, báo và tài liệu truyền thông.", LinhVucId = 14 },
                new NgheNghiep { Id = 112, TenNghe = "Phim và truyền hình", MoTa = "Sản xuất phim, quay dựng, diễn xuất, hậu kỳ và kỹ thuật truyền hình.", LinhVucId = 14 },
                new NgheNghiep { Id = 113, TenNghe = "Phim và truyền hình - Báo chí - Xuất bản khác", MoTa = "Các công việc khác thuộc nhóm phim, báo chí và xuất bản.", LinhVucId = 14 },

                //Lĩnh vực 15: Điện - Điện tử - Viễn thông
                new NgheNghiep { Id = 114, TenNghe = "Điện - Tự động hoá", MoTa = "Thiết kế, vận hành và bảo trì hệ thống điện và tự động hoá công nghiệp.", LinhVucId = 15 },
                new NgheNghiep { Id = 115, TenNghe = "Điện tử - Phần cứng", MoTa = "Thiết kế mạch điện, phát triển phần cứng và sửa chữa thiết bị điện tử.", LinhVucId = 15 },
                new NgheNghiep { Id = 116, TenNghe = "Nhiệt - Gió - Điều hoà (HVAC-R)", MoTa = "Thiết kế và vận hành hệ thống điều hoà, thông gió và kỹ thuật nhiệt lạnh.", LinhVucId = 15 },
                new NgheNghiep { Id = 117, TenNghe = "Chất bán dẫn - Chip", MoTa = "Thiết kế vi mạch, kiểm định chip và phát triển công nghệ bán dẫn.", LinhVucId = 15 },
                new NgheNghiep { Id = 118, TenNghe = "Quản lý - Vận hành dự án kỹ thuật", MoTa = "Điều phối, quản lý và triển khai dự án điện, viễn thông và kỹ thuật.", LinhVucId = 15 },
                new NgheNghiep { Id = 119, TenNghe = "Viễn thông", MoTa = "Thiết kế, vận hành và tối ưu hệ thống mạng và truyền thông.", LinhVucId = 15 },
                new NgheNghiep { Id = 120, TenNghe = "Vận hành và bảo trì - Hỗ trợ kỹ thuật", MoTa = "Vận hành thiết bị, hỗ trợ kỹ thuật và bảo trì hệ thống điện tử – viễn thông.", LinhVucId = 15 },
                new NgheNghiep { Id = 121, TenNghe = "Sales Điện - Điện tử - Viễn thông", MoTa = "Kinh doanh thiết bị điện, giải pháp viễn thông và sản phẩm công nghiệp.", LinhVucId = 15 },
                new NgheNghiep { Id = 122, TenNghe = "Điện - Điện tử - Viễn thông khác", MoTa = "Các công việc khác thuộc ngành điện, điện tử và viễn thông.", LinhVucId = 15 },

                //Lĩnh vực 16: Logistics - Thu mua - Kho - Vận tải
                new NgheNghiep { Id = 123, TenNghe = "Sales Xuất nhập khẩu - Logistics", MoTa = "Kinh doanh dịch vụ logistics, vận chuyển, kho bãi và xuất nhập khẩu.", LinhVucId = 16 },
                new NgheNghiep { Id = 124, TenNghe = "Xuất nhập khẩu - Logistics", MoTa = "Chứng từ, điều phối hàng hóa, theo dõi đơn hàng và khai báo hải quan.", LinhVucId = 16 },
                new NgheNghiep { Id = 125, TenNghe = "Vận tải", MoTa = "Điều phối, vận hành phương tiện và quản lý vận tải hàng hóa.", LinhVucId = 16 },
                new NgheNghiep { Id = 126, TenNghe = "Giao nhận", MoTa = "Bưu tá, giao hàng, phân loại và điều phối giao nhận.", LinhVucId = 16 },
                new NgheNghiep { Id = 127, TenNghe = "Kho vận", MoTa = "Quản lý kho, nhập xuất, đóng gói và sắp xếp hàng hóa.", LinhVucId = 16 },
                new NgheNghiep { Id = 128, TenNghe = "Thu mua - Mua hàng", MoTa = "Đàm phán, đặt hàng, quản lý nhà cung cấp và kiểm soát vật tư.", LinhVucId = 16 },
                new NgheNghiep { Id = 129, TenNghe = "Chuỗi cung ứng", MoTa = "Hoạch định, điều phối và tối ưu chuỗi cung ứng hàng hóa.", LinhVucId = 16 },
                new NgheNghiep { Id = 130, TenNghe = "Logistics - Thu mua - Kho - Vận tải khác", MoTa = "Các vị trí khác thuộc nhóm logistics, kho vận và vận tải.", LinhVucId = 16 },

                //Lĩnh vực 17: Tư vấn chuyên môn
                new NgheNghiep { Id = 131, TenNghe = "Tư vấn - Phân tích chuyên môn", MoTa = "Tư vấn chiến lược, phân tích dữ liệu, thị trường và giải pháp cho doanh nghiệp.", LinhVucId = 17 },

                //Lĩnh vực 18: Dược - Y tế - Sức khoẻ - Công nghệ sinh học
                new NgheNghiep { Id = 132, TenNghe = "Nghề Y tá - Điều dưỡng", MoTa = "Chăm sóc bệnh nhân, hỗ trợ y khoa và theo dõi điều trị.", LinhVucId = 18 },
                new NgheNghiep { Id = 133, TenNghe = "Bác sĩ - Kỹ thuật viên", MoTa = "Khám chữa bệnh, chẩn đoán hình ảnh, xét nghiệm và kỹ thuật y học.", LinhVucId = 18 },
                new NgheNghiep { Id = 134, TenNghe = "Vật lý trị liệu và chăm sóc sức khỏe", MoTa = "Phục hồi chức năng, vật lý trị liệu và chăm sóc sức khỏe cá nhân.", LinhVucId = 18 },
                new NgheNghiep { Id = 135, TenNghe = "Dược phẩm - Công nghệ sinh học", MoTa = "Sản xuất, nghiên cứu và kinh doanh dược phẩm, sinh học và R&D y dược.", LinhVucId = 18 },
                new NgheNghiep { Id = 136, TenNghe = "Thiết bị y tế", MoTa = "Quản lý, vận hành, kinh doanh và bảo trì thiết bị y tế.", LinhVucId = 18 },
                new NgheNghiep { Id = 137, TenNghe = "Sales Dược - Y tế - Sức khoẻ - Làm đẹp", MoTa = "Kinh doanh dược phẩm, thiết bị y tế và dịch vụ làm đẹp.", LinhVucId = 18 },
                new NgheNghiep { Id = 138, TenNghe = "Dược - Y tế - Sức khoẻ - Công nghệ sinh học khác", MoTa = "Các công việc khác thuộc nhóm y tế, dược và công nghệ sinh học.", LinhVucId = 18 },

                //Lĩnh vực 19: Thiết kế
                new NgheNghiep { Id = 139, TenNghe = "Thiết kế Đồ hoạ - Giao diện - Trải nghiệm", MoTa = "Thiết kế đồ họa, UX/UI, giao diện và trải nghiệm người dùng.", LinhVucId = 19 },
                new NgheNghiep { Id = 140, TenNghe = "Thiết kế Nhà - Nội thất - Môi trường", MoTa = "Thiết kế kiến trúc, nội thất, cảnh quan và không gian.", LinhVucId = 19 },
                new NgheNghiep { Id = 141, TenNghe = "Thiết kế Công nghiệp", MoTa = "Thiết kế sản phẩm, bao bì, kỹ thuật và mô hình công nghiệp.", LinhVucId = 19 },
                new NgheNghiep { Id = 142, TenNghe = "Thiết kế Thời trang", MoTa = "Thiết kế trang phục, rập, vải và sản phẩm thời trang.", LinhVucId = 19 },
                new NgheNghiep { Id = 143, TenNghe = "Nghệ thuật - Hoạt hình - Game", MoTa = "Animation, minh họa, concept art, dựng hình và thiết kế game.", LinhVucId = 19 },
                new NgheNghiep { Id = 144, TenNghe = "Nghiên cứu người dùng", MoTa = "Nghiên cứu hành vi người dùng, usability test và phân tích trải nghiệm.", LinhVucId = 19 },
                new NgheNghiep { Id = 145, TenNghe = "Quản lý thiết kế", MoTa = "Quản lý đội ngũ thiết kế, định hướng sáng tạo và giám sát dự án.", LinhVucId = 19 },
                new NgheNghiep { Id = 146, TenNghe = "Thiết kế khác", MoTa = "Các công việc khác thuộc nhóm ngành thiết kế.", LinhVucId = 19 },

                //Lĩnh vực 20: Nhà hàng - Khách sạn - Du lịch
                new NgheNghiep { Id = 147, TenNghe = "Nhà hàng - Dịch vụ ăn uống", MoTa = "Phục vụ, bếp, pha chế, quản lý và vận hành nhà hàng.", LinhVucId = 20 },
                new NgheNghiep { Id = 148, TenNghe = "Khách sạn - Dịch vụ cư trú", MoTa = "Lễ tân, buồng phòng, quản lý khách sạn và dịch vụ lưu trú.", LinhVucId = 20 },
                new NgheNghiep { Id = 149, TenNghe = "Dịch vụ du lịch", MoTa = "Hướng dẫn viên, điều hành tour, visa và dịch vụ du lịch.", LinhVucId = 20 },
                new NgheNghiep { Id = 150, TenNghe = "Sales Nhà hàng - Khách sạn - Du lịch", MoTa = "Kinh doanh tour, phòng khách sạn, HORECA và dịch vụ lữ hành.", LinhVucId = 20 },
                new NgheNghiep { Id = 151, TenNghe = "Nhà hàng - Khách sạn - Du lịch khác", MoTa = "Các vị trí khác trong ngành F&B, khách sạn và du lịch.", LinhVucId = 20 },

                //Lĩnh vực 21: Năng lượng - Môi trường - Nông nghiệp
                new NgheNghiep { Id = 152, TenNghe = "Năng lượng - Địa chất", MoTa = "Kỹ sư năng lượng, địa chất, thủy lợi và các dự án năng lượng.", LinhVucId = 21 },
                new NgheNghiep { Id = 153, TenNghe = "An toàn lao động - Môi trường", MoTa = "HSE, môi trường, xử lý chất thải và giám sát an toàn.", LinhVucId = 21 },
                new NgheNghiep { Id = 154, TenNghe = "Nông - Lâm - Ngư nghiệp", MoTa = "Trồng trọt, chăn nuôi, thủy sản và quản lý nông nghiệp.", LinhVucId = 21 },
                new NgheNghiep { Id = 155, TenNghe = "Năng lượng - Môi trường - Nông nghiệp khác", MoTa = "Các công việc khác trong lĩnh vực năng lượng, môi trường, nông nghiệp.", LinhVucId = 21 },

                //Lĩnh vực 22: Tài xế
                new NgheNghiep { Id = 156, TenNghe = "Vận tải", MoTa = "Tài xế xe tải, container, đường dài và vận hành phương tiện.", LinhVucId = 22 },
                new NgheNghiep { Id = 157, TenNghe = "Đưa đón", MoTa = "Tài xế taxi, công nghệ, lái xe văn phòng và dịch vụ đưa đón.", LinhVucId = 22 },

                //Lĩnh vực 23: Biên phiên dịch
                new NgheNghiep { Id = 158, TenNghe = "Nghề Biên phiên dịch", MoTa = "Phiên dịch, biên dịch đa ngôn ngữ và tư vấn dịch thuật.", LinhVucId = 23 },

                //Lĩnh vực 24: Luật
                new NgheNghiep { Id = 159, TenNghe = "Dịch vụ pháp lý (Agency - Firm)", MoTa = "Luật sư, tư vấn pháp lý, hỗ trợ hồ sơ và pháp lý doanh nghiệp.", LinhVucId = 24 },
                new NgheNghiep { Id = 160, TenNghe = "Dịch vụ pháp chế (In-house)", MoTa = "Pháp chế doanh nghiệp, tuân thủ, hợp đồng và pháp lý nội bộ.", LinhVucId = 24 },

                //Lĩnh vực 25: Nhóm nghề khác
                new NgheNghiep { Id = 161, TenNghe = "Hàng hải", MoTa = "Vận hành tàu biển, kỹ thuật hàng hải và dịch vụ logistics biển.", LinhVucId = 25 },
                new NgheNghiep { Id = 162, TenNghe = "NGO - Phi chính phủ - Phi lợi nhuận", MoTa = "Công việc xã hội, cộng đồng, phát triển bền vững và hỗ trợ nhân đạo.", LinhVucId = 25 },
                new NgheNghiep { Id = 163, TenNghe = "Nghề khác", MoTa = "Các nghề chưa thuộc các nhóm lĩnh vực còn lại.", LinhVucId = 25 }
             );
        }
    }   
}