namespace BVUJobPortal.DTOs.CV
{
    public class CVDetailDto
    {
        public int Id { get; set; }
        public int NguoiDungId { get; set; }

        public string MucTieuNgheNghiep { get; set; } = string.Empty;
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int? TemplateId { get; set; }

        public List<HocVanDto> HocVans { get; set; } = new();
        public List<KinhNghiemDto> KinhNghiems { get; set; } = new();
        public List<ChungChiDto> ChungChis { get; set; } = new();
        public List<KyNangDto> KyNangs { get; set; } = new();
        public List<DuAnDto> DuAns { get; set; } = new();
    }
}
