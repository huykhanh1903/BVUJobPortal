using System;
using System.Collections.Generic;

namespace BVUJobPortal.Models
{
    public class CongViec
    {
        public int Id { get; set; }

        public string TieuDe { get; set; } = string.Empty;
        public int SoLuongTuyen { get; set; }

        public int? LoaiCongViecId { get; set; }
        public LoaiCongViec? LoaiCongViec { get; set; }

        public int? CapBacId { get; set; }
        public CapBac? CapBac { get; set; }

        public int? MucKinhNghiemId { get; set; }
        public MucKinhNghiem? MucKinhNghiem { get; set; }

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

        public ICollection<CongViecChuyenNganh> CongViecChuyenNganhs { get; set; } = new List<CongViecChuyenNganh>();

        public ICollection<CongViecKhuVuc> KhuVucLamViecs { get; set; }  = new List<CongViecKhuVuc>();

        public DateTime? HanNopHoSo { get; set; }
        public string? NguoiNhanCV_HoTen { get; set; }
        public string? NguoiNhanCV_SDT { get; set; }
        public string? NguoiNhanCV_Email { get; set; }

        public int NguoiDungId { get; set; }
        public NguoiDung? NguoiDung { get; set; }

        public int? CongTyId { get; set; }
        public CongTy? CongTy { get; set; }

        public bool DaDuyet { get; set; } = false;
        public DateTime? NgayDuyet { get; set; }
        public int? NguoiDuyetId { get; set; }
        public NguoiDung? NguoiDuyet { get; set; }

        public DateTime NgayDang { get; set; } = DateTime.UtcNow;
        public DateTime NgayCapNhat { get; set; } = DateTime.UtcNow;
    }
}