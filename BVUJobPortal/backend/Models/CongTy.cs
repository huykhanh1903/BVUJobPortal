using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BVUJobPortal.Models
{
    public class CongTy
    {
        public int Id { get; set; }
        public string Ma { get; set; } = string.Empty;
        public string TenCongTy { get; set; } = string.Empty;

        public string? GioiThieu { get; set; }
        public string? LogoUrl { get; set; }
        public string? DiaChiLamViec { get; set; }
        public int? TinhThanhId { get; set; }
        public TinhThanh? TinhThanh { get; set; }
        public string? Website { get; set; }
        public int? NamThanhLap { get; set; }
        public string? QuyMoNhanSu { get; set; }
        public string? EmailLienHe { get; set; }
        public string? SoDienThoaiLienHe { get; set; }
        public string? NguoiLienHe { get; set; }
        public string? ChucVuNguoiLienHe { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public bool DaDuocAdminXacMinh { get; set; } = false;
        public DateTime? NgayXacMinh { get; set; }

        public int? AdminXacMinhId { get; set; } 
        [ForeignKey(nameof(AdminXacMinhId))]
        public NguoiDung? DaXacMinhBoiAdmin { get; set; }
        public ICollection<NguoiDung>? NhaTuyenDungs { get; set; }
        public ICollection<CongViec>? CongViecs { get; set; }
    }
}
