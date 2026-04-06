using System.Collections.Generic;

namespace BVUJobPortal.DTOs.CongViec
{
    public class CongViecChiTietDto : CongViecDto
    {
        public string? MoTaCongViec { get; set; }
        public string? QuyenLoiUngVien { get; set; }

        public string? LyDo1 { get; set; }
        public string? LyDo2 { get; set; }
        public string? LyDo3 { get; set; }

        public string? NguoiNhanCV_HoTen { get; set; }
        public string? NguoiNhanCV_SDT { get; set; }
        public string? NguoiNhanCV_Email { get; set; }

        public List<KhuVucItemDto> KhuVucChiTiet { get; set; }
        public List<KhuVucItemDto> KhuVucs { get; set; } = new List<KhuVucItemDto>();

        public List<string> LinhVucs { get; set; }
        public List<string> NganhNghieps { get; set; }
        public List<string> ChuyenNganhs { get; set; }

        public string? GioiThieuCongTy { get; set; }
        public string? Website { get; set; }
        public string? EmailLienHe { get; set; }
        public string? SoDienThoaiLienHe { get; set; }
        public string? NguoiLienHe { get; set; }
        public string? ChucVuNguoiLienHe { get; set; }
    }
}