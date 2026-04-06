using System;
using System.Collections.Generic;

namespace BVUJobPortal.DTOs.CongViec
{
    public class CongViecDto
    {
        public int Id { get; set; }
        public string TieuDe { get; set; } = string.Empty;

        public List<object> ChuyenNganhs { get; set; } = new();
        public List<object> LinhVucs { get; set; } = new();
        public List<object> NganhNghieps { get; set; } = new();

        public int SoLuongTuyen { get; set; }

        public int? LoaiCongViecId { get; set; }
        public string? TenLoaiCongViec { get; set; }

        public int? CapBacId { get; set; }
        public string? TenCapBac { get; set; }

        public int? MucKinhNghiemId { get; set; }
        public string? TenKinhNghiem { get; set; }

        public string? GioiTinh { get; set; }

        public string? LoaiTienTe { get; set; }
        public string? KieuLuong { get; set; }
        public decimal? LuongTu { get; set; }
        public decimal? LuongDen { get; set; }

        public DateTime? HanNopHoSo { get; set; }
        public DateTime NgayDang { get; set; }
        public bool DaDuyet { get; set; }

        public string? TenCongTy { get; set; }
        public string? LogoUrl { get; set; }
        public string? TenTinhThanh { get; set; }

        public List<string> KhuVucLamViec { get; set; }
    }
}