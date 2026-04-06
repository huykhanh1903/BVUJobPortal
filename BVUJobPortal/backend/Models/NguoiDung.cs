using System.ComponentModel.DataAnnotations.Schema;

namespace BVUJobPortal.Models
{
    public class NguoiDung
    {
        public int Id { get; set; }
        public string? Ma { get; set; } = string.Empty;

        //Thong tin ca nhan
        public string HoTen { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MatKhauHash { get; set; } = string.Empty;
        public bool DangNhapBangGoogle { get; set; } = false;

        public string VaiTro { get; set; } = "SinhVien"; 
        public string? LopHoc { get; set; }
        public string? KhoaHoc { get; set; }
        public int? CongTyId { get; set; }
        public CongTy? CongTy { get; set; }

        public bool IsNhaTuyenDung { get; set; } = false; 

        public string? VaiTroCongTy { get; set; } 
        public bool DaDuocCongTyXacThuc { get; set; } = false;
        public DateTime? NgayXacThuc { get; set; }

        public int? NguoiXacThucId { get; set; }
        [ForeignKey(nameof(NguoiXacThucId))]
        public NguoiDung? NguoiXacThuc { get; set; }
        public string? LyDoXinXacThuc { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.UtcNow;
        public bool BiKhoa { get; set; } = false;
        public string? LyDoKhoa { get; set; }
        public string? AvatarUrl { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
        public string? EmailVerificationToken { get; set; }
        public DateTime? EmailVerificationExpiry { get; set; }
        public string? ResetPasswordOtp { get; set; }
        public DateTime? ResetPasswordExpiry { get; set; }
        public ICollection<KhieuNai> KhieuNais { get; set; } = new List<KhieuNai>();
        public ICollection<CV> CVs { get; set; } = new List<CV>();
    }
}