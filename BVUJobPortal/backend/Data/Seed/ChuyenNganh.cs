using BVUJobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BVUJobPortal.Data.Seed
{
    public static class ChuyenNganhSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuyenNganh>().HasData(
                // Nghề: Sales Xuất nhập khẩu / Logistics
                new ChuyenNganh { Id = 1, TenChuyenNganh = "Sales Logistics", MoTa = "Tư vấn và bán giải pháp logistics, vận chuyển, kho bãi.", NgheNghiepId = 1 },
                new ChuyenNganh { Id = 2, TenChuyenNganh = "Sales Xuất nhập khẩu - Logistics khác", MoTa = "Các vị trí kinh doanh khác trong lĩnh vực XNK và Logistics.", NgheNghiepId = 1 },

                // Nghề: Sales Bất động sản
                new ChuyenNganh { Id = 3, TenChuyenNganh = "Sales bất động sản - Môi giới bất động sản", MoTa = "Tư vấn và môi giới mua bán, cho thuê bất động sản.", NgheNghiepId = 2 },
                new ChuyenNganh { Id = 4, TenChuyenNganh = "Sales Bất động sản khác", MoTa = "Các vị trí kinh doanh khác trong lĩnh vực bất động sản.", NgheNghiepId = 2 },

                // Nghề: Sales Xây dựng
                new ChuyenNganh { Id = 5, TenChuyenNganh = "Kinh doanh thiết bị - vật liệu xây dựng", MoTa = "Bán thiết bị, vật tư và vật liệu xây dựng cho công trình.", NgheNghiepId = 3 },
                new ChuyenNganh { Id = 6, TenChuyenNganh = "Kinh doanh nội thất", MoTa = "Bán sản phẩm nội thất nhà ở, văn phòng và công trình.", NgheNghiepId = 3 },
                new ChuyenNganh { Id = 7, TenChuyenNganh = "Tư vấn thiết kế xây dựng", MoTa = "Tư vấn giải pháp thiết kế và thi công xây dựng.", NgheNghiepId = 3 },
                new ChuyenNganh { Id = 8, TenChuyenNganh = "Sales Xây dựng khác", MoTa = "Các vị trí kinh doanh khác trong lĩnh vực xây dựng.", NgheNghiepId = 3 },

                // Nghề: Sales Giáo dục/Khoá học
                new ChuyenNganh { Id = 9, TenChuyenNganh = "Tư vấn tuyển sinh - khoá học", MoTa = "Tư vấn khoá học, chương trình đào tạo và hỗ trợ tuyển sinh.", NgheNghiepId = 4 },
                new ChuyenNganh { Id = 10, TenChuyenNganh = "Sales Giáo dục - Khoá học khác", MoTa = "Các vị trí kinh doanh khác trong lĩnh vực giáo dục.", NgheNghiepId = 4 },
                new ChuyenNganh { Id = 11, TenChuyenNganh = "Tư vấn du học", MoTa = "Tư vấn hồ sơ du học và các chương trình quốc tế.", NgheNghiepId = 4 },

                // Nghề: Sales Admin/Sales Support
                new ChuyenNganh { Id = 12, TenChuyenNganh = "Sales Admin - Sales Support", MoTa = "Hỗ trợ kinh doanh, soạn hợp đồng, theo dõi đơn hàng.", NgheNghiepId = 5 },
                new ChuyenNganh { Id = 13, TenChuyenNganh = "Vận hành Livestream", MoTa = "Vận hành kỹ thuật livestream bán hàng và hỗ trợ nội dung.", NgheNghiepId = 5 },
                new ChuyenNganh { Id = 14, TenChuyenNganh = "Chuyên viên đấu thầu", MoTa = "Chuẩn bị hồ sơ thầu và tham gia đấu thầu dự án.", NgheNghiepId = 5 },
                new ChuyenNganh { Id = 15, TenChuyenNganh = "Customer Success", MoTa = "Hỗ trợ khách hàng sau bán và tối ưu trải nghiệm.", NgheNghiepId = 5 },

                // Nghề : Sales Tài chính/Ngân hàng/Bảo hiểm
                new ChuyenNganh { Id = 16, TenChuyenNganh = "Quan hệ khách hàng cá nhân - doanh nghiệp ", MoTa = "Chăm sóc và tư vấn sản phẩm tài chính cho khách hàng.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 17, TenChuyenNganh = "Tư vấn tài chính", MoTa = "Tư vấn các giải pháp tài chính cá nhân và doanh nghiệp.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 18, TenChuyenNganh = "Tư vấn tín dụng", MoTa = "Tư vấn vay vốn, hạn mức và giải pháp tín dụng.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 19, TenChuyenNganh = "Tư vấn bảo hiểm", MoTa = "Tư vấn các gói bảo hiểm sức khỏe, nhân thọ và tài sản.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 20, TenChuyenNganh = "Sales Tài chính - Ngân hàng - Bảo hiểm khác", MoTa = "Các vị trí kinh doanh khác trong lĩnh vực tài chính.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 21, TenChuyenNganh = "Chăm sóc khách hàng bảo hiểm", MoTa = "Hỗ trợ khách hàng bảo hiểm và xử lý quyền lợi bảo hiểm.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 22, TenChuyenNganh = "Tư vấn trả góp", MoTa = "Tư vấn trả góp và tài chính tiêu dùng.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 23, TenChuyenNganh = "Tư vấn đầu tư", MoTa = "Tư vấn danh mục đầu tư tài chính và chứng khoán.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 24, TenChuyenNganh = "Bancassurance", MoTa = "Kinh doanh bảo hiểm qua kênh ngân hàng.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 25, TenChuyenNganh = "Kinh doanh ngoại hối, vàng, phái sinh", MoTa = "Tư vấn và kinh doanh sản phẩm FX và phái sinh tài chính.", NgheNghiepId = 6 },
                new ChuyenNganh { Id = 26, TenChuyenNganh = "Tư vấn chứng khoán", MoTa = "Tư vấn giao dịch cổ phiếu, trái phiếu và thị trường vốn.", NgheNghiepId = 6 },

                // Nghề: Sales Bán lẻ/Dịch vụ tiêu dùng
                new ChuyenNganh { Id = 27, TenChuyenNganh = "Sales Bán lẻ - Dịch vụ tiêu dùng khác", MoTa = "Các vị trí kinh doanh khác trong ngành bán lẻ.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 28, TenChuyenNganh = "Bán hàng thời trang", MoTa = "Tư vấn và bán sản phẩm thời trang.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 29, TenChuyenNganh = "Kinh doanh kênh GT", MoTa = "Phụ trách bán hàng qua kênh truyền thống GT.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 30, TenChuyenNganh = "Bán hàng siêu thị - cửa hàng tiện ích - tiện lợi", MoTa = "Bán hàng và chăm sóc khách tại hệ thống siêu thị.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 31, TenChuyenNganh = "Kinh doanh thực phẩm", MoTa = "Kinh doanh các sản phẩm thực phẩm tiêu dùng.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 32, TenChuyenNganh = "Kinh doanh kênh MT", MoTa = "Phát triển bán hàng qua kênh hiện đại MT.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 33, TenChuyenNganh = "Bán hàng điện thoại", MoTa = "Bán sản phẩm điện thoại, phụ kiện.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 34, TenChuyenNganh = "Bán hàng điện máy", MoTa = "Kinh doanh thiết bị điện máy gia dụng.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 35, TenChuyenNganh = "Bán hàng mỹ phẩm", MoTa = "Bán sản phẩm mỹ phẩm và làm đẹp.", NgheNghiepId = 7 },
                new ChuyenNganh { Id = 36, TenChuyenNganh = "Bán hàng trang sức đá quý", MoTa = "Kinh doanh trang sức vàng, bạc, đá quý.", NgheNghiepId = 7 },

                // Nghề: Sales Sản xuất
                new ChuyenNganh { Id = 37, TenChuyenNganh = "Kinh doanh ô tô - xe máy - xe điện", MoTa = "Bán ô tô, xe máy, xe điện và sản phẩm liên quan.", NgheNghiepId = 8 },
                new ChuyenNganh { Id = 38, TenChuyenNganh = "Sales Sản xuất khác", MoTa = "Các vị trí kinh doanh khác trong ngành sản xuất.", NgheNghiepId = 8 },
                new ChuyenNganh { Id = 39, TenChuyenNganh = "Kinh doanh phụ tùng ô tô - xe máy - xe điện", MoTa = "Bán phụ tùng, linh kiện ô tô và xe máy.", NgheNghiepId = 8 },
                new ChuyenNganh { Id = 40, TenChuyenNganh = "Kinh doanh hoá chất", MoTa = "Bán hoá chất công nghiệp hoặc hoá mỹ phẩm.", NgheNghiepId = 8 },

                // Nghề: Sales Kỹ thuật (Sales Engineer)
                new ChuyenNganh { Id = 41, TenChuyenNganh = "Bán hàng kỹ thuật Điện - Điện tử - Viễn thông", MoTa = "Bán thiết bị và giải pháp kỹ thuật ngành điện – viễn thông.", NgheNghiepId = 9 },
                new ChuyenNganh { Id = 42, TenChuyenNganh = "Bán hàng kỹ thuật cơ khí", MoTa = "Kinh doanh máy móc, thiết bị cơ khí.", NgheNghiepId = 9 },
                new ChuyenNganh { Id = 43, TenChuyenNganh = "Bán hàng kỹ thuật IT", MoTa = "Bán phần mềm, phần cứng và giải pháp CNTT.", NgheNghiepId = 9 },
                new ChuyenNganh { Id = 44, TenChuyenNganh = "Sales Kỹ thuật khác", MoTa = "Các vị trí Sales Engineer khác.", NgheNghiepId = 9 },

                // Nghề 10: Sales Nhà hàng - Khách sạn - Du lịch
                new ChuyenNganh { Id = 45, TenChuyenNganh = "Sales Tour - Kinh doanh du lịch", MoTa = "Bán tour và dịch vụ du lịch.", NgheNghiepId = 10 },
                new ChuyenNganh { Id = 46, TenChuyenNganh = "Kinh doanh khách sạn", MoTa = "Bán phòng và dịch vụ khách sạn.", NgheNghiepId = 10 },
                new ChuyenNganh { Id = 47, TenChuyenNganh = "Kinh doanh HORECA", MoTa = "Cung cấp sản phẩm/dịch vụ cho nhà hàng – khách sạn.", NgheNghiepId = 10 },
                new ChuyenNganh { Id = 48, TenChuyenNganh = "Bán vé máy bay (Ticketing/Booker)", MoTa = "Đặt vé máy bay và hỗ trợ khách hàng.", NgheNghiepId = 10 },
                new ChuyenNganh { Id = 49, TenChuyenNganh = "Kinh doanh khách đoàn (MICE)", MoTa = "Bán dịch vụ hội nghị – hội thảo – sự kiện.", NgheNghiepId = 10 },
                new ChuyenNganh { Id = 50, TenChuyenNganh = "Kinh doanh OTA", MoTa = "Quản lý bán phòng qua booking/agoda.", NgheNghiepId = 10 },
                new ChuyenNganh { Id = 51, TenChuyenNganh = "Sales Nhà hàng - Khách sạn - Du lịch khác", MoTa = "Các vị trí Sales khác trong F&B – du lịch.", NgheNghiepId = 10 },

                // Nghề 11: Sales Dược - Y tế - Sức khoẻ - Làm đẹp
                new ChuyenNganh { Id = 52, TenChuyenNganh = "Sales Dược - Y tế - Sức khoẻ - Làm đẹp khác", MoTa = "Các vị trí kinh doanh khác trong y tế – dược – thẩm mỹ.", NgheNghiepId = 11 },
                new ChuyenNganh { Id = 53, TenChuyenNganh = "Tư vấn thẩm mỹ - Spa", MoTa = "Tư vấn dịch vụ thẩm mỹ, spa, chăm sóc da.", NgheNghiepId = 11 },
                new ChuyenNganh { Id = 54, TenChuyenNganh = "Trình dược viên", MoTa = "Giới thiệu và bán thuốc tại nhà thuốc/bệnh viện.", NgheNghiepId = 11 },
                new ChuyenNganh { Id = 55, TenChuyenNganh = "Kinh doanh dịch vụ y tế", MoTa = "Bán các dịch vụ khám chữa bệnh và chăm sóc sức khoẻ.", NgheNghiepId = 11 },
                new ChuyenNganh { Id = 56, TenChuyenNganh = "Dược sĩ - Bán thuốc", MoTa = "Tư vấn và bán thuốc theo đơn.", NgheNghiepId = 11 },

                // Nghề 12: Sales IT Phần mềm
                new ChuyenNganh { Id = 57, TenChuyenNganh = "Kinh doanh phần mềm", MoTa = "Bán phần mềm và giải pháp công nghệ.", NgheNghiepId = 12 },
                new ChuyenNganh { Id = 58, TenChuyenNganh = "Kinh doanh Domain/Hosting/Server", MoTa = "Bán tên miền, dịch vụ hosting, cloud server.", NgheNghiepId = 12 },
                new ChuyenNganh { Id = 59, TenChuyenNganh = "Sales IT Phần mềm khác", MoTa = "Các vị trí kinh doanh khác về phần mềm và IT.", NgheNghiepId = 12 },

                // Nghề 13: Sales Điện - Điện tử - Viễn thông
                new ChuyenNganh { Id = 60, TenChuyenNganh = "Kinh doanh thiết bị linh kiện điện", MoTa = "Bán linh kiện, vật tư ngành điện.", NgheNghiepId = 13 },
                new ChuyenNganh { Id = 61, TenChuyenNganh = "Kinh doanh dịch vụ viễn thông", MoTa = "Bán dịch vụ viễn thông, truyền hình, internet.", NgheNghiepId = 13 },
                new ChuyenNganh { Id = 62, TenChuyenNganh = "Sales Điện/Điện tử/Viễn thông khác", MoTa = "Các vị trí Sales khác ngành điện – viễn thông.", NgheNghiepId = 13 },
                new ChuyenNganh { Id = 63, TenChuyenNganh = "Kinh doanh thiết bị công nghiệp", MoTa = "Bán máy móc và thiết bị công nghiệp.", NgheNghiepId = 13 },
                new ChuyenNganh { Id = 64, TenChuyenNganh = "Kinh doanh điện mặt trời", MoTa = "Bán thiết bị và giải pháp năng lượng mặt trời.", NgheNghiepId = 13 },
                new ChuyenNganh { Id = 65, TenChuyenNganh = "Kinh doanh HVAC", MoTa = "Kinh doanh thiết bị và giải pháp điều hòa – thông gió.", NgheNghiepId = 13 },

                // Nghề 14: Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện
                new ChuyenNganh { Id = 66, TenChuyenNganh = "Sales Marketing", MoTa = "Kinh doanh dịch vụ marketing và quảng cáo.", NgheNghiepId = 14 },
                new ChuyenNganh { Id = 67, TenChuyenNganh = "Kinh doanh dịch vụ quảng cáo", MoTa = "Bán dịch vụ quảng cáo truyền thông.", NgheNghiepId = 14 },
                new ChuyenNganh { Id = 68, TenChuyenNganh = "Kinh doanh tiệc/sự kiện/hội nghị", MoTa = "Kinh doanh dịch vụ tổ chức sự kiện và hội nghị.", NgheNghiepId = 14 },
                new ChuyenNganh { Id = 69, TenChuyenNganh = "Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện khác", MoTa = "Các vị trí Sales khác thuộc nhóm event – media.", NgheNghiepId = 14 },
                new ChuyenNganh { Id = 70, TenChuyenNganh = "Kinh doanh mảng Nhà tài trợ", MoTa = "Tìm kiếm nhà tài trợ cho sự kiện và chiến dịch.", NgheNghiepId = 14 },
                new ChuyenNganh { Id = 71, TenChuyenNganh = "Kinh doanh triển lãm", MoTa = "Kinh doanh gian hàng và dịch vụ triển lãm.", NgheNghiepId = 14 },
                new ChuyenNganh { Id = 72, TenChuyenNganh = "Sales dịch vụ Quảng cáo/Triển lãm/Sự kiện khác", MoTa = "Các vị trí khác thuộc lĩnh vực quảng cáo và triển lãm.", NgheNghiepId = 14 },

                // Nghề 15: Sales Thương mại điện tử
                new ChuyenNganh { Id = 73, TenChuyenNganh = "Kinh doanh sàn thương mại điện tử", MoTa = "Quản lý gian hàng và kinh doanh trên sàn TMĐT.", NgheNghiepId = 15 },

                // Nghề 16: Quản lý kinh doanh
                new ChuyenNganh { Id = 74, TenChuyenNganh = "Sales Manager/Trưởng phòng kinh doanh", MoTa = "Quản lý đội ngũ kinh doanh và kế hoạch bán hàng.", NgheNghiepId = 16 },
                new ChuyenNganh { Id = 75, TenChuyenNganh = "Quản lý cửa hàng/Cửa hàng trưởng", MoTa = "Quản lý vận hành cửa hàng và nhân sự.", NgheNghiepId = 16 },
                new ChuyenNganh { Id = 76, TenChuyenNganh = "Sales Director/Giám đốc kinh doanh", MoTa = "Điều hành chiến lược kinh doanh toàn doanh nghiệp.", NgheNghiepId = 16 },
                new ChuyenNganh { Id = 77, TenChuyenNganh = "Quản lý Kinh doanh khác", MoTa = "Các vị trí quản lý khác trong kinh doanh.", NgheNghiepId = 16 },
                new ChuyenNganh { Id = 78, TenChuyenNganh = "ASM/Quản lý khu vực/vùng miền", MoTa = "Quản lý bán hàng theo khu vực.", NgheNghiepId = 16 },
                new ChuyenNganh { Id = 79, TenChuyenNganh = "Chuyên viên chính sách kinh doanh", MoTa = "Xây dựng chính sách kinh doanh và bán hàng.", NgheNghiepId = 16 },

                // Nghề 17: Kinh doanh - Bán hàng khác
                new ChuyenNganh { Id = 80, TenChuyenNganh = "Trợ lý kinh doanh", MoTa = "Hỗ trợ công việc kinh doanh và khách hàng.", NgheNghiepId = 17 },
                new ChuyenNganh { Id = 81, TenChuyenNganh = "Account Executive", MoTa = "Chăm sóc khách hàng và triển khai hợp đồng.", NgheNghiepId = 17 },
                new ChuyenNganh { Id = 82, TenChuyenNganh = "Sales Dịch vụ kế toán", MoTa = "Kinh doanh dịch vụ kế toán và tài chính.", NgheNghiepId = 17 },
                new ChuyenNganh { Id = 83, TenChuyenNganh = "Kinh doanh nông sản", MoTa = "Kinh doanh và phân phối sản phẩm nông nghiệp.", NgheNghiepId = 17 },
                new ChuyenNganh { Id = 84, TenChuyenNganh = "Chuyên môn Kinh doanh/Bán hàng khác", MoTa = "Các vị trí kinh doanh không thuộc nhóm khác.", NgheNghiepId = 17 },
                new ChuyenNganh { Id = 85, TenChuyenNganh = "Sales Representative/Phát triển kinh doanh", MoTa = "Tìm kiếm khách hàng mới và phát triển thị trường.", NgheNghiepId = 17 },
                new ChuyenNganh { Id = 86, TenChuyenNganh = "Account Manager (Quản lý khách hàng)", MoTa = "Quản lý danh mục khách hàng doanh nghiệp.", NgheNghiepId = 17 },

                // Nghề 18: Marketing
                new ChuyenNganh { Id = 1112, TenChuyenNganh = "Digital Marketing", MoTa = "Thực hiện chiến dịch marketing online.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1113, TenChuyenNganh = "Content Marketing", MoTa = "Xây dựng nội dung marketing đa nền tảng.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1114, TenChuyenNganh = "Content Creator", MoTa = "Sản xuất nội dung sáng tạo trên mạng xã hội.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1115, TenChuyenNganh = "Chuyên môn Marketing", MoTa = "Các vị trí marketing khác.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1116, TenChuyenNganh = "Social Media", MoTa = "Quản lý nội dung và tương tác mạng xã hội.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1117, TenChuyenNganh = "Host Livestream/Streamer", MoTa = "Livestream bán hàng và xây dựng tệp người xem.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1118, TenChuyenNganh = "SEO", MoTa = "Tối ưu website tăng thứ hạng tìm kiếm.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1119, TenChuyenNganh = "Marketing Manager", MoTa = "Quản lý chiến dịch marketing và đội ngũ.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1120, TenChuyenNganh = "Brand Marketing", MoTa = "Xây dựng và phát triển thương hiệu.", NgheNghiepId = 18 },
                new ChuyenNganh { Id = 1121, TenChuyenNganh = "Chạy Ads", MoTa = "Chạy quảng cáo Facebook, Google, TikTok...", NgheNghiepId = 18 },

                // Nghề 19: Quảng cáo - Sáng tạo
                new ChuyenNganh { Id = 1122, TenChuyenNganh = "Thiết kế đồ họa (Graphic Design)", MoTa = "Thiết kế ấn phẩm thương hiệu, visual.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1123, TenChuyenNganh = "Photographer/Video Editor", MoTa = "Chụp ảnh và dựng video quảng cáo.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1124, TenChuyenNganh = "Media Planner/Buyer Executive", MoTa = "Lên kế hoạch và đặt mua quảng cáo truyền thông.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1125, TenChuyenNganh = "Creative Planner", MoTa = "Lên ý tưởng và concept sáng tạo cho chiến dịch.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1126, TenChuyenNganh = "Animation Design", MoTa = "Thiết kế hoạt hình 2D/3D cho quảng cáo.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1127, TenChuyenNganh = "Campaign Manager", MoTa = "Quản lý chiến dịch quảng cáo.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1128, TenChuyenNganh = "Production Manager", MoTa = "Quản lý sản xuất TVC, video, shooting.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1129, TenChuyenNganh = "Ad Operations Manager", MoTa = "Quản lý kỹ thuật hệ thống quảng cáo số.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1130, TenChuyenNganh = "Media Placement Specialist", MoTa = "Triển khai booking bài PR, quảng cáo báo chí.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1131, TenChuyenNganh = "Quảng cáo - Sáng tạo khác", MoTa = "Các vị trí sáng tạo khác.", NgheNghiepId = 19 },
                new ChuyenNganh { Id = 1132, TenChuyenNganh = "Chuyên môn Quảng cáo/Sáng tạo khác", MoTa = "Các vị trí khác trong ngành quảng cáo – sáng tạo.", NgheNghiepId = 19 },

                // Nghề 20: Quan hệ Công chúng (PR)
                new ChuyenNganh { Id = 1133, TenChuyenNganh = "PR Specialist", MoTa = "Phụ trách hoạt động quan hệ công chúng và truyền thông thương hiệu.", NgheNghiepId = 20 },
                new ChuyenNganh { Id = 1134, TenChuyenNganh = "Chuyên môn Quan hệ Công chúng", MoTa = "Thực hiện các hoạt động PR xây dựng hình ảnh tổ chức.", NgheNghiepId = 20 },
                new ChuyenNganh { Id = 1135, TenChuyenNganh = "Xây dựng và bảo vệ thương hiệu", MoTa = "Quản lý danh tiếng và định vị thương hiệu.", NgheNghiepId = 20 },
                new ChuyenNganh { Id = 1136, TenChuyenNganh = "Truyền thông nội bộ", MoTa = "Kết nối nội bộ và truyền tải thông điệp doanh nghiệp.", NgheNghiepId = 20 },
                new ChuyenNganh { Id = 1137, TenChuyenNganh = "Phát triển cộng đồng", MoTa = "Triển khai các hoạt động CSR và kết nối cộng đồng.", NgheNghiepId = 20 },
                new ChuyenNganh { Id = 1138, TenChuyenNganh = "Corporate Communication", MoTa = "Truyền thông doanh nghiệp, duy trì hình ảnh chuyên nghiệp.", NgheNghiepId = 20 },
                new ChuyenNganh { Id = 1139, TenChuyenNganh = "Quan hệ báo chí", MoTa = "Làm việc với báo chí, viết thông cáo và quản lý truyền thông.", NgheNghiepId = 20 },
                new ChuyenNganh { Id = 1140, TenChuyenNganh = "Xử lý khủng hoảng truyền thông", MoTa = "Quản lý khủng hoảng, xử lý rủi ro truyền thông.", NgheNghiepId = 20 },

                // Nghề 21: Quan hệ Chính phủ
                new ChuyenNganh { Id = 87, TenChuyenNganh = "Quan hệ đối ngoại", MoTa = "Xây dựng mối quan hệ giữa doanh nghiệp và các cơ quan Nhà nước, tổ chức bên ngoài.", NgheNghiepId = 21 },
                new ChuyenNganh { Id = 88, TenChuyenNganh = "Pháp chế", MoTa = "Đảm bảo tuân thủ pháp luật, tư vấn và xử lý các vấn đề pháp lý.", NgheNghiepId = 21 },
                new ChuyenNganh { Id = 89, TenChuyenNganh = "Nghiên cứu chính sách", MoTa = "Phân tích luật, nghị định và đề xuất chính sách phù hợp cho tổ chức.", NgheNghiepId = 21 },
                new ChuyenNganh { Id = 90, TenChuyenNganh = "Hợp tác quốc tế", MoTa = "Làm việc với cơ quan, tổ chức quốc tế nhằm thúc đẩy quan hệ đối tác.", NgheNghiepId = 21 },

                // Nghề 22: Market Research and Analysis
                new ChuyenNganh { Id = 91, TenChuyenNganh = "Nghiên cứu thị trường (Market Research)", MoTa = "Thu thập, phân tích dữ liệu thị trường để hỗ trợ chiến lược doanh nghiệp.", NgheNghiepId = 22 },
                new ChuyenNganh { Id = 92, TenChuyenNganh = "Data Analyst", MoTa = "Phân tích dữ liệu người dùng, hành vi và hiệu quả kinh doanh để đưa ra insight.", NgheNghiepId = 22 },
                new ChuyenNganh { Id = 93, TenChuyenNganh = "Chuyên môn Market Research and Analysis khác", MoTa = "Các nghiệp vụ khác trong nghiên cứu thị trường và phân tích dữ liệu.", NgheNghiepId = 22 },
                new ChuyenNganh { Id = 94, TenChuyenNganh = "Business Intelligence", MoTa = "Xây dựng báo cáo, dashboard và phân tích hiệu suất doanh nghiệp.", NgheNghiepId = 22 },
                new ChuyenNganh { Id = 95, TenChuyenNganh = "Quantitative Analyst", MoTa = "Phân tích định lượng, mô hình thống kê và dự báo xu hướng thị trường.", NgheNghiepId = 22 },

                // Nghề 23: Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện
                new ChuyenNganh { Id = 96, TenChuyenNganh = "Sales Marketing", MoTa = "Tư vấn và bán các gói dịch vụ marketing, quảng cáo và truyền thông.", NgheNghiepId = 23 },
                new ChuyenNganh { Id = 97, TenChuyenNganh = "Kinh doanh dịch vụ quảng cáo", MoTa = "Bán các gói quảng cáo, truyền thông và giải pháp marketing cho doanh nghiệp.", NgheNghiepId = 23 },
                new ChuyenNganh { Id = 98, TenChuyenNganh = "Kinh doanh tiệc/sự kiện/hội nghị", MoTa = "Tư vấn và bán dịch vụ tổ chức sự kiện, hội nghị và tiệc doanh nghiệp.", NgheNghiepId = 23 },
                new ChuyenNganh { Id = 99, TenChuyenNganh = "Sales dịch vụ Quảng cáo/Triển lãm/Sự kiện khác", MoTa = "Các mảng kinh doanh khác liên quan đến quảng cáo, triển lãm và sự kiện.", NgheNghiepId = 23 },
                new ChuyenNganh { Id = 100, TenChuyenNganh = "Kinh doanh mảng Nhà tài trợ", MoTa = "Tìm kiếm và ký kết nhà tài trợ cho sự kiện, chương trình hoặc dự án.", NgheNghiepId = 23 },
                new ChuyenNganh { Id = 101, TenChuyenNganh = "Kinh doanh triển lãm", MoTa = "Bán dịch vụ gian hàng, gói trưng bày và quyền lợi cho các nhà triển lãm.", NgheNghiepId = 23 },

                // Nghề 24: Marketing - PR - Quảng cáo khác
                new ChuyenNganh { Id = 102, TenChuyenNganh = "Chuyên môn Marketing/PR/Quảng cáo khác", MoTa = "Các chuyên môn khác thuộc lĩnh vực Marketing, PR và Quảng cáo.", NgheNghiepId = 24 },
                new ChuyenNganh { Id = 103, TenChuyenNganh = "Vendor Management Executive/Supplier Relationship Management Executive", MoTa = "Quản lý nhà cung cấp, đàm phán hợp đồng và tối ưu chi phí marketing.", NgheNghiepId = 24 },
                new ChuyenNganh { Id = 104, TenChuyenNganh = "PG", MoTa = "Đại diện thương hiệu tại sự kiện, hỗ trợ quảng bá sản phẩm và dịch vụ.", NgheNghiepId = 24 },
                new ChuyenNganh { Id = 105, TenChuyenNganh = "Nhân viên phát tờ rơi", MoTa = "Hỗ trợ quảng bá trực tiếp thông qua phát tờ rơi tại các khu vực chỉ định.", NgheNghiepId = 24 },

                // Nghề 25: Chăm sóc khách hàng (Customer Service)
                new ChuyenNganh { Id = 106, TenChuyenNganh = "Chăm sóc khách hàng", MoTa = "Tiếp nhận và hỗ trợ giải quyết nhu cầu, thắc mắc của khách hàng.", NgheNghiepId = 25 },
                new ChuyenNganh { Id = 107, TenChuyenNganh = "Dịch vụ khách hàng/Chăm sóc khách hàng khác", MoTa = "Các nghiệp vụ khác liên quan đến dịch vụ và chăm sóc khách hàng.", NgheNghiepId = 25 },
                new ChuyenNganh { Id = 108, TenChuyenNganh = "Call Center/Trực tổng đài", MoTa = "Tiếp nhận cuộc gọi, giải đáp thông tin và hỗ trợ sự cố cho khách hàng.", NgheNghiepId = 25 },
                new ChuyenNganh { Id = 109, TenChuyenNganh = "Trực page", MoTa = "Phản hồi tin nhắn và hỗ trợ khách hàng qua fanpage hoặc kênh mạng xã hội.", NgheNghiepId = 25 },
                new ChuyenNganh { Id = 110, TenChuyenNganh = "Customer Experience (Trải nghiệm khách hàng)", MoTa = "Cải thiện trải nghiệm, đo lường mức độ hài lòng của khách hàng.", NgheNghiepId = 25 },
                new ChuyenNganh { Id = 111, TenChuyenNganh = "Customer Success", MoTa = "Đồng hành với khách hàng để đảm bảo họ đạt được mục tiêu khi sử dụng sản phẩm/dịch vụ.", NgheNghiepId = 25 },

                // Nghề 26: Vận hành Thương mại điện tử
                new ChuyenNganh { Id = 112, TenChuyenNganh = "Vận hành sàn thương mại điện tử", MoTa = "Quản lý gian hàng, xử lý đơn, tối ưu vận hành trên các sàn TMĐT.", NgheNghiepId = 26 },

                // Nghề 27: Business Operation (Vận hành kinh doanh)
                new ChuyenNganh { Id = 113, TenChuyenNganh = "Vận hành chung", MoTa = "Quản lý và tối ưu các quy trình vận hành nhằm hỗ trợ hoạt động kinh doanh.", NgheNghiepId = 27 },
                new ChuyenNganh { Id = 114, TenChuyenNganh = "Data Labeling (Gán nhãn dữ liệu)", MoTa = "Gán nhãn, phân loại và xử lý dữ liệu phục vụ mô hình AI/ML.", NgheNghiepId = 27 },

                // Nghề 28: Quản lý vận hành
                new ChuyenNganh { Id = 115, TenChuyenNganh = "Quản lý/Trưởng phòng vận hành", MoTa = "Quản lý đội ngũ và tối ưu quy trình vận hành của doanh nghiệp.", NgheNghiepId = 28 },
                new ChuyenNganh { Id = 116, TenChuyenNganh = "Giám đốc vận hành/COO", MoTa = "Lãnh đạo toàn bộ hoạt động vận hành và đảm bảo hiệu quả kinh doanh.", NgheNghiepId = 28 },
                new ChuyenNganh { Id = 117, TenChuyenNganh = "Giám đốc dịch vụ khách hàng", MoTa = "Quản lý chiến lược dịch vụ, nâng cao trải nghiệm và sự hài lòng của khách hàng.", NgheNghiepId = 28 },

                // Nghề 28: Dịch vụ khách hàng - Vận hành khác
                new ChuyenNganh { Id = 118, TenChuyenNganh = "Dịch vụ khách hàng - Vận hành khác", MoTa = "Các vị trí khác thuộc mảng dịch vụ khách hàng và vận hành.", NgheNghiepId = 28 },

                // Nghề 30: Nhân sự (Human Resources)
                new ChuyenNganh { Id = 119, TenChuyenNganh = "Tuyển dụng", MoTa = "Thực hiện quy trình tìm kiếm, sàng lọc và phỏng vấn ứng viên.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 120, TenChuyenNganh = "Đào tạo", MoTa = "Lập kế hoạch, triển khai và đánh giá chương trình đào tạo nhân sự.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 121, TenChuyenNganh = "Nhân sự tổng hợp", MoTa = "Quản lý hồ sơ, hợp đồng lao động và các nghiệp vụ nhân sự chung.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 122, TenChuyenNganh = "Payroll/C&B (Lương/Thưởng/Phúc lợi)", MoTa = "Tính lương, thưởng, chế độ và xây dựng chính sách phúc lợi.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 123, TenChuyenNganh = "Trưởng phòng nhân sự", MoTa = "Quản lý bộ phận nhân sự, xây dựng chiến lược và quy trình HR.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 124, TenChuyenNganh = "Đối tác nhân sự (HRBP)", MoTa = "Kết nối chiến lược giữa phòng nhân sự và các bộ phận trong doanh nghiệp.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 125, TenChuyenNganh = "Chuyên môn Nhân sự khác", MoTa = "Các chuyên môn khác trong lĩnh vực nhân sự và quản lý con người.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 126, TenChuyenNganh = "Giám đốc nhân sự", MoTa = "Lãnh đạo toàn bộ chiến lược nhân sự và văn hoá doanh nghiệp.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 127, TenChuyenNganh = "Phát triển tổ chức", MoTa = "Xây dựng cấu trúc tổ chức, tối ưu nhân sự và chiến lược tăng trưởng.", NgheNghiepId = 30 },
                new ChuyenNganh { Id = 128, TenChuyenNganh = "Quan hệ lao động", MoTa = "Giải quyết tranh chấp, kỷ luật lao động và đảm bảo tuân thủ pháp luật.", NgheNghiepId = 30 },


                // Nghề 31: Hành chính - Văn phòng
                new ChuyenNganh { Id = 129, TenChuyenNganh = "Trợ lý/Thư ký", MoTa = "Hỗ trợ lãnh đạo trong công việc hằng ngày, sắp xếp lịch và xử lý thông tin.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 130, TenChuyenNganh = "Hành chính nhân sự", MoTa = "Thực hiện công tác hành chính kết hợp hỗ trợ các nghiệp vụ nhân sự.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 131, TenChuyenNganh = "Hành chính tổng hợp", MoTa = "Quản lý văn phòng, hồ sơ, trang thiết bị và hỗ trợ các bộ phận.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 132, TenChuyenNganh = "Xử lý hồ sơ", MoTa = "Tiếp nhận, kiểm tra và xử lý hồ sơ, giấy tờ hành chính.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 133, TenChuyenNganh = "Tài xế lái xe văn phòng", MoTa = "Phụ trách đưa đón nhân viên, đối tác theo lịch công ty.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 134, TenChuyenNganh = "Lễ tân/Đón tiếp", MoTa = "Tiếp nhận khách, hỗ trợ thông tin và thực hiện công tác lễ tân.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 135, TenChuyenNganh = "Chuyên môn Hành chính khác", MoTa = "Các nghiệp vụ khác thuộc lĩnh vực hành chính – văn phòng.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 136, TenChuyenNganh = "Trưởng phòng hành chính", MoTa = "Quản lý toàn bộ công tác hành chính và điều phối hoạt động văn phòng.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 137, TenChuyenNganh = "Văn thư", MoTa = "Quản lý công văn đi – đến, lưu trữ hồ sơ và soạn thảo văn bản.", NgheNghiepId = 31 },
                new ChuyenNganh { Id = 138, TenChuyenNganh = "Lái xe cho sếp", MoTa = "Đưa đón lãnh đạo, đảm bảo an toàn và lịch trình di chuyển.", NgheNghiepId = 31 },

                // Nghề 32: Dịch vụ pháp chế (In-house)
                new ChuyenNganh { Id = 139, TenChuyenNganh = "Pháp chế", MoTa = "Thực hiện tư vấn pháp lý và đảm bảo tuân thủ pháp luật trong doanh nghiệp.", NgheNghiepId = 32 },
                new ChuyenNganh { Id = 140, TenChuyenNganh = "Chuyên môn Pháp chế khác", MoTa = "Các nghiệp vụ pháp chế khác liên quan đến hợp đồng, tuân thủ và rủi ro pháp lý.", NgheNghiepId = 32 },
                new ChuyenNganh { Id = 141, TenChuyenNganh = "Giám đốc pháp chế", MoTa = "Lãnh đạo bộ phận pháp chế, định hướng chiến lược pháp lý và quản trị rủi ro cho doanh nghiệp.", NgheNghiepId = 32 },

                // Nghề 33: Nhân sự - Hành chính - Pháp chế khác
                new ChuyenNganh { Id = 142, TenChuyenNganh = "Chuyên môn Nhân sự/Hành chính/Pháp chế khác", MoTa = "Các chuyên môn khác thuộc nhóm Nhân sự, Hành chính và Pháp chế trong doanh nghiệp.", NgheNghiepId = 33 },

                // Nghề 34: Software Engineering
                new ChuyenNganh { Id = 143, TenChuyenNganh = "Software Engineer", MoTa = "Phát triển và duy trì phần mềm theo quy trình kỹ thuật phần mềm.", NgheNghiepId = 34 },
                new ChuyenNganh { Id = 144, TenChuyenNganh = "Backend Developer", MoTa = "Xây dựng API, dịch vụ backend và hệ thống xử lý dữ liệu.", NgheNghiepId = 34 },
                new ChuyenNganh { Id = 145, TenChuyenNganh = "Fullstack Developer", MoTa = "Phát triển cả frontend và backend, xây dựng hệ thống hoàn chỉnh.", NgheNghiepId = 34 },
                new ChuyenNganh { Id = 146, TenChuyenNganh = "Mobile Developer", MoTa = "Phát triển ứng dụng mobile trên iOS/Android.", NgheNghiepId = 34 },
                new ChuyenNganh { Id = 147, TenChuyenNganh = "Frontend Developer", MoTa = "Phát triển giao diện người dùng, tối ưu trải nghiệm và hiệu năng.", NgheNghiepId = 34 },
                new ChuyenNganh { Id = 148, TenChuyenNganh = "Blockchain Engineer", MoTa = "Phát triển ứng dụng blockchain, smart contract và hệ thống phi tập trung.", NgheNghiepId = 34 },

                // Nghề 35: Software Testing
                new ChuyenNganh { Id = 149, TenChuyenNganh = "Software Tester (Automation & Manual)", MoTa = "Thực hiện kiểm thử phần mềm bằng phương pháp thủ công và tự động.", NgheNghiepId = 35 },
                new ChuyenNganh { Id = 150, TenChuyenNganh = "Manual Tester", MoTa = "Kiểm thử phần mềm thủ công, phát hiện lỗi và đảm bảo chất lượng sản phẩm.", NgheNghiepId = 35 },
                new ChuyenNganh { Id = 151, TenChuyenNganh = "Automation Tester", MoTa = "Viết script và sử dụng công cụ tự động để kiểm thử phần mềm.", NgheNghiepId = 35 },
                new ChuyenNganh { Id = 152, TenChuyenNganh = "QA Engineer", MoTa = "Đảm bảo chất lượng sản phẩm thông qua quy trình kiểm thử và tiêu chuẩn QA.", NgheNghiepId = 35 },
                new ChuyenNganh { Id = 153, TenChuyenNganh = "Process Quality Assurance (PQA)", MoTa = "Giám sát quy trình sản xuất phần mềm và đảm bảo tuân thủ tiêu chuẩn chất lượng.", NgheNghiepId = 35 },
                new ChuyenNganh { Id = 154, TenChuyenNganh = "Game Tester", MoTa = "Kiểm thử tính năng, hiệu năng và trải nghiệm trong các sản phẩm game.", NgheNghiepId = 35 },

                // Nghề 36: Artificial Intelligence (AI)
                new ChuyenNganh { Id = 155, TenChuyenNganh = "AI Engineer", MoTa = "Phát triển mô hình AI/ML, xây dựng hệ thống trí tuệ nhân tạo ứng dụng vào sản phẩm.", NgheNghiepId = 36 },
                new ChuyenNganh { Id = 156, TenChuyenNganh = "Data Labeling (Gán nhãn dữ liệu)", MoTa = "Xử lý, phân loại và gán nhãn dữ liệu phục vụ huấn luyện mô hình AI.", NgheNghiepId = 36 },
                new ChuyenNganh { Id = 157, TenChuyenNganh = "AI Researcher", MoTa = "Nghiên cứu thuật toán, mô hình và kiến trúc mới trong lĩnh vực trí tuệ nhân tạo.", NgheNghiepId = 36 },

                // Nghề 37: Data Science & Big Data
                new ChuyenNganh { Id = 158, TenChuyenNganh = "Data Analyst", MoTa = "Phân tích dữ liệu để tạo insight, hỗ trợ quyết định kinh doanh.", NgheNghiepId = 37 },
                new ChuyenNganh { Id = 159, TenChuyenNganh = "Data Engineer", MoTa = "Xây dựng hạ tầng dữ liệu, pipeline ETL và hệ thống xử lý dữ liệu lớn.", NgheNghiepId = 37 },
                new ChuyenNganh { Id = 160, TenChuyenNganh = "Data Scientist", MoTa = "Ứng dụng thuật toán và mô hình thống kê để dự đoán và phân tích chuyên sâu.", NgheNghiepId = 37 },

                // Nghề 38: IT Infrastructure and Operations
                new ChuyenNganh { Id = 161, TenChuyenNganh = "IT Helpdesk/IT Support", MoTa = "Hỗ trợ kỹ thuật, xử lý sự cố phần mềm và phần cứng cho người dùng.", NgheNghiepId = 38 },
                new ChuyenNganh { Id = 162, TenChuyenNganh = "System Engineer", MoTa = "Triển khai và vận hành hệ thống máy chủ, dịch vụ và hạ tầng CNTT.", NgheNghiepId = 38 },
                new ChuyenNganh { Id = 163, TenChuyenNganh = "DevOps Engineer", MoTa = "Tự động hóa triển khai, tối ưu hệ thống và quản lý CI/CD.", NgheNghiepId = 38 },
                new ChuyenNganh { Id = 164, TenChuyenNganh = "System Administrator", MoTa = "Quản trị hệ thống, giám sát hoạt động và đảm bảo tính ổn định cho hạ tầng.", NgheNghiepId = 38 },
                new ChuyenNganh { Id = 165, TenChuyenNganh = "Kỹ thuật IT", MoTa = "Lắp đặt, bảo trì thiết bị CNTT và hỗ trợ vận hành hạ tầng kỹ thuật.", NgheNghiepId = 38 },
                new ChuyenNganh { Id = 166, TenChuyenNganh = "Network Engineer", MoTa = "Thiết kế, vận hành và bảo trì hệ thống mạng trong doanh nghiệp.", NgheNghiepId = 38 },
                new ChuyenNganh { Id = 167, TenChuyenNganh = "Database Administrator (DBA)", MoTa = "Quản trị cơ sở dữ liệu, tối ưu hiệu năng và đảm bảo an toàn dữ liệu.", NgheNghiepId = 38 },
                new ChuyenNganh { Id = 168, TenChuyenNganh = "Cloud Engineer", MoTa = "Triển khai và vận hành hệ thống cloud như AWS, Azure, GCP.", NgheNghiepId = 38 },

                // Nghề 39: Information Security
                new ChuyenNganh { Id = 169, TenChuyenNganh = "Quản trị và vận hành bảo mật", MoTa = "Triển khai, giám sát và vận hành hệ thống an ninh mạng trong doanh nghiệp.", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 170, TenChuyenNganh = "Chuyên viên Cyber Security", MoTa = "Phát hiện, phòng chống và xử lý các mối đe dọa liên quan đến an ninh mạng.", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 171, TenChuyenNganh = "Chuyên viên IT Security", MoTa = "Đảm bảo an toàn cho hệ thống CNTT bằng các giải pháp bảo mật kỹ thuật.", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 172, TenChuyenNganh = "Kiểm thử và đánh giá bảo mật", MoTa = "Thực hiện PenTest, kiểm thử xâm nhập và đánh giá lỗ hổng bảo mật.", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 173, TenChuyenNganh = "Tuân thủ và kiểm toán bảo mật", MoTa = "Đảm bảo hệ thống tuân thủ tiêu chuẩn bảo mật như ISO 27001, PCI-DSS.", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 174, TenChuyenNganh = "Chiến lược và phân tích bảo mật", MoTa = "Xây dựng chiến lược an ninh mạng và phân tích rủi ro bảo mật doanh nghiệp.", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 175, TenChuyenNganh = "Phòng chống lừa đảo và an ninh mạng", MoTa = "Theo dõi, phát hiện và xử lý các hành vi gian lận và tấn công mạng.", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 176, TenChuyenNganh = "Bảo mật ứng dụng và phát triển", MoTa = "Tích hợp bảo mật vào quy trình phát triển phần mềm (AppSec, DevSecOps).", NgheNghiepId = 39 },
                new ChuyenNganh { Id = 177, TenChuyenNganh = "Mã hóa và bảo mật dữ liệu", MoTa = "Ứng dụng mã hóa và giải pháp bảo vệ dữ liệu nhạy cảm.", NgheNghiepId = 39 },

                // Nghề 40: IoT - Embedded Engineer
                new ChuyenNganh { Id = 178, TenChuyenNganh = "Embedded Engineer/Lập trình nhúng", MoTa = "Phát triển phần mềm nhúng cho vi điều khiển, thiết bị phần cứng và hệ thống IoT.", NgheNghiepId = 40 },
                new ChuyenNganh { Id = 179, TenChuyenNganh = "Kỹ sư IoT (IoT Engineer)", MoTa = "Thiết kế, phát triển và triển khai giải pháp IoT kết nối thiết bị và hệ thống.", NgheNghiepId = 40 },

                // Nghề 41: IT Project Management
                new ChuyenNganh { Id = 180, TenChuyenNganh = "IT Project Manager", MoTa = "Quản lý dự án CNTT, điều phối đội ngũ và đảm bảo tiến độ - chất lượng sản phẩm.", NgheNghiepId = 41 },
                new ChuyenNganh { Id = 181, TenChuyenNganh = "Kỹ sư cầu nối BrSE", MoTa = "Làm cầu nối giữa khách hàng và đội phát triển, phân tích yêu cầu và quản lý giao tiếp.", NgheNghiepId = 41 },
                new ChuyenNganh { Id = 182, TenChuyenNganh = "IT Comtor", MoTa = "Thông dịch viên IT, hỗ trợ giao tiếp giữa các nhóm kỹ thuật và khách hàng nước ngoài.", NgheNghiepId = 41 },
                new ChuyenNganh { Id = 183, TenChuyenNganh = "Scrum Master", MoTa = "Dẫn dắt nhóm theo mô hình Agile/Scrum, tối ưu quy trình và loại bỏ cản trở.", NgheNghiepId = 41 },

                // Nghề 42: IT Management - Specialist
                new ChuyenNganh { Id = 184, TenChuyenNganh = "Technical Leader", MoTa = "Dẫn dắt kỹ thuật, định hướng giải pháp và hỗ trợ đội ngũ phát triển.", NgheNghiepId = 42 },
                new ChuyenNganh { Id = 185, TenChuyenNganh = "Solution Architect", MoTa = "Thiết kế kiến trúc tổng thể cho hệ thống, đảm bảo hiệu năng và khả năng mở rộng.", NgheNghiepId = 42 },
                new ChuyenNganh { Id = 186, TenChuyenNganh = "Technical Manager", MoTa = "Quản lý đội kỹ thuật, phân bổ nguồn lực và giám sát tiến độ dự án.", NgheNghiepId = 42 },
                new ChuyenNganh { Id = 187, TenChuyenNganh = "Software Architect", MoTa = "Thiết kế kiến trúc ứng dụng phần mềm, đảm bảo chất lượng và tính ổn định.", NgheNghiepId = 42 },
                new ChuyenNganh { Id = 188, TenChuyenNganh = "Chief Technology Officer (CTO)", MoTa = "Lãnh đạo chiến lược công nghệ, định hướng giải pháp và đổi mới sản phẩm.", NgheNghiepId = 42 },
                new ChuyenNganh { Id = 189, TenChuyenNganh = "Head of Engineering", MoTa = "Quản lý toàn bộ bộ phận kỹ thuật và phát triển sản phẩm.", NgheNghiepId = 42 },
                new ChuyenNganh { Id = 190, TenChuyenNganh = "System Architect", MoTa = "Thiết kế và tối ưu kiến trúc hệ thống CNTT quy mô lớn.", NgheNghiepId = 42 },
                new ChuyenNganh { Id = 191, TenChuyenNganh = "Chief Information Officer (CIO)", MoTa = "Quản lý hệ thống thông tin doanh nghiệp và chiến lược công nghệ dài hạn.", NgheNghiepId = 42 },

                // Nghề 43: Software Design
                new ChuyenNganh { Id = 192, TenChuyenNganh = "UI/UX Design", MoTa = "Thiết kế giao diện và trải nghiệm người dùng cho sản phẩm số.", NgheNghiepId = 43 },
                new ChuyenNganh { Id = 193, TenChuyenNganh = "Thiết kế đồ họa (Graphic Design)", MoTa = "Thiết kế hình ảnh, ấn phẩm và đồ họa phục vụ sản phẩm phần mềm.", NgheNghiepId = 43 },
                new ChuyenNganh { Id = 194, TenChuyenNganh = "Interaction Designer", MoTa = "Thiết kế tương tác để tối ưu trải nghiệm sử dụng sản phẩm số.", NgheNghiepId = 43 },
                new ChuyenNganh { Id = 195, TenChuyenNganh = "Animation Design", MoTa = "Thiết kế chuyển động, animation cho giao diện và sản phẩm kỹ thuật số.", NgheNghiepId = 43 },
                new ChuyenNganh { Id = 196, TenChuyenNganh = "3D Modeler", MoTa = "Thiết kế mô hình 3D phục vụ game, ứng dụng và sản phẩm phần mềm.", NgheNghiepId = 43 },

                // Nghề 44: Product Management
                new ChuyenNganh { Id = 197, TenChuyenNganh = "Business Analyst (Phân tích nghiệp vụ)", MoTa = "Phân tích yêu cầu, tối ưu quy trình và làm cầu nối giữa nghiệp vụ và kỹ thuật.", NgheNghiepId = 44 },
                new ChuyenNganh { Id = 198, TenChuyenNganh = "Product Owner/Product Manager", MoTa = "Quản lý sản phẩm, xây dựng roadmap và phối hợp đội ngũ để phát triển tính năng.", NgheNghiepId = 44 },
                new ChuyenNganh { Id = 199, TenChuyenNganh = "Product Analyst/Research", MoTa = "Phân tích dữ liệu sản phẩm, nghiên cứu thị trường và đề xuất cải tiến.", NgheNghiepId = 44 },

                // Nghề 45: Game Development
                new ChuyenNganh { Id = 200, TenChuyenNganh = "Game Design", MoTa = "Thiết kế gameplay, cơ chế, cốt truyện và trải nghiệm game.", NgheNghiepId = 45 },
                new ChuyenNganh { Id = 201, TenChuyenNganh = "Game Developer", MoTa = "Lập trình và phát triển tính năng trong trò chơi trên nhiều nền tảng.", NgheNghiepId = 45 },
                new ChuyenNganh { Id = 202, TenChuyenNganh = "Vị trí Game Development khác", MoTa = "Các vị trí khác thuộc lĩnh vực phát triển game.", NgheNghiepId = 45 },
                new ChuyenNganh { Id = 203, TenChuyenNganh = "Concept Artist", MoTa = "Thiết kế ý tưởng nhân vật, bối cảnh và đồ họa cho game.", NgheNghiepId = 45 },
                new ChuyenNganh { Id = 204, TenChuyenNganh = "AR/VR Developer", MoTa = "Phát triển ứng dụng và trò chơi sử dụng công nghệ AR/VR.", NgheNghiepId = 45 },

                // Nghề 46: Sales IT Phần mềm
                new ChuyenNganh { Id = 205, TenChuyenNganh = "Kinh doanh phần mềm", MoTa = "Tư vấn và bán các giải pháp phần mềm cho doanh nghiệp và cá nhân.", NgheNghiepId = 46 },
                new ChuyenNganh { Id = 206, TenChuyenNganh = "Kinh doanh Domain/Hosting/Server", MoTa = "Bán dịch vụ domain, hosting, server và giải pháp hạ tầng IT.", NgheNghiepId = 46 },
                new ChuyenNganh { Id = 207, TenChuyenNganh = "Sales IT Phần mềm khác", MoTa = "Các hoạt động kinh doanh liên quan đến sản phẩm và dịch vụ IT khác.", NgheNghiepId = 46 },

                // Nghề 47: Công nghệ Thông tin khác
                new ChuyenNganh { Id = 208, TenChuyenNganh = "Chuyên môn Công nghệ thông tin khác", MoTa = "Các chuyên môn khác thuộc lĩnh vực CNTT không nằm trong nhóm cụ thể.", NgheNghiepId = 47 },
                new ChuyenNganh { Id = 209, TenChuyenNganh = "IT Consultant", MoTa = "Tư vấn giải pháp CNTT và hỗ trợ doanh nghiệp triển khai công nghệ.", NgheNghiepId = 47 },
                new ChuyenNganh { Id = 210, TenChuyenNganh = "Bán hàng kỹ thuật IT", MoTa = "Tư vấn và bán giải pháp kỹ thuật, thiết bị và hệ thống IT.", NgheNghiepId = 47 },
                new ChuyenNganh { Id = 211, TenChuyenNganh = "GIS Engineer", MoTa = "Phát triển và vận hành hệ thống thông tin địa lý (GIS).", NgheNghiepId = 47 },

                // Nghề 48: Công nhân
                new ChuyenNganh { Id = 212, TenChuyenNganh = "Công nhân may", MoTa = "Thực hiện may mặc, vận hành máy may công nghiệp.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 213, TenChuyenNganh = "Công nhân cơ khí", MoTa = "Gia công, lắp ráp và vận hành thiết bị cơ khí.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 214, TenChuyenNganh = "Công nhân xây dựng", MoTa = "Thi công công trình, vận hành máy và hỗ trợ xây dựng.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 215, TenChuyenNganh = "Công nhân thời vụ", MoTa = "Làm việc theo thời vụ trong các nhà máy hoặc công trường.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 216, TenChuyenNganh = "Công nhân bốc xếp hàng hóa", MoTa = "Bốc xếp, vận chuyển và sắp xếp hàng hóa trong kho/xưởng.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 217, TenChuyenNganh = "Công nhân đóng gói hàng hóa", MoTa = "Đóng gói sản phẩm theo quy trình của nhà máy.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 218, TenChuyenNganh = "Công nhân môi trường", MoTa = "Vệ sinh môi trường, thu gom rác và xử lý rác thải.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 219, TenChuyenNganh = "Công nhân chăn nuôi", MoTa = "Chăm sóc vật nuôi và hỗ trợ công việc tại trang trại.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 220, TenChuyenNganh = "Công nhân làm nước đá", MoTa = "Vận hành máy sản xuất nước đá và đóng gói thành phẩm.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 221, TenChuyenNganh = "Công nhân xưởng gỗ", MoTa = "Gia công, cắt và lắp ráp các sản phẩm từ gỗ.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 222, TenChuyenNganh = "Công nhân bao bì", MoTa = "Sản xuất, đóng gói và kiểm tra chất lượng bao bì.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 223, TenChuyenNganh = "Công nhân điện tử", MoTa = "Lắp ráp linh kiện điện tử và kiểm tra chất lượng sản phẩm.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 224, TenChuyenNganh = "Công nhân sản xuất", MoTa = "Tham gia dây chuyền sản xuất trong nhà máy.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 225, TenChuyenNganh = "Công nhân ép nhựa", MoTa = "Vận hành máy ép nhựa và kiểm tra sản phẩm đầu ra.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 226, TenChuyenNganh = "Công nhân giày da", MoTa = "Gia công, sản xuất và hoàn thiện các sản phẩm giày da.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 227, TenChuyenNganh = "Công nhân vận hành máy", MoTa = "Vận hành máy móc sản xuất theo quy trình tiêu chuẩn.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 228, TenChuyenNganh = "Công nhân khai thác than", MoTa = "Khai thác, vận chuyển và xử lý than theo quy định.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 229, TenChuyenNganh = "Công nhân lắp ráp", MoTa = "Lắp ráp linh kiện và sản phẩm theo quy trình.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 230, TenChuyenNganh = "Công nhân xếp quần áo", MoTa = "Gấp, phân loại và đóng kiện quần áo trong xưởng.", NgheNghiepId = 48 },
                new ChuyenNganh { Id = 231, TenChuyenNganh = "Việc làm Công nhân khác", MoTa = "Các công việc công nhân phổ thông khác theo nhu cầu doanh nghiệp.", NgheNghiepId = 48 },

                // Nghề 49: Tài xế
                new ChuyenNganh { Id = 232, TenChuyenNganh = "Tài xế taxi", MoTa = "Lái taxi, đưa đón khách theo lộ trình được phân công.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 233, TenChuyenNganh = "Tài xế B2", MoTa = "Lái các loại xe theo tiêu chuẩn bằng B2, phục vụ vận tải hoặc cá nhân.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 234, TenChuyenNganh = "Tài xế xe tải", MoTa = "Vận chuyển hàng hóa bằng xe tải trong và ngoài tỉnh.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 235, TenChuyenNganh = "Phụ xe", MoTa = "Hỗ trợ tài xế bốc xếp hàng hóa và quản lý lộ trình.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 236, TenChuyenNganh = "Lái xe cho sếp", MoTa = "Đưa đón lãnh đạo, đảm bảo an toàn và đúng lịch trình.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 237, TenChuyenNganh = "Tài xế công nghệ", MoTa = "Chạy xe công nghệ như Grab, Gojek, Be để đưa đón khách hoặc giao hàng.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 238, TenChuyenNganh = "Tài xế container", MoTa = "Vận hành xe container, vận chuyển hàng hóa nặng và kích thước lớn.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 239, TenChuyenNganh = "Tài xế lái xe văn phòng", MoTa = "Lái xe phục vụ nội bộ công ty và các chuyến công tác.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 240, TenChuyenNganh = "Tài xế xe khách", MoTa = "Lái xe chở khách trên các tuyến cố định hoặc hợp đồng.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 241, TenChuyenNganh = "Tài xế lái xe nâng", MoTa = "Vận hành xe nâng để di chuyển và sắp xếp hàng hóa trong kho/xưởng.", NgheNghiepId = 49 },
                new ChuyenNganh { Id = 242, TenChuyenNganh = "Tài xế lái xe đường dài", MoTa = "Vận chuyển hàng hóa hoặc hành khách trên các tuyến đường dài liên tỉnh.", NgheNghiepId = 49 },

                // Nghề 50: Kho vận - Giao hàng
                new ChuyenNganh { Id = 243, TenChuyenNganh = "Nhân viên kho", MoTa = "Quản lý xuất nhập kho, kiểm kê và sắp xếp hàng hóa.", NgheNghiepId = 50 },
                new ChuyenNganh { Id = 244, TenChuyenNganh = "Shipper (Nhân viên giao hàng)", MoTa = "Giao nhận hàng hóa theo tuyến hoặc theo yêu cầu khách hàng.", NgheNghiepId = 50 },
                new ChuyenNganh { Id = 245, TenChuyenNganh = "Công nhân bốc xếp hàng hóa", MoTa = "Bốc xếp, vận chuyển và sắp xếp hàng hóa trong kho hoặc xe tải.", NgheNghiepId = 50 },
                new ChuyenNganh { Id = 246, TenChuyenNganh = "Bưu tá", MoTa = "Giao thư, bưu phẩm và xử lý các dịch vụ bưu chính.", NgheNghiepId = 50 },
                new ChuyenNganh { Id = 247, TenChuyenNganh = "Phân loại/Sắp xếp hàng hoá", MoTa = "Phân loại, sắp xếp và kiểm tra hàng hóa theo quy trình kho vận.", NgheNghiepId = 50 },
                new ChuyenNganh { Id = 248, TenChuyenNganh = "Công nhân đóng gói hàng hóa", MoTa = "Đóng gói sản phẩm theo tiêu chuẩn đóng gói của kho hoặc nhà máy.", NgheNghiepId = 50 },

                // Nghề 60: Bảo vệ - Bảo trì - Sửa chữa
                new ChuyenNganh { Id = 249, TenChuyenNganh = "Sửa chữa điện thoại", MoTa = "Sửa chữa, thay thế linh kiện và khắc phục lỗi điện thoại.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 250, TenChuyenNganh = "Bảo vệ", MoTa = "Đảm bảo an ninh, kiểm soát ra vào và bảo vệ tài sản.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 251, TenChuyenNganh = "Sửa chữa/Bảo trì điện nước", MoTa = "Sửa chữa và bảo trì hệ thống điện, nước cho nhà ở hoặc công trình.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 252, TenChuyenNganh = "Thợ sửa khoá", MoTa = "Sửa chữa, mở khóa và xử lý các vấn đề liên quan đến khóa.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 253, TenChuyenNganh = "Thợ điện", MoTa = "Lắp đặt và sửa chữa hệ thống điện dân dụng hoặc công nghiệp.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 254, TenChuyenNganh = "Thợ điện lạnh", MoTa = "Lắp đặt, sửa chữa và bảo trì máy lạnh, tủ lạnh và thiết bị điện lạnh.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 255, TenChuyenNganh = "Bảo trì tòa nhà", MoTa = "Kiểm tra, bảo trì hệ thống kỹ thuật và cơ sở vật chất tòa nhà.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 256, TenChuyenNganh = "Thợ sửa xe", MoTa = "Sửa chữa và bảo trì xe máy hoặc ô tô.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 257, TenChuyenNganh = "Nhân viên rửa xe", MoTa = "Vệ sinh và chăm sóc xe theo quy trình của cửa hàng.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 258, TenChuyenNganh = "Sửa chữa máy tính và máy in", MoTa = "Sửa chữa và bảo trì máy tính, máy in và thiết bị văn phòng.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 259, TenChuyenNganh = "Lắp đặt/bảo trì thang máy", MoTa = "Lắp đặt và bảo trì hệ thống thang máy trong các tòa nhà.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 260, TenChuyenNganh = "Việc làm Bảo vệ/Bảo trì/Sửa chữa khác", MoTa = "Các công việc khác thuộc nhóm bảo vệ, bảo trì và sửa chữa.", NgheNghiepId = 60 },

                // Nghề 52: Vệ sinh - Giúp việc - Bảo mẫu
                new ChuyenNganh { Id = 261, TenChuyenNganh = "Vệ sinh/Tạp vụ", MoTa = "Thực hiện vệ sinh văn phòng, nhà ở và khu vực làm việc.", NgheNghiepId = 52 },
                new ChuyenNganh { Id = 262, TenChuyenNganh = "Giúp việc", MoTa = "Hỗ trợ công việc nhà, dọn dẹp và chăm sóc sinh hoạt gia đình.", NgheNghiepId = 52 },
                new ChuyenNganh { Id = 263, TenChuyenNganh = "Bảo mẫu/Người trông trẻ", MoTa = "Chăm sóc trẻ nhỏ, hỗ trợ ăn uống và sinh hoạt hằng ngày.", NgheNghiepId = 52 },
                new ChuyenNganh { Id = 264, TenChuyenNganh = "Nhân viên dọn vệ sinh", MoTa = "Dọn dẹp, vệ sinh khu vực theo quy trình tiêu chuẩn.", NgheNghiepId = 52 },
                new ChuyenNganh { Id = 265, TenChuyenNganh = "Dịch vụ vệ sinh/nhà cửa khác", MoTa = "Các công việc vệ sinh, chăm sóc nhà cửa khác theo nhu cầu.", NgheNghiepId = 52 },

                // Nghề 53: Chăm sóc sức khoẻ - Làm đẹp
                new ChuyenNganh { Id = 266, TenChuyenNganh = "Phun xăm thẩm mỹ", MoTa = "Thực hiện phun xăm, điêu khắc và các kỹ thuật thẩm mỹ.", NgheNghiepId = 53 },
                new ChuyenNganh { Id = 267, TenChuyenNganh = "Thợ xăm (Tattoo Artist)", MoTa = "Thiết kế và xăm hình nghệ thuật theo yêu cầu khách hàng.", NgheNghiepId = 53 },
                new ChuyenNganh { Id = 268, TenChuyenNganh = "Kỹ thuật viên Spa", MoTa = "Thực hiện các liệu trình chăm sóc da và thư giãn tại spa.", NgheNghiepId = 53 },
                new ChuyenNganh { Id = 269, TenChuyenNganh = "Thợ cắt tóc", MoTa = "Cắt, tạo kiểu và chăm sóc tóc cho khách hàng.", NgheNghiepId = 53 },
                new ChuyenNganh { Id = 270, TenChuyenNganh = "Thợ nail/mi", MoTa = "Làm móng, nối mi và các dịch vụ làm đẹp liên quan.", NgheNghiepId = 53 },
                new ChuyenNganh { Id = 271, TenChuyenNganh = "Nhân viên massage", MoTa = "Thực hiện các liệu pháp massage thư giãn và trị liệu.", NgheNghiepId = 53 },
                new ChuyenNganh { Id = 272, TenChuyenNganh = "Việc làm Chăm sóc sức khỏe/Làm đẹp khác", MoTa = "Các công việc khác thuộc lĩnh vực làm đẹp và chăm sóc sức khỏe.", NgheNghiepId = 53 },

                // Nghề 54: Nhà hàng - Dịch vụ ăn uống
                new ChuyenNganh { Id = 273, TenChuyenNganh = "Đầu bếp", MoTa = "Chế biến món ăn và quản lý quy trình bếp.", NgheNghiepId = 54 },
                new ChuyenNganh { Id = 274, TenChuyenNganh = "Pha chế (Barista)", MoTa = "Pha chế đồ uống và phục vụ tại quầy bar hoặc cà phê.", NgheNghiepId = 54 },
                new ChuyenNganh { Id = 275, TenChuyenNganh = "Phục vụ", MoTa = "Phục vụ khách hàng, nhận order và hỗ trợ vận hành nhà hàng.", NgheNghiepId = 54 },
                new ChuyenNganh { Id = 276, TenChuyenNganh = "Phụ bếp", MoTa = "Hỗ trợ đầu bếp sơ chế và chuẩn bị nguyên liệu.", NgheNghiepId = 54 },
                new ChuyenNganh { Id = 277, TenChuyenNganh = "Thợ làm bánh", MoTa = "Làm bánh, chuẩn bị nguyên liệu và trang trí sản phẩm.", NgheNghiepId = 54 },
                new ChuyenNganh { Id = 278, TenChuyenNganh = "Chuyên môn Nhà hàng/Dịch vụ ăn uống khác", MoTa = "Các vị trí khác trong lĩnh vực nhà hàng và dịch vụ ăn uống.", NgheNghiepId = 54 },

                // Nghề 55: Khách sạn / Dịch vụ cư trú
                new ChuyenNganh { Id = 279, TenChuyenNganh = "Giặt là", MoTa = "Thực hiện giặt, ủi và xử lý đồ vải trong khách sạn.", NgheNghiepId = 55 },
                new ChuyenNganh { Id = 280, TenChuyenNganh = "Lễ tân/Đón tiếp", MoTa = "Tiếp nhận khách, làm thủ tục check-in và check-out.", NgheNghiepId = 55 },
                new ChuyenNganh { Id = 281, TenChuyenNganh = "Bellman (nhân viên hành lý)", MoTa = "Hỗ trợ vận chuyển hành lý và hướng dẫn khách trong khách sạn.", NgheNghiepId = 55 },
                new ChuyenNganh { Id = 282, TenChuyenNganh = "Buồng phòng", MoTa = "Dọn dẹp phòng, thay vật dụng và đảm bảo tiêu chuẩn sạch sẽ.", NgheNghiepId = 55 },
                new ChuyenNganh { Id = 283, TenChuyenNganh = "Nhân viên đỗ xe (Valet Parking)", MoTa = "Nhận và đỗ xe cho khách tại khu vực khách sạn.", NgheNghiepId = 55 },

                // Nghề 56: Tiếp thị/Bán hàng
                new ChuyenNganh { Id = 284, TenChuyenNganh = "PG", MoTa = "Giới thiệu sản phẩm, hỗ trợ bán hàng tại sự kiện hoặc điểm bán.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 285, TenChuyenNganh = "Nhập liệu", MoTa = "Nhập dữ liệu sản phẩm, đơn hàng hoặc thông tin bán hàng.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 286, TenChuyenNganh = "Thu ngân", MoTa = "Thanh toán, xử lý hóa đơn và hỗ trợ khách hàng tại quầy.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 287, TenChuyenNganh = "Trực page", MoTa = "Tư vấn và chăm sóc khách hàng qua fanpage, chat.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 288, TenChuyenNganh = "Nhân viên siêu thị", MoTa = "Bán hàng, trưng bày, kiểm hàng trong siêu thị.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 289, TenChuyenNganh = "Bán hàng siêu thị/cửa hàng tiện ích/tiện lợi", MoTa = "Phục vụ và hỗ trợ khách hàng tại cửa hàng tiện lợi.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 290, TenChuyenNganh = "Nhân viên phát tờ rơi", MoTa = "Phát tờ rơi quảng bá sản phẩm/dịch vụ tại các khu vực đông người.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 291, TenChuyenNganh = "Bán hàng điện thoại", MoTa = "Tư vấn và bán sản phẩm điện thoại, phụ kiện công nghệ.", NgheNghiepId = 56 },
                new ChuyenNganh { Id = 292, TenChuyenNganh = "Nhân viên cây xăng", MoTa = "Bơm xăng, hỗ trợ khách hàng và xử lý giao dịch tại trạm xăng.", NgheNghiepId = 56 },

                // Nghề 57: Thợ thủ công
                new ChuyenNganh { Id = 293, TenChuyenNganh = "Công nhân may", MoTa = "May mặc, vận hành máy may công nghiệp.", NgheNghiepId = 57 },
                new ChuyenNganh { Id = 294, TenChuyenNganh = "Thợ cắm hoa", MoTa = "Thiết kế và cắm hoa nghệ thuật.", NgheNghiepId = 57 },
                new ChuyenNganh { Id = 295, TenChuyenNganh = "Thợ cắt vải", MoTa = "Cắt vải theo mẫu, hỗ trợ quy trình may mặc.", NgheNghiepId = 57 },
                new ChuyenNganh { Id = 296, TenChuyenNganh = "Thợ thủ công mỹ nghệ", MoTa = "Làm đồ thủ công, mỹ nghệ, sản phẩm truyền thống.", NgheNghiepId = 57 },

                // Nghề 58: Thợ thủ công khác
                new ChuyenNganh { Id = 297, TenChuyenNganh = "Gia công cơ khí", MoTa = "Gia công kim loại và linh kiện cơ khí.", NgheNghiepId = 58 },
                new ChuyenNganh { Id = 298, TenChuyenNganh = "Thợ hàn", MoTa = "Hàn, gò và lắp ghép các cấu kiện kim loại.", NgheNghiepId = 58 },
                new ChuyenNganh { Id = 299, TenChuyenNganh = "Công nhân cơ khí", MoTa = "Vận hành máy và sản xuất linh kiện cơ khí.", NgheNghiepId = 58 },
                new ChuyenNganh { Id = 300, TenChuyenNganh = "Thợ tiện", MoTa = "Tiện chi tiết kim loại theo bản vẽ kỹ thuật.", NgheNghiepId = 58 },
                new ChuyenNganh { Id = 301, TenChuyenNganh = "Thợ khoan", MoTa = "Khoan, tạo lỗ trên vật liệu theo yêu cầu kỹ thuật.", NgheNghiepId = 58 },
                new ChuyenNganh { Id = 302, TenChuyenNganh = "Thợ mài", MoTa = "Mài, chỉnh sửa và hoàn thiện bề mặt chi tiết.", NgheNghiepId = 58 },
                new ChuyenNganh { Id = 303, TenChuyenNganh = "Thợ phay", MoTa = "Phay chi tiết kim loại bằng máy phay công nghiệp.", NgheNghiepId = 58 },
                new ChuyenNganh { Id = 304, TenChuyenNganh = "Thợ Gia công cơ khí khác", MoTa = "Các nghiệp vụ gia công cơ khí khác theo yêu cầu.", NgheNghiepId = 58 },

                // Nghề 59: Thợ xây dựng
                new ChuyenNganh { Id = 305, TenChuyenNganh = "Thợ xây/Thợ nề/Thợ hồ", MoTa = "Thi công xây dựng, trát, ốp lát và hoàn thiện công trình.", NgheNghiepId = 59 },
                new ChuyenNganh { Id = 306, TenChuyenNganh = "Thợ mộc", MoTa = "Gia công, lắp đặt và sửa chữa đồ gỗ.", NgheNghiepId = 59 },
                new ChuyenNganh { Id = 307, TenChuyenNganh = "Thợ sơn", MoTa = "Sơn, bả và hoàn thiện bề mặt công trình.", NgheNghiepId = 59 },
                new ChuyenNganh { Id = 308, TenChuyenNganh = "Thợ nhôm kính", MoTa = "Lắp đặt cửa nhôm, vách kính và các sản phẩm liên quan.", NgheNghiepId = 59 },
                new ChuyenNganh { Id = 309, TenChuyenNganh = "Thợ xây dựng khác", MoTa = "Các công việc xây dựng khác theo nhu cầu công trình.", NgheNghiepId = 59 },

                // Nghề 60: Tài chính
                new ChuyenNganh { Id = 310, TenChuyenNganh = "Chuyên môn Tài chính", MoTa = "Thực hiện phân tích tài chính, quản lý ngân sách và kế hoạch tài chính.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 311, TenChuyenNganh = "Hoạch định tài chính", MoTa = "Lập kế hoạch, dự báo và phân bổ nguồn lực tài chính cho doanh nghiệp.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 312, TenChuyenNganh = "Định chế tài chính", MoTa = "Làm việc tại các tổ chức tài chính như quỹ đầu tư, công ty chứng khoán.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 313, TenChuyenNganh = "Kiểm soát và báo cáo tài chính", MoTa = "Chịu trách nhiệm kiểm soát nội bộ và lập báo cáo tài chính.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 314, TenChuyenNganh = "Tư vấn tài chính", MoTa = "Tư vấn giải pháp tài chính cho doanh nghiệp hoặc cá nhân.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 315, TenChuyenNganh = "Giám đốc tài chính", MoTa = "Quản lý chiến lược tài chính và điều hành nguồn vốn doanh nghiệp.", NgheNghiepId = 60 },
                new ChuyenNganh { Id = 316, TenChuyenNganh = "Huy động vốn", MoTa = "Tìm kiếm và quản lý nguồn vốn từ các nhà đầu tư hoặc tổ chức tài chính.", NgheNghiepId = 60 },

                // Nghề 61: Ngân hàng
                new ChuyenNganh { Id = 317, TenChuyenNganh = "Giao dịch viên", MoTa = "Tiếp nhận giao dịch, hỗ trợ khách hàng tại quầy ngân hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 318, TenChuyenNganh = "Chuyên viên xử lý nợ", MoTa = "Quản lý, thu hồi và xử lý các khoản nợ xấu.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 319, TenChuyenNganh = "Kinh doanh nguồn vốn", MoTa = "Quản lý và phát triển các hoạt động kinh doanh nguồn vốn ngân hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 320, TenChuyenNganh = "Kinh doanh ngoại hối, vàng, phái sinh", MoTa = "Thực hiện giao dịch ngoại hối, vàng và các công cụ phái sinh.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 321, TenChuyenNganh = "Tài trợ thương mại", MoTa = "Xử lý L/C, nhờ thu và các nghiệp vụ tài trợ thương mại.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 322, TenChuyenNganh = "Giám đốc khối khách hàng cá nhân", MoTa = "Quản lý mảng khách hàng cá nhân trong ngân hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 323, TenChuyenNganh = "Giám đốc khối khách hàng doanh nghiệp", MoTa = "Quản lý mảng khách hàng doanh nghiệp và các dịch vụ liên quan.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 324, TenChuyenNganh = "Giám đốc khối nguồn vốn và thị trường", MoTa = "Lãnh đạo hoạt động kinh doanh nguồn vốn và giao dịch thị trường.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 325, TenChuyenNganh = "Giám đốc kinh doanh bảo hiểm", MoTa = "Quản lý hoạt động kinh doanh bảo hiểm tại ngân hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 326, TenChuyenNganh = "Giám đốc ngân hàng", MoTa = "Điều hành toàn bộ hoạt động của chi nhánh ngân hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 327, TenChuyenNganh = "Quan hệ khách hàng cá nhân/doanh nghiệp", MoTa = "Tư vấn, chăm sóc và phát triển khách hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 328, TenChuyenNganh = "Tư vấn trả góp", MoTa = "Tư vấn các sản phẩm vay trả góp cho khách hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 329, TenChuyenNganh = "Thẩm định tín dụng", MoTa = "Đánh giá hồ sơ tín dụng và khả năng trả nợ của khách hàng.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 330, TenChuyenNganh = "Tác nghiệp tín dụng", MoTa = "Xử lý thủ tục, hồ sơ và giải ngân khoản vay.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 331, TenChuyenNganh = "Kiểm soát tuân thủ", MoTa = "Đảm bảo hoạt động tuân thủ quy định pháp lý và nội bộ.", NgheNghiepId = 61 },
                new ChuyenNganh { Id = 332, TenChuyenNganh = "Chuyên môn Ngân hàng khác", MoTa = "Các nghiệp vụ khác thuộc lĩnh vực ngân hàng.", NgheNghiepId = 61 },

                // Nghề 62: Chứng khoán
                new ChuyenNganh { Id = 333, TenChuyenNganh = "Phân tích đầu tư chứng khoán", MoTa = "Phân tích cổ phiếu, thị trường và đưa ra khuyến nghị đầu tư.", NgheNghiepId = 62 },
                new ChuyenNganh { Id = 334, TenChuyenNganh = "Quản lý danh mục đầu tư", MoTa = "Quản lý tài sản và tối ưu lợi nhuận cho các danh mục đầu tư.", NgheNghiepId = 62 },
                new ChuyenNganh { Id = 335, TenChuyenNganh = "Tư vấn chứng khoán", MoTa = "Tư vấn giao dịch và chiến lược đầu tư cho khách hàng.", NgheNghiepId = 62 },
                new ChuyenNganh { Id = 336, TenChuyenNganh = "Chuyên môn Chứng khoán khác", MoTa = "Các nghiệp vụ khác trong lĩnh vực chứng khoán.", NgheNghiepId = 62 },

                // Nghề 63: Thẩm định và quản trị rủi ro
                new ChuyenNganh { Id = 337, TenChuyenNganh = "Quản trị rủi ro", MoTa = "Đánh giá và kiểm soát rủi ro tài chính, thị trường và hoạt động.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 338, TenChuyenNganh = "Kiểm soát tuân thủ", MoTa = "Theo dõi và đảm bảo tuân thủ quy định pháp luật và nội bộ.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 339, TenChuyenNganh = "Phòng chống rửa tiền", MoTa = "Giám sát giao dịch và phòng chống rửa tiền theo chuẩn AML.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 340, TenChuyenNganh = "Pháp chế", MoTa = "Tư vấn pháp lý và đảm bảo tuân thủ pháp luật trong hoạt động tài chính.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 341, TenChuyenNganh = "Thẩm định tín dụng", MoTa = "Đánh giá khách hàng và quyết định cấp tín dụng.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 342, TenChuyenNganh = "Quản lý thanh khoản", MoTa = "Đảm bảo khả năng thanh toán và cân đối nguồn vốn.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 343, TenChuyenNganh = "Định giá tài sản", MoTa = "Định giá tài sản đảm bảo theo tiêu chuẩn thẩm định.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 344, TenChuyenNganh = "Thu hồi nợ", MoTa = "Quản lý và thu hồi các khoản nợ của khách hàng.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 345, TenChuyenNganh = "Giám đốc tuân thủ và pháp lý", MoTa = "Quản lý tuân thủ và pháp lý trong doanh nghiệp tài chính.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 346, TenChuyenNganh = "Giám đốc quản lý rủi ro (CRO)", MoTa = "Lãnh đạo chiến lược quản trị rủi ro tổng thể.", NgheNghiepId = 63 },
                new ChuyenNganh { Id = 347, TenChuyenNganh = "Chuyên môn Thẩm định và quản trị rủi ro khác", MoTa = "Các nghiệp vụ khác thuộc thẩm định và quản trị rủi ro.", NgheNghiepId = 63 },

                // Nghề 64: Đầu tư và Tài trợ
                new ChuyenNganh { Id = 348, TenChuyenNganh = "Phân tích đầu tư", MoTa = "Phân tích cơ hội đầu tư và thị trường tài chính.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 349, TenChuyenNganh = "Tài trợ thương mại", MoTa = "Xử lý tài trợ thương mại như L/C và nhờ thu.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 350, TenChuyenNganh = "Mua bán và sáp nhập (M&A)", MoTa = "Thực hiện giao dịch M&A và đánh giá doanh nghiệp.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 351, TenChuyenNganh = "Quan hệ nhà đầu tư", MoTa = "Quản lý thông tin và truyền thông với nhà đầu tư.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 352, TenChuyenNganh = "Quản lý tài sản", MoTa = "Quản lý danh mục tài sản doanh nghiệp hoặc cá nhân.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 353, TenChuyenNganh = "Quản lý danh mục/quỹ", MoTa = "Điều hành quỹ đầu tư và tối ưu lợi nhuận.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 354, TenChuyenNganh = "Giám đốc/Phó giám đốc đầu tư", MoTa = "Lãnh đạo hoạt động đầu tư, chiến lược tài chính.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 355, TenChuyenNganh = "Tư vấn đầu tư", MoTa = "Cung cấp giải pháp đầu tư và hoạch định tài chính.", NgheNghiepId = 64 },
                new ChuyenNganh { Id = 356, TenChuyenNganh = "Chuyên môn đầu tư và tài trợ khác", MoTa = "Các hoạt động khác thuộc đầu tư và tài trợ.", NgheNghiepId = 64 },

                // Nghề 65: Bảo hiểm
                new ChuyenNganh { Id = 357, TenChuyenNganh = "Bồi thường bảo hiểm", MoTa = "Xử lý hồ sơ bồi thường và giải quyết quyền lợi.", NgheNghiepId = 65 },
                new ChuyenNganh { Id = 358, TenChuyenNganh = "Định phí bảo hiểm", MoTa = "Tính toán phí bảo hiểm dựa trên rủi ro và dữ liệu.", NgheNghiepId = 65 },
                new ChuyenNganh { Id = 359, TenChuyenNganh = "Thẩm định và phát hành hợp đồng bảo hiểm", MoTa = "Xem xét và phát hành hợp đồng cho khách hàng.", NgheNghiepId = 65 },
                new ChuyenNganh { Id = 360, TenChuyenNganh = "Quản lý hợp đồng bảo hiểm", MoTa = "Theo dõi, cập nhật và xử lý thông tin hợp đồng.", NgheNghiepId = 65 },
                new ChuyenNganh { Id = 361, TenChuyenNganh = "Tư vấn bảo hiểm", MoTa = "Tư vấn sản phẩm bảo hiểm nhân thọ và phi nhân thọ.", NgheNghiepId = 65 },
                new ChuyenNganh { Id = 362, TenChuyenNganh = "Bancassurance", MoTa = "Phân phối sản phẩm bảo hiểm qua kênh ngân hàng.", NgheNghiepId = 65 },
                new ChuyenNganh { Id = 363, TenChuyenNganh = "Chuyên môn Bảo hiểm khác", MoTa = "Các nghiệp vụ khác trong lĩnh vực bảo hiểm.", NgheNghiepId = 65 },

                // Nghề 66: Sales Tài chính/Ngân hàng/Bảo hiểm
                new ChuyenNganh { Id = 364, TenChuyenNganh = "Tư vấn bảo hiểm", MoTa = "Tư vấn quyền lợi và hỗ trợ ký hợp đồng bảo hiểm.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 365, TenChuyenNganh = "Quan hệ khách hàng cá nhân/doanh nghiệp", MoTa = "Chăm sóc và phát triển khách hàng tài chính/ngân hàng.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 366, TenChuyenNganh = "Tư vấn trả góp", MoTa = "Tư vấn các sản phẩm vay mua sắm trả góp.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 367, TenChuyenNganh = "Tư vấn tín dụng", MoTa = "Tư vấn các gói vay vốn và sản phẩm tín dụng.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 368, TenChuyenNganh = "Bancassurance", MoTa = "Bán bảo hiểm thông qua kênh ngân hàng.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 369, TenChuyenNganh = "Tư vấn đầu tư", MoTa = "Tư vấn giải pháp đầu tư tài chính.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 370, TenChuyenNganh = "Tư vấn chứng khoán", MoTa = "Hỗ trợ giao dịch và chiến lược đầu tư chứng khoán.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 371, TenChuyenNganh = "Kinh doanh ngoại hối, vàng, phái sinh", MoTa = "Giao dịch FX, vàng và các sản phẩm phái sinh.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 372, TenChuyenNganh = "Tư vấn tài chính", MoTa = "Phân tích tài chính và đưa ra giải pháp tối ưu cho khách hàng.", NgheNghiepId = 66 },
                new ChuyenNganh { Id = 373, TenChuyenNganh = "Sales Tài chính/Ngân hàng/Bảo hiểm khác", MoTa = "Các hoạt động kinh doanh khác thuộc nhóm tài chính - ngân hàng - bảo hiểm.", NgheNghiepId = 66 },

                // Nghề 67: Tài chính/Ngân hàng/Bảo hiểm khác
                new ChuyenNganh { Id = 374, TenChuyenNganh = "Chuyên viên kế hoạch", MoTa = "Lập kế hoạch tài chính, theo dõi ngân sách và phân tích hiệu quả.", NgheNghiepId = 67 },
                new ChuyenNganh { Id = 375, TenChuyenNganh = "Chuyên môn Tài chính/Ngân hàng/Bảo hiểm khác", MoTa = "Các chuyên môn khác thuộc lĩnh vực tài chính, ngân hàng và bảo hiểm.", NgheNghiepId = 67 },

                // Nghề 68: Quản lý vận hành bất động sản
                new ChuyenNganh { Id = 376, TenChuyenNganh = "Quản lý tòa nhà", MoTa = "Điều hành hoạt động tòa nhà, đảm bảo dịch vụ và an ninh.", NgheNghiepId = 68 },
                new ChuyenNganh { Id = 377, TenChuyenNganh = "Bảo trì tòa nhà", MoTa = "Bảo trì hệ thống kỹ thuật và cơ sở vật chất trong tòa nhà.", NgheNghiepId = 68 },
                new ChuyenNganh { Id = 378, TenChuyenNganh = "Giám sát bảo trì tòa nhà", MoTa = "Giám sát đội ngũ kỹ thuật và các hoạt động bảo trì.", NgheNghiepId = 68 },
                new ChuyenNganh { Id = 379, TenChuyenNganh = "Nhân viên cảnh quan", MoTa = "Quản lý và chăm sóc cảnh quan, cây xanh xung quanh dự án.", NgheNghiepId = 68 },
                new ChuyenNganh { Id = 380, TenChuyenNganh = "Bảo trì PCCC", MoTa = "Bảo trì, kiểm định hệ thống phòng cháy chữa cháy.", NgheNghiepId = 68 },
                new ChuyenNganh { Id = 381, TenChuyenNganh = "Vận hành tòa nhà", MoTa = "Theo dõi, vận hành hệ thống kỹ thuật trong tòa nhà.", NgheNghiepId = 68 },
                new ChuyenNganh { Id = 382, TenChuyenNganh = "Quản lý vận hành bất động sản khác", MoTa = "Các nghiệp vụ khác trong quản lý và vận hành bất động sản.", NgheNghiepId = 68 },

                // Nghề 69: Quy hoạch và phát triển bất động sản
                new ChuyenNganh { Id = 383, TenChuyenNganh = "Quy hoạch và thiết kế đô thị", MoTa = "Thiết kế và quy hoạch đô thị, hạ tầng và dự án bất động sản.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 384, TenChuyenNganh = "Đấu thầu bất động sản", MoTa = "Thực hiện hồ sơ đấu thầu và quản lý quy trình đấu thầu dự án.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 385, TenChuyenNganh = "Quản lý dự án bất động sản", MoTa = "Điều phối, giám sát tiến độ và chất lượng dự án.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 386, TenChuyenNganh = "Quy hoạch bất động sản", MoTa = "Phân tích, lập kế hoạch và quy hoạch dự án bất động sản.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 387, TenChuyenNganh = "Phát triển mặt bằng", MoTa = "Xây dựng và phát triển quỹ đất phục vụ dự án.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 388, TenChuyenNganh = "Giải phóng mặt bằng", MoTa = "Quản lý và triển khai công tác bồi thường, giải tỏa.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 389, TenChuyenNganh = "Thẩm định giá bất động sản", MoTa = "Định giá bất động sản theo tiêu chuẩn thẩm định.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 390, TenChuyenNganh = "Giám đốc kế hoạch bất động sản", MoTa = "Lập kế hoạch chiến lược cho các dự án bất động sản.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 391, TenChuyenNganh = "Giám đốc đấu thầu bất động sản", MoTa = "Quản lý chiến lược đấu thầu và phát triển dự án.", NgheNghiepId = 69 },
                new ChuyenNganh { Id = 392, TenChuyenNganh = "Giám đốc dự án bất động sản", MoTa = "Lãnh đạo triển khai và vận hành dự án bất động sản.", NgheNghiepId = 69 },

                /// Nghề 70: Sales Bất động sản
                new ChuyenNganh { Id = 393, TenChuyenNganh = "Sales bất động sản/Môi giới bất động sản", MoTa = "Tư vấn, giới thiệu và môi giới giao dịch bất động sản.", NgheNghiepId = 70 },
                new ChuyenNganh { Id = 394, TenChuyenNganh = "Sales Bất động sản khác", MoTa = "Các hoạt động kinh doanh và môi giới bất động sản khác.", NgheNghiepId = 70 },

                // Nghề 71: Bất động sản khác
                new ChuyenNganh { Id = 395, TenChuyenNganh = "Chuyên môn Bất động sản khác", MoTa = "Các chuyên môn khác trong lĩnh vực bất động sản.", NgheNghiepId = 71 },

                // Nghề 72: Quản lý dự án xây dựng
                new ChuyenNganh { Id = 396, TenChuyenNganh = "Quản lý dự án thi công xây dựng", MoTa = "Điều phối, giám sát tiến độ và chất lượng dự án xây dựng.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 397, TenChuyenNganh = "Dự toán công trình", MoTa = "Lập dự toán chi phí, khối lượng và giá thành công trình.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 398, TenChuyenNganh = "Giám sát dự án/công trình/thi công", MoTa = "Giám sát thi công, đảm bảo đúng kỹ thuật và an toàn.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 399, TenChuyenNganh = "Thư ký công trình", MoTa = "Quản lý hồ sơ, văn bản và hỗ trợ hành chính công trình.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 400, TenChuyenNganh = "Nhân viên hồ sơ xây dựng", MoTa = "Chuẩn bị hồ sơ, nghiệm thu và pháp lý công trình.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 401, TenChuyenNganh = "Nhân viên vật tư", MoTa = "Quản lý vật tư, thiết bị và cung ứng cho công trình.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 402, TenChuyenNganh = "Nhân viên trắc đạc", MoTa = "Đo đạc, khảo sát hiện trường phục vụ thi công.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 403, TenChuyenNganh = "Kỹ sư an toàn lao động (HSE)", MoTa = "Đảm bảo an toàn lao động, giám sát PCCC và nội quy công trình.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 404, TenChuyenNganh = "Kỹ sư hiện trường", MoTa = "Theo dõi thi công, xử lý kỹ thuật tại công trường.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 405, TenChuyenNganh = "Quản đốc công trình", MoTa = "Điều hành đội thi công, phân công công việc cho tổ đội.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 406, TenChuyenNganh = "Quản lý chất lượng công trình", MoTa = "Kiểm soát chất lượng, nghiệm thu và tiêu chuẩn kỹ thuật.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 407, TenChuyenNganh = "Kỹ sư địa chất", MoTa = "Khảo sát địa chất, đánh giá nền đất và khả năng thi công.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 408, TenChuyenNganh = "Đấu thầu xây dựng", MoTa = "Chuẩn bị hồ sơ và tham gia đấu thầu dự án xây dựng.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 409, TenChuyenNganh = "Quản lý thiết bị công trình", MoTa = "Quản lý, bảo dưỡng và vận hành thiết bị thi công.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 410, TenChuyenNganh = "Giám sát thi công nội thất", MoTa = "Giám sát thi công hoàn thiện và nội thất công trình.", NgheNghiepId = 72 },
                new ChuyenNganh { Id = 411, TenChuyenNganh = "Quản lý dự án xây dựng khác", MoTa = "Các nghiệp vụ khác trong quản lý dự án xây dựng.", NgheNghiepId = 72 },

                // Nghề 73: Thiết kế và Kiến trúc
                new ChuyenNganh { Id = 412, TenChuyenNganh = "Kỹ sư kết cấu công trình", MoTa = "Thiết kế kết cấu và tính toán an toàn công trình.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 413, TenChuyenNganh = "Kỹ sư hạ tầng đô thị", MoTa = "Thiết kế và giám sát hệ thống hạ tầng đô thị.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 414, TenChuyenNganh = "Thiết kế cảnh quan", MoTa = "Thiết kế sân vườn, cảnh quan và không gian ngoại thất.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 415, TenChuyenNganh = "Thiết kế nội thất", MoTa = "Thiết kế và giám sát thi công nội thất công trình.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 416, TenChuyenNganh = "Kiến trúc sư", MoTa = "Thiết kế kiến trúc tổng thể và công năng công trình.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 417, TenChuyenNganh = "Kỹ sư xây dựng", MoTa = "Thiết kế, thi công và giám sát các công trình xây dựng.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 418, TenChuyenNganh = "Kỹ sư hệ thống điện nhẹ", MoTa = "Thiết kế và triển khai hệ thống điện nhẹ (ELV).", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 419, TenChuyenNganh = "Kỹ sư cơ điện", MoTa = "Thiết kế, giám sát hệ thống cơ điện M&E.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 420, TenChuyenNganh = "Kỹ sư cấp thoát nước", MoTa = "Thiết kế và giám sát hệ thống cấp thoát nước.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 421, TenChuyenNganh = "Kỹ sư HVAC", MoTa = "Thiết kế, lắp đặt và giám sát hệ thống điều hòa HVAC.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 422, TenChuyenNganh = "Kỹ sư thiết kế nhôm kính", MoTa = "Thiết kế và triển khai bản vẽ nhôm kính.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 423, TenChuyenNganh = "BIM Engineer", MoTa = "Triển khai mô hình thông tin công trình (BIM).", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 424, TenChuyenNganh = "Kỹ sư PCCC", MoTa = "Thiết kế và giám sát hệ thống phòng cháy chữa cháy.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 425, TenChuyenNganh = "Kỹ sư cầu đường", MoTa = "Thiết kế và thi công công trình giao thông, cầu đường.", NgheNghiepId = 73 },
                new ChuyenNganh { Id = 426, TenChuyenNganh = "Chuyên môn Thiết kế và Kiến trúc khác", MoTa = "Các công việc khác thuộc nhóm thiết kế và kiến trúc.", NgheNghiepId = 73 },


                /// Nghề 74: Công nhân Xây dựng/Cải tạo
                new ChuyenNganh { Id = 427, TenChuyenNganh = "Sửa chữa/Bảo trì điện nước", MoTa = "Sửa chữa và bảo trì hệ thống điện, nước trong công trình.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 428, TenChuyenNganh = "Thợ điện lạnh", MoTa = "Lắp đặt và sửa chữa thiết bị điện lạnh.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 429, TenChuyenNganh = "Thợ hàn", MoTa = "Hàn và gia công kim loại trong thi công.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 430, TenChuyenNganh = "Thợ mộc", MoTa = "Gia công và lắp đặt các kết cấu gỗ.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 431, TenChuyenNganh = "Thợ sơn", MoTa = "Sơn, bả và hoàn thiện công trình.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 432, TenChuyenNganh = "Lắp đặt/bảo trì thang máy", MoTa = "Lắp đặt và bảo trì các hệ thống thang máy.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 433, TenChuyenNganh = "Thợ xây/Thợ nề/Thợ hồ", MoTa = "Xây dựng, trát và hoàn thiện công trình.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 434, TenChuyenNganh = "Thợ nhôm kính", MoTa = "Thi công và lắp đặt các sản phẩm nhôm kính.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 435, TenChuyenNganh = "Nhân viên thi công", MoTa = "Tham gia thi công công trình theo phân công.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 436, TenChuyenNganh = "Công nhân thời vụ", MoTa = "Làm việc thời vụ tại công trường xây dựng.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 437, TenChuyenNganh = "Công nhân khai thác than", MoTa = "Khai thác và vận chuyển than.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 438, TenChuyenNganh = "Công nhân xưởng gỗ", MoTa = "Gia công sản phẩm gỗ phục vụ xây dựng.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 439, TenChuyenNganh = "Công nhân lắp ráp", MoTa = "Lắp ráp các bộ phận công trình theo hướng dẫn.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 440, TenChuyenNganh = "Công nhân vận hành máy", MoTa = "Vận hành máy móc thiết bị trong thi công.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 441, TenChuyenNganh = "Công nhân xây dựng", MoTa = "Làm việc trong các hạng mục thi công xây dựng.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 442, TenChuyenNganh = "Thợ xây dựng khác", MoTa = "Các công việc khác thuộc nhóm xây dựng và cải tạo.", NgheNghiepId = 74 },
                new ChuyenNganh { Id = 443, TenChuyenNganh = "Việc làm Công nhân khác", MoTa = "Các công việc công nhân phổ thông khác.", NgheNghiepId = 74 },

                // Nghề 75: Sales Xây dựng
                new ChuyenNganh { Id = 444, TenChuyenNganh = "Kinh doanh thiết bị/vật liệu xây dựng", MoTa = "Bán thiết bị, vật liệu phục vụ công trình xây dựng.", NgheNghiepId = 75 },
                new ChuyenNganh { Id = 445, TenChuyenNganh = "Kinh doanh nội thất", MoTa = "Bán sản phẩm nội thất và vật liệu hoàn thiện.", NgheNghiepId = 75 },
                new ChuyenNganh { Id = 446, TenChuyenNganh = "Tư vấn thiết kế xây dựng", MoTa = "Tư vấn giải pháp và thiết kế các hạng mục xây dựng.", NgheNghiepId = 75 },
                new ChuyenNganh { Id = 447, TenChuyenNganh = "Sales Xây dựng khác", MoTa = "Các công việc kinh doanh khác trong lĩnh vực xây dựng.", NgheNghiepId = 75 },

                // Nghề 76: Xây dựng khác
                new ChuyenNganh { Id = 448, TenChuyenNganh = "Chuyên môn Xây dựng khác", MoTa = "Các chuyên môn khác thuộc lĩnh vực xây dựng.", NgheNghiepId = 76 },

                // Nghề 77: Kế toán
                new ChuyenNganh { Id = 449, TenChuyenNganh = "Kế toán tổng hợp", MoTa = "Tổng hợp số liệu và lập báo cáo tài chính cho doanh nghiệp.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 450, TenChuyenNganh = "Kế toán nội bộ", MoTa = "Theo dõi chi phí, doanh thu và tài sản nội bộ công ty.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 451, TenChuyenNganh = "Kế toán công nợ", MoTa = "Theo dõi và quản lý công nợ phải thu, phải trả.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 452, TenChuyenNganh = "Kế toán thuế", MoTa = "Kê khai thuế và đảm bảo tuân thủ các quy định pháp luật về thuế.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 453, TenChuyenNganh = "Kế toán chi phí/giá thành", MoTa = "Tính giá thành sản phẩm và phân tích chi phí sản xuất.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 454, TenChuyenNganh = "Kế toán bán hàng", MoTa = "Theo dõi doanh thu bán hàng và xuất hóa đơn.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 455, TenChuyenNganh = "Kế toán doanh thu", MoTa = "Hạch toán doanh thu và lập báo cáo liên quan.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 456, TenChuyenNganh = "Kế toán tài chính", MoTa = "Quản lý dòng tiền, phân tích tài chính và lập báo cáo tài chính.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 457, TenChuyenNganh = "Kế toán đầu tư", MoTa = "Theo dõi và hạch toán các hoạt động đầu tư tài chính.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 458, TenChuyenNganh = "Kế toán tài sản cố định", MoTa = "Quản lý và khấu hao tài sản cố định.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 459, TenChuyenNganh = "Kế toán mua hàng", MoTa = "Theo dõi mua hàng, nhập kho và công nợ nhà cung cấp.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 460, TenChuyenNganh = "Kế toán thanh toán", MoTa = "Xử lý các khoản thanh toán và đối soát chứng từ.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 461, TenChuyenNganh = "Kế toán kho/nguyên vật liệu", MoTa = "Theo dõi xuất nhập tồn và quản lý hàng hóa trong kho.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 462, TenChuyenNganh = "Kế toán tiền lương", MoTa = "Tính lương, bảo hiểm và phúc lợi nhân viên.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 463, TenChuyenNganh = "Kế toán quản trị", MoTa = "Phân tích chi phí – lợi nhuận và hỗ trợ ra quyết định quản trị.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 464, TenChuyenNganh = "Kế toán trưởng", MoTa = "Quản lý bộ phận kế toán và kiểm soát tài chính doanh nghiệp.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 465, TenChuyenNganh = "Kế toán công trình", MoTa = "Theo dõi chi phí và hồ sơ kế toán trong dự án xây dựng.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 466, TenChuyenNganh = "Kế toán sản xuất", MoTa = "Hạch toán và theo dõi chi phí sản xuất theo từng công đoạn.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 467, TenChuyenNganh = "Kế toán dự án", MoTa = "Quản lý chi phí, ngân sách và báo cáo tài chính dự án.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 468, TenChuyenNganh = "Kế toán xuất nhập khẩu", MoTa = "Hạch toán hoạt động XNK và xử lý chứng từ hải quan.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 469, TenChuyenNganh = "Kế toán ngân hàng", MoTa = "Theo dõi giao dịch ngân hàng, đối chiếu và quản lý dòng tiền.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 470, TenChuyenNganh = "Thủ quỹ", MoTa = "Quản lý tiền mặt và thực hiện thu – chi tại doanh nghiệp.", NgheNghiepId = 77 },
                new ChuyenNganh { Id = 471, TenChuyenNganh = "Kế toán khác", MoTa = "Các công việc kế toán khác theo yêu cầu doanh nghiệp.", NgheNghiepId = 77 },

                // Nghề 78: Kiểm toán
                new ChuyenNganh { Id = 472, TenChuyenNganh = "Kiểm toán viên", MoTa = "Thực hiện kiểm toán báo cáo tài chính và hệ thống.", NgheNghiepId = 78 },
                new ChuyenNganh { Id = 473, TenChuyenNganh = "Kiểm toán nội bộ", MoTa = "Đánh giá hệ thống kiểm soát nội bộ và rủi ro.", NgheNghiepId = 78 },
                new ChuyenNganh { Id = 474, TenChuyenNganh = "Kiểm toán độc lập", MoTa = "Thực hiện kiểm toán cho khách hàng bên ngoài doanh nghiệp.", NgheNghiepId = 78 },
                new ChuyenNganh { Id = 475, TenChuyenNganh = "Trưởng nhóm kiểm toán", MoTa = "Quản lý nhóm kiểm toán và điều phối dự án.", NgheNghiepId = 78 },
                new ChuyenNganh { Id = 476, TenChuyenNganh = "Chuyên môn Kiểm toán khác", MoTa = "Các nghiệp vụ kiểm toán khác theo yêu cầu.", NgheNghiepId = 78 },

                // Nghề 79: Thuế
                new ChuyenNganh { Id = 477, TenChuyenNganh = "Chuyên viên thuế", MoTa = "Tư vấn, kê khai và xử lý các vấn đề liên quan đến thuế.", NgheNghiepId = 79 },
                new ChuyenNganh { Id = 478, TenChuyenNganh = "Chuyên môn Thuế khác", MoTa = "Các nghiệp vụ khác trong lĩnh vực thuế.", NgheNghiepId = 79 },

                // Nghề 80: Kế toán/Kiểm toán/Thuế khác
                new ChuyenNganh { Id = 479, TenChuyenNganh = "Chuyên môn Kế toán/Kiểm toán/Thuế khác", MoTa = "Các chuyên môn khác trong lĩnh vực kế toán, kiểm toán và thuế.", NgheNghiepId = 80 },

                // Nghề 81: Gia công cơ khí
                new ChuyenNganh { Id = 480, TenChuyenNganh = "Công nhân cơ khí", MoTa = "Thực hiện gia công và vận hành máy móc cơ khí.", NgheNghiepId = 81 },
                new ChuyenNganh { Id = 481, TenChuyenNganh = "Thợ hàn", MoTa = "Hàn, gò và gia công kim loại.", NgheNghiepId = 81 },
                new ChuyenNganh { Id = 482, TenChuyenNganh = "Thợ phay", MoTa = "Thực hiện phay chi tiết kim loại theo bản vẽ kỹ thuật.", NgheNghiepId = 81 },
                new ChuyenNganh { Id = 483, TenChuyenNganh = "Thợ mài", MoTa = "Mài và hoàn thiện bề mặt chi tiết cơ khí.", NgheNghiepId = 81 },
                new ChuyenNganh { Id = 484, TenChuyenNganh = "Thợ tiện", MoTa = "Tiện chi tiết kim loại theo yêu cầu kỹ thuật.", NgheNghiepId = 81 },
                new ChuyenNganh { Id = 485, TenChuyenNganh = "Thợ khoan", MoTa = "Khoan lỗ và gia công chi tiết cơ khí.", NgheNghiepId = 81 },
                new ChuyenNganh { Id = 486, TenChuyenNganh = "Thợ Gia công cơ khí khác", MoTa = "Các công việc khác trong lĩnh vực gia công cơ khí.", NgheNghiepId = 81 },

                // Nghề 82: Thiết kế/chế tạo máy
                new ChuyenNganh { Id = 487, TenChuyenNganh = "Thợ tiện", MoTa = "Tiện chi tiết máy và gia công kim loại.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 488, TenChuyenNganh = "Kỹ sư lập trình máy", MoTa = "Lập trình máy CNC và tối ưu quy trình gia công.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 489, TenChuyenNganh = "Kỹ sư tự động hóa", MoTa = "Thiết kế và vận hành hệ thống tự động hóa.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 490, TenChuyenNganh = "Kỹ sư cơ khí", MoTa = "Thiết kế và chế tạo chi tiết, máy móc cơ khí.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 491, TenChuyenNganh = "Kỹ sư kết cấu máy", MoTa = "Thiết kế kết cấu và bộ phận máy công nghiệp.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 492, TenChuyenNganh = "Kỹ sư quy trình", MoTa = "Xây dựng và tối ưu quy trình sản xuất.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 493, TenChuyenNganh = "Kỹ sư khuôn mẫu", MoTa = "Thiết kế, chế tạo và bảo trì khuôn mẫu.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 494, TenChuyenNganh = "Kỹ sư thiết kế cơ khí", MoTa = "Thiết kế 3D, mô phỏng và phân tích sản phẩm cơ khí.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 495, TenChuyenNganh = "Kỹ sư vật liệu", MoTa = "Nghiên cứu và ứng dụng vật liệu mới vào sản xuất.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 496, TenChuyenNganh = "Kỹ sư công nghiệp (IE)", MoTa = "Tối ưu sản xuất, công đoạn và hiệu suất hệ thống.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 497, TenChuyenNganh = "Kỹ sư thiết kế HVAC", MoTa = "Thiết kế hệ thống điều hòa và thông gió cho nhà máy.", NgheNghiepId = 82 },
                new ChuyenNganh { Id = 498, TenChuyenNganh = "Chuyên môn Thiết kế/chế tạo máy khác", MoTa = "Các chuyên môn khác trong lĩnh vực thiết kế–chế tạo máy.", NgheNghiepId = 82 },

                // Nghề 83: Hoá chất/Hoá mỹ phẩm
                new ChuyenNganh { Id = 499, TenChuyenNganh = "Kỹ thuật viên phòng thí nghiệm", MoTa = "Thực hiện thí nghiệm, kiểm nghiệm và phân tích hóa chất.", NgheNghiepId = 83 },
                new ChuyenNganh { Id = 500, TenChuyenNganh = "Kỹ sư hóa học", MoTa = "Nghiên cứu, phát triển và vận hành quy trình hóa học.", NgheNghiepId = 83 },
                new ChuyenNganh { Id = 501, TenChuyenNganh = "Nghiên cứu và phát triển (R&D) thực phẩm/đồ uống", MoTa = "Nghiên cứu, cải tiến sản phẩm thực phẩm, đồ uống.", NgheNghiepId = 83 },
                new ChuyenNganh { Id = 502, TenChuyenNganh = "Nghiên cứu và phát triển (R&D) mỹ phẩm", MoTa = "Phát triển và thử nghiệm sản phẩm mỹ phẩm.", NgheNghiepId = 83 },
                new ChuyenNganh { Id = 503, TenChuyenNganh = "Chuyên môn Hoá chất/Hoá mỹ phẩm khác", MoTa = "Các chuyên môn khác trong ngành hóa chất – mỹ phẩm.", NgheNghiepId = 83 },

                // Nghề 84: May mặc/Dệt may/Da
                new ChuyenNganh { Id = 504, TenChuyenNganh = "Thiết kế rập", MoTa = "Thiết kế rập và phát triển mẫu kỹ thuật cho may mặc.", NgheNghiepId = 84 },
                new ChuyenNganh { Id = 505, TenChuyenNganh = "Thiết kế vải", MoTa = "Thiết kế hoa văn, màu sắc và chất liệu vải.", NgheNghiepId = 84 },
                new ChuyenNganh { Id = 506, TenChuyenNganh = "Công nhân may", MoTa = "May sản phẩm theo quy trình công nghiệp.", NgheNghiepId = 84 },
                new ChuyenNganh { Id = 507, TenChuyenNganh = "Thợ cắt vải", MoTa = "Cắt vải theo mẫu phục vụ sản xuất.", NgheNghiepId = 84 },
                new ChuyenNganh { Id = 508, TenChuyenNganh = "Công nhân xếp quần áo", MoTa = "Gấp, phân loại và đóng kiện quần áo.", NgheNghiepId = 84 },
                new ChuyenNganh { Id = 509, TenChuyenNganh = "Công nhân giày da", MoTa = "Sản xuất và lắp ráp các sản phẩm giày da.", NgheNghiepId = 84 },
                new ChuyenNganh { Id = 510, TenChuyenNganh = "Chuyên môn May mặc/Dệt may/Da khác", MoTa = "Các vị trí khác thuộc ngành may mặc – da.", NgheNghiepId = 84 },

                // Nghề 85: R&D/Sản xuất ô tô
                new ChuyenNganh { Id = 511, TenChuyenNganh = "Kỹ sư thiết kế ô tô", MoTa = "Thiết kế cấu trúc và ngoại thất xe ô tô.", NgheNghiepId = 85 },
                new ChuyenNganh { Id = 512, TenChuyenNganh = "Kỹ sư khung gầm", MoTa = "Thiết kế và thử nghiệm khung gầm xe.", NgheNghiepId = 85 },
                new ChuyenNganh { Id = 513, TenChuyenNganh = "Kỹ sư lắp ráp ô tô", MoTa = "Lắp ráp linh kiện và hệ thống xe ô tô.", NgheNghiepId = 85 },
                new ChuyenNganh { Id = 514, TenChuyenNganh = "Chuyên môn R&D/Sản xuất ô tô khác", MoTa = "Các chuyên môn khác trong sản xuất ô tô.", NgheNghiepId = 85 },

                // Nghề 86: Thợ kỹ thuật
                new ChuyenNganh { Id = 515, TenChuyenNganh = "Kỹ sư thiết kế điện", MoTa = "Thiết kế hệ thống điện dân dụng và công nghiệp.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 516, TenChuyenNganh = "Thợ mộc", MoTa = "Gia công và lắp đặt các sản phẩm gỗ.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 517, TenChuyenNganh = "Thợ sơn", MoTa = "Sơn và hoàn thiện bề mặt công trình.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 518, TenChuyenNganh = "Công nhân xưởng gỗ", MoTa = "Gia công và chế biến sản phẩm gỗ.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 519, TenChuyenNganh = "Công nhân lắp ráp", MoTa = "Lắp ráp thiết bị, linh kiện hoặc sản phẩm.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 520, TenChuyenNganh = "Công nhân giày da", MoTa = "Tham gia sản xuất giày da công nghiệp.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 521, TenChuyenNganh = "Công nhân bao bì", MoTa = "Sản xuất và đóng gói bao bì sản phẩm.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 522, TenChuyenNganh = "Công nhân ép nhựa", MoTa = "Vận hành máy ép nhựa và kiểm tra sản phẩm.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 523, TenChuyenNganh = "Công nhân làm nước đá", MoTa = "Vận hành hệ thống sản xuất nước đá.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 524, TenChuyenNganh = "Công nhân sản xuất", MoTa = "Tham gia dây chuyền sản xuất công nghiệp.", NgheNghiepId = 86 },
                new ChuyenNganh { Id = 525, TenChuyenNganh = "Thợ kỹ thuật khác", MoTa = "Các công việc khác trong lĩnh vực kỹ thuật.", NgheNghiepId = 86 },

                // Nghề 87: Vận hành thiết bị vận tải/thiết bị nặng
                new ChuyenNganh { Id = 526, TenChuyenNganh = "Tài xế lái xe nâng", MoTa = "Vận hành xe nâng trong kho/xưởng.", NgheNghiepId = 87 },
                new ChuyenNganh { Id = 527, TenChuyenNganh = "Tài xế lái máy công trình", MoTa = "Lái máy xúc, máy ủi, máy lu trong thi công.", NgheNghiepId = 87 },
                new ChuyenNganh { Id = 528, TenChuyenNganh = "Vận hành thiết bị nặng/phụ trợ", MoTa = "Vận hành thiết bị công trình và máy móc nặng.", NgheNghiepId = 87 },
                new ChuyenNganh { Id = 529, TenChuyenNganh = "Tài xế xe tải", MoTa = "Vận chuyển hàng hóa bằng xe tải.", NgheNghiepId = 87 },
                new ChuyenNganh { Id = 530, TenChuyenNganh = "Tài xế container", MoTa = "Lái container vận chuyển hàng hóa nặng.", NgheNghiepId = 87 },
                new ChuyenNganh { Id = 531, TenChuyenNganh = "Vận hành thiết bị vận tải/thiết bị nặng khác", MoTa = "Các công việc vận hành thiết bị nặng khác.", NgheNghiepId = 87 },

                // Nghề 88: Quản lý chất lượng
                new ChuyenNganh { Id = 532, TenChuyenNganh = "Quản lý chất lượng (QA)", MoTa = "Xây dựng quy trình và đảm bảo chất lượng sản phẩm.", NgheNghiepId = 88 },
                new ChuyenNganh { Id = 533, TenChuyenNganh = "Kiểm soát chất lượng (QC)", MoTa = "Kiểm tra và kiểm soát chất lượng sản xuất.", NgheNghiepId = 88 },
                new ChuyenNganh { Id = 534, TenChuyenNganh = "Kỹ thuật viên phòng thí nghiệm", MoTa = "Kiểm nghiệm, phân tích chất lượng sản phẩm.", NgheNghiepId = 88 },
                new ChuyenNganh { Id = 535, TenChuyenNganh = "Kỹ sư phân tích lỗi (PE)", MoTa = "Phân tích lỗi sản xuất và đề xuất cải tiến.", NgheNghiepId = 88 },
                new ChuyenNganh { Id = 536, TenChuyenNganh = "Phát triển bao bì", MoTa = "Thiết kế, tối ưu và kiểm tra chất lượng bao bì sản phẩm.", NgheNghiepId = 88 },
                new ChuyenNganh { Id = 537, TenChuyenNganh = "Kỹ sư quản lý chất lượng nhà cung cấp (SQE)", MoTa = "Đánh giá và kiểm soát chất lượng từ nhà cung cấp.", NgheNghiepId = 88 },
                new ChuyenNganh { Id = 538, TenChuyenNganh = "Quản lý chất lượng khác", MoTa = "Các hoạt động khác trong quản lý và kiểm soát chất lượng.", NgheNghiepId = 88 },

                // Nghề 89: Vận hành sản xuất
                new ChuyenNganh { Id = 539, TenChuyenNganh = "Giám đốc sản xuất", MoTa = "Quản lý toàn bộ hoạt động sản xuất.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 540, TenChuyenNganh = "Trưởng phòng sản xuất", MoTa = "Điều hành phòng sản xuất và quản lý nhân sự.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 541, TenChuyenNganh = "Quản đốc phân xưởng/nhà máy", MoTa = "Giám sát vận hành phân xưởng.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 542, TenChuyenNganh = "Trưởng chuyền/Tổ trưởng sản xuất", MoTa = "Quản lý dây chuyền sản xuất và phân công công việc.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 543, TenChuyenNganh = "Trưởng ca", MoTa = "Điều phối sản xuất theo ca làm việc.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 544, TenChuyenNganh = "Giám sát sản xuất", MoTa = "Theo dõi quy trình sản xuất và đảm bảo chất lượng.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 545, TenChuyenNganh = "Công nhân sản xuất", MoTa = "Tham gia dây chuyền sản xuất công nghiệp.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 546, TenChuyenNganh = "Theo dõi đơn hàng", MoTa = "Theo dõi tiến độ và chất lượng đơn hàng sản xuất.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 547, TenChuyenNganh = "Kế hoạch sản xuất", MoTa = "Lập kế hoạch sản xuất và điều phối nguyên liệu.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 548, TenChuyenNganh = "Thủ kho/Quản lý kho", MoTa = "Quản lý kho hàng và tồn kho vật tư.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 549, TenChuyenNganh = "Quản lý thiết bị sản xuất", MoTa = "Bảo trì và theo dõi thiết bị máy móc sản xuất.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 550, TenChuyenNganh = "Công nhân vận hành máy", MoTa = "Vận hành và theo dõi máy móc sản xuất.", NgheNghiepId = 89 },
                new ChuyenNganh { Id = 551, TenChuyenNganh = "Chuyên môn Vận hành sản xuất khác", MoTa = "Các công việc khác thuộc vận hành sản xuất.", NgheNghiepId = 89 },

                // Nghề 90: Bảo trì, sửa chữa
                new ChuyenNganh { Id = 552, TenChuyenNganh = "Sửa chữa/Bảo trì máy công nghiệp", MoTa = "Bảo trì, sửa chữa máy móc và thiết bị công nghiệp.", NgheNghiepId = 90 },
                new ChuyenNganh { Id = 553, TenChuyenNganh = "Kỹ thuật viên lắp đặt", MoTa = "Lắp đặt thiết bị sản xuất và hệ thống kỹ thuật.", NgheNghiepId = 90 },
                new ChuyenNganh { Id = 554, TenChuyenNganh = "Bảo trì, sửa chữa khác", MoTa = "Các công việc khác thuộc bảo trì và sửa chữa máy móc.", NgheNghiepId = 90 },
                // Nghề 91: Sales Sản xuất
                new ChuyenNganh { Id = 566, TenChuyenNganh = "Kinh doanh hoá chất", MoTa = "Bán và tư vấn sản phẩm hóa chất công nghiệp.", NgheNghiepId = 91 },
                new ChuyenNganh { Id = 567, TenChuyenNganh = "Kinh doanh ô tô/xe máy/xe điện", MoTa = "Tư vấn và bán sản phẩm ngành ô tô – xe máy – xe điện.", NgheNghiepId = 91 },
                new ChuyenNganh { Id = 568, TenChuyenNganh = "Kinh doanh phụ tùng ô tô/xe máy/xe điện", MoTa = "Bán phụ tùng và linh kiện cơ khí.", NgheNghiepId = 91 },
                new ChuyenNganh { Id = 569, TenChuyenNganh = "Sales Sản xuất khác", MoTa = "Các hoạt động kinh doanh liên quan đến sản phẩm công nghiệp.", NgheNghiepId = 91 },

                // Nghề 92: Sản xuất khác
                new ChuyenNganh { Id = 570, TenChuyenNganh = "Kỹ sư an toàn lao động (HSE)", MoTa = "Đảm bảo an toàn lao động và phòng chống sự cố.", NgheNghiepId = 92 },
                new ChuyenNganh { Id = 571, TenChuyenNganh = "Công nhân đóng gói hàng hóa", MoTa = "Đóng gói, phân loại và kiểm tra hàng hóa trong xưởng.", NgheNghiepId = 92 },
                new ChuyenNganh { Id = 572, TenChuyenNganh = "Công nhân bốc xếp hàng hóa", MoTa = "Bốc xếp và vận chuyển hàng hóa trong nhà máy.", NgheNghiepId = 92 },
                new ChuyenNganh { Id = 573, TenChuyenNganh = "Bán hàng kỹ thuật cơ khí", MoTa = "Tư vấn và bán sản phẩm – dịch vụ kỹ thuật cơ khí.", NgheNghiepId = 92 },
                new ChuyenNganh { Id = 574, TenChuyenNganh = "Trợ lý/Thư ký sản xuất", MoTa = "Hỗ trợ hành chính và điều phối hoạt động sản xuất.", NgheNghiepId = 92 },
                new ChuyenNganh { Id = 575, TenChuyenNganh = "Công nhân thời vụ", MoTa = "Tham gia sản xuất theo thời vụ hoặc ca ngắn hạn.", NgheNghiepId = 92 },
                new ChuyenNganh { Id = 576, TenChuyenNganh = "Việc làm công nhân khác", MoTa = "Các công việc khác thuộc lĩnh vực sản xuất.", NgheNghiepId = 92 },

                // Nghề 93: Giáo viên/Giảng viên/Gia sư
                new ChuyenNganh { Id = 577, TenChuyenNganh = "Giáo viên mầm non", MoTa = "Giảng dạy và chăm sóc trẻ mầm non.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 578, TenChuyenNganh = "Giáo viên giáo dục sớm", MoTa = "Dạy trẻ nhỏ theo phương pháp giáo dục sớm.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 579, TenChuyenNganh = "Giáo viên tiểu học", MoTa = "Giảng dạy các môn học bậc tiểu học.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 580, TenChuyenNganh = "Giảng viên thỉnh giảng", MoTa = "Giảng dạy theo hợp đồng tại các cơ sở giáo dục.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 581, TenChuyenNganh = "Giáo viên Toán", MoTa = "Giảng dạy môn Toán ở nhiều cấp học.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 582, TenChuyenNganh = "Giáo viên Tiếng Việt/Ngữ văn", MoTa = "Dạy môn Ngữ văn và kỹ năng đọc – viết.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 583, TenChuyenNganh = "Giáo viên Tin học", MoTa = "Dạy môn Tin học và kỹ năng CNTT.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 584, TenChuyenNganh = "Giáo viên Giáo dục thể chất", MoTa = "Dạy môn Thể dục và phát triển thể chất.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 585, TenChuyenNganh = "Giáo viên dạy nhảy/múa", MoTa = "Dạy các bộ môn nhảy, múa, nghệ thuật biểu diễn.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 586, TenChuyenNganh = "Giáo viên tiếng Anh", MoTa = "Giảng dạy tiếng Anh cho nhiều độ tuổi.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 587, TenChuyenNganh = "Giáo viên tiếng Nhật", MoTa = "Dạy tiếng Nhật các trình độ.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 588, TenChuyenNganh = "Giáo viên tiếng Hàn", MoTa = "Dạy tiếng Hàn cho người học.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 589, TenChuyenNganh = "Giáo viên tiếng Trung", MoTa = "Dạy tiếng Trung và giao tiếp.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 590, TenChuyenNganh = "Giáo viên tiếng Đức", MoTa = "Giảng dạy tiếng Đức các cấp độ.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 591, TenChuyenNganh = "Giáo viên ngoại ngữ khác", MoTa = "Các môn ngoại ngữ khác theo nhu cầu.", NgheNghiepId = 93 },
                new ChuyenNganh { Id = 592, TenChuyenNganh = "Giáo viên bộ môn khác", MoTa = "Các môn học khác theo chương trình giáo dục.", NgheNghiepId = 93 },

                // Nghề 94: Văn hoá/Nghệ thuật/Khoa học
                new ChuyenNganh { Id = 609, TenChuyenNganh = "Giáo viên mỹ thuật", MoTa = "Dạy vẽ, hội họa và nghệ thuật tạo hình.", NgheNghiepId = 94 },
                new ChuyenNganh { Id = 610, TenChuyenNganh = "Giáo viên dạy nhảy/múa", MoTa = "Giảng dạy nhảy và múa nghệ thuật.", NgheNghiepId = 94 },
                new ChuyenNganh { Id = 611, TenChuyenNganh = "Giáo viên âm nhạc", MoTa = "Giảng dạy nhạc lý, nhạc cụ và thanh nhạc.", NgheNghiepId = 94 },
                new ChuyenNganh { Id = 612, TenChuyenNganh = "Giáo viên dạy chơi cờ", MoTa = "Dạy cờ vua, cờ tướng và tư duy chiến lược.", NgheNghiepId = 94 },
                new ChuyenNganh { Id = 613, TenChuyenNganh = "Giáo viên STEAM/STEM", MoTa = "Dạy tích hợp khoa học – công nghệ – kỹ thuật – toán.", NgheNghiepId = 94 },
                new ChuyenNganh { Id = 614, TenChuyenNganh = "Giáo viên Văn hóa/Nghệ thuật/Khoa học khác", MoTa = "Các lĩnh vực văn hóa – khoa học khác.", NgheNghiepId = 94 },

                // Nghề 95: Thể chất/Thể hình
                new ChuyenNganh { Id = 615, TenChuyenNganh = "Huấn luyện viên Thể hình (PT)", MoTa = "Hướng dẫn tập luyện và xây dựng giáo án.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 616, TenChuyenNganh = "Giáo viên dạy nhảy/múa", MoTa = "Dạy các bộ môn nhảy/múa vận động.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 617, TenChuyenNganh = "Giáo viên Giáo dục thể chất", MoTa = "Giảng dạy thể dục và rèn luyện sức khỏe.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 618, TenChuyenNganh = "Huấn luyện viên bóng rổ", MoTa = "Dạy kỹ năng bóng rổ.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 619, TenChuyenNganh = "Huấn luyện viên Yoga", MoTa = "Dạy yoga và thiền.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 620, TenChuyenNganh = "Huấn luyện viên bơi lội", MoTa = "Dạy bơi và an toàn nước.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 621, TenChuyenNganh = "Huấn luyện viên võ thuật", MoTa = "Dạy võ và tự vệ.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 622, TenChuyenNganh = "Huấn luyện viên trượt patin", MoTa = "Dạy kỹ năng roller skating.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 623, TenChuyenNganh = "Huấn luyện viên bóng bàn", MoTa = "Dạy bóng bàn.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 624, TenChuyenNganh = "Huấn luyện viên bóng đá", MoTa = "Dạy kỹ năng bóng đá.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 625, TenChuyenNganh = "Huấn luyện viên cầu lông", MoTa = "Dạy cầu lông.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 626, TenChuyenNganh = "Huấn luyện viên quyền anh (Boxing)", MoTa = "Dạy boxing.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 627, TenChuyenNganh = "Huấn luyện viên Bi-a (Billiard)", MoTa = "Dạy bi-a.", NgheNghiepId = 95 },
                new ChuyenNganh { Id = 628, TenChuyenNganh = "Huấn luyện viên thể thao khác", MoTa = "Các môn thể thao khác.", NgheNghiepId = 95 },

                // Nghề 96: Quản lý giáo dục
                new ChuyenNganh { Id = 629, TenChuyenNganh = "Quản lý học vụ", MoTa = "Quản lý lịch học, hồ sơ, điểm số.", NgheNghiepId = 96 },
                new ChuyenNganh { Id = 630, TenChuyenNganh = "Chuyên viên điều phối giáo viên", MoTa = "Điều phối và phân công giảng dạy.", NgheNghiepId = 96 },
                new ChuyenNganh { Id = 631, TenChuyenNganh = "Hiệu trưởng/Phó hiệu trưởng", MoTa = "Quản lý cơ sở giáo dục.", NgheNghiepId = 96 },
                new ChuyenNganh { Id = 632, TenChuyenNganh = "Giáo viên chủ nhiệm", MoTa = "Quản lý lớp học và học sinh.", NgheNghiepId = 96 },
                new ChuyenNganh { Id = 633, TenChuyenNganh = "Quản lý giảng dạy", MoTa = "Quản lý chương trình dạy học.", NgheNghiepId = 96 },
                new ChuyenNganh { Id = 634, TenChuyenNganh = "Quản lý chất lượng giáo dục", MoTa = "Đảm bảo chất lượng đào tạo.", NgheNghiepId = 96 },
                new ChuyenNganh { Id = 635, TenChuyenNganh = "Quản lý giáo dục khác", MoTa = "Các hoạt động quản lý giáo dục khác.", NgheNghiepId = 96 },

                // Nghề 97: Trợ giảng
                new ChuyenNganh { Id = 636, TenChuyenNganh = "Trợ giảng tiếng Anh", MoTa = "Hỗ trợ giảng dạy tiếng Anh.", NgheNghiepId = 97 },
                new ChuyenNganh { Id = 637, TenChuyenNganh = "Trợ giảng tiếng Trung", MoTa = "Hỗ trợ giảng dạy tiếng Trung.", NgheNghiepId = 97 },
                new ChuyenNganh { Id = 638, TenChuyenNganh = "Trợ giảng tiếng Nhật", MoTa = "Hỗ trợ giảng dạy tiếng Nhật.", NgheNghiepId = 97 },
                new ChuyenNganh { Id = 639, TenChuyenNganh = "Trợ giảng tiếng Hàn", MoTa = "Hỗ trợ giáo viên tiếng Hàn.", NgheNghiepId = 97 },
                new ChuyenNganh { Id = 640, TenChuyenNganh = "Trợ giảng tiếng Đức", MoTa = "Hỗ trợ giảng dạy tiếng Đức.", NgheNghiepId = 97 },
                new ChuyenNganh { Id = 641, TenChuyenNganh = "Trợ giảng ngoại ngữ khác", MoTa = "Hỗ trợ dạy các môn ngoại ngữ khác.", NgheNghiepId = 97 },
                new ChuyenNganh { Id = 642, TenChuyenNganh = "Trợ giảng bộ môn khác", MoTa = "Hỗ trợ dạy các môn học khác.", NgheNghiepId = 97 },

                // Nghề 98: Quản lý/Hỗ trợ lớp học
                new ChuyenNganh { Id = 643, TenChuyenNganh = "Quản lý/Vận hành lớp học", MoTa = "Quản lý hoạt động và vận hành lớp học.", NgheNghiepId = 98 },
                new ChuyenNganh { Id = 644, TenChuyenNganh = "Hỗ trợ lớp học", MoTa = "Hỗ trợ học viên và giáo viên trong quá trình học.", NgheNghiepId = 98 },
                new ChuyenNganh { Id = 645, TenChuyenNganh = "Chăm sóc/Hỗ trợ học viên", MoTa = "Theo dõi và hỗ trợ học viên trong quá trình học tập.", NgheNghiepId = 98 },
                new ChuyenNganh { Id = 646, TenChuyenNganh = "Quản lý/Hỗ trợ lớp học khác", MoTa = "Các công việc khác thuộc hỗ trợ lớp học.", NgheNghiepId = 98 },

                // Nghề 99: Sales Giáo dục/Khoá học
                new ChuyenNganh { Id = 647, TenChuyenNganh = "Tư vấn tuyển sinh/khoá học", MoTa = "Tư vấn chương trình học và hỗ trợ tuyển sinh.", NgheNghiepId = 99 },
                new ChuyenNganh { Id = 648, TenChuyenNganh = "Tư vấn du học", MoTa = "Tư vấn chương trình du học và hồ sơ liên quan.", NgheNghiepId = 99 },
                new ChuyenNganh { Id = 649, TenChuyenNganh = "Sales Giáo dục/Khoá học khác", MoTa = "Các hoạt động kinh doanh liên quan đến giáo dục.", NgheNghiepId = 99 },

                // Nghề 100: Giáo dục/Đào tạo khác
                new ChuyenNganh { Id = 650, TenChuyenNganh = "Giáo viên dạy lái xe ô tô", MoTa = "Giảng dạy kỹ năng lái xe ô tô.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 651, TenChuyenNganh = "Giáo viên dạy nghề", MoTa = "Dạy các nghề kỹ thuật hoặc đào tạo nghề.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 652, TenChuyenNganh = "Giáo viên giáo dục đặc biệt", MoTa = "Dạy học sinh có nhu cầu đặc biệt.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 653, TenChuyenNganh = "Giáo viên dạy cắm hoa", MoTa = "Dạy nghệ thuật cắm hoa và trang trí.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 654, TenChuyenNganh = "Giáo viên dạy nấu ăn", MoTa = "Dạy kỹ năng nấu ăn và ẩm thực.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 655, TenChuyenNganh = "Thủ thư", MoTa = "Quản lý thư viện và hỗ trợ học liệu.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 656, TenChuyenNganh = "Phát triển học liệu/Thiết kế khóa học", MoTa = "Thiết kế nội dung học tập và tài liệu giảng dạy.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 657, TenChuyenNganh = "Cố vấn học tập", MoTa = "Hỗ trợ học viên định hướng học tập.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 658, TenChuyenNganh = "Tư vấn hướng nghiệp", MoTa = "Tư vấn nghề nghiệp và định hướng tương lai.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 659, TenChuyenNganh = "Tư vấn tâm lý học đường", MoTa = "Hỗ trợ tâm lý và cảm xúc cho học sinh.", NgheNghiepId = 100 },
                new ChuyenNganh { Id = 660, TenChuyenNganh = "Chuyên môn Giáo dục/Đào tạo khác", MoTa = "Các chuyên môn khác trong lĩnh vực giáo dục.", NgheNghiepId = 100 },

                // Nghề 101: Bán lẻ
                new ChuyenNganh { Id = 661, TenChuyenNganh = "Kinh doanh kênh MT", MoTa = "Quản lý bán hàng kênh Modern Trade.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 662, TenChuyenNganh = "Kinh doanh kênh GT", MoTa = "Phát triển bán hàng kênh General Trade.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 663, TenChuyenNganh = "Bán hàng siêu thị/cửa hàng tiện ích/tiện lợi", MoTa = "Bán hàng tại cửa hàng tiện ích.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 664, TenChuyenNganh = "Bán hàng điện thoại", MoTa = "Tư vấn và bán điện thoại/phụ kiện.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 665, TenChuyenNganh = "Bán hàng điện máy", MoTa = "Bán thiết bị điện máy và gia dụng.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 666, TenChuyenNganh = "Bán hàng thời trang", MoTa = "Bán sản phẩm thời trang.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 667, TenChuyenNganh = "Bán hàng trang sức đá quý", MoTa = "Bán vàng bạc – đá quý.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 668, TenChuyenNganh = "Bán hàng mỹ phẩm", MoTa = "Bán mỹ phẩm và nước hoa.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 669, TenChuyenNganh = "Kinh doanh thực phẩm", MoTa = "Bán lẻ thực phẩm.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 670, TenChuyenNganh = "Kinh doanh bao bì", MoTa = "Bán các loại bao bì.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 671, TenChuyenNganh = "Sales thẻ tập", MoTa = "Bán thẻ tập gym/yoga.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 672, TenChuyenNganh = "Sales Bán lẻ/Dịch vụ tiêu dùng khác", MoTa = "Các vị trí bán lẻ khác.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 673, TenChuyenNganh = "Thu ngân", MoTa = "Xử lý thanh toán tại quầy.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 674, TenChuyenNganh = "Giám sát thu ngân", MoTa = "Quản lý đội ngũ thu ngân.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 675, TenChuyenNganh = "Nhân viên siêu thị", MoTa = "Trưng bày, bán hàng và kiểm kho.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 676, TenChuyenNganh = "Phòng chống thất thoát", MoTa = "Theo dõi, giảm thất thoát hàng hóa.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 677, TenChuyenNganh = "Quản lý cửa hàng/Cửa hàng trưởng", MoTa = "Điều hành hoạt động cửa hàng.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 678, TenChuyenNganh = "Giám đốc siêu thị", MoTa = "Quản lý toàn bộ siêu thị.", NgheNghiepId = 101 },
                new ChuyenNganh { Id = 679, TenChuyenNganh = "Vận hành trung tâm thương mại", MoTa = "Vận hành & quản lý TTTM.", NgheNghiepId = 101 },

                /// Nghề 102: Dịch vụ làm đẹp
                new ChuyenNganh { Id = 680, TenChuyenNganh = "Kỹ thuật viên Spa", MoTa = "Thực hiện các liệu trình chăm sóc da và trị liệu spa.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 681, TenChuyenNganh = "Quản lý Spa", MoTa = "Quản lý vận hành và dịch vụ tại spa.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 682, TenChuyenNganh = "Tư vấn thẩm mỹ/Spa", MoTa = "Tư vấn dịch vụ làm đẹp và chăm sóc da.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 683, TenChuyenNganh = "Tư vấn nha khoa", MoTa = "Tư vấn dịch vụ nha khoa và chăm sóc răng miệng.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 684, TenChuyenNganh = "Thợ nail/mi", MoTa = "Làm móng, nối mi và chăm sóc thẩm mỹ.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 685, TenChuyenNganh = "Phun xăm thẩm mỹ", MoTa = "Thực hiện phun xăm, điêu khắc chân mày/môi.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 686, TenChuyenNganh = "Thợ xăm (Tattoo Artist)", MoTa = "Xăm hình nghệ thuật theo yêu cầu khách hàng.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 687, TenChuyenNganh = "Thợ cắt tóc", MoTa = "Cắt tóc, tạo kiểu và chăm sóc tóc.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 688, TenChuyenNganh = "Trợ lý/Học việc làm tóc", MoTa = "Hỗ trợ thợ chính trong salon tóc.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 689, TenChuyenNganh = "Makeup/Stylist", MoTa = "Trang điểm và tư vấn phong cách cá nhân.", NgheNghiepId = 102 },
                new ChuyenNganh { Id = 690, TenChuyenNganh = "Việc làm Chăm sóc sức khỏe/Làm đẹp khác", MoTa = "Các công việc khác trong lĩnh vực làm đẹp.", NgheNghiepId = 102 },

                // Nghề 103: Dịch vụ chăm sóc sức khoẻ
                new ChuyenNganh { Id = 691, TenChuyenNganh = "Chuyên viên vật lý trị liệu", MoTa = "Thực hiện phục hồi chức năng và vật lý trị liệu.", NgheNghiepId = 103 },
                new ChuyenNganh { Id = 692, TenChuyenNganh = "Kỹ thuật viên châm cứu bấm huyệt", MoTa = "Thực hiện châm cứu, bấm huyệt và trị liệu đông y.", NgheNghiepId = 103 },
                new ChuyenNganh { Id = 693, TenChuyenNganh = "Nhân viên massage", MoTa = "Thực hiện massage thư giãn hoặc trị liệu.", NgheNghiepId = 103 },
                new ChuyenNganh { Id = 694, TenChuyenNganh = "Dịch vụ chăm sóc sức khỏe khác", MoTa = "Các dịch vụ chăm sóc sức khỏe khác.", NgheNghiepId = 103 },

                // Nghề 104: Dịch vụ vệ sinh/nhà cửa
                new ChuyenNganh { Id = 695, TenChuyenNganh = "Nhân viên dọn vệ sinh", MoTa = "Dọn dẹp, vệ sinh nhà cửa, văn phòng.", NgheNghiepId = 104 },
                new ChuyenNganh { Id = 696, TenChuyenNganh = "Giám sát vệ sinh", MoTa = "Quản lý đội vệ sinh và chất lượng dịch vụ.", NgheNghiepId = 104 },
                new ChuyenNganh { Id = 697, TenChuyenNganh = "Giúp việc", MoTa = "Hỗ trợ việc nhà và sinh hoạt gia đình.", NgheNghiepId = 104 },
                new ChuyenNganh { Id = 698, TenChuyenNganh = "Sắp xếp tủ quần áo và nhà cửa", MoTa = "Sắp xếp đồ đạc, dọn dẹp không gian sống.", NgheNghiepId = 104 },
                new ChuyenNganh { Id = 699, TenChuyenNganh = "Vệ sinh/Tạp vụ", MoTa = "Thực hiện vệ sinh trong nhà hàng, khách sạn, văn phòng.", NgheNghiepId = 104 },
                new ChuyenNganh { Id = 700, TenChuyenNganh = "Dịch vụ vệ sinh/nhà cửa khác", MoTa = "Các dịch vụ vệ sinh khác.", NgheNghiepId = 104 },

                // Nghề 105: Tài xế/Lái xe
                new ChuyenNganh { Id = 701, TenChuyenNganh = "Bưu tá", MoTa = "Giao thư từ, bưu phẩm tận nơi.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 702, TenChuyenNganh = "Shipper (Nhân viên giao hàng)", MoTa = "Giao hàng hóa theo đơn cho khách hàng.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 703, TenChuyenNganh = "Tài xế lái xe thuê", MoTa = "Lái xe theo yêu cầu thuê riêng của khách.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 704, TenChuyenNganh = "Tài xế taxi", MoTa = "Đưa đón khách bằng taxi.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 705, TenChuyenNganh = "Tài xế lái xe văn phòng", MoTa = "Đưa đón nhân viên hoặc sếp đi công tác.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 706, TenChuyenNganh = "Tài xế xe khách", MoTa = "Chở hành khách trên các tuyến cố định.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 707, TenChuyenNganh = "Tài xế B2", MoTa = "Lái các loại xe du lịch, xe tải nhẹ theo bằng B2.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 708, TenChuyenNganh = "Lái xe cho sếp", MoTa = "Đưa đón lãnh đạo, đảm bảo lịch trình và an toàn.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 709, TenChuyenNganh = "Tài xế lái xe đường dài", MoTa = "Lái xe đường dài, xuyên tỉnh hoặc quốc tế.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 710, TenChuyenNganh = "Tài xế công nghệ", MoTa = "Chạy xe công nghệ cho các ứng dụng như Grab/Be.", NgheNghiepId = 105 },
                new ChuyenNganh { Id = 711, TenChuyenNganh = "Dịch vụ vận tải khác", MoTa = "Các công việc vận tải khác theo nhu cầu.", NgheNghiepId = 105 },

                // Nghề 106: Dịch vụ an ninh và bảo trì
                new ChuyenNganh { Id = 712, TenChuyenNganh = "Bảo vệ", MoTa = "Đảm bảo an ninh khu vực, kiểm soát ra vào.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 713, TenChuyenNganh = "Giám sát an ninh", MoTa = "Kiểm soát an ninh và xử lý sự cố.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 714, TenChuyenNganh = "Nhân viên PCCC", MoTa = "Theo dõi, vận hành hệ thống phòng cháy chữa cháy.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 715, TenChuyenNganh = "Bảo trì PCCC", MoTa = "Kiểm tra và bảo trì thiết bị phòng cháy chữa cháy.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 716, TenChuyenNganh = "Sửa chữa thiết bị gia dụng", MoTa = "Sửa chữa và bảo trì thiết bị trong gia đình.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 717, TenChuyenNganh = "Sửa chữa điện thoại", MoTa = "Khắc phục lỗi và sửa chữa điện thoại.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 718, TenChuyenNganh = "Sửa chữa máy tính và máy in", MoTa = "Sửa chữa thiết bị văn phòng.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 719, TenChuyenNganh = "Thợ điện lạnh", MoTa = "Sửa chữa và bảo trì thiết bị điện lạnh.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 720, TenChuyenNganh = "Thợ sửa khoá", MoTa = "Mở khóa và sửa khóa gia đình/cửa hàng.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 721, TenChuyenNganh = "Sửa chữa/Bảo trì điện nước", MoTa = "Sửa chữa hệ thống điện, nước dân dụng.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 722, TenChuyenNganh = "Lắp đặt/bảo trì thang máy", MoTa = "Lắp đặt và bảo trì hệ thống thang máy.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 723, TenChuyenNganh = "Thợ sửa xe", MoTa = "Sửa chữa xe máy hoặc ô tô.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 724, TenChuyenNganh = "Bảo trì tòa nhà", MoTa = "Bảo trì cơ sở vật chất trong tòa nhà.", NgheNghiepId = 106 },
                new ChuyenNganh { Id = 725, TenChuyenNganh = "Việc làm Bảo vệ/Bảo trì/Sửa chữa khác", MoTa = "Các công việc khác trong lĩnh vực an ninh – bảo trì.", NgheNghiepId = 106 },

                // Nghề 107: Dịch vụ bà mẹ trẻ em
                new ChuyenNganh { Id = 726, TenChuyenNganh = "Bảo mẫu/Người trông trẻ", MoTa = "Chăm sóc trẻ tại nhà hoặc trường học.", NgheNghiepId = 107 },
                new ChuyenNganh { Id = 727, TenChuyenNganh = "Chăm sóc mẹ và bé", MoTa = "Hỗ trợ chăm sóc mẹ sau sinh và trẻ sơ sinh.", NgheNghiepId = 107 },
                new ChuyenNganh { Id = 728, TenChuyenNganh = "Dịch vụ bà mẹ trẻ em khác", MoTa = "Các dịch vụ chăm sóc mẹ và bé khác.", NgheNghiepId = 107 },

                // Nghề 108: Dịch vụ ô tô/xe máy/xe điện
                new ChuyenNganh { Id = 729, TenChuyenNganh = "Thợ sửa xe", MoTa = "Sửa chữa và bảo dưỡng xe máy hoặc ô tô.", NgheNghiepId = 108 },
                new ChuyenNganh { Id = 730, TenChuyenNganh = "Nhân viên rửa xe", MoTa = "Rửa xe, vệ sinh nội ngoại thất.", NgheNghiepId = 108 },
                new ChuyenNganh { Id = 731, TenChuyenNganh = "Thợ độ xe ô tô/xe máy/xe điện", MoTa = "Độ xe, nâng cấp phụ kiện và ngoại thất.", NgheNghiepId = 108 },
                new ChuyenNganh { Id = 732, TenChuyenNganh = "Quản lý cửa hàng sửa chữa và bảo trì ô tô/xe máy/xe điện", MoTa = "Quản lý vận hành và dịch vụ tại garage.", NgheNghiepId = 108 },
                new ChuyenNganh { Id = 733, TenChuyenNganh = "Kiểm định ô tô", MoTa = "Kiểm định an toàn kỹ thuật và đăng kiểm xe.", NgheNghiepId = 108 },
                new ChuyenNganh { Id = 734, TenChuyenNganh = "Giám định bồi thường ô tô", MoTa = "Giám định thiệt hại xe và xử lý bồi thường bảo hiểm.", NgheNghiepId = 108 },
                new ChuyenNganh { Id = 735, TenChuyenNganh = "Dịch vụ ô tô/xe máy/xe điện khác", MoTa = "Các dịch vụ khác liên quan đến xe.", NgheNghiepId = 108 },

                // Nghề 109: Dịch vụ thú cưng
                new ChuyenNganh { Id = 736, TenChuyenNganh = "Chuyên viên chăm sóc/spa thú cưng", MoTa = "Tắm, cắt tỉa, chăm sóc thú cưng chuyên nghiệp.", NgheNghiepId = 109 },
                new ChuyenNganh { Id = 737, TenChuyenNganh = "Bác sĩ thú y", MoTa = "Thăm khám và điều trị cho thú cưng.", NgheNghiepId = 109 },
                new ChuyenNganh { Id = 738, TenChuyenNganh = "Dịch vụ thú cưng khác", MoTa = "Các dịch vụ khác liên quan đến thú cưng.", NgheNghiepId = 109 },

                // Nghề 110: Bán lẻ/Dịch vụ đời sống khác
                new ChuyenNganh { Id = 739, TenChuyenNganh = "Thợ cắm hoa", MoTa = "Thiết kế và cắm hoa nghệ thuật.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 740, TenChuyenNganh = "Thợ thủ công mỹ nghệ", MoTa = "Tạo ra sản phẩm thủ công và mỹ nghệ.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 741, TenChuyenNganh = "Thợ thủ công khác", MoTa = "Các nghề thủ công khác.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 742, TenChuyenNganh = "Tổ chức tiệc cưới (Wedding Planner)", MoTa = "Lên kế hoạch và điều phối tiệc cưới.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 743, TenChuyenNganh = "Quản lý quán net", MoTa = "Quản lý hoạt động phòng game/Internet.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 744, TenChuyenNganh = "Sales Tour/Kinh doanh du lịch", MoTa = "Bán tour và dịch vụ du lịch.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 745, TenChuyenNganh = "Bán vé máy bay (Ticketing/Booker)", MoTa = "Đặt vé máy bay và xử lý booking.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 746, TenChuyenNganh = "Kinh doanh khách sạn", MoTa = "Kinh doanh dịch vụ khách sạn, lưu trú.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 747, TenChuyenNganh = "Chuyên viên đo thị lực", MoTa = "Đo mắt và tư vấn kính/áp tròng.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 748, TenChuyenNganh = "Photographer/Video Editor", MoTa = "Chụp ảnh và dựng video.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 749, TenChuyenNganh = "Nhân viên rạp chiếu phim", MoTa = "Hỗ trợ bán vé, phục vụ và vận hành rạp phim.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 750, TenChuyenNganh = "Nhân viên cây xăng", MoTa = "Bơm xăng và hỗ trợ khách tại cửa hàng xăng dầu.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 751, TenChuyenNganh = "Nhân viên cứu hộ (Lifeguard)", MoTa = "Giám sát an toàn tại hồ bơi/bãi biển.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 752, TenChuyenNganh = "Giáo viên dạy cắm hoa", MoTa = "Giảng dạy kỹ năng cắm hoa.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 753, TenChuyenNganh = "Giáo viên dạy nấu ăn", MoTa = "Dạy nấu ăn và kỹ năng ẩm thực.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 754, TenChuyenNganh = "Giáo viên dạy lái xe ô tô", MoTa = "Dạy kỹ năng lái ô tô.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 755, TenChuyenNganh = "Chuyên viên điều khiển drone", MoTa = "Điều khiển drone cho quay phim/chụp ảnh/kỹ thuật.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 756, TenChuyenNganh = "Tổ chức sự kiện (Event Planner)", MoTa = "Lên kế hoạch và điều phối sự kiện.", NgheNghiepId = 110 },
                new ChuyenNganh { Id = 757, TenChuyenNganh = "Việc làm Bán lẻ/Dịch vụ đời sống khác", MoTa = "Các công việc khác thuộc nhóm dịch vụ – bán lẻ.", NgheNghiepId = 110 },

                // Nghề 111: Biên tập/Viết/Xuất bản
                new ChuyenNganh { Id = 758, TenChuyenNganh = "Biên tập viên", MoTa = "Biên tập nội dung, chỉnh sửa bài viết và tài liệu xuất bản.", NgheNghiepId = 111 },
                new ChuyenNganh { Id = 759, TenChuyenNganh = "Tổng biên tập/Phó tổng biên tập", MoTa = "Quản lý nội dung, kiểm duyệt và định hướng xuất bản.", NgheNghiepId = 111 },
                new ChuyenNganh { Id = 760, TenChuyenNganh = "Phóng viên/Biên tập viên tin tức", MoTa = "Thu thập thông tin, viết tin bài và biên tập tin tức.", NgheNghiepId = 111 },
                new ChuyenNganh { Id = 761, TenChuyenNganh = "Nhập liệu", MoTa = "Nhập nội dung, dữ liệu và chỉnh sửa cơ bản cho ấn phẩm.", NgheNghiepId = 111 },
                new ChuyenNganh { Id = 762, TenChuyenNganh = "In ấn và sắp chữ", MoTa = "Thực hiện dàn trang, sắp chữ và in ấn tài liệu.", NgheNghiepId = 111 },
                new ChuyenNganh { Id = 763, TenChuyenNganh = "Nhân viên chế bản", MoTa = "Xử lý chế bản điện tử, chuẩn bị file in ấn.", NgheNghiepId = 111 },
                new ChuyenNganh { Id = 764, TenChuyenNganh = "Chuyên môn Biên tập/Viết/Xuất bản khác", MoTa = "Các vị trí khác trong biên tập, viết và xuất bản.", NgheNghiepId = 111 },

                // Nghề 112: Phim và truyền hình
                new ChuyenNganh { Id = 765, TenChuyenNganh = "Makeup/Stylist", MoTa = "Trang điểm và tạo phong cách cho diễn viên và nhân vật.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 766, TenChuyenNganh = "Diễn viên", MoTa = "Tham gia diễn xuất trong phim, TVC hoặc sân khấu.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 767, TenChuyenNganh = "Diễn viên lồng tiếng", MoTa = "Lồng tiếng cho nhân vật trong phim hoặc hoạt hình.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 768, TenChuyenNganh = "Quản lý/Trợ lý nghệ sĩ", MoTa = "Quản lý lịch trình và hỗ trợ nghệ sĩ.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 769, TenChuyenNganh = "Dẫn chương trình (MC)", MoTa = "Dẫn dắt chương trình truyền hình hoặc sự kiện.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 770, TenChuyenNganh = "Người mẫu/Mẫu ảnh", MoTa = "Tham gia chụp hình, quảng cáo và biểu diễn.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 771, TenChuyenNganh = "Photographer/Video Editor", MoTa = "Chụp ảnh, quay phim và dựng video.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 772, TenChuyenNganh = "Đạo diễn", MoTa = "Chỉ đạo sản xuất phim, TVC và chương trình truyền hình.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 773, TenChuyenNganh = "Biên đạo", MoTa = "Dàn dựng động tác, cảnh quay và trình diễn.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 774, TenChuyenNganh = "Biên kịch", MoTa = "Viết kịch bản phim, TVC hoặc chương trình truyền hình.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 775, TenChuyenNganh = "Producer (Sản xuất phim)", MoTa = "Quản lý sản xuất, ekip và tiến độ làm phim.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 776, TenChuyenNganh = "Phát hành điện ảnh và truyền hình", MoTa = "Phân phối và phát hành phim ra thị trường.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 777, TenChuyenNganh = "Hậu kỳ sản xuất", MoTa = "Xử lý hậu kỳ phim như dựng, chỉnh màu và âm thanh.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 778, TenChuyenNganh = "Animation Design", MoTa = "Thiết kế hoạt hình và chuyển động hình ảnh.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 779, TenChuyenNganh = "Chỉnh sửa ảnh (Retouch)", MoTa = "Chỉnh sửa hình ảnh cho sản phẩm truyền thông.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 780, TenChuyenNganh = "Kỹ thuật viên ánh sáng", MoTa = "Thiết lập và điều chỉnh ánh sáng trong quay phim.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 781, TenChuyenNganh = "Kỹ thuật viên âm thanh", MoTa = "Thu âm, xử lý âm thanh cho phim và truyền hình.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 782, TenChuyenNganh = "Nhân viên chiếu phim", MoTa = "Vận hành hệ thống chiếu phim tại rạp.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 783, TenChuyenNganh = "Thiết kế mỹ thuật sân khấu", MoTa = "Thiết kế không gian, đạo cụ và mỹ thuật sân khấu.", NgheNghiepId = 112 },
                new ChuyenNganh { Id = 784, TenChuyenNganh = "Chuyên môn Phim và truyền hình khác", MoTa = "Các chuyên môn khác thuộc lĩnh vực phim – truyền hình.", NgheNghiepId = 112 },

                // Nghề 113: Phim và truyền hình/Báo chí/Xuất bản khác
                new ChuyenNganh { Id = 785, TenChuyenNganh = "Chuyên môn Phim và truyền hình/Báo chí/Xuất bản khác", MoTa = "Các công việc khác thuộc nhóm phim, báo chí và xuất bản.", NgheNghiepId = 113 },

                // Nghề 114: Điện/Tự động hoá
                new ChuyenNganh { Id = 786, TenChuyenNganh = "Kỹ sư điện", MoTa = "Thiết kế, lắp đặt và vận hành hệ thống điện dân dụng và công nghiệp.", NgheNghiepId = 114 },
                new ChuyenNganh { Id = 787, TenChuyenNganh = "Kỹ sư thiết kế điện", MoTa = "Thiết kế bản vẽ điện, hệ thống điện tòa nhà, nhà máy.", NgheNghiepId = 114 },
                new ChuyenNganh { Id = 788, TenChuyenNganh = "Thợ điện", MoTa = "Thi công, sửa chữa và bảo trì hệ thống điện.", NgheNghiepId = 114 },
                new ChuyenNganh { Id = 789, TenChuyenNganh = "Kỹ sư tự động hóa", MoTa = "Thiết kế và vận hành hệ thống tự động hóa, dây chuyền.", NgheNghiepId = 114 },
                new ChuyenNganh { Id = 790, TenChuyenNganh = "Kỹ sư cơ điện", MoTa = "Thiết kế, thi công hệ thống M&E tòa nhà, nhà máy.", NgheNghiepId = 114 },
                new ChuyenNganh { Id = 791, TenChuyenNganh = "Kỹ sư lập trình PLC/SCADA", MoTa = "Lập trình PLC/SCADA điều khiển dây chuyền tự động.", NgheNghiepId = 114 },
                new ChuyenNganh { Id = 792, TenChuyenNganh = "Kỹ sư robot", MoTa = "Lập trình và vận hành robot công nghiệp.", NgheNghiepId = 114 },
                new ChuyenNganh { Id = 793, TenChuyenNganh = "Chuyên môn Điện/Tự động hoá khác", MoTa = "Các vị trí khác trong lĩnh vực điện và tự động hóa.", NgheNghiepId = 114 },

                // Nghề 115: Điện tử/Phần cứng
                new ChuyenNganh { Id = 794, TenChuyenNganh = "Kỹ sư điện tử", MoTa = "Thiết kế và phát triển mạch điện, hệ thống điện tử.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 795, TenChuyenNganh = "Thiết kế mạch điện/vi mạch", MoTa = "Thiết kế schematic, PCB và vi mạch.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 796, TenChuyenNganh = "Kỹ sư phần cứng", MoTa = "Phát triển bo mạch và phần cứng điện tử.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 797, TenChuyenNganh = "Embedded Engineer/Lập trình nhúng", MoTa = "Lập trình nhúng trên vi điều khiển và hệ thống nhúng.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 798, TenChuyenNganh = "Sửa chữa/Bảo trì điện tử/viễn thông", MoTa = "Sửa chữa và bảo trì thiết bị điện tử, viễn thông.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 799, TenChuyenNganh = "Phát triển FPGA", MoTa = "Thiết kế, lập trình FPGA cho xử lý phần cứng.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 800, TenChuyenNganh = "Vi điều khiển", MoTa = "Lập trình, thiết kế hệ thống sử dụng vi điều khiển.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 801, TenChuyenNganh = "Kỹ sư phát triển Driver", MoTa = "Phát triển driver cho thiết bị phần cứng.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 802, TenChuyenNganh = "Kỹ sư PCB", MoTa = "Thiết kế, layout và kiểm tra PCB.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 803, TenChuyenNganh = "Kỹ sư RF", MoTa = "Phát triển hệ thống RF và vô tuyến.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 804, TenChuyenNganh = "Tích hợp hệ thống", MoTa = "Tích hợp phần cứng – phần mềm cho sản phẩm điện tử.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 805, TenChuyenNganh = "Kỹ sư quang học", MoTa = "Thiết kế và thử nghiệm hệ thống quang học.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 806, TenChuyenNganh = "Phát triển DSP", MoTa = "Phát triển xử lý tín hiệu số DSP.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 807, TenChuyenNganh = "Phát triển ARM", MoTa = "Lập trình chip ARM và hệ thống nhúng.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 808, TenChuyenNganh = "Kỹ thuật điện/điện tử", MoTa = "Lắp đặt, sửa chữa và vận hành thiết bị điện tử.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 809, TenChuyenNganh = "Công nhân điện tử", MoTa = "Lắp ráp và vận hành dây chuyền sản xuất điện tử.", NgheNghiepId = 115 },
                new ChuyenNganh { Id = 810, TenChuyenNganh = "Chuyên môn Điện tử/Phần cứng khác", MoTa = "Các chuyên môn khác thuộc phần cứng – điện tử.", NgheNghiepId = 115 },

                // Nghề 116: Nhiệt/Gió/Điều hoà (HVAC-R)
                new ChuyenNganh { Id = 811, TenChuyenNganh = "Kỹ sư HVAC", MoTa = "Thiết kế và giám sát hệ thống điều hòa thông gió.", NgheNghiepId = 116 },
                new ChuyenNganh { Id = 812, TenChuyenNganh = "Kỹ sư nhiệt lạnh", MoTa = "Thiết kế và vận hành hệ thống nhiệt lạnh công nghiệp.", NgheNghiepId = 116 },
                new ChuyenNganh { Id = 813, TenChuyenNganh = "Kỹ sư điện lạnh", MoTa = "Phát triển hệ thống điện lạnh dân dụng và công nghiệp.", NgheNghiepId = 116 },
                new ChuyenNganh { Id = 814, TenChuyenNganh = "Thợ điện lạnh", MoTa = "Sửa chữa và bảo trì thiết bị điện lạnh.", NgheNghiepId = 116 },
                new ChuyenNganh { Id = 815, TenChuyenNganh = "Chuyên môn Nhiệt/Gió/Điều hoà (HVAC-R)", MoTa = "Các chuyên môn khác thuộc HVAC-R.", NgheNghiepId = 116 },

                // Nghề 117: Chất bán dẫn/Chip
                new ChuyenNganh { Id = 816, TenChuyenNganh = "Thiết kế vi mạch IC", MoTa = "Thiết kế IC analog, digital hoặc mixed-signal.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 817, TenChuyenNganh = "Kỹ sư kiểm định IC", MoTa = "Kiểm tra và đánh giá chất lượng IC.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 818, TenChuyenNganh = "Analog Layout Design Engineer", MoTa = "Thiết kế layout cho IC analog.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 819, TenChuyenNganh = "Chip Test Engineer", MoTa = "Test và phân tích các lỗi IC.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 820, TenChuyenNganh = "DFT Engineer", MoTa = "Thiết kế kiểm thử cho chip (Design For Test).", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 821, TenChuyenNganh = "FAE", MoTa = "Hỗ trợ kỹ thuật chip và bán dẫn cho khách hàng.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 822, TenChuyenNganh = "Digital Front-end Designer", MoTa = "Thiết kế logic số cho IC.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 823, TenChuyenNganh = "Back-end Engineer", MoTa = "Thiết kế layout và physical design cho chip.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 824, TenChuyenNganh = "Analog IC Design Engineer", MoTa = "Thiết kế các mạch analog trên IC.", NgheNghiepId = 117 },
                new ChuyenNganh { Id = 825, TenChuyenNganh = "Chuyên môn Chất bán dẫn/Chip khác", MoTa = "Các vị trí khác trong ngành bán dẫn.", NgheNghiepId = 117 },

                // Nghề 118: Quản lý/Vận hành dự án kỹ thuật
                new ChuyenNganh { Id = 826, TenChuyenNganh = "Quản lý dự án điện", MoTa = "Quản lý tiến độ và kỹ thuật dự án điện.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 827, TenChuyenNganh = "Quản lý dự án kỹ thuật", MoTa = "Điều hành và giám sát các dự án kỹ thuật.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 828, TenChuyenNganh = "Trợ lý dự án kỹ thuật", MoTa = "Hỗ trợ điều phối và quản lý dự án kỹ thuật.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 829, TenChuyenNganh = "Chuyên viên dự án kỹ thuật", MoTa = "Phối hợp triển khai và giám sát dự án.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 830, TenChuyenNganh = "Kỹ sư triển khai", MoTa = "Triển khai các hệ thống thiết bị kỹ thuật.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 831, TenChuyenNganh = "Tư vấn triển khai", MoTa = "Tư vấn kỹ thuật và hỗ trợ triển khai dự án.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 832, TenChuyenNganh = "Kỹ sư phân tích yêu cầu", MoTa = "Phân tích yêu cầu kỹ thuật và đề xuất giải pháp.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 833, TenChuyenNganh = "Quản lý dự án phần cứng", MoTa = "Điều hành các dự án phát triển phần cứng.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 834, TenChuyenNganh = "Quản lý dự án viễn thông", MoTa = "Triển khai và giám sát dự án viễn thông.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 835, TenChuyenNganh = "Quản lý dự án hệ thống tự động hóa", MoTa = "Điều hành dự án hệ thống công nghiệp tự động.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 836, TenChuyenNganh = "Quản lý dự án năng lượng tái tạo", MoTa = "Quản lý dự án điện mặt trời, gió và năng lượng sạch.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 837, TenChuyenNganh = "Công nhân vận hành máy", MoTa = "Vận hành máy móc trong dây chuyền sản xuất.", NgheNghiepId = 118 },
                new ChuyenNganh { Id = 838, TenChuyenNganh = "Chuyên môn Quản lý/Vận hành dự án kỹ thuật khác", MoTa = "Các vị trí khác trong quản lý và vận hành dự án kỹ thuật.", NgheNghiepId = 118 },

                // Nghề 119: Viễn thông
                new ChuyenNganh { Id = 839, TenChuyenNganh = "Kỹ sư điện tử viễn thông", MoTa = "Thiết kế và vận hành hệ thống điện tử viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 840, TenChuyenNganh = "Kỹ thuật viễn thông", MoTa = "Thi công, bảo trì hệ thống viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 841, TenChuyenNganh = "Kỹ sư IoT (IoT Engineer)", MoTa = "Phát triển và triển khai hệ thống IoT.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 842, TenChuyenNganh = "Kỹ sư nghiên cứu và phát triển viễn thông", MoTa = "R&D các công nghệ và thiết bị viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 843, TenChuyenNganh = "Kỹ sư truyền thông không dây/vô tuyến (RF)", MoTa = "Phát triển và tối ưu hệ thống RF và wireless.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 844, TenChuyenNganh = "Kỹ sư truyền thông di động", MoTa = "Làm việc với mạng 4G/5G/6G.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 845, TenChuyenNganh = "Kỹ sư mạng viễn thông", MoTa = "Triển khai và quản lý mạng viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 846, TenChuyenNganh = "Kỹ sư truyền thông dữ liệu", MoTa = "Xây dựng hệ thống truyền dẫn dữ liệu.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 847, TenChuyenNganh = "Kỹ sư kiểm thử viễn thông", MoTa = "Kiểm thử thiết bị và hệ thống viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 848, TenChuyenNganh = "Kỹ sư truyền thông quang học", MoTa = "Thiết kế và vận hành mạng quang.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 849, TenChuyenNganh = "Kỹ sư mạng quang", MoTa = "Triển khai hệ thống cáp quang và truyền dẫn.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 850, TenChuyenNganh = "Kỹ sư điện viễn thông", MoTa = "Lắp đặt và bảo trì hệ thống điện – viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 851, TenChuyenNganh = "Kỹ sư truyền dẫn cáp", MoTa = "Thi công, kiểm tra đường cáp quang và đồng.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 852, TenChuyenNganh = "Kỹ sư thiết bị viễn thông", MoTa = "Vận hành và bảo trì thiết bị viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 853, TenChuyenNganh = "Kỹ sư mạng lõi", MoTa = "Triển khai core network cho hệ thống viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 854, TenChuyenNganh = "Kỹ sư tiêu chuẩn hóa viễn thông", MoTa = "Nghiên cứu và thiết lập tiêu chuẩn kỹ thuật viễn thông.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 855, TenChuyenNganh = "Kỹ sư mạng", MoTa = "Quản trị hệ thống mạng và hạ tầng kết nối.", NgheNghiepId = 119 },
                new ChuyenNganh { Id = 856, TenChuyenNganh = "Chuyên môn Viễn thông khác", MoTa = "Các chuyên môn khác trong ngành viễn thông.", NgheNghiepId = 119 },

                // Nghề 120: Vận hành và bảo trì/Hỗ trợ kỹ thuật
                new ChuyenNganh { Id = 857, TenChuyenNganh = "Sửa chữa/Bảo trì điện tử/viễn thông", MoTa = "Sửa chữa và bảo trì thiết bị điện tử, viễn thông.", NgheNghiepId = 120 },
                new ChuyenNganh { Id = 858, TenChuyenNganh = "Kỹ sư hệ thống", MoTa = "Vận hành và quản trị hệ thống CNTT hoặc viễn thông.", NgheNghiepId = 120 },
                new ChuyenNganh { Id = 859, TenChuyenNganh = "Kỹ sư tài liệu kỹ thuật", MoTa = "Soạn thảo tài liệu kỹ thuật và quy trình vận hành.", NgheNghiepId = 120 },
                new ChuyenNganh { Id = 860, TenChuyenNganh = "Vận hành điện", MoTa = "Vận hành hệ thống điện công nghiệp và tòa nhà.", NgheNghiepId = 120 },
                new ChuyenNganh { Id = 861, TenChuyenNganh = "Kỹ thuật điện/điện tử", MoTa = "Lắp đặt và sửa chữa thiết bị điện, điện tử.", NgheNghiepId = 120 },
                new ChuyenNganh { Id = 862, TenChuyenNganh = "Công nhân vận hành máy", MoTa = "Vận hành dây chuyền và thiết bị sản xuất.", NgheNghiepId = 120 },
                new ChuyenNganh { Id = 863, TenChuyenNganh = "Chuyên môn Vận hành và bảo trì/Hỗ trợ kỹ thuật khác", MoTa = "Các vị trí khác thuộc vận hành và kỹ thuật.", NgheNghiepId = 120 },

                // Nghề 121: Sales Điện/Điện tử/Viễn thông
                new ChuyenNganh { Id = 864, TenChuyenNganh = "Kinh doanh thiết bị/linh kiện điện", MoTa = "Bán thiết bị và linh kiện điện công nghiệp/dân dụng.", NgheNghiepId = 121 },
                new ChuyenNganh { Id = 865, TenChuyenNganh = "Kinh doanh thiết bị công nghiệp", MoTa = "Kinh doanh máy móc, thiết bị và giải pháp công nghiệp.", NgheNghiepId = 121 },
                new ChuyenNganh { Id = 866, TenChuyenNganh = "Kinh doanh dịch vụ viễn thông", MoTa = "Bán dịch vụ viễn thông, Internet và truyền dẫn dữ liệu.", NgheNghiepId = 121 },
                new ChuyenNganh { Id = 867, TenChuyenNganh = "Kinh doanh điện mặt trời", MoTa = "Bán thiết bị và dự án năng lượng mặt trời.", NgheNghiepId = 121 },
                new ChuyenNganh { Id = 868, TenChuyenNganh = "Kinh doanh HVAC", MoTa = "Bán thiết bị HVAC và giải pháp điều hòa.", NgheNghiepId = 121 },
                new ChuyenNganh { Id = 869, TenChuyenNganh = "Sales Điện/Điện tử/Viễn thông khác", MoTa = "Các vị trí kinh doanh khác trong ngành điện – điện tử.", NgheNghiepId = 121 },

                // Nghề 122: Điện/Điện tử/Viễn thông khác
                new ChuyenNganh { Id = 870, TenChuyenNganh = "Bán hàng kỹ thuật Điện/Điện tử/Viễn thông", MoTa = "Tư vấn, bán hàng và hỗ trợ kỹ thuật sản phẩm điện – điện tử.", NgheNghiepId = 122 },
                new ChuyenNganh { Id = 871, TenChuyenNganh = "Chuyên môn Điện/Điện tử/Viễn thông khác", MoTa = "Các chuyên môn khác không thuộc nhóm chính.", NgheNghiepId = 122 },

                // Nghề 123: Sales Xuất nhập khẩu/Logistics
                new ChuyenNganh { Id = 872, TenChuyenNganh = "Sales Logistics", MoTa = "Tư vấn, bán dịch vụ logistics và giải pháp vận chuyển.", NgheNghiepId = 123 },
                new ChuyenNganh { Id = 873, TenChuyenNganh = "Sales Xuất nhập khẩu/Logistics khác", MoTa = "Các vị trí kinh doanh khác trong lĩnh vực logistics.", NgheNghiepId = 123 },

                // Nghề 124: Xuất nhập khẩu/Logistics
                new ChuyenNganh { Id = 874, TenChuyenNganh = "Chuyên môn Xuất nhập khẩu/Logistics", MoTa = "Thực hiện quy trình XNK, chứng từ và logistics.", NgheNghiepId = 124 },
                new ChuyenNganh { Id = 875, TenChuyenNganh = "Giám đốc Logistics", MoTa = "Quản lý toàn bộ hoạt động logistics của doanh nghiệp.", NgheNghiepId = 124 },
                new ChuyenNganh { Id = 876, TenChuyenNganh = "Theo dõi đơn hàng", MoTa = "Theo dõi tiến độ nhập/xuất và vận chuyển hàng hóa.", NgheNghiepId = 124 },
                new ChuyenNganh { Id = 877, TenChuyenNganh = "Nhân viên hiện trường Logistics", MoTa = "Làm việc tại cảng/kho, giám sát xếp dỡ hàng hóa.", NgheNghiepId = 124 },
                new ChuyenNganh { Id = 878, TenChuyenNganh = "Quản lý hệ thống vận tải (TMS)", MoTa = "Vận hành và tối ưu hệ thống quản lý vận tải.", NgheNghiepId = 124 },
                new ChuyenNganh { Id = 879, TenChuyenNganh = "Giám sát/Điều phối hàng hoá và kho vận", MoTa = "Điều phối hoạt động kho, vận chuyển và phân phối.", NgheNghiepId = 124 },
                new ChuyenNganh { Id = 880, TenChuyenNganh = "Chứng từ xuất nhập khẩu", MoTa = "Chuẩn bị và xử lý bộ chứng từ XNK.", NgheNghiepId = 124 },

                // Nghề 125: Vận tải
                new ChuyenNganh { Id = 881, TenChuyenNganh = "Giám sát/Điều phối vận tải", MoTa = "Điều phối phương tiện và theo dõi vận chuyển.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 882, TenChuyenNganh = "Phân loại/Sắp xếp hàng hoá", MoTa = "Sắp xếp hàng hóa tại kho hoặc bưu cục.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 883, TenChuyenNganh = "Công nhân bốc xếp hàng hóa", MoTa = "Bốc xếp hàng hóa tại kho hoặc điểm giao nhận.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 884, TenChuyenNganh = "Tài xế lái xe nâng", MoTa = "Vận hành xe nâng trong kho/xưởng.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 885, TenChuyenNganh = "Tài xế xe tải", MoTa = "Vận chuyển hàng hóa bằng xe tải.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 886, TenChuyenNganh = "Tài xế container", MoTa = "Lái container vận chuyển hàng hóa.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 887, TenChuyenNganh = "Tài xế lái xe đường dài", MoTa = "Lái xe vận chuyển xuyên tỉnh/quốc tế.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 888, TenChuyenNganh = "Tài xế lái xe chuyên dụng", MoTa = "Lái xe chuyên dụng như xe cẩu, xe bồn.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 889, TenChuyenNganh = "Tài xế xe khách", MoTa = "Lái xe khách tuyến cố định hoặc hợp đồng.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 890, TenChuyenNganh = "Phụ xe", MoTa = "Hỗ trợ tài xế giao nhận và xếp dỡ hàng hóa.", NgheNghiepId = 125 },
                new ChuyenNganh { Id = 891, TenChuyenNganh = "Dịch vụ vận tải khác", MoTa = "Các công việc khác thuộc lĩnh vực vận tải.", NgheNghiepId = 125 },

                // Nghề 126: Giao nhận
                new ChuyenNganh { Id = 892, TenChuyenNganh = "Bưu tá", MoTa = "Giao thư, bưu phẩm đến khách hàng.", NgheNghiepId = 126 },
                new ChuyenNganh { Id = 893, TenChuyenNganh = "Quản lý trạm giao nhận/bưu cục", MoTa = "Quản lý nhân sự và vận hành bưu cục.", NgheNghiepId = 126 },
                new ChuyenNganh { Id = 894, TenChuyenNganh = "Phân loại/Sắp xếp hàng hoá", MoTa = "Phân loại hàng hóa tại trung tâm/xưởng.", NgheNghiepId = 126 },
                new ChuyenNganh { Id = 895, TenChuyenNganh = "Shipper (Nhân viên giao hàng)", MoTa = "Giao hàng theo đơn đến khách hàng.", NgheNghiepId = 126 },
                new ChuyenNganh { Id = 896, TenChuyenNganh = "Điều phối giao hàng", MoTa = "Điều phối shipper và lộ trình giao hàng.", NgheNghiepId = 126 },
                new ChuyenNganh { Id = 897, TenChuyenNganh = "Công nhân bốc xếp hàng hóa", MoTa = "Bốc xếp hàng tại kho giao nhận.", NgheNghiepId = 126 },
                new ChuyenNganh { Id = 898, TenChuyenNganh = "Freight Forwarder", MoTa = "Giao nhận vận chuyển quốc tế và thủ tục xuất nhập khẩu.", NgheNghiepId = 126 },
                new ChuyenNganh { Id = 899, TenChuyenNganh = "Dịch vụ giao nhận khác", MoTa = "Các vị trí khác trong giao nhận – vận chuyển.", NgheNghiepId = 126 },

                // Nghề 127: Kho vận
                new ChuyenNganh { Id = 900, TenChuyenNganh = "Nhân viên kho", MoTa = "Quản lý xuất/nhập và sắp xếp hàng trong kho.", NgheNghiepId = 127 },
                new ChuyenNganh { Id = 901, TenChuyenNganh = "Hành chính kho", MoTa = "Quản lý chứng từ, số liệu và hành chính kho.", NgheNghiepId = 127 },
                new ChuyenNganh { Id = 902, TenChuyenNganh = "Trưởng kho/Giám sát kho", MoTa = "Quản lý vận hành kho và nhân sự kho.", NgheNghiepId = 127 },
                new ChuyenNganh { Id = 903, TenChuyenNganh = "Freight Forwarder", MoTa = "Giao nhận và xử lý thủ tục xuất nhập khẩu.", NgheNghiepId = 127 },
                new ChuyenNganh { Id = 904, TenChuyenNganh = "Công nhân xếp quần áo", MoTa = "Gấp, đóng kiện và phân loại quần áo trong kho.", NgheNghiepId = 127 },
                new ChuyenNganh { Id = 905, TenChuyenNganh = "Công nhân đóng gói hàng hóa", MoTa = "Đóng gói, dán nhãn và kiểm hàng.", NgheNghiepId = 127 },
                new ChuyenNganh { Id = 906, TenChuyenNganh = "Chuyên môn Kho vận khác", MoTa = "Các công việc khác trong lĩnh vực kho vận.", NgheNghiepId = 127 },

                // Nghề 128: Thu mua/Mua hàng
                new ChuyenNganh { Id = 907, TenChuyenNganh = "Chuyên môn Thu mua/Mua hàng", MoTa = "Tìm nguồn cung, báo giá và quản lý nhà cung cấp.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 908, TenChuyenNganh = "Quản lý/Giám sát mua hàng", MoTa = "Giám sát hoạt động mua hàng và đội ngũ thu mua.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 909, TenChuyenNganh = "Kỹ sư quản lý chất lượng nhà cung cấp (SQE)", MoTa = "Kiểm soát chất lượng và đánh giá nhà cung cấp.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 910, TenChuyenNganh = "Điều phối hàng hóa", MoTa = "Điều phối luân chuyển hàng trong chuỗi cung ứng.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 911, TenChuyenNganh = "Quản lý hàng hoá (Merchandiser)", MoTa = "Theo dõi sản xuất, chất lượng và tiến độ hàng hóa.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 912, TenChuyenNganh = "Giám đốc Thu mua/Mua hàng", MoTa = "Quản lý chiến lược mua hàng của doanh nghiệp.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 913, TenChuyenNganh = "Chuyên viên đấu thầu", MoTa = "Tham gia đấu thầu và mua sắm vật tư.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 914, TenChuyenNganh = "Chuyên viên hồ sơ thầu", MoTa = "Chuẩn bị hồ sơ thầu và tài liệu đấu thầu.", NgheNghiepId = 128 },
                new ChuyenNganh { Id = 915, TenChuyenNganh = "Khai báo hải quan và kiểm dịch", MoTa = "Thực hiện khai báo hải quan và thủ tục kiểm dịch.", NgheNghiepId = 128 },

                // Nghề 129: Chuỗi cung ứng
                new ChuyenNganh { Id = 916, TenChuyenNganh = "Chuyên môn chuỗi cung ứng", MoTa = "Quản lý tiến độ, nguyên liệu và dòng chảy hàng hóa.", NgheNghiepId = 129 },
                new ChuyenNganh { Id = 917, TenChuyenNganh = "Quản lý/Giám sát chuỗi cung ứng", MoTa = "Điều hành hoạt động supply chain của doanh nghiệp.", NgheNghiepId = 129 },
                new ChuyenNganh { Id = 918, TenChuyenNganh = "Giám đốc chuỗi cung ứng", MoTa = "Quản lý chiến lược và toàn bộ hệ thống supply chain.", NgheNghiepId = 129 },
                new ChuyenNganh { Id = 919, TenChuyenNganh = "Quản lý sản xuất/Quản lý nguyên vật liệu (PMC)", MoTa = "Điều phối sản xuất và kế hoạch vật tư.", NgheNghiepId = 129 },

                // Nghề 130: Logistics khác
                new ChuyenNganh { Id = 920, TenChuyenNganh = "Việc làm Kho vận/Giao hàng khác", MoTa = "Các công việc khác thuộc kho vận và giao hàng.", NgheNghiepId = 130 },

                // Nghề 131: Tư vấn/Phân tích chuyên môn
                new ChuyenNganh { Id = 921, TenChuyenNganh = "Tư vấn quản lý doanh nghiệp", MoTa = "Tư vấn cải thiện vận hành, mô hình tổ chức và quy trình doanh nghiệp.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 922, TenChuyenNganh = "Tư vấn chiến lược", MoTa = "Xây dựng chiến lược phát triển, mở rộng thị trường và định hướng doanh nghiệp.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 923, TenChuyenNganh = "Tư vấn tài chính", MoTa = "Tư vấn tài chính doanh nghiệp, đầu tư, phân tích dòng tiền và rủi ro.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 924, TenChuyenNganh = "Tư vấn CNTT/IT Consultant", MoTa = "Tư vấn giải pháp phần mềm, hệ thống, chuyển đổi số và công nghệ.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 925, TenChuyenNganh = "Tư vấn nhân sự", MoTa = "Tư vấn cơ cấu nhân sự, đào tạo, C&B và quản trị nhân lực.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 926, TenChuyenNganh = "Tư vấn headhunting", MoTa = "Tìm kiếm nhân sự cấp cao và tư vấn tuyển dụng chuyên sâu.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 927, TenChuyenNganh = "Tư vấn tâm lý", MoTa = "Tư vấn tâm lý cá nhân, gia đình và sức khỏe tinh thần.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 928, TenChuyenNganh = "Tư vấn hôn nhân", MoTa = "Tư vấn quan hệ, hôn nhân và hòa giải gia đình.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 929, TenChuyenNganh = "Nghiên cứu thị trường (Market Research)", MoTa = "Thu thập, phân tích dữ liệu thị trường và hành vi khách hàng.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 930, TenChuyenNganh = "Phân tích dữ liệu", MoTa = "Phân tích dữ liệu kinh doanh để đề xuất giải pháp tối ưu.", NgheNghiepId = 131 },
                new ChuyenNganh { Id = 931, TenChuyenNganh = "Các vị trí tư vấn khác", MoTa = "Các công việc tư vấn chuyên môn khác theo nhu cầu doanh nghiệp.", NgheNghiepId = 131 },

                // Nghề 132: Y tá/Điều dưỡng
                new ChuyenNganh { Id = 932, TenChuyenNganh = "Y tá/Điều dưỡng", MoTa = "Chăm sóc bệnh nhân, hỗ trợ bác sĩ và theo dõi tình trạng sức khỏe.", NgheNghiepId = 132 },
                new ChuyenNganh { Id = 933, TenChuyenNganh = "Y tá trưởng/Điều dưỡng trưởng", MoTa = "Quản lý đội ngũ điều dưỡng và điều phối chăm sóc y tế.", NgheNghiepId = 132 },
                new ChuyenNganh { Id = 934, TenChuyenNganh = "Hộ lý/Hộ sinh", MoTa = "Chăm sóc mẹ và bé, hỗ trợ sinh nở và phục hồi.", NgheNghiepId = 132 },

                // Nghề 133: Bác sĩ/Kỹ thuật viên
                new ChuyenNganh { Id = 935, TenChuyenNganh = "Bác sĩ ngoại khoa", MoTa = "Khám, điều trị và phẫu thuật các bệnh lý ngoại khoa.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 936, TenChuyenNganh = "Bác sĩ nội khoa", MoTa = "Chẩn đoán và điều trị bệnh lý nội tạng.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 937, TenChuyenNganh = "Bác sĩ da liễu", MoTa = "Khám và điều trị bệnh về da liễu và thẩm mỹ.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 938, TenChuyenNganh = "Bác sĩ sản khoa và phụ khoa", MoTa = "Chăm sóc sức khỏe sinh sản và thai kỳ.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 939, TenChuyenNganh = "Bác sĩ nhi khoa", MoTa = "Khám chữa bệnh cho trẻ sơ sinh và trẻ em.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 940, TenChuyenNganh = "Bác sĩ nhãn khoa", MoTa = "Khám và điều trị bệnh về mắt.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 941, TenChuyenNganh = "Bác sĩ tâm lý", MoTa = "Tư vấn và điều trị các vấn đề sức khỏe tinh thần.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 942, TenChuyenNganh = "Bác sĩ thẩm mỹ", MoTa = "Thực hiện thẩm mỹ nội khoa và ngoại khoa.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 943, TenChuyenNganh = "Bác sĩ đa khoa", MoTa = "Khám tổng quát và điều trị đa chuyên khoa.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 944, TenChuyenNganh = "Bác sĩ tai mũi họng", MoTa = "Điều trị các bệnh về tai, mũi, họng.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 945, TenChuyenNganh = "Bác sĩ siêu âm", MoTa = "Thực hiện siêu âm chẩn đoán hình ảnh.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 946, TenChuyenNganh = "Bác sĩ gây mê hồi sức", MoTa = "Gây mê và hồi sức người bệnh trong phẫu thuật.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 947, TenChuyenNganh = "Bác sĩ y học cổ truyền", MoTa = "Khám chữa bệnh bằng Đông y và y học cổ truyền.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 948, TenChuyenNganh = "Bác sĩ nha khoa", MoTa = "Khám và điều trị răng hàm mặt.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 949, TenChuyenNganh = "Kỹ thuật viên xét nghiệm", MoTa = "Thực hiện xét nghiệm máu, nước tiểu và mẫu sinh học.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 950, TenChuyenNganh = "Kỹ thuật viên chẩn đoán hình ảnh", MoTa = "Thực hiện X-ray, CT, MRI và các kỹ thuật hình ảnh khác.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 951, TenChuyenNganh = "Kỹ thuật viên gây mê", MoTa = "Hỗ trợ gây mê và hồi sức trong phẫu thuật.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 952, TenChuyenNganh = "Kỹ thuật viên đo thị lực", MoTa = "Đo mắt và hỗ trợ bác sĩ nhãn khoa.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 953, TenChuyenNganh = "Quản lý y tế", MoTa = "Quản lý bệnh viện, phòng khám và hệ thống y tế.", NgheNghiepId = 133 },
                new ChuyenNganh { Id = 954, TenChuyenNganh = "Các vị trí bác sĩ khác", MoTa = "Các chuyên khoa khác theo hệ thống y tế.", NgheNghiepId = 133 },

                // Nghề 134: Vật lý trị liệu và chăm sóc sức khỏe
                new ChuyenNganh { Id = 955, TenChuyenNganh = "Chuyên viên vật lý trị liệu", MoTa = "Điều trị và phục hồi chức năng cho bệnh nhân.", NgheNghiepId = 134 },
                new ChuyenNganh { Id = 956, TenChuyenNganh = "Chuyên gia dinh dưỡng/quản lý sức khoẻ", MoTa = "Xây dựng chế độ dinh dưỡng và tư vấn sức khỏe.", NgheNghiepId = 134 },
                new ChuyenNganh { Id = 957, TenChuyenNganh = "Kỹ thuật viên châm cứu bấm huyệt", MoTa = "Thực hiện châm cứu, bấm huyệt phục hồi sức khỏe.", NgheNghiepId = 134 },
                new ChuyenNganh { Id = 958, TenChuyenNganh = "Nhân viên massage", MoTa = "Massage trị liệu, thư giãn và hỗ trợ hồi phục.", NgheNghiepId = 134 },
                new ChuyenNganh { Id = 959, TenChuyenNganh = "Kỹ thuật viên phục hồi chức năng", MoTa = "Hỗ trợ tập luyện và phục hồi cơ – khớp.", NgheNghiepId = 134 },
                new ChuyenNganh { Id = 960, TenChuyenNganh = "Chăm sóc mẹ và bé", MoTa = "Chăm sóc sau sinh và chăm sóc trẻ sơ sinh.", NgheNghiepId = 134 },
                new ChuyenNganh { Id = 961, TenChuyenNganh = "Chuyên môn Vật lý trị liệu và chăm sóc sức khỏe khác", MoTa = "Các vị trí chăm sóc sức khỏe khác.", NgheNghiepId = 134 },

                // Nghề 135: Dược phẩm/Công nghệ sinh học
                new ChuyenNganh { Id = 962, TenChuyenNganh = "Dược sĩ/Bán thuốc", MoTa = "Tư vấn và cấp phát thuốc theo chỉ định.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 963, TenChuyenNganh = "Quản lý cửa hàng thuốc", MoTa = "Quản lý hoạt động hiệu thuốc và kiểm soát dược phẩm.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 964, TenChuyenNganh = "Nghiên cứu sinh học", MoTa = "Nghiên cứu tế bào, sinh học phân tử và vi sinh.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 965, TenChuyenNganh = "R&D y dược", MoTa = "Nghiên cứu phát triển thuốc và sản phẩm y dược.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 966, TenChuyenNganh = "Kỹ sư Bioinformatics", MoTa = "Ứng dụng tin sinh học vào nghiên cứu y sinh.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 967, TenChuyenNganh = "Sản xuất dược phẩm", MoTa = "Tham gia sản xuất và kiểm soát chất lượng dược phẩm.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 968, TenChuyenNganh = "Đăng ký dược phẩm", MoTa = "Đăng ký sản phẩm dược phẩm với cơ quan quản lý.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 969, TenChuyenNganh = "Quản lý dự án y dược", MoTa = "Điều phối dự án trong lĩnh vực y dược.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 970, TenChuyenNganh = "Kỹ thuật viên nuôi cấy tế bào", MoTa = "Thực hiện nuôi cấy tế bào phục vụ nghiên cứu.", NgheNghiepId = 135 },
                new ChuyenNganh { Id = 971, TenChuyenNganh = "Chuyên môn Dược phẩm/Công nghệ sinh học khác", MoTa = "Các vị trí khác thuộc dược phẩm và công nghệ sinh học.", NgheNghiepId = 135 },

                // Nghề 136: Thiết bị y tế
                new ChuyenNganh { Id = 972, TenChuyenNganh = "Quản lý thiết bị y tế", MoTa = "Quản lý, bảo trì và kiểm định thiết bị y tế.", NgheNghiepId = 136 },
                new ChuyenNganh { Id = 973, TenChuyenNganh = "Phát triển thuốc thử", MoTa = "Phát triển hóa chất, test kit và thuốc thử y tế.", NgheNghiepId = 136 },
                new ChuyenNganh { Id = 974, TenChuyenNganh = "Kỹ thuật viên phòng lab", MoTa = "Thực hiện thí nghiệm và phân tích mẫu trong phòng lab.", NgheNghiepId = 136 },
                new ChuyenNganh { Id = 975, TenChuyenNganh = "Quản lý phòng lab", MoTa = "Quản lý hoạt động, thiết bị và an toàn phòng lab.", NgheNghiepId = 136 },
                new ChuyenNganh { Id = 976, TenChuyenNganh = "Chuyên môn Thiết bị y tế khác", MoTa = "Các vị trí khác trong thiết bị y tế.", NgheNghiepId = 136 },

                // Nghề 137: Sales Dược/Y tế/Sức khoẻ/Làm đẹp
                new ChuyenNganh { Id = 977, TenChuyenNganh = "Kinh doanh thiết bị/vật tư y tế", MoTa = "Bán thiết bị y tế và vật tư tiêu hao cho bệnh viện/phòng khám.", NgheNghiepId = 137 },
                new ChuyenNganh { Id = 978, TenChuyenNganh = "Trình dược viên", MoTa = "Giới thiệu và phân phối thuốc đến bệnh viện và nhà thuốc.", NgheNghiepId = 137 },
                new ChuyenNganh { Id = 979, TenChuyenNganh = "Dược sĩ/Bán thuốc", MoTa = "Tư vấn thuốc và chăm sóc sức khỏe cho khách hàng.", NgheNghiepId = 137 },
                new ChuyenNganh { Id = 980, TenChuyenNganh = "Tư vấn thẩm mỹ/Spa", MoTa = "Tư vấn dịch vụ thẩm mỹ và chăm sóc sắc đẹp.", NgheNghiepId = 137 },
                new ChuyenNganh { Id = 981, TenChuyenNganh = "Tư vấn nha khoa", MoTa = "Tư vấn điều trị răng, dịch vụ nha khoa.", NgheNghiepId = 137 },
                new ChuyenNganh { Id = 982, TenChuyenNganh = "Kinh doanh dịch vụ y tế", MoTa = "Bán các dịch vụ liên quan đến y tế và sức khỏe.", NgheNghiepId = 137 },
                new ChuyenNganh { Id = 983, TenChuyenNganh = "Sales Dược/Y tế/Sức khoẻ/Làm đẹp khác", MoTa = "Các vị trí kinh doanh khác thuộc ngành y tế – dược – làm đẹp.", NgheNghiepId = 137 },

                // Nghề 138: Dược/Y tế/Sức khoẻ/Công nghệ sinh học khác
                new ChuyenNganh { Id = 984, TenChuyenNganh = "Thử nghiệm lâm sàng", MoTa = "Thực hiện thử nghiệm lâm sàng cho thuốc và sản phẩm y tế.", NgheNghiepId = 138 },
                new ChuyenNganh { Id = 985, TenChuyenNganh = "Chuyên môn Dược/Y tế/Sức khoẻ/Công nghệ sinh học khác", MoTa = "Các vị trí khác trong dược – y tế – sức khỏe – CNSH.", NgheNghiepId = 138 },

                // Nghề 139: Thiết kế Đồ hoạ/Giao diện/Trải nghiệm
                new ChuyenNganh { Id = 986, TenChuyenNganh = "Thiết kế đồ họa (Graphic Design)", MoTa = "Thiết kế ấn phẩm, poster, banner và nhận diện thương hiệu.", NgheNghiepId = 139 },
                new ChuyenNganh { Id = 987, TenChuyenNganh = "Illustration", MoTa = "Minh họa hình ảnh, vẽ digital và concept nghệ thuật.", NgheNghiepId = 139 },
                new ChuyenNganh { Id = 988, TenChuyenNganh = "UI/UX Design", MoTa = "Thiết kế giao diện và tối ưu trải nghiệm người dùng.", NgheNghiepId = 139 },
                new ChuyenNganh { Id = 989, TenChuyenNganh = "3D Modeler", MoTa = "Dựng mô hình 3D cho game, phim hoặc sản phẩm.", NgheNghiepId = 139 },
                new ChuyenNganh { Id = 990, TenChuyenNganh = "Chuyên môn Thiết kế Đồ hoạ/Giao diện/Trải nghiệm khác", MoTa = "Các vị trí khác trong thiết kế đồ hoạ, UI/UX.", NgheNghiepId = 139 },

                // Nghề 140: Thiết kế Nhà/Nội thất/Môi trường
                new ChuyenNganh { Id = 991, TenChuyenNganh = "Kiến trúc sư", MoTa = "Thiết kế kiến trúc công trình, nhà ở, nội ngoại thất.", NgheNghiepId = 140 },
                new ChuyenNganh { Id = 992, TenChuyenNganh = "Thiết kế nội thất", MoTa = "Thiết kế không gian, bố cục nội thất và phối màu.", NgheNghiepId = 140 },
                new ChuyenNganh { Id = 993, TenChuyenNganh = "Thiết kế triển lãm/trưng bày", MoTa = "Thiết kế không gian triển lãm, showroom và sự kiện.", NgheNghiepId = 140 },
                new ChuyenNganh { Id = 994, TenChuyenNganh = "Thiết kế cảnh quan", MoTa = "Thiết kế công viên, sân vườn và cảnh quan đô thị.", NgheNghiepId = 140 },
                new ChuyenNganh { Id = 995, TenChuyenNganh = "Thiết kế mỹ thuật sân khấu", MoTa = "Thiết kế đạo cụ, bối cảnh và không gian sân khấu.", NgheNghiepId = 140 },
                new ChuyenNganh { Id = 996, TenChuyenNganh = "Vẽ AutoCAD", MoTa = "Triển khai bản vẽ kỹ thuật bằng AutoCAD.", NgheNghiepId = 140 },
                new ChuyenNganh { Id = 997, TenChuyenNganh = "Chuyên môn Thiết kế Nhà/Nội thất/Môi trường khác", MoTa = "Các vị trí thiết kế khác thuộc kiến trúc – nội thất.", NgheNghiepId = 140 },

                // Nghề 141: Thiết kế Công nghiệp
                new ChuyenNganh { Id = 998, TenChuyenNganh = "Thiết kế sản phẩm nội thất", MoTa = "Thiết kế đồ nội thất, mô hình sản phẩm, concept 3D.", NgheNghiepId = 141 },
                new ChuyenNganh { Id = 999, TenChuyenNganh = "Chuyên môn Thiết kế Công nghiệp", MoTa = "Thiết kế sản phẩm và giải pháp công nghiệp.", NgheNghiepId = 141 },
                new ChuyenNganh { Id = 1000, TenChuyenNganh = "Thiết kế bao bì", MoTa = "Thiết kế bao bì sản phẩm, hộp giấy, nhãn mác.", NgheNghiepId = 141 },
                new ChuyenNganh { Id = 1001, TenChuyenNganh = "Thiết kế đồ trang sức", MoTa = "Thiết kế nữ trang, trang sức theo yêu cầu.", NgheNghiepId = 141 },
                new ChuyenNganh { Id = 1002, TenChuyenNganh = "Vẽ kỹ thuật", MoTa = "Triển khai bản vẽ kỹ thuật cho sản xuất.", NgheNghiepId = 141 },

                // Nghề 142: Thiết kế Thời trang
                new ChuyenNganh { Id = 1003, TenChuyenNganh = "Chuyên môn Thiết kế Thời trang", MoTa = "Thiết kế trang phục, concept thời trang và bộ sưu tập.", NgheNghiepId = 142 },
                new ChuyenNganh { Id = 1004, TenChuyenNganh = "Thiết kế rập", MoTa = "Thiết kế rập, mẫu kỹ thuật cho may mặc.", NgheNghiepId = 142 },
                new ChuyenNganh { Id = 1005, TenChuyenNganh = "Thiết kế vải", MoTa = "Thiết kế hoạ tiết và chất liệu cho vải.", NgheNghiepId = 142 },

                // Nghề 143: Nghệ thuật/Hoạt hình/Game
                new ChuyenNganh { Id = 1006, TenChuyenNganh = "Illustration", MoTa = "Minh hoạ nhân vật, bối cảnh hoặc đồ họa game.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1007, TenChuyenNganh = "Animation Design", MoTa = "Thiết kế hoạt hình 2D/3D cho phim và game.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1008, TenChuyenNganh = "Motion Graphic", MoTa = "Thiết kế chuyển động cho video, TVC và quảng cáo.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1009, TenChuyenNganh = "Hoạ sĩ truyện tranh", MoTa = "Vẽ manga, comic và truyện minh hoạ.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1010, TenChuyenNganh = "Chỉnh sửa ảnh (Retouch)", MoTa = "Retouch ảnh phục vụ truyền thông, thương mại.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1011, TenChuyenNganh = "Concept Artist", MoTa = "Vẽ concept nhân vật, môi trường cho game/phim.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1012, TenChuyenNganh = "Game Design", MoTa = "Thiết kế gameplay, hệ thống và tài liệu game.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1013, TenChuyenNganh = "Photographer/Video Editor", MoTa = "Chụp ảnh và dựng video nghệ thuật.", NgheNghiepId = 143 },
                new ChuyenNganh { Id = 1014, TenChuyenNganh = "Chuyên môn Nghệ thuật/Hoạt hình/Game khác", MoTa = "Các vị trí khác trong nghệ thuật – hoạt hình – game.", NgheNghiepId = 143 },

                // Nghề 144: Nghiên cứu người dùng
                new ChuyenNganh { Id = 1015, TenChuyenNganh = "Chuyên môn nghiên cứu người dùng", MoTa = "Thu thập, phân tích hành vi người dùng để tối ưu sản phẩm.", NgheNghiepId = 144 },

                // Nghề 145: Quản lý thiết kế
                new ChuyenNganh { Id = 1016, TenChuyenNganh = "Quản lý/Giám sát thiết kế", MoTa = "Quản lý đội ngũ thiết kế và tiến độ dự án.", NgheNghiepId = 145 },
                new ChuyenNganh { Id = 1017, TenChuyenNganh = "Giám đốc/Đạo diễn thiết kế", MoTa = "Định hướng thiết kế tổng thể của dự án/thương hiệu.", NgheNghiepId = 145 },
                new ChuyenNganh { Id = 1018, TenChuyenNganh = "Giám đốc thiết kế hình ảnh (Visual)", MoTa = "Phụ trách toàn bộ hình ảnh, concept và phong cách thị giác.", NgheNghiepId = 145 },
                new ChuyenNganh { Id = 1019, TenChuyenNganh = "Quản lý thiết kế khác", MoTa = "Các vị trí quản lý khác trong lĩnh vực thiết kế.", NgheNghiepId = 145 },

                // Nghề 146: Thiết kế khác
                new ChuyenNganh { Id = 1020, TenChuyenNganh = "Chuyên môn Thiết kế khác", MoTa = "Các vị trí thiết kế khác ngoài danh mục chính.", NgheNghiepId = 146 },

                // Nghề 147: Nhà hàng/Dịch vụ ăn uống
                new ChuyenNganh { Id = 1021, TenChuyenNganh = "Phục vụ", MoTa = "Phục vụ khách hàng tại nhà hàng, quán ăn, quán cà phê.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1022, TenChuyenNganh = "Thu ngân", MoTa = "Thanh toán, xử lý hóa đơn và hỗ trợ khách hàng.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1023, TenChuyenNganh = "Lễ tân/Đón tiếp", MoTa = "Đón tiếp khách, sắp xếp bàn và hỗ trợ thông tin.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1024, TenChuyenNganh = "Quản lý lễ tân", MoTa = "Quản lý đội lễ tân và vận hành khu vực đón khách.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1025, TenChuyenNganh = "Đầu bếp", MoTa = "Chế biến món ăn theo tiêu chuẩn của nhà hàng.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1026, TenChuyenNganh = "Bếp trưởng", MoTa = "Quản lý khu bếp và xây dựng menu.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1027, TenChuyenNganh = "Phụ bếp", MoTa = "Hỗ trợ đầu bếp sơ chế và chế biến món ăn.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1028, TenChuyenNganh = "Quản lý bếp", MoTa = "Quản lý nhân sự và quy trình vận hành khu bếp.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1029, TenChuyenNganh = "Thợ làm bánh", MoTa = "Làm bánh mì, bánh ngọt và các sản phẩm liên quan.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1030, TenChuyenNganh = "Pha chế (Barista)", MoTa = "Pha chế đồ uống và phục vụ tại quầy bar.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1031, TenChuyenNganh = "Chuyên gia thẩm rượu", MoTa = "Tư vấn và phục vụ rượu vang cho khách hàng.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1032, TenChuyenNganh = "Quản lý nhà hàng", MoTa = "Quản lý hoạt động và nhân sự của nhà hàng.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1033, TenChuyenNganh = "Shipper (Nhân viên giao hàng)", MoTa = "Giao đồ ăn, thức uống cho khách hàng.", NgheNghiepId = 147 },
                new ChuyenNganh { Id = 1034, TenChuyenNganh = "Chuyên môn Nhà hàng/Dịch vụ ăn uống khác", MoTa = "Các vị trí khác thuộc nhóm dịch vụ F&B.", NgheNghiepId = 147 },

                // Nghề 148: Khách sạn/Dịch vụ cư trú
                new ChuyenNganh { Id = 1035, TenChuyenNganh = "Lễ tân/Đón tiếp", MoTa = "Đón tiếp khách, làm thủ tục check-in/check-out.", NgheNghiepId = 148 },
                new ChuyenNganh { Id = 1036, TenChuyenNganh = "Bellman (nhân viên hành lý)", MoTa = "Hỗ trợ hành lý và hướng dẫn khách trong khách sạn.", NgheNghiepId = 148 },
                new ChuyenNganh { Id = 1037, TenChuyenNganh = "Buồng phòng", MoTa = "Dọn phòng và chuẩn bị phòng cho khách.", NgheNghiepId = 148 },
                new ChuyenNganh { Id = 1038, TenChuyenNganh = "Giặt là", MoTa = "Giặt ủi và bảo quản đồ vải khách sạn.", NgheNghiepId = 148 },
                new ChuyenNganh { Id = 1039, TenChuyenNganh = "Nhân viên đỗ xe (Valet Parking)", MoTa = "Đỗ xe và hỗ trợ khách tại khách sạn.", NgheNghiepId = 148 },
                new ChuyenNganh { Id = 1040, TenChuyenNganh = "Quản lý khách sạn", MoTa = "Quản lý toàn bộ hoạt động khách sạn.", NgheNghiepId = 148 },
                new ChuyenNganh { Id = 1041, TenChuyenNganh = "Quản lý homestay", MoTa = "Vận hành homestay, villa và khu lưu trú.", NgheNghiepId = 148 },
                new ChuyenNganh { Id = 1042, TenChuyenNganh = "Chuyên môn Khách sạn/Dịch vụ cư trú khác", MoTa = "Các vị trí khác trong khách sạn và khu lưu trú.", NgheNghiepId = 148 },

                // Nghề 149: Dịch vụ du lịch
                new ChuyenNganh { Id = 1043, TenChuyenNganh = "Hướng dẫn viên du lịch", MoTa = "Dẫn đoàn và thuyết minh điểm đến.", NgheNghiepId = 149 },
                new ChuyenNganh { Id = 1044, TenChuyenNganh = "Điều hành tour", MoTa = "Xây dựng và vận hành tour du lịch.", NgheNghiepId = 149 },
                new ChuyenNganh { Id = 1045, TenChuyenNganh = "Nhân viên visa", MoTa = "Xử lý hồ sơ visa du lịch.", NgheNghiepId = 149 },
                new ChuyenNganh { Id = 1046, TenChuyenNganh = "Sales Tour/Kinh doanh du lịch", MoTa = "Tư vấn và bán tour du lịch.", NgheNghiepId = 149 },
                new ChuyenNganh { Id = 1047, TenChuyenNganh = "Chuyên môn Dịch vụ du lịch khác", MoTa = "Các vị trí khác thuộc ngành du lịch.", NgheNghiepId = 149 },

                // Nghề 150: Sales Nhà hàng/Khách sạn/Du lịch
                new ChuyenNganh { Id = 1048, TenChuyenNganh = "Kinh doanh HORECA", MoTa = "Kinh doanh sản phẩm/dịch vụ cho nhà hàng – khách sạn.", NgheNghiepId = 150 },
                new ChuyenNganh { Id = 1049, TenChuyenNganh = "Sales Tour/Kinh doanh du lịch", MoTa = "Bán tour và gói du lịch.", NgheNghiepId = 150 },
                new ChuyenNganh { Id = 1050, TenChuyenNganh = "Kinh doanh khách đoàn (MICE)", MoTa = "Kinh doanh hội nghị – hội thảo – sự kiện.", NgheNghiepId = 150 },
                new ChuyenNganh { Id = 1051, TenChuyenNganh = "Bán vé máy bay (Ticketing/Booker)", MoTa = "Đặt vé máy bay và dịch vụ du lịch.", NgheNghiepId = 150 },
                new ChuyenNganh { Id = 1052, TenChuyenNganh = "Kinh doanh khách sạn", MoTa = "Kinh doanh phòng ở và dịch vụ lưu trú.", NgheNghiepId = 150 },
                new ChuyenNganh { Id = 1053, TenChuyenNganh = "Kinh doanh OTA", MoTa = "Quản lý bán phòng qua Booking, Agoda,...", NgheNghiepId = 150 },
                new ChuyenNganh { Id = 1054, TenChuyenNganh = "Sales Nhà hàng/Khách sạn/Du lịch khác", MoTa = "Các vị trí sale khác thuộc ngành F&B – du lịch.", NgheNghiepId = 150 },

                // Nghề 151: Nhà hàng/Khách sạn/Du lịch khác
                new ChuyenNganh { Id = 1055, TenChuyenNganh = "Chuyên môn Nhà hàng/Khách sạn/Du lịch khác", MoTa = "Các vị trí khác ngoài danh mục chính.", NgheNghiepId = 151 },

                // Nghề 152: Năng lượng/Địa chất
                new ChuyenNganh { Id = 1056, TenChuyenNganh = "Kỹ sư năng lượng", MoTa = "Vận hành và tối ưu hệ thống năng lượng.", NgheNghiepId = 152 },
                new ChuyenNganh { Id = 1057, TenChuyenNganh = "Kỹ sư điện mặt trời", MoTa = "Thiết kế hệ thống điện mặt trời.", NgheNghiepId = 152 },
                new ChuyenNganh { Id = 1058, TenChuyenNganh = "Kỹ sư thủy lợi", MoTa = "Thiết kế và quản lý công trình thủy lợi.", NgheNghiepId = 152 },
                new ChuyenNganh { Id = 1059, TenChuyenNganh = "Kỹ sư địa chất", MoTa = "Khảo sát địa chất và thăm dò khoáng sản.", NgheNghiepId = 152 },
                new ChuyenNganh { Id = 1060, TenChuyenNganh = "Chuyên môn Năng lượng/Địa chất khác", MoTa = "Các vị trí khác trong năng lượng – địa chất.", NgheNghiepId = 152 },

                // Nghề 153: An toàn lao động/Môi trường
                new ChuyenNganh { Id = 1061, TenChuyenNganh = "Kỹ sư an toàn lao động (HSE)", MoTa = "Đảm bảo an toàn lao động và hệ thống HSE trong doanh nghiệp.", NgheNghiepId = 153 },
                new ChuyenNganh { Id = 1062, TenChuyenNganh = "Kỹ sư môi trường", MoTa = "Quản lý chất thải, khí thải và giải pháp bảo vệ môi trường.", NgheNghiepId = 153 },
                new ChuyenNganh { Id = 1063, TenChuyenNganh = "Công nhân môi trường", MoTa = "Xử lý rác thải, vệ sinh công cộng và bảo vệ môi trường.", NgheNghiepId = 153 },
                new ChuyenNganh { Id = 1064, TenChuyenNganh = "Vận hành hệ thống xử lý nước thải", MoTa = "Vận hành và bảo trì hệ thống xử lý nước thải.", NgheNghiepId = 153 },

                // Nghề 154: Nông/Lâm/Ngư nghiệp
                new ChuyenNganh { Id = 1065, TenChuyenNganh = "Kỹ thuật viên nông nghiệp/trồng trọt", MoTa = "Chăm sóc cây trồng và quy trình nông nghiệp.", NgheNghiepId = 154 },
                new ChuyenNganh { Id = 1066, TenChuyenNganh = "Công nhân chăn nuôi", MoTa = "Chăm sóc vật nuôi trong trang trại.", NgheNghiepId = 154 },
                new ChuyenNganh { Id = 1067, TenChuyenNganh = "Kỹ sư lâm nghiệp", MoTa = "Quản lý rừng và tài nguyên lâm nghiệp.", NgheNghiepId = 154 },
                new ChuyenNganh { Id = 1068, TenChuyenNganh = "Kiểm lâm", MoTa = "Bảo vệ rừng và đa dạng sinh học.", NgheNghiepId = 154 },
                new ChuyenNganh { Id = 1069, TenChuyenNganh = "Chuyên môn Nông/Lâm/Ngư nghiệp khác", MoTa = "Các vị trí khác thuộc nhóm nông – lâm – ngư.", NgheNghiepId = 154 },

                // Nghề 155: Năng lượng/Môi trường/Nông nghiệp khác
                new ChuyenNganh { Id = 1070, TenChuyenNganh = "Chuyên môn Năng lượng/Môi trường/Nông nghiệp khác", MoTa = "Các công việc khác trong nhóm này.", NgheNghiepId = 155 },

                // Nghề 156: Vận tải
                new ChuyenNganh { Id = 1071, TenChuyenNganh = "Giám sát/Điều phối vận tải", MoTa = "Điều phối phương tiện và tài xế.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1072, TenChuyenNganh = "Phân loại/Sắp xếp hàng hoá", MoTa = "Phân loại hàng hóa tại kho/bưu cục.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1073, TenChuyenNganh = "Công nhân bốc xếp hàng hóa", MoTa = "Bốc xếp hàng hóa tại kho/cảng.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1074, TenChuyenNganh = "Tài xế lái xe nâng", MoTa = "Vận hành xe nâng trong kho.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1075, TenChuyenNganh = "Tài xế xe tải", MoTa = "Vận chuyển hàng bằng xe tải.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1076, TenChuyenNganh = "Tài xế container", MoTa = "Lái container vận chuyển hàng.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1077, TenChuyenNganh = "Tài xế lái xe đường dài", MoTa = "Lái xe đường dài xuyên tỉnh.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1078, TenChuyenNganh = "Tài xế lái xe chuyên dụng", MoTa = "Lái xe chuyên dụng (xe cẩu, xe bồn,...).", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1079, TenChuyenNganh = "Tài xế xe khách", MoTa = "Lái xe khách tuyến cố định/hợp đồng.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1080, TenChuyenNganh = "Phụ xe", MoTa = "Hỗ trợ tài xế giao nhận hàng.", NgheNghiepId = 156 },
                new ChuyenNganh { Id = 1081, TenChuyenNganh = "Dịch vụ vận tải khác", MoTa = "Các công việc vận tải khác.", NgheNghiepId = 156 },

                // Nghề 157: Đưa đón
                new ChuyenNganh { Id = 1082, TenChuyenNganh = "Tài xế công nghệ", MoTa = "Lái Grab/Be/Gojek.", NgheNghiepId = 157 },
                new ChuyenNganh { Id = 1083, TenChuyenNganh = "Tài xế taxi", MoTa = "Lái taxi đưa đón khách.", NgheNghiepId = 157 },
                new ChuyenNganh { Id = 1084, TenChuyenNganh = "Tài xế lái xe thuê", MoTa = "Lái xe theo yêu cầu cá nhân/doanh nghiệp.", NgheNghiepId = 157 },
                new ChuyenNganh { Id = 1085, TenChuyenNganh = "Tài xế lái xe văn phòng", MoTa = "Lái xe nội bộ cho công ty.", NgheNghiepId = 157 },
                new ChuyenNganh { Id = 1086, TenChuyenNganh = "Tài xế B2", MoTa = "Lái các xe theo bằng B2.", NgheNghiepId = 157 },
                new ChuyenNganh { Id = 1087, TenChuyenNganh = "Lái xe cho sếp", MoTa = "Lái xe riêng cho lãnh đạo.", NgheNghiepId = 157 },
                new ChuyenNganh { Id = 1088, TenChuyenNganh = "Tài xế xe khách", MoTa = "Đưa đón khách theo tour/hợp đồng.", NgheNghiepId = 157 },
                new ChuyenNganh { Id = 1089, TenChuyenNganh = "Dịch vụ đưa đón khác", MoTa = "Các vị trí đưa đón khác.", NgheNghiepId = 157 },

                // Nghề 158: Biên phiên dịch
                new ChuyenNganh { Id = 1090, TenChuyenNganh = "Biên phiên dịch tiếng Anh", MoTa = "Biên dịch và phiên dịch tiếng Anh trong doanh nghiệp hoặc tổ chức.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1091, TenChuyenNganh = "Biên phiên dịch tiếng Trung", MoTa = "Biên dịch và phiên dịch tiếng Trung cho tài liệu hoặc hội thoại.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1092, TenChuyenNganh = "Biên phiên dịch tiếng Nhật", MoTa = "Thực hiện dịch thuật và phiên dịch tiếng Nhật trong nhiều lĩnh vực.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1093, TenChuyenNganh = "Biên phiên dịch tiếng Hàn", MoTa = "Dịch tài liệu, hợp đồng và phiên dịch giao tiếp tiếng Hàn.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1094, TenChuyenNganh = "Biên phiên dịch tiếng Nga", MoTa = "Dịch thuật và phiên dịch tiếng Nga cho doanh nghiệp và giáo dục.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1095, TenChuyenNganh = "Biên phiên dịch tiếng Tây Ban Nha", MoTa = "Biên dịch và phiên dịch tiếng Tây Ban Nha cho nhiều lĩnh vực.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1096, TenChuyenNganh = "Biên phiên dịch tiếng Đức", MoTa = "Dịch thuật và phiên dịch tiếng Đức trong doanh nghiệp.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1097, TenChuyenNganh = "Biên phiên dịch tiếng Pháp", MoTa = "Biên phiên dịch tài liệu và hội thoại tiếng Pháp.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1098, TenChuyenNganh = "Biên phiên dịch ngôn ngữ khác", MoTa = "Dịch thuật các ngôn ngữ khác ngoài danh sách chính.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1099, TenChuyenNganh = "Biên phiên dịch đa ngôn ngữ", MoTa = "Thực hiện dịch nhiều ngôn ngữ, hỗ trợ dự án quốc tế.", NgheNghiepId = 158 },
                new ChuyenNganh { Id = 1100, TenChuyenNganh = "Tư vấn dịch thuật", MoTa = "Tư vấn giải pháp dịch thuật và tiêu chuẩn ngôn ngữ cho doanh nghiệp.", NgheNghiepId = 158 },

                // Nghề 159: Dịch vụ pháp lý (Agency/Firm)
                new ChuyenNganh { Id = 1101, TenChuyenNganh = "Luật sư", MoTa = "Tư vấn pháp lý, đại diện tố tụng và giải quyết tranh chấp.", NgheNghiepId = 159 },
                new ChuyenNganh { Id = 1102, TenChuyenNganh = "Chuyên viên pháp lý", MoTa = "Nghiên cứu hồ sơ, soạn thảo hợp đồng và hỗ trợ pháp lý.", NgheNghiepId = 159 },
                new ChuyenNganh { Id = 1103, TenChuyenNganh = "Thư ký công chứng viên", MoTa = "Hỗ trợ công chứng viên xử lý hồ sơ và giấy tờ pháp lý.", NgheNghiepId = 159 },
                new ChuyenNganh { Id = 1104, TenChuyenNganh = "Thư ký văn phòng luật sư/Thư ký pháp lý", MoTa = "Hỗ trợ luật sư quản lý hồ sơ, tài liệu và công việc pháp lý.", NgheNghiepId = 159 },
                new ChuyenNganh { Id = 1105, TenChuyenNganh = "Chuyên môn Pháp lý khác", MoTa = "Các vị trí pháp lý khác tại Agency/Firm.", NgheNghiepId = 159 },

                // Nghề 160: Dịch vụ pháp chế (In-house)
                new ChuyenNganh { Id = 1106, TenChuyenNganh = "Pháp chế", MoTa = "Tư vấn, rà soát pháp lý và hỗ trợ pháp luật nội bộ doanh nghiệp.", NgheNghiepId = 160 },
                new ChuyenNganh { Id = 1107, TenChuyenNganh = "Giám đốc pháp chế", MoTa = "Quản lý bộ phận pháp chế và chiến lược tuân thủ.", NgheNghiepId = 160 },
                new ChuyenNganh { Id = 1108, TenChuyenNganh = "Chuyên môn Pháp chế khác", MoTa = "Các công việc pháp chế nội bộ khác.", NgheNghiepId = 160 },

                // Nghề 161: Hàng hải
                new ChuyenNganh { Id = 1109, TenChuyenNganh = "Chuyên môn Hàng hải", MoTa = "Các vị trí liên quan vận tải biển, kỹ thuật và khai thác tàu.", NgheNghiepId = 161 },

                // Nghề 162: NGO/Phi chính phủ/Phi lợi nhuận
                new ChuyenNganh { Id = 1110, TenChuyenNganh = "Chuyên môn NGO/Phi chính phủ/Phi lợi nhuận", MoTa = "Các vị trí hoạt động xã hội, cộng đồng, dự án phi lợi nhuận.", NgheNghiepId = 162 },

                // Nghề 163: Nghề khác
                new ChuyenNganh { Id = 1111, TenChuyenNganh = "Chuyên môn khác", MoTa = "Các nghề không thuộc nhóm ngành đã liệt kê.", NgheNghiepId = 163 }


            );
        }
    }
}