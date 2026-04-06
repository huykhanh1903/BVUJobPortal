using System;
using System.Collections.Generic;

namespace BVUJobPortal.DTOs.CongViec
{
    public class CapNhatCongViecDto
    {
        public string? TieuDe { get; set; }
        public List<int>? ChuyenNganhIds { get; set; }

        public int? SoLuongTuyen { get; set; }
        public int? LoaiCongViecId { get; set; }
        public int? CapBacId { get; set; }
        public int? KinhNghiemId { get; set; }
        public string? GioiTinh { get; set; }

        public string? LoaiTienTe { get; set; }
        public string? KieuLuong { get; set; }
        public decimal? LuongTu { get; set; }
        public decimal? LuongDen { get; set; }

        public string? LyDo1 { get; set; }
        public string? LyDo2 { get; set; }
        public string? LyDo3 { get; set; }

        public string? MoTaCongViec { get; set; }
        public string? QuyenLoiUngVien { get; set; }

        public List<KhuVucItemDto>? KhuVucs { get; set; }
        public DateTime? HanNopHoSo { get; set; }
        public string? NguoiNhanCV_HoTen { get; set; }
        public string? NguoiNhanCV_SDT { get; set; }
        public string? NguoiNhanCV_Email { get; set; }
    }
}