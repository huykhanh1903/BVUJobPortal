using AutoMapper;
using BVUJobPortal.DTOs;
using BVUJobPortal.DTOs.Admin;
using BVUJobPortal.DTOs.CongTy;
using BVUJobPortal.DTOs.CongViec;
using BVUJobPortal.DTOs.CV;
using BVUJobPortal.DTOs.TaiKhoan;
using BVUJobPortal.DTOs.ThongBao;
using BVUJobPortal.DTOs.UngTuyen;
using BVUJobPortal.Models;

namespace BVUJobPortal.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NguoiDung, TaiKhoanDto>()
                .ForMember(dest => dest.SoDienThoaiLienHe,
                    opt => opt.MapFrom(src =>
                        src.VaiTro == "DoanhNghiep" && src.CongTy != null
                            ? src.CongTy.SoDienThoaiLienHe
                            : src.SDT))
                .ForMember(dest => dest.AvatarUrl, opt => opt.MapFrom(src => src.AvatarUrl))
                .ForMember(dest => dest.BiKhoa, opt => opt.MapFrom(src => src.BiKhoa))

                .ForMember(dest => dest.DaDuocCongTyXacThuc,
                    opt => opt.MapFrom(src => src.DaDuocCongTyXacThuc))

                .ForMember(dest => dest.DaGuiYeuCau,
                    opt => opt.MapFrom(src =>
                        !src.DaDuocCongTyXacThuc &&
                        src.LyDoXinXacThuc != null));

            CreateMap<DangKyDto, NguoiDung>()
                .ForMember(dest => dest.MatKhauHash,
                           opt => opt.MapFrom(src => BCrypt.Net.BCrypt.HashPassword(src.MatKhau)))
                .ForMember(dest => dest.AvatarUrl, opt => opt.Ignore());

            CreateMap<CapNhatSinhVienDto, NguoiDung>()
                .ForMember(dest => dest.MatKhauHash, opt => opt.Ignore())
                .ForMember(dest => dest.SDT, opt => opt.MapFrom(src => src.SDT))
                .ForMember(dest => dest.AvatarUrl,
                           opt => opt.Condition(src => !string.IsNullOrEmpty(src.AvatarUrl)));

            CreateMap<NguoiDung, AdminCapNhatNguoiDungDto>().ReverseMap();


            CreateMap<CongTy, CongTyDto>()
                .ForMember(d => d.TenTinhThanh,
                    o => o.MapFrom(s => s.TinhThanh != null ? s.TinhThanh.TenTinh : null))
                .ForMember(d => d.TinhThanhId, o => o.Ignore());

            CreateMap<CongTyDto, CongTy>()
                .ForMember(d => d.TinhThanh, o => o.Ignore())
                .ForMember(d => d.NhaTuyenDungs, o => o.Ignore())
                .ForMember(d => d.CongViecs, o => o.Ignore());

            CreateMap<CongTy, AdminCongTyDto>()
                .ForMember(d => d.TenTinhThanh,
                    o => o.MapFrom(s => s.TinhThanh != null ? s.TinhThanh.TenTinh : null));

            CreateMap<AdminCongTyDto, CongTy>()
                .ForMember(d => d.TinhThanh, o => o.Ignore())
                .ForMember(d => d.NhaTuyenDungs, o => o.Ignore())
                .ForMember(d => d.CongViecs, o => o.Ignore());


            // ================= CÔNG VIỆC =================
            CreateMap<CongViec, CongViecDto>()
                // Loại, cấp bậc, kinh nghiệm
                .ForMember(dest => dest.TenLoaiCongViec,
                    opt => opt.MapFrom(src => src.LoaiCongViec != null ? src.LoaiCongViec.Ten : null))
                .ForMember(dest => dest.TenCapBac,
                    opt => opt.MapFrom(src => src.CapBac != null ? src.CapBac.Ten : null))
                .ForMember(dest => dest.TenKinhNghiem,
                    opt => opt.MapFrom(src => src.MucKinhNghiem != null ? src.MucKinhNghiem.Ten : null))

                // Chuyên ngành (Danh sách string)
                .ForMember(dest => dest.ChuyenNganhs,
                    opt => opt.MapFrom(src =>
                        src.CongViecChuyenNganhs.Select(x => x.ChuyenNganh.TenChuyenNganh)))

                // Khu vực (Danh sách string)
                .ForMember(dest => dest.KhuVucLamViec,
                    opt => opt.MapFrom(src =>
                        src.KhuVucLamViecs.Select(x => x.TinhThanh.TenTinh)))

                // Công ty
                .ForMember(dest => dest.TenCongTy,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.TenCongTy : null))
                .ForMember(dest => dest.LogoUrl,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.LogoUrl : null));


            CreateMap<CongViec, CongViecChiTietDto>()
                .IncludeBase<CongViec, CongViecDto>()

                // mapping khu vực chi tiết
                .ForMember(dest => dest.KhuVucs,
                    opt => opt.MapFrom(src =>
                        src.KhuVucLamViecs.Select(k => new KhuVucItemDto
                        {
                            TinhThanhId = k.TinhThanhId,
                            DiaChiCuThe = k.DiaChiCuThe
                        })))

                // Công ty chi tiết
                .ForMember(dest => dest.GioiThieuCongTy,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.GioiThieu : null))
                .ForMember(dest => dest.Website,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.Website : null))
                .ForMember(dest => dest.EmailLienHe,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.EmailLienHe : null))
                .ForMember(dest => dest.SoDienThoaiLienHe,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.SoDienThoaiLienHe : null))
                .ForMember(dest => dest.NguoiLienHe,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.NguoiLienHe : null))
                .ForMember(dest => dest.ChucVuNguoiLienHe,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.ChucVuNguoiLienHe : null));

            // Map Post
            CreateMap<DangTuyenDto, CongViec>()
                .ForMember(dest => dest.MucKinhNghiemId, opt => opt.MapFrom(src => src.MucKinhNghiemId));

            CreateMap<CapNhatCongViecDto, CongViec>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));


            CreateMap<AdminCapNhatCongViecDto, CongViec>().ReverseMap();


            // ================= LĨNH VỰC =================
            CreateMap<LinhVuc, AdminLinhVucDto>().ReverseMap();


            // ================= NHÀ TUYỂN DỤNG =================
            CreateMap<NguoiDung, AdminNhaTuyenDungDto>()
                .ForMember(dest => dest.TenCongTy,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.TenCongTy : string.Empty))
                .ForMember(dest => dest.Website,
                    opt => opt.MapFrom(src => src.CongTy != null ? src.CongTy.Website : string.Empty))
                .ForMember(dest => dest.MatKhau, opt => opt.Ignore());

            CreateMap<AdminNhaTuyenDungDto, NguoiDung>()
                .ForMember(dest => dest.VaiTro, opt => opt.MapFrom(_ => "NhaTuyenDung"))
                .ForMember(dest => dest.MatKhauHash, opt => opt.Ignore())
                .ForMember(dest => dest.CongTy, opt => opt.Ignore());

            CreateMap<AdminNhaTuyenDungDto, CongTy>()
                .ForMember(dest => dest.TenCongTy, opt => opt.MapFrom(src => src.TenCongTy))
                .ForMember(dest => dest.Website, opt => opt.MapFrom(src => src.Website));


            // ================= CV =================
 


            // ================= THÔNG BÁO =================

            CreateMap<AdminThongBaoDto, ThongBao>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.NguoiDung, opt => opt.Ignore());

            CreateMap<ThongBao, ThongBaoDto>()
                .ForMember(dest => dest.NguoiDungId, opt => opt.MapFrom(src => src.NguoiDungId))
                .ForMember(dest => dest.TenNguoiGui,
                    opt => opt.MapFrom(src => src.NguoiDung != null ? src.NguoiDung.HoTen : string.Empty));

            CreateMap<ThongBaoDto, ThongBao>()
                .ForMember(dest => dest.NguoiDung, opt => opt.Ignore());


            // ================= BÁO CÁO =================
            CreateMap<BaoCaoNoiDung, BaoCaoNoiDungDto>()
                .ForMember(dest => dest.NguoiBaoCao,
                    opt => opt.MapFrom(src => src.NguoiDung != null ? src.NguoiDung.HoTen : string.Empty))
                .ForMember(dest => dest.CongViec,
                    opt => opt.MapFrom(src => src.CongViec != null ? src.CongViec.TieuDe : string.Empty))
                .ForMember(dest => dest.CV,
                    opt => opt.MapFrom(src => src.CV != null ? src.CV.Id.ToString() : string.Empty));

            CreateMap<BaoCaoNoiDungDto, BaoCaoNoiDung>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.NguoiDung, opt => opt.Ignore())
                .ForMember(dest => dest.CongViec, opt => opt.Ignore())
                .ForMember(dest => dest.CV, opt => opt.Ignore());


            // ================= ỨNG TUYỂN =================
            CreateMap<DonUngTuyen, DonUngTuyenDto>()
                .ForMember(dest => dest.TieuDeCongViec,
                    opt => opt.MapFrom(src => src.CongViec != null ? src.CongViec.TieuDe : string.Empty))
                .ForMember(dest => dest.TenCongTy,
                    opt => opt.MapFrom(src => src.CongViec != null && src.CongViec.CongTy != null
                        ? src.CongViec.CongTy.TenCongTy : string.Empty));


            // ================= CV TEMPLATE (ADMIN) =================
            CreateMap<CVTemplate, CVTemplateDetailDto>().ReverseMap();
            CreateMap<CVTemplate, CVTemplateListItemDto>();
            CreateMap<CVTemplateCreateDto, CVTemplate>();
            CreateMap<CVTemplateUpdateDto, CVTemplate>();
        }
    }
}
