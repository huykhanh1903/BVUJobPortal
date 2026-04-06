using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814
namespace BVUJobPortal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CapBacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapBacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CVTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MauChuDao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Font = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviewUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayoutJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StyleJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeThongCauHinhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeThongCauHinhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinhVucs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLinhVuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhVucs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiCongViecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiCongViecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MucKinhNghiems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MucKinhNghiems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaTinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TuKhoaTimKiems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLan = table.Column<int>(type: "int", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinhVucId = table.Column<int>(type: "int", nullable: true),
                    NganhNgheId = table.Column<int>(type: "int", nullable: true),
                    ChuyenNganhId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuKhoaTimKiems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NgheNghieps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNghe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinhVucId = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgheNghieps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NgheNghieps_LinhVucs_LinhVucId",
                        column: x => x.LinhVucId,
                        principalTable: "LinhVucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenNganhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuyenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgheNghiepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuyenNganhs_NgheNghieps_NgheNghiepId",
                        column: x => x.NgheNghiepId,
                        principalTable: "NgheNghieps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaoCaoNoiDungs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungId = table.Column<int>(type: "int", nullable: false),
                    CongViecId = table.Column<int>(type: "int", nullable: true),
                    CVDaNopId = table.Column<int>(type: "int", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBaoCao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoCaoNoiDungs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChungChis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChungChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoiCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChungChis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChungChiSinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienProfileId = table.Column<int>(type: "int", nullable: false),
                    TenChungChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapBoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KhongHetHan = table.Column<bool>(type: "bit", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChungChiSinhViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CongTys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiThieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiLamViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhThanhId = table.Column<int>(type: "int", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailLienHe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoaiLienHe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiLienHe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucVuNguoiLienHe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaDuocAdminXacMinh = table.Column<bool>(type: "bit", nullable: false),
                    NgayXacMinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminXacMinhId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongTys_TinhThanhs_TinhThanhId",
                        column: x => x.TinhThanhId,
                        principalTable: "TinhThanhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhauHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DangNhapBangGoogle = table.Column<bool>(type: "bit", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LopHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongTyId = table.Column<int>(type: "int", nullable: true),
                    IsNhaTuyenDung = table.Column<bool>(type: "bit", nullable: false),
                    VaiTroCongTy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaDuocCongTyXacThuc = table.Column<bool>(type: "bit", nullable: false),
                    NgayXacThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXacThucId = table.Column<int>(type: "int", nullable: true),
                    LyDoXinXacThuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BiKhoa = table.Column<bool>(type: "bit", nullable: false),
                    LyDoKhoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    EmailVerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVerificationExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResetPasswordOtp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetPasswordExpiry = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_CongTys_CongTyId",
                        column: x => x.CongTyId,
                        principalTable: "CongTys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_NguoiDungs_NguoiXacThucId",
                        column: x => x.NguoiXacThucId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CongViecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongTuyen = table.Column<int>(type: "int", nullable: false),
                    LoaiCongViecId = table.Column<int>(type: "int", nullable: true),
                    CapBacId = table.Column<int>(type: "int", nullable: true),
                    MucKinhNghiemId = table.Column<int>(type: "int", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiTienTe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KieuLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuongTu = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LuongDen = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LyDo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LyDo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LyDo3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTaCongViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyenLoiUngVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HanNopHoSo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiNhanCV_HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiNhanCV_SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiNhanCV_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDungId = table.Column<int>(type: "int", nullable: false),
                    CongTyId = table.Column<int>(type: "int", nullable: true),
                    DaDuyet = table.Column<bool>(type: "bit", nullable: false),
                    NgayDuyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiDuyetId = table.Column<int>(type: "int", nullable: true),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChuyenNganhId = table.Column<int>(type: "int", nullable: true),
                    LinhVucId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongViecs_CapBacs_CapBacId",
                        column: x => x.CapBacId,
                        principalTable: "CapBacs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CongViecs_ChuyenNganhs_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CongViecs_CongTys_CongTyId",
                        column: x => x.CongTyId,
                        principalTable: "CongTys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongViecs_LinhVucs_LinhVucId",
                        column: x => x.LinhVucId,
                        principalTable: "LinhVucs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CongViecs_LoaiCongViecs_LoaiCongViecId",
                        column: x => x.LoaiCongViecId,
                        principalTable: "LoaiCongViecs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CongViecs_MucKinhNghiems_MucKinhNghiemId",
                        column: x => x.MucKinhNghiemId,
                        principalTable: "MucKinhNghiems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CongViecs_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongViecs_NguoiDungs_NguoiDuyetId",
                        column: x => x.NguoiDuyetId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungId = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTriUngTuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieuNgheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    ThongTinThem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVs_CVTemplates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "CVTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CVs_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhieuNais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungId = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayGui = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanHoiAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhieuNais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhieuNais_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinhVienProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungId = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TinhThanhId = table.Column<int>(type: "int", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieuNgheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapBacMongMuon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuongThoaThuan = table.Column<bool>(type: "bit", nullable: false),
                    MucLuongTu = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MucLuongDen = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DonViTienTe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhThucLamViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NganhNgheMongMuon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiLamViecMongMuon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhucLoiMongMuon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanhTichNoiBat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVienProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhVienProfiles_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongBaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungId = table.Column<int>(type: "int", nullable: false),
                    TieuDe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaDoc = table.Column<bool>(type: "bit", nullable: false),
                    NgayGui = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThongBaos_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongViecChuyenNganhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongViecId = table.Column<int>(type: "int", nullable: false),
                    ChuyenNganhId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViecChuyenNganhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongViecChuyenNganhs_ChuyenNganhs_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongViecChuyenNganhs_CongViecs_CongViecId",
                        column: x => x.CongViecId,
                        principalTable: "CongViecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongViecKhuVucs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongViecId = table.Column<int>(type: "int", nullable: false),
                    TinhThanhId = table.Column<int>(type: "int", nullable: false),
                    DiaChiCuThe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViecKhuVucs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongViecKhuVucs_CongViecs_CongViecId",
                        column: x => x.CongViecId,
                        principalTable: "CongViecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongViecKhuVucs_TinhThanhs_TinhThanhId",
                        column: x => x.TinhThanhId,
                        principalTable: "TinhThanhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonUngTuyens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongViecId = table.Column<int>(type: "int", nullable: false),
                    NguoiDungId = table.Column<int>(type: "int", nullable: false),
                    ThuGioiThieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayUngTuyen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CvId = table.Column<int>(type: "int", nullable: true),
                    CvFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileSnapshotJson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonUngTuyens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonUngTuyens_CVs_CvId",
                        column: x => x.CvId,
                        principalTable: "CVs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DonUngTuyens_CongViecs_CongViecId",
                        column: x => x.CongViecId,
                        principalTable: "CongViecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonUngTuyens_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DuAns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongNghe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuAns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuAns_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiaiThuongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvId = table.Column<int>(type: "int", nullable: false),
                    TenGiaiThuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaiThuongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaiThuongs_CVs_CvId",
                        column: x => x.CvId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoatDongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvId = table.Column<int>(type: "int", nullable: false),
                    TenHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoatDongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoatDongs_CVs_CvId",
                        column: x => x.CvId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocVans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Truong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NganhHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThanhTich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HocVans_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KinhNghiems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianLamViec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTaCongViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KinhNghiems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KinhNghiems_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KyNangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKyNang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KyNangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KyNangs_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiThamChieus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvId = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiThamChieus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NguoiThamChieus_CVs_CvId",
                        column: x => x.CvId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoThichs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvId = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoThichs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoThichs_CVs_CvId",
                        column: x => x.CvId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoatDongSinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienProfileId = table.Column<int>(type: "int", nullable: false),
                    ToChuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DangHoatDong = table.Column<bool>(type: "bit", nullable: false),
                    MoTaHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoatDongSinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoatDongSinhViens_SinhVienProfiles_SinhVienProfileId",
                        column: x => x.SinhVienProfileId,
                        principalTable: "SinhVienProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocVanSinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienProfileId = table.Column<int>(type: "int", nullable: false),
                    TruongHoacKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BangCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThangNamTotNghiep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTotNghiep = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MoTaChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVanSinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HocVanSinhViens_SinhVienProfiles_SinhVienProfileId",
                        column: x => x.SinhVienProfileId,
                        principalTable: "SinhVienProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KinhNghiemSinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienProfileId = table.Column<int>(type: "int", nullable: false),
                    ViTriChucDanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucCongViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianLamViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DangLamHienTai = table.Column<bool>(type: "bit", nullable: false),
                    MoTaCongViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KinhNghiemSinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KinhNghiemSinhViens_SinhVienProfiles_SinhVienProfileId",
                        column: x => x.SinhVienProfileId,
                        principalTable: "SinhVienProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KyNangChuyenMonSinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienProfileId = table.Column<int>(type: "int", nullable: false),
                    TenKyNang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTaKyNang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDo = table.Column<int>(type: "int", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KyNangChuyenMonSinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KyNangChuyenMonSinhViens_SinhVienProfiles_SinhVienProfileId",
                        column: x => x.SinhVienProfileId,
                        principalTable: "SinhVienProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NgoaiNguSinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienProfileId = table.Column<int>(type: "int", nullable: false),
                    TenNgoaiNgu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChungChiNgoaiNgu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgoaiNguSinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NgoaiNguSinhViens_SinhVienProfiles_SinhVienProfileId",
                        column: x => x.SinhVienProfileId,
                        principalTable: "SinhVienProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiThamChieuSinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienProfileId = table.Column<int>(type: "int", nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongTy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiThamChieuSinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NguoiThamChieuSinhViens_SinhVienProfiles_SinhVienProfileId",
                        column: x => x.SinhVienProfileId,
                        principalTable: "SinhVienProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CVTemplates",
                columns: new[] { "Id", "Font", "IsPublished", "LayoutJson", "MauChuDao", "MoTa", "PreviewUrl", "StyleJson", "TenTemplate" },
                values: new object[,]
                {
                    { 1, "Arial", true, null, "#0057B8", "Mẫu truyền thống đơn giản, phù hợp mọi ngành nghề.", "/images/templates/classic.png", null, "Classic" },
                    { 2, "Segoe UI", true, null, "#2E8B57", "Mẫu hiện đại, màu sắc nổi bật, bố cục 2 cột.", "/images/templates/modern.png", null, "Modern" },
                    { 3, "Calibri", true, null, "#FF6347", "Mẫu sáng tạo, thích hợp cho ngành thiết kế và truyền thông.", "/images/templates/creative.png", null, "Creative" }
                });

            migrationBuilder.InsertData(
                table: "CapBacs",
                columns: new[] { "Id", "Ten" },
                values: new object[,]
                {
                    { 1, "Nhân viên" },
                    { 2, "Trưởng nhóm" },
                    { 3, "Quản lý" },
                    { 4, "Giám đốc" },
                    { 5, "Phó giám đốc" },
                    { 6, "Thực tập sinh" },
                    { 7, "Khác" }
                });

            migrationBuilder.InsertData(
                table: "LinhVucs",
                columns: new[] { "Id", "MoTa", "NgayTao", "TenLinhVuc" },
                values: new object[,]
                {
                    { 1, "Các công việc liên quan đến bán hàng, quản lý kinh doanh, chăm sóc khách hàng, phát triển thị trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6944), "Kinh Doanh - Bán hàng" },
                    { 2, "Xây dựng thương hiệu, truyền thông, digital marketing, nghiên cứu thị trường và chiến lược quảng bá.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6948), "Marketing - PR - Quảng cáo" },
                    { 3, "Hỗ trợ khách hàng, xử lý dịch vụ, vận hành hệ thống và quy trình doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6949), "Chăm sóc khách hàng (Customer Service) - Vận hành" },
                    { 4, "Quản lý nhân sự, tuyển dụng, đào tạo, hành chính văn phòng và tuân thủ pháp lý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6950), "Nhân sự - Hành chính - Pháp chế" },
                    { 5, "Phát triển phần mềm, hệ thống mạng, quản trị dữ liệu, an ninh mạng và hỗ trợ kỹ thuật CNTT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6950), "Công nghệ Thông tin" },
                    { 6, "Công việc không yêu cầu bằng cấp cao, công nhân sản xuất, lao động trong nhà máy/xí nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6951), "Lao động phổ thông" },
                    { 7, "Tư vấn tài chính, giao dịch ngân hàng, phân tích rủi ro, thẩm định đầu tư và bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6952), "Tài chính - Ngân hàng - Bảo hiểm" },
                    { 8, "Tư vấn, môi giới nhà đất, quản lý dự án, đầu tư và phát triển bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6953), "Bất động sản" },
                    { 9, "Thiết kế, giám sát và thi công công trình dân dụng/ công nghiệp, quản lý dự án xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6953), "Xây dựng" },
                    { 10, "Ghi nhận tài chính, lập báo cáo, kiểm toán, tư vấn thuế và tuân thủ các chuẩn mực kế toán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6954), "Kế toán - Kiểm toán - Thuế" },
                    { 11, "Vận hành dây chuyền sản xuất, quản lý vật tư, kiểm soát chất lượng và quy trình sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6955), "Sản xuất" },
                    { 12, "Giảng dạy, hướng dẫn kỹ năng, nghiên cứu giáo dục và phát triển chương trình đào tạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6955), "Giáo dục - Đào tạo" },
                    { 13, "Các hoạt động bán lẻ, siêu thị, dịch vụ chăm sóc và đáp ứng nhu cầu đời sống hàng ngày.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6956), "Bán lẻ - Dịch vụ đời sống" },
                    { 14, "Sản xuất nội dung đa phương tiện, biên tập, truyền tải thông tin và xuất bản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6957), "Phim và truyền hình - Báo chí - Xuất bản" },
                    { 15, "Thiết kế và vận hành hệ thống điện, bảo trì thiết bị điện tử và mạng lưới viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6957), "Điện - Điện tử - Viễn thông" },
                    { 16, "Chuỗi cung ứng, quản lý kho bãi, vận tải hàng hóa và thu mua vật tư doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6958), "Logistics - Thu mua - Kho - Vận tải" },
                    { 17, "Cung cấp giải pháp chuyên môn, tư vấn chiến lược và hỗ trợ nghiệp vụ cho doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6959), "Tư vấn chuyên môn" },
                    { 18, "Khám chữa bệnh, phát triển dược phẩm, xét nghiệm và nghiên cứu chăm sóc sức khỏe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6959), "Dược - Y tế - Sức khoẻ - Công nghệ sinh học" },
                    { 19, "Thiết kế đồ họa, UI/UX, thiết kế sản phẩm, không gian và sáng tạo nghệ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6960), "Thiết kế" },
                    { 20, "Dịch vụ lưu trú, ẩm thực, tổ chức tour và chăm sóc trải nghiệm khách du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6968), "Du lịch - Nhà hàng - Khách sạn" },
                    { 21, "Phát triển năng lượng, quản lý môi trường bền vững và sản xuất nông nghiệp/vật nuôi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6969), "Năng lượng - Môi trường - Nông nghiệp" },
                    { 22, "Lái xe cá nhân, taxi, vận tải hàng hóa và điều phối phương tiện giao thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6970), "Tài xế" },
                    { 23, "Dịch thuật tài liệu, thông dịch hội thoại và hỗ trợ giao tiếp đa ngôn ngữ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6970), "Biên phiên dịch" },
                    { 24, "Tư vấn pháp lý, đại diện pháp luật, giải quyết tranh chấp và tuân thủ quy định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6971), "Luật" },
                    { 25, "Các vị trí và công việc thuộc các ngành nghề khác không nằm trong các danh mục đã liệt kê.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6973), "Ngành nghề khác" }
                });

            migrationBuilder.InsertData(
                table: "LoaiCongViecs",
                columns: new[] { "Id", "Ten" },
                values: new object[,]
                {
                    { 1, "Full-Time" },
                    { 2, "Part-Time" }
                });

            migrationBuilder.InsertData(
                table: "MucKinhNghiems",
                columns: new[] { "Id", "Ten" },
                values: new object[,]
                {
                    { 1, "Chưa kinh nghiệm" },
                    { 2, "Dưới 1 năm" },
                    { 3, "1-3 năm" }
                });

            migrationBuilder.InsertData(
                table: "NguoiDungs",
                columns: new[] { "Id", "AvatarUrl", "BiKhoa", "CongTyId", "DaDuocCongTyXacThuc", "DangNhapBangGoogle", "Email", "EmailVerificationExpiry", "EmailVerificationToken", "HoTen", "IsEmailConfirmed", "IsNhaTuyenDung", "KhoaHoc", "LopHoc", "LyDoKhoa", "LyDoXinXacThuc", "Ma", "MatKhauHash", "NgayTao", "NgayXacThuc", "NguoiXacThucId", "ResetPasswordExpiry", "ResetPasswordOtp", "SDT", "VaiTro", "VaiTroCongTy" },
                values: new object[,]
                {
                    { 1, null, false, null, false, false, "superadmin@bvu.edu.vn", null, null, "Siêu Quản Trị Viên hệ thống", false, false, null, null, null, null, "SA-1", "$2a$11$.JFW/4VpsyKeO937./7vuezVmvOSm4ZELUnnFFvdPp3toet2f0dna", new DateTime(2025, 12, 11, 13, 10, 28, 226, DateTimeKind.Utc).AddTicks(9389), null, null, null, null, "0910000000", "SuperAdmin", null },
                    { 2, null, false, null, false, false, "admin@bvu.edu.vn", null, null, "Quản Trị Viên", false, false, null, null, null, null, "AD-1", "$2a$11$wtPxRhZV7P0PTGhOJMNmIeI4oGwwwW6sCbo5mNuk/2SbS./csFICa", new DateTime(2025, 12, 11, 13, 10, 28, 341, DateTimeKind.Utc).AddTicks(873), null, null, null, null, "0920000000", "Admin", null },
                    { 3, null, false, null, false, false, "sinhvien@bvu.edu.vn", null, null, "Trần Thị Sinh Viên", false, false, "K20", "D20KTPM01", null, null, "SV-1", "$2a$11$pFvrRrSvPdhhhJU2XnDXluARvPWcnVIaeAkCWAwMkpwjj.8EBwsK6", new DateTime(2025, 12, 11, 13, 10, 28, 570, DateTimeKind.Utc).AddTicks(1218), null, null, null, null, "0944000000", "SinhVien", null },
                    { 4, null, false, null, false, false, "ntd@abc.com", null, null, "Nguyễn Văn Nhà Tuyển Dụng", false, false, null, null, null, null, "NTD-1", "$2a$11$OS1HjeUSUDJhOfdDr5BbAeFxPUibFhsWe7j67BZuF3JVOEJEfsKqa", new DateTime(2025, 12, 11, 13, 10, 28, 455, DateTimeKind.Utc).AddTicks(691), null, null, null, null, "0933111222", "NhaTuyenDung", null }
                });

            migrationBuilder.InsertData(
                table: "TinhThanhs",
                columns: new[] { "Id", "MaTinh", "TenTinh" },
                values: new object[,]
                {
                    { 1, "HNI", "Thành phố Hà Nội" },
                    { 2, "HUE", "Thành phố Huế" },
                    { 3, "LCH", "Tỉnh Lai Châu" },
                    { 4, "DBN", "Tỉnh Điện Biên" },
                    { 5, "SLA", "Tỉnh Sơn La" },
                    { 6, "LSN", "Tỉnh Lạng Sơn" },
                    { 7, "QNI", "Tỉnh Quảng Ninh" },
                    { 8, "THA", "Tỉnh Thanh Hoá" },
                    { 9, "NAN", "Tỉnh Nghệ An" },
                    { 10, "HTH", "Tỉnh Hà Tĩnh" },
                    { 11, "CBG", "Tỉnh Cao Bằng" },
                    { 12, "TTQ", "Tỉnh Tuyên Quang" },
                    { 13, "LCA", "Tỉnh Lào Cai" },
                    { 14, "TNG", "Tỉnh Thái Nguyên" },
                    { 15, "PTO", "Tỉnh Phú Thọ" },
                    { 16, "BNH", "Tỉnh Bắc Ninh" },
                    { 17, "HYE", "Tỉnh Hưng Yên" },
                    { 18, "HPG", "Thành phố Hải Phòng" },
                    { 19, "NBI", "Tỉnh Ninh Bình" },
                    { 20, "QTR", "Tỉnh Quảng Trị" },
                    { 21, "DNG", "Thành phố Đà Nẵng" },
                    { 22, "QNG", "Tỉnh Quảng Ngãi" },
                    { 23, "GLI", "Tỉnh Gia Lai" },
                    { 24, "KHA", "Tỉnh Khánh Hoà" },
                    { 25, "LDG", "Tỉnh Lâm Đồng" },
                    { 26, "DLK", "Tỉnh Đắk Lắk" },
                    { 27, "HCM", "Thành phố Hồ Chí Minh" },
                    { 28, "DNI", "Tỉnh Đồng Nai" },
                    { 29, "TNI", "Tỉnh Tây Ninh" },
                    { 30, "CTO", "Thành phố Cần Thơ" },
                    { 31, "VLG", "Tỉnh Vĩnh Long" },
                    { 32, "DTP", "Tỉnh Đồng Tháp" },
                    { 33, "CMU", "Tỉnh Cà Mau" },
                    { 34, "AGG", "Tỉnh An Giang" }
                });

            migrationBuilder.InsertData(
                table: "NgheNghieps",
                columns: new[] { "Id", "LinhVucId", "MoTa", "NgayTao", "TenNghe" },
                values: new object[,]
                {
                    { 1, 1, "Kinh doanh dịch vụ logistics, vận tải và xuất nhập khẩu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7133), "Sales Xuất nhập khẩu/Logistics" },
                    { 2, 1, "Tư vấn, môi giới và kinh doanh sản phẩm/dịch vụ bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7137), "Sales Bất động sản" },
                    { 3, 1, "Kinh doanh thiết bị, vật tư và dịch vụ trong ngành xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7138), "Sales Xây dựng" },
                    { 4, 1, "Tư vấn khoá học, tuyển sinh và kinh doanh dịch vụ giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7139), "Sales Giáo dục - Khoá học" },
                    { 5, 1, "Hỗ trợ kinh doanh, xử lý đơn hàng và vận hành bán hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7140), "Sales Admin - Sales Support" },
                    { 6, 1, "Tư vấn tài chính, tín dụng, bảo hiểm và sản phẩm ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7140), "Sales Tài chính - Ngân hàng - Bảo hiểm" },
                    { 7, 1, "Kinh doanh sản phẩm bán lẻ, FMCG và dịch vụ tiêu dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7141), "Sales Bán lẻ - Dịch vụ tiêu dùng" },
                    { 8, 1, "Kinh doanh sản phẩm công nghiệp, sản xuất và phụ tùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7142), "Sales Sản xuất" },
                    { 9, 1, "Kinh doanh thiết bị kỹ thuật, phần mềm và giải pháp công nghệ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7143), "Sales Kỹ thuật (Sales Engineer)" },
                    { 10, 1, "Kinh doanh phòng khách sạn, tour và dịch vụ F&B.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7144), "Sales Nhà hàng - Khách sạn - Du lịch" },
                    { 11, 1, "Kinh doanh thuốc, thiết bị y tế và dịch vụ chăm sóc sắc đẹp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7145), "Sales Dược - Y tế - Sức khoẻ - Làm đẹp" },
                    { 12, 1, "Kinh doanh phần mềm, hosting, server và giải pháp CNTT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7145), "Sales IT Phần mềm" },
                    { 13, 1, "Kinh doanh thiết bị điện, điện tử, viễn thông và công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7147), "Sales Điện - Điện tử - Viễn thông" },
                    { 14, 1, "Kinh doanh dịch vụ quảng cáo, media, event và triển lãm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7148), "Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện" },
                    { 15, 1, "Kinh doanh trên sàn thương mại điện tử và vận hành cửa hàng online.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7149), "Sales Thương mại điện tử" },
                    { 16, 1, "Quản lý đội ngũ kinh doanh, xây dựng chiến lược và vận hành bán hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7150), "Quản lý kinh doanh" },
                    { 17, 1, "Các nghề kinh doanh và bán hàng khác không thuộc nhóm cụ thể.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7150), "Kinh doanh - Bán hàng khác" },
                    { 18, 2, "Triển khai chiến dịch marketing, phát triển thương hiệu và nội dung truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7151), "Marketing" },
                    { 19, 2, "Sáng tạo nội dung, sản xuất media và triển khai chiến dịch quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7152), "Quảng cáo - Sáng tạo" },
                    { 20, 2, "Xây dựng hình ảnh doanh nghiệp, PR, truyền thông và xử lý khủng hoảng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7153), "Quan hệ Công chúng" },
                    { 21, 2, "Làm việc với cơ quan Nhà nước, chính sách và đối ngoại doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7154), "Quan hệ Chính phủ" },
                    { 22, 2, "Phân tích dữ liệu, nghiên cứu thị trường và hành vi người tiêu dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7155), "Market Research and Analysis" },
                    { 23, 2, "Kinh doanh dịch vụ quảng cáo, truyền thông, sự kiện và triển lãm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7156), "Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện" },
                    { 24, 2, "Các công việc khác liên quan đến marketing, PR và quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7157), "Marketing-PR-Quảng cáo khác" },
                    { 25, 3, "Hỗ trợ khách hàng, xử lý yêu cầu, cải thiện trải nghiệm và duy trì quan hệ khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7158), "Chăm sóc khách hàng (Customer Service)" },
                    { 26, 3, "Quản lý đơn hàng, gian hàng, sản phẩm và vận hành hoạt động TMĐT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7159), "Vận hành Thương mại điện tử" },
                    { 27, 3, "Quản lý quy trình, dữ liệu và vận hành các hoạt động kinh doanh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7160), "Business Operation (Vận hành kinh doanh)" },
                    { 28, 3, "Điều phối và quản lý hoạt động vận hành của doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7161), "Quản lý vận hành" },
                    { 29, 3, "Các công việc khác liên quan đến chăm sóc khách hàng và vận hành.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7161), "Dịch vụ khách hàng - Vận hành khác" },
                    { 30, 4, "Tuyển dụng, đào tạo, C&B, quan hệ lao động và phát triển tổ chức.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7198), "Nhân sự (Human Resources)" },
                    { 31, 4, "Quản lý hồ sơ, văn thư, lễ tân, hậu cần và hỗ trợ vận hành văn phòng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7199), "Hành chính Văn phòng" },
                    { 32, 4, "Soạn thảo hợp đồng, tư vấn pháp lý và đảm bảo tuân thủ pháp luật trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7200), "Dịch vụ pháp chế (In-house)" },
                    { 33, 4, "Các vị trí khác thuộc nhóm nhân sự, hành chính và pháp chế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7201), "Nhân sự - Hành chính - Pháp chế khác" },
                    { 34, 5, "Phát triển phần mềm, lập trình ứng dụng và xây dựng hệ thống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7202), "Software Engineering" },
                    { 35, 5, "Kiểm thử phần mềm, đảm bảo chất lượng và tự động hóa kiểm thử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7203), "Software Testing" },
                    { 36, 5, "Phát triển hệ thống AI, machine learning, deep learning và gán nhãn dữ liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7203), "Artificial Intelligence (AI)" },
                    { 37, 5, "Phân tích dữ liệu, xây dựng mô hình và xử lý dữ liệu lớn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7204), "Data Science & Big Data" },
                    { 38, 5, "Quản trị hệ thống, mạng, máy chủ, cloud và vận hành CNTT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7208), "IT Infrastructure and Operations" },
                    { 39, 5, "Bảo mật hệ thống, kiểm thử bảo mật và phòng chống tấn công mạng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7209), "Information Security" },
                    { 40, 5, "Phát triển hệ thống IoT, lập trình nhúng và phần cứng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7209), "IoT - Embedded Engineer" },
                    { 41, 5, "Quản lý dự án phần mềm, agile, scrum và điều phối kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7210), "IT Project Management" },
                    { 42, 5, "Quản lý kỹ thuật, kiến trúc hệ thống và vận hành CNTT cấp cao.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7211), "IT Management - Specialist" },
                    { 43, 5, "Thiết kế UX/UI, giao diện, đồ họa và trải nghiệm người dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7212), "Software Design" },
                    { 44, 5, "Quản lý sản phẩm, phân tích nghiệp vụ và phát triển chiến lược sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7212), "Product Management" },
                    { 45, 5, "Lập trình game, thiết kế game và phát triển đồ họa/gameplay.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7213), "Game Development" },
                    { 46, 5, "Kinh doanh phần mềm, dịch vụ công nghệ và giải pháp CNTT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7214), "Sales IT Phần mềm" },
                    { 47, 5, "Các công việc CNTT khác không thuộc nhóm đã liệt kê.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7215), "Công nghệ Thông tin khác" },
                    { 48, 6, "Lao động phổ thông trong nhà máy, xưởng sản xuất và dây chuyền công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7216), "Công nhân" },
                    { 49, 6, "Lái xe vận tải, giao nhận, đưa đón và vận chuyển hàng hoá.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7216), "Tài xế" },
                    { 50, 6, "Quản lý kho, phân loại hàng, đóng gói và giao nhận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7217), "Kho vận - Giao hàng" },
                    { 51, 6, "Bảo vệ tài sản, bảo trì thiết bị và sửa chữa hệ thống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7218), "Bảo vệ - Bảo trì - Sửa chữa" },
                    { 52, 6, "Dọn dẹp, chăm trẻ, hỗ trợ gia đình và dịch vụ vệ sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7219), "Vệ sinh - Giúp việc - Bảo mẫu" },
                    { 53, 6, "Thẩm mỹ, spa, massage và chăm sóc cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7220), "Chăm sóc sức khoẻ - Làm đẹp" },
                    { 54, 6, "Phục vụ, bếp, pha chế và vận hành nhà hàng/quán ăn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7220), "Nhà hàng - Dịch vụ ăn uống" },
                    { 55, 6, "Buồng phòng, lễ tân, vận hành và hỗ trợ khách lưu trú.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7221), "Khách sạn - Dịch vụ cư trú" },
                    { 56, 6, "Bán hàng trực tiếp, PG, thu ngân và hỗ trợ bán lẻ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7222), "Tiếp thị - Bán hàng" },
                    { 57, 6, "Làm thủ công mỹ nghệ, may mặc, cắt vải và sản phẩm handmade.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7223), "Thợ thủ công" },
                    { 58, 6, "Hàn, tiện, phay, mài và vận hành máy cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7224), "Gia công cơ khí" },
                    { 59, 6, "Xây dựng, sửa chữa, sơn, mộc, nhôm kính và thi công công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7225), "Thợ xây dựng" },
                    { 60, 7, "Phân tích tài chính, hoạch định, kiểm soát và tư vấn tài chính doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7226), "Tài chính" },
                    { 61, 7, "Giao dịch, tín dụng, xử lý nợ, quan hệ khách hàng và vận hành ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7228), "Ngân hàng" },
                    { 62, 7, "Tư vấn, phân tích đầu tư và quản lý danh mục chứng khoán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7228), "Chứng khoán" },
                    { 63, 7, "Đánh giá rủi ro, tuân thủ, thẩm định tín dụng và kiểm soát rủi ro.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7229), "Thẩm định và quản trị rủi ro" },
                    { 64, 7, "Phân tích đầu tư, M&A, tài trợ thương mại và quản lý tài sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7230), "Đầu tư và Tài trợ" },
                    { 65, 7, "Thẩm định, tư vấn, xử lý bồi thường và quản lý hợp đồng bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7231), "Bảo hiểm" },
                    { 66, 7, "Kinh doanh sản phẩm tài chính, ngân hàng, bảo hiểm và đầu tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7232), "Sales Tài chính - Ngân hàng - Bảo hiểm" },
                    { 67, 7, "Các công việc khác trong nhóm tài chính, ngân hàng và bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7232), "Tài chính - Ngân hàng - Bảo hiểm khác" },
                    { 68, 8, "Vận hành tòa nhà, bảo trì, an ninh và dịch vụ khách thuê.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7233), "Quản lý vận hành bất động sản" },
                    { 69, 8, "Quy hoạch, phát triển dự án, đấu thầu và thẩm định bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7234), "Quy hoạch và phát triển bất động sản" },
                    { 70, 8, "Môi giới, tư vấn và kinh doanh sản phẩm bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7235), "Sales Bất động sản" },
                    { 71, 8, "Các công việc khác liên quan đến lĩnh vực bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7236), "Bất động sản khác" },
                    { 72, 9, "Quản lý tiến độ, chất lượng, hồ sơ và thi công dự án xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7236), "Quản lý dự án xây dựng" },
                    { 73, 9, "Thiết kế công trình, kiến trúc, nội thất và hệ thống kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7237), "Thiết kế và Kiến trúc" },
                    { 74, 9, "Thi công xây dựng, cải tạo, sửa chữa và lắp đặt công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7238), "Công nhân Xây dựng - Cải tạo" },
                    { 75, 9, "Kinh doanh vật liệu, thiết bị và giải pháp trong ngành xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7239), "Sales Xây dựng" },
                    { 76, 9, "Các công việc khác thuộc lĩnh vực xây dựng và thi công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7240), "Xây dựng khác" },
                    { 77, 10, "Hạch toán, báo cáo tài chính, quản lý chi phí và xử lý nghiệp vụ kế toán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7240), "Kế toán" },
                    { 78, 10, "Kiểm tra báo cáo tài chính, đánh giá tuân thủ và kiểm toán nội bộ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7241), "Kiểm toán" },
                    { 79, 10, "Khai báo, quyết toán, lập hồ sơ và tư vấn chính sách thuế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7242), "Thuế" },
                    { 80, 10, "Các công việc khác liên quan đến kế toán, kiểm toán và thuế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7243), "Kế toán - Kiểm toán - Thuế khác" },
                    { 81, 11, "Hàn, tiện, phay, mài và gia công chi tiết cơ khí theo yêu cầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7244), "Gia công cơ khí" },
                    { 82, 11, "Thiết kế, chế tạo, lắp ráp và cải tiến máy móc thiết bị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7244), "Thiết kế - chế tạo máy" },
                    { 83, 11, "Sản xuất, kiểm nghiệm và nghiên cứu các sản phẩm hoá chất và mỹ phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7245), "Hoá chất - Hoá mỹ phẩm" },
                    { 84, 11, "Thiết kế, sản xuất và gia công sản phẩm may mặc, dệt may và da giày.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7246), "May mặc - Dệt may - Da" },
                    { 85, 11, "Nghiên cứu, thiết kế, lắp ráp và phát triển linh kiện ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7247), "R & D - Sản xuất ô tô" },
                    { 86, 11, "Sửa chữa, lắp đặt, vận hành và hỗ trợ kỹ thuật trong nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7247), "Thợ kỹ thuật" },
                    { 87, 11, "Vận hành xe nâng, máy công trình, thiết bị nặng và phương tiện vận tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7249), "Vận hành thiết bị vận tải - thiết bị nặng" },
                    { 88, 11, "Đảm bảo, kiểm soát chất lượng sản phẩm và quy trình sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7250), "Quản lý chất lượng" },
                    { 89, 11, "Giám sát dây chuyền, điều phối sản xuất và quản lý thiết bị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7250), "Vận hành sản xuất" },
                    { 90, 11, "Bảo trì máy móc, sửa chữa thiết bị và xử lý sự cố kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7251), "Bảo trì, sửa chữa" },
                    { 91, 11, "Kinh doanh sản phẩm công nghiệp, máy móc và vật tư sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7252), "Sales Sản xuất" },
                    { 92, 11, "Các công việc khác liên quan đến lĩnh vực sản xuất và công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7253), "Sản xuất khác" },
                    { 93, 12, "Giảng dạy, đào tạo học viên và hỗ trợ học tập theo chuyên môn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7254), "Giáo viên - Giảng viên - Gia sư" },
                    { 94, 12, "Dạy và đào tạo các môn nghệ thuật, mỹ thuật, khoa học và kỹ năng sáng tạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7254), "Văn hoá - Nghệ thuật - Khoa học" },
                    { 95, 12, "Huấn luyện thể thao, thể hình, yoga, bơi lội và các bộ môn vận động.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7255), "Thể chất - Thể hình" },
                    { 96, 12, "Quản lý học vụ, điều phối giáo viên và vận hành hệ thống giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7256), "Quản lý giáo dục" },
                    { 97, 12, "Hỗ trợ giảng viên, hướng dẫn học viên và quản lý lớp học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7257), "Trợ giảng" },
                    { 98, 12, "Hỗ trợ vận hành lớp học, chăm sóc học viên và điều phối học tập.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7257), "Quản lý - Hỗ trợ lớp học" },
                    { 99, 12, "Tư vấn khoá học, tuyển sinh và kinh doanh dịch vụ giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7258), "Sales Giáo dục - Khoá học" },
                    { 100, 12, "Các công việc khác trong lĩnh vực giáo dục và đào tạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7259), "Giáo dục - Đào tạo khác" },
                    { 101, 13, "Bán hàng siêu thị, cửa hàng tiện lợi, thời trang và thương mại tiêu dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7260), "Bán lẻ" },
                    { 102, 13, "Spa, phun xăm, nail, tóc và các dịch vụ thẩm mỹ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7260), "Dịch vụ làm đẹp" },
                    { 103, 13, "Massage, vật lý trị liệu, chăm sóc sức khoẻ cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7261), "Dịch vụ chăm sóc sức khoẻ" },
                    { 104, 13, "Dọn vệ sinh, giúp việc, sắp xếp nhà cửa và vệ sinh công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7262), "Dịch vụ vệ sinh - nhà cửa" },
                    { 105, 13, "Lái xe taxi, xe tải, giao hàng và đưa đón.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7263), "Tài xế - Lái xe" },
                    { 106, 13, "Bảo vệ, giám sát an ninh và bảo trì thiết bị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7263), "Dịch vụ an ninh và bảo trì" },
                    { 107, 13, "Chăm sóc mẹ và bé, bảo mẫu và hỗ trợ trẻ nhỏ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7264), "Dịch vụ bà mẹ trẻ em" },
                    { 108, 13, "Sửa chữa, rửa xe, bảo trì và chăm sóc xe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7265), "Dịch vụ ô tô - xe máy - xe điện" },
                    { 109, 13, "Chăm sóc, spa, nuôi dưỡng và điều trị thú cưng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7266), "Dịch vụ thú cưng" },
                    { 110, 13, "Các công việc khác trong nhóm bán lẻ và dịch vụ đời sống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7266), "Bán lẻ - Dịch vụ đời sống khác" },
                    { 111, 14, "Biên tập nội dung, viết bài, xuất bản sách, báo và tài liệu truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7267), "Biên tập - Viết - Xuất bản" },
                    { 112, 14, "Sản xuất phim, quay dựng, diễn xuất, hậu kỳ và kỹ thuật truyền hình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7269), "Phim và truyền hình" },
                    { 113, 14, "Các công việc khác thuộc nhóm phim, báo chí và xuất bản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7270), "Phim và truyền hình - Báo chí - Xuất bản khác" },
                    { 114, 15, "Thiết kế, vận hành và bảo trì hệ thống điện và tự động hoá công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7270), "Điện - Tự động hoá" },
                    { 115, 15, "Thiết kế mạch điện, phát triển phần cứng và sửa chữa thiết bị điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7299), "Điện tử - Phần cứng" },
                    { 116, 15, "Thiết kế và vận hành hệ thống điều hoà, thông gió và kỹ thuật nhiệt lạnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7300), "Nhiệt - Gió - Điều hoà (HVAC-R)" },
                    { 117, 15, "Thiết kế vi mạch, kiểm định chip và phát triển công nghệ bán dẫn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7301), "Chất bán dẫn - Chip" },
                    { 118, 15, "Điều phối, quản lý và triển khai dự án điện, viễn thông và kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7301), "Quản lý - Vận hành dự án kỹ thuật" },
                    { 119, 15, "Thiết kế, vận hành và tối ưu hệ thống mạng và truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7302), "Viễn thông" },
                    { 120, 15, "Vận hành thiết bị, hỗ trợ kỹ thuật và bảo trì hệ thống điện tử – viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7303), "Vận hành và bảo trì - Hỗ trợ kỹ thuật" },
                    { 121, 15, "Kinh doanh thiết bị điện, giải pháp viễn thông và sản phẩm công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7304), "Sales Điện - Điện tử - Viễn thông" },
                    { 122, 15, "Các công việc khác thuộc ngành điện, điện tử và viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7305), "Điện - Điện tử - Viễn thông khác" },
                    { 123, 16, "Kinh doanh dịch vụ logistics, vận chuyển, kho bãi và xuất nhập khẩu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7305), "Sales Xuất nhập khẩu - Logistics" },
                    { 124, 16, "Chứng từ, điều phối hàng hóa, theo dõi đơn hàng và khai báo hải quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7306), "Xuất nhập khẩu - Logistics" },
                    { 125, 16, "Điều phối, vận hành phương tiện và quản lý vận tải hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7307), "Vận tải" },
                    { 126, 16, "Bưu tá, giao hàng, phân loại và điều phối giao nhận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7308), "Giao nhận" },
                    { 127, 16, "Quản lý kho, nhập xuất, đóng gói và sắp xếp hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7308), "Kho vận" },
                    { 128, 16, "Đàm phán, đặt hàng, quản lý nhà cung cấp và kiểm soát vật tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7309), "Thu mua - Mua hàng" },
                    { 129, 16, "Hoạch định, điều phối và tối ưu chuỗi cung ứng hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7310), "Chuỗi cung ứng" },
                    { 130, 16, "Các vị trí khác thuộc nhóm logistics, kho vận và vận tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7311), "Logistics - Thu mua - Kho - Vận tải khác" },
                    { 131, 17, "Tư vấn chiến lược, phân tích dữ liệu, thị trường và giải pháp cho doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7312), "Tư vấn - Phân tích chuyên môn" },
                    { 132, 18, "Chăm sóc bệnh nhân, hỗ trợ y khoa và theo dõi điều trị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7313), "Nghề Y tá - Điều dưỡng" },
                    { 133, 18, "Khám chữa bệnh, chẩn đoán hình ảnh, xét nghiệm và kỹ thuật y học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7313), "Bác sĩ - Kỹ thuật viên" },
                    { 134, 18, "Phục hồi chức năng, vật lý trị liệu và chăm sóc sức khỏe cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7314), "Vật lý trị liệu và chăm sóc sức khỏe" },
                    { 135, 18, "Sản xuất, nghiên cứu và kinh doanh dược phẩm, sinh học và R&D y dược.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7315), "Dược phẩm - Công nghệ sinh học" },
                    { 136, 18, "Quản lý, vận hành, kinh doanh và bảo trì thiết bị y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7316), "Thiết bị y tế" },
                    { 137, 18, "Kinh doanh dược phẩm, thiết bị y tế và dịch vụ làm đẹp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7318), "Sales Dược - Y tế - Sức khoẻ - Làm đẹp" },
                    { 138, 18, "Các công việc khác thuộc nhóm y tế, dược và công nghệ sinh học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7319), "Dược - Y tế - Sức khoẻ - Công nghệ sinh học khác" },
                    { 139, 19, "Thiết kế đồ họa, UX/UI, giao diện và trải nghiệm người dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7319), "Thiết kế Đồ hoạ - Giao diện - Trải nghiệm" },
                    { 140, 19, "Thiết kế kiến trúc, nội thất, cảnh quan và không gian.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7320), "Thiết kế Nhà - Nội thất - Môi trường" },
                    { 141, 19, "Thiết kế sản phẩm, bao bì, kỹ thuật và mô hình công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7321), "Thiết kế Công nghiệp" },
                    { 142, 19, "Thiết kế trang phục, rập, vải và sản phẩm thời trang.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7322), "Thiết kế Thời trang" },
                    { 143, 19, "Animation, minh họa, concept art, dựng hình và thiết kế game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7323), "Nghệ thuật - Hoạt hình - Game" },
                    { 144, 19, "Nghiên cứu hành vi người dùng, usability test và phân tích trải nghiệm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7323), "Nghiên cứu người dùng" },
                    { 145, 19, "Quản lý đội ngũ thiết kế, định hướng sáng tạo và giám sát dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7324), "Quản lý thiết kế" },
                    { 146, 19, "Các công việc khác thuộc nhóm ngành thiết kế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7325), "Thiết kế khác" },
                    { 147, 20, "Phục vụ, bếp, pha chế, quản lý và vận hành nhà hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7326), "Nhà hàng - Dịch vụ ăn uống" },
                    { 148, 20, "Lễ tân, buồng phòng, quản lý khách sạn và dịch vụ lưu trú.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7327), "Khách sạn - Dịch vụ cư trú" },
                    { 149, 20, "Hướng dẫn viên, điều hành tour, visa và dịch vụ du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7327), "Dịch vụ du lịch" },
                    { 150, 20, "Kinh doanh tour, phòng khách sạn, HORECA và dịch vụ lữ hành.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7328), "Sales Nhà hàng - Khách sạn - Du lịch" },
                    { 151, 20, "Các vị trí khác trong ngành F&B, khách sạn và du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7329), "Nhà hàng - Khách sạn - Du lịch khác" },
                    { 152, 21, "Kỹ sư năng lượng, địa chất, thủy lợi và các dự án năng lượng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7330), "Năng lượng - Địa chất" },
                    { 153, 21, "HSE, môi trường, xử lý chất thải và giám sát an toàn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7331), "An toàn lao động - Môi trường" },
                    { 154, 21, "Trồng trọt, chăn nuôi, thủy sản và quản lý nông nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7331), "Nông - Lâm - Ngư nghiệp" },
                    { 155, 21, "Các công việc khác trong lĩnh vực năng lượng, môi trường, nông nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7332), "Năng lượng - Môi trường - Nông nghiệp khác" },
                    { 156, 22, "Tài xế xe tải, container, đường dài và vận hành phương tiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7333), "Vận tải" },
                    { 157, 22, "Tài xế taxi, công nghệ, lái xe văn phòng và dịch vụ đưa đón.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7334), "Đưa đón" },
                    { 158, 23, "Phiên dịch, biên dịch đa ngôn ngữ và tư vấn dịch thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7335), "Nghề Biên phiên dịch" },
                    { 159, 24, "Luật sư, tư vấn pháp lý, hỗ trợ hồ sơ và pháp lý doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7335), "Dịch vụ pháp lý (Agency - Firm)" },
                    { 160, 24, "Pháp chế doanh nghiệp, tuân thủ, hợp đồng và pháp lý nội bộ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7336), "Dịch vụ pháp chế (In-house)" },
                    { 161, 25, "Vận hành tàu biển, kỹ thuật hàng hải và dịch vụ logistics biển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7337), "Hàng hải" },
                    { 162, 25, "Công việc xã hội, cộng đồng, phát triển bền vững và hỗ trợ nhân đạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7338), "NGO - Phi chính phủ - Phi lợi nhuận" },
                    { 163, 25, "Các nghề chưa thuộc các nhóm lĩnh vực còn lại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7338), "Nghề khác" }
                });

            migrationBuilder.InsertData(
                table: "ChuyenNganhs",
                columns: new[] { "Id", "MoTa", "NgayTao", "NgheNghiepId", "TenChuyenNganh" },
                values: new object[,]
                {
                    { 1, "Tư vấn và bán giải pháp logistics, vận chuyển, kho bãi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7499), 1, "Sales Logistics" },
                    { 2, "Các vị trí kinh doanh khác trong lĩnh vực XNK và Logistics.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7502), 1, "Sales Xuất nhập khẩu - Logistics khác" },
                    { 3, "Tư vấn và môi giới mua bán, cho thuê bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7502), 2, "Sales bất động sản - Môi giới bất động sản" },
                    { 4, "Các vị trí kinh doanh khác trong lĩnh vực bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7503), 2, "Sales Bất động sản khác" },
                    { 5, "Bán thiết bị, vật tư và vật liệu xây dựng cho công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7504), 3, "Kinh doanh thiết bị - vật liệu xây dựng" },
                    { 6, "Bán sản phẩm nội thất nhà ở, văn phòng và công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7505), 3, "Kinh doanh nội thất" },
                    { 7, "Tư vấn giải pháp thiết kế và thi công xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7505), 3, "Tư vấn thiết kế xây dựng" },
                    { 8, "Các vị trí kinh doanh khác trong lĩnh vực xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7506), 3, "Sales Xây dựng khác" },
                    { 9, "Tư vấn khoá học, chương trình đào tạo và hỗ trợ tuyển sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7507), 4, "Tư vấn tuyển sinh - khoá học" },
                    { 10, "Các vị trí kinh doanh khác trong lĩnh vực giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7508), 4, "Sales Giáo dục - Khoá học khác" },
                    { 11, "Tư vấn hồ sơ du học và các chương trình quốc tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7508), 4, "Tư vấn du học" },
                    { 12, "Hỗ trợ kinh doanh, soạn hợp đồng, theo dõi đơn hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7509), 5, "Sales Admin - Sales Support" },
                    { 13, "Vận hành kỹ thuật livestream bán hàng và hỗ trợ nội dung.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7510), 5, "Vận hành Livestream" },
                    { 14, "Chuẩn bị hồ sơ thầu và tham gia đấu thầu dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7512), 5, "Chuyên viên đấu thầu" },
                    { 15, "Hỗ trợ khách hàng sau bán và tối ưu trải nghiệm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7513), 5, "Customer Success" },
                    { 16, "Chăm sóc và tư vấn sản phẩm tài chính cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7514), 6, "Quan hệ khách hàng cá nhân - doanh nghiệp " },
                    { 17, "Tư vấn các giải pháp tài chính cá nhân và doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7515), 6, "Tư vấn tài chính" },
                    { 18, "Tư vấn vay vốn, hạn mức và giải pháp tín dụng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7516), 6, "Tư vấn tín dụng" },
                    { 19, "Tư vấn các gói bảo hiểm sức khỏe, nhân thọ và tài sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7516), 6, "Tư vấn bảo hiểm" },
                    { 20, "Các vị trí kinh doanh khác trong lĩnh vực tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7517), 6, "Sales Tài chính - Ngân hàng - Bảo hiểm khác" },
                    { 21, "Hỗ trợ khách hàng bảo hiểm và xử lý quyền lợi bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7518), 6, "Chăm sóc khách hàng bảo hiểm" },
                    { 22, "Tư vấn trả góp và tài chính tiêu dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7519), 6, "Tư vấn trả góp" },
                    { 23, "Tư vấn danh mục đầu tư tài chính và chứng khoán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7520), 6, "Tư vấn đầu tư" },
                    { 24, "Kinh doanh bảo hiểm qua kênh ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7521), 6, "Bancassurance" },
                    { 25, "Tư vấn và kinh doanh sản phẩm FX và phái sinh tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7522), 6, "Kinh doanh ngoại hối, vàng, phái sinh" },
                    { 26, "Tư vấn giao dịch cổ phiếu, trái phiếu và thị trường vốn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7523), 6, "Tư vấn chứng khoán" },
                    { 27, "Các vị trí kinh doanh khác trong ngành bán lẻ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7523), 7, "Sales Bán lẻ - Dịch vụ tiêu dùng khác" },
                    { 28, "Tư vấn và bán sản phẩm thời trang.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7524), 7, "Bán hàng thời trang" },
                    { 29, "Phụ trách bán hàng qua kênh truyền thống GT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7525), 7, "Kinh doanh kênh GT" },
                    { 30, "Bán hàng và chăm sóc khách tại hệ thống siêu thị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7526), 7, "Bán hàng siêu thị - cửa hàng tiện ích - tiện lợi" },
                    { 31, "Kinh doanh các sản phẩm thực phẩm tiêu dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7526), 7, "Kinh doanh thực phẩm" },
                    { 32, "Phát triển bán hàng qua kênh hiện đại MT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7527), 7, "Kinh doanh kênh MT" },
                    { 33, "Bán sản phẩm điện thoại, phụ kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7528), 7, "Bán hàng điện thoại" },
                    { 34, "Kinh doanh thiết bị điện máy gia dụng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7529), 7, "Bán hàng điện máy" },
                    { 35, "Bán sản phẩm mỹ phẩm và làm đẹp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7529), 7, "Bán hàng mỹ phẩm" },
                    { 36, "Kinh doanh trang sức vàng, bạc, đá quý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7531), 7, "Bán hàng trang sức đá quý" },
                    { 37, "Bán ô tô, xe máy, xe điện và sản phẩm liên quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7532), 8, "Kinh doanh ô tô - xe máy - xe điện" },
                    { 38, "Các vị trí kinh doanh khác trong ngành sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7533), 8, "Sales Sản xuất khác" },
                    { 39, "Bán phụ tùng, linh kiện ô tô và xe máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7535), 8, "Kinh doanh phụ tùng ô tô - xe máy - xe điện" },
                    { 40, "Bán hoá chất công nghiệp hoặc hoá mỹ phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7536), 8, "Kinh doanh hoá chất" },
                    { 41, "Bán thiết bị và giải pháp kỹ thuật ngành điện – viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7537), 9, "Bán hàng kỹ thuật Điện - Điện tử - Viễn thông" },
                    { 42, "Kinh doanh máy móc, thiết bị cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7537), 9, "Bán hàng kỹ thuật cơ khí" },
                    { 43, "Bán phần mềm, phần cứng và giải pháp CNTT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7538), 9, "Bán hàng kỹ thuật IT" },
                    { 44, "Các vị trí Sales Engineer khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7539), 9, "Sales Kỹ thuật khác" },
                    { 45, "Bán tour và dịch vụ du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7540), 10, "Sales Tour - Kinh doanh du lịch" },
                    { 46, "Bán phòng và dịch vụ khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7540), 10, "Kinh doanh khách sạn" },
                    { 47, "Cung cấp sản phẩm/dịch vụ cho nhà hàng – khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7542), 10, "Kinh doanh HORECA" },
                    { 48, "Đặt vé máy bay và hỗ trợ khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7543), 10, "Bán vé máy bay (Ticketing/Booker)" },
                    { 49, "Bán dịch vụ hội nghị – hội thảo – sự kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7543), 10, "Kinh doanh khách đoàn (MICE)" },
                    { 50, "Quản lý bán phòng qua booking/agoda.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7544), 10, "Kinh doanh OTA" },
                    { 51, "Các vị trí Sales khác trong F&B – du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7545), 10, "Sales Nhà hàng - Khách sạn - Du lịch khác" },
                    { 52, "Các vị trí kinh doanh khác trong y tế – dược – thẩm mỹ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7546), 11, "Sales Dược - Y tế - Sức khoẻ - Làm đẹp khác" },
                    { 53, "Tư vấn dịch vụ thẩm mỹ, spa, chăm sóc da.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7547), 11, "Tư vấn thẩm mỹ - Spa" },
                    { 54, "Giới thiệu và bán thuốc tại nhà thuốc/bệnh viện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7547), 11, "Trình dược viên" },
                    { 55, "Bán các dịch vụ khám chữa bệnh và chăm sóc sức khoẻ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7548), 11, "Kinh doanh dịch vụ y tế" },
                    { 56, "Tư vấn và bán thuốc theo đơn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7549), 11, "Dược sĩ - Bán thuốc" },
                    { 57, "Bán phần mềm và giải pháp công nghệ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7550), 12, "Kinh doanh phần mềm" },
                    { 58, "Bán tên miền, dịch vụ hosting, cloud server.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7550), 12, "Kinh doanh Domain/Hosting/Server" },
                    { 59, "Các vị trí kinh doanh khác về phần mềm và IT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7551), 12, "Sales IT Phần mềm khác" },
                    { 60, "Bán linh kiện, vật tư ngành điện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7552), 13, "Kinh doanh thiết bị linh kiện điện" },
                    { 61, "Bán dịch vụ viễn thông, truyền hình, internet.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7553), 13, "Kinh doanh dịch vụ viễn thông" },
                    { 62, "Các vị trí Sales khác ngành điện – viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7553), 13, "Sales Điện/Điện tử/Viễn thông khác" },
                    { 63, "Bán máy móc và thiết bị công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7554), 13, "Kinh doanh thiết bị công nghiệp" },
                    { 64, "Bán thiết bị và giải pháp năng lượng mặt trời.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7556), 13, "Kinh doanh điện mặt trời" },
                    { 65, "Kinh doanh thiết bị và giải pháp điều hòa – thông gió.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7557), 13, "Kinh doanh HVAC" },
                    { 66, "Kinh doanh dịch vụ marketing và quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7558), 14, "Sales Marketing" },
                    { 67, "Bán dịch vụ quảng cáo truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7559), 14, "Kinh doanh dịch vụ quảng cáo" },
                    { 68, "Kinh doanh dịch vụ tổ chức sự kiện và hội nghị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7559), 14, "Kinh doanh tiệc/sự kiện/hội nghị" },
                    { 69, "Các vị trí Sales khác thuộc nhóm event – media.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7560), 14, "Sales dịch vụ Quảng cáo - Triển lãm - Sự kiện khác" },
                    { 70, "Tìm kiếm nhà tài trợ cho sự kiện và chiến dịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7561), 14, "Kinh doanh mảng Nhà tài trợ" },
                    { 71, "Kinh doanh gian hàng và dịch vụ triển lãm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7562), 14, "Kinh doanh triển lãm" },
                    { 72, "Các vị trí khác thuộc lĩnh vực quảng cáo và triển lãm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7563), 14, "Sales dịch vụ Quảng cáo/Triển lãm/Sự kiện khác" },
                    { 73, "Quản lý gian hàng và kinh doanh trên sàn TMĐT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7563), 15, "Kinh doanh sàn thương mại điện tử" },
                    { 74, "Quản lý đội ngũ kinh doanh và kế hoạch bán hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7564), 16, "Sales Manager/Trưởng phòng kinh doanh" },
                    { 75, "Quản lý vận hành cửa hàng và nhân sự.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7565), 16, "Quản lý cửa hàng/Cửa hàng trưởng" },
                    { 76, "Điều hành chiến lược kinh doanh toàn doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7566), 16, "Sales Director/Giám đốc kinh doanh" },
                    { 77, "Các vị trí quản lý khác trong kinh doanh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7566), 16, "Quản lý Kinh doanh khác" },
                    { 78, "Quản lý bán hàng theo khu vực.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7567), 16, "ASM/Quản lý khu vực/vùng miền" },
                    { 79, "Xây dựng chính sách kinh doanh và bán hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7568), 16, "Chuyên viên chính sách kinh doanh" },
                    { 80, "Hỗ trợ công việc kinh doanh và khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7569), 17, "Trợ lý kinh doanh" },
                    { 81, "Chăm sóc khách hàng và triển khai hợp đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7569), 17, "Account Executive" },
                    { 82, "Kinh doanh dịch vụ kế toán và tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7571), 17, "Sales Dịch vụ kế toán" },
                    { 83, "Kinh doanh và phân phối sản phẩm nông nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7572), 17, "Kinh doanh nông sản" },
                    { 84, "Các vị trí kinh doanh không thuộc nhóm khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7574), 17, "Chuyên môn Kinh doanh/Bán hàng khác" },
                    { 85, "Tìm kiếm khách hàng mới và phát triển thị trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7576), 17, "Sales Representative/Phát triển kinh doanh" },
                    { 86, "Quản lý danh mục khách hàng doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7576), 17, "Account Manager (Quản lý khách hàng)" },
                    { 87, "Xây dựng mối quan hệ giữa doanh nghiệp và các cơ quan Nhà nước, tổ chức bên ngoài.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7624), 21, "Quan hệ đối ngoại" },
                    { 88, "Đảm bảo tuân thủ pháp luật, tư vấn và xử lý các vấn đề pháp lý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7625), 21, "Pháp chế" },
                    { 89, "Phân tích luật, nghị định và đề xuất chính sách phù hợp cho tổ chức.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7626), 21, "Nghiên cứu chính sách" },
                    { 90, "Làm việc với cơ quan, tổ chức quốc tế nhằm thúc đẩy quan hệ đối tác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7627), 21, "Hợp tác quốc tế" },
                    { 91, "Thu thập, phân tích dữ liệu thị trường để hỗ trợ chiến lược doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7628), 22, "Nghiên cứu thị trường (Market Research)" },
                    { 92, "Phân tích dữ liệu người dùng, hành vi và hiệu quả kinh doanh để đưa ra insight.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7628), 22, "Data Analyst" },
                    { 93, "Các nghiệp vụ khác trong nghiên cứu thị trường và phân tích dữ liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7629), 22, "Chuyên môn Market Research and Analysis khác" },
                    { 94, "Xây dựng báo cáo, dashboard và phân tích hiệu suất doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7630), 22, "Business Intelligence" },
                    { 95, "Phân tích định lượng, mô hình thống kê và dự báo xu hướng thị trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7631), 22, "Quantitative Analyst" },
                    { 96, "Tư vấn và bán các gói dịch vụ marketing, quảng cáo và truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7631), 23, "Sales Marketing" },
                    { 97, "Bán các gói quảng cáo, truyền thông và giải pháp marketing cho doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7632), 23, "Kinh doanh dịch vụ quảng cáo" },
                    { 98, "Tư vấn và bán dịch vụ tổ chức sự kiện, hội nghị và tiệc doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7633), 23, "Kinh doanh tiệc/sự kiện/hội nghị" },
                    { 99, "Các mảng kinh doanh khác liên quan đến quảng cáo, triển lãm và sự kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7634), 23, "Sales dịch vụ Quảng cáo/Triển lãm/Sự kiện khác" },
                    { 100, "Tìm kiếm và ký kết nhà tài trợ cho sự kiện, chương trình hoặc dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7634), 23, "Kinh doanh mảng Nhà tài trợ" },
                    { 101, "Bán dịch vụ gian hàng, gói trưng bày và quyền lợi cho các nhà triển lãm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7635), 23, "Kinh doanh triển lãm" },
                    { 102, "Các chuyên môn khác thuộc lĩnh vực Marketing, PR và Quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7636), 24, "Chuyên môn Marketing/PR/Quảng cáo khác" },
                    { 103, "Quản lý nhà cung cấp, đàm phán hợp đồng và tối ưu chi phí marketing.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7637), 24, "Vendor Management Executive/Supplier Relationship Management Executive" },
                    { 104, "Đại diện thương hiệu tại sự kiện, hỗ trợ quảng bá sản phẩm và dịch vụ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7637), 24, "PG" },
                    { 105, "Hỗ trợ quảng bá trực tiếp thông qua phát tờ rơi tại các khu vực chỉ định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7638), 24, "Nhân viên phát tờ rơi" },
                    { 106, "Tiếp nhận và hỗ trợ giải quyết nhu cầu, thắc mắc của khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7639), 25, "Chăm sóc khách hàng" },
                    { 107, "Các nghiệp vụ khác liên quan đến dịch vụ và chăm sóc khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7640), 25, "Dịch vụ khách hàng/Chăm sóc khách hàng khác" },
                    { 108, "Tiếp nhận cuộc gọi, giải đáp thông tin và hỗ trợ sự cố cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7640), 25, "Call Center/Trực tổng đài" },
                    { 109, "Phản hồi tin nhắn và hỗ trợ khách hàng qua fanpage hoặc kênh mạng xã hội.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7641), 25, "Trực page" },
                    { 110, "Cải thiện trải nghiệm, đo lường mức độ hài lòng của khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7643), 25, "Customer Experience (Trải nghiệm khách hàng)" },
                    { 111, "Đồng hành với khách hàng để đảm bảo họ đạt được mục tiêu khi sử dụng sản phẩm/dịch vụ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7644), 25, "Customer Success" },
                    { 112, "Quản lý gian hàng, xử lý đơn, tối ưu vận hành trên các sàn TMĐT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7644), 26, "Vận hành sàn thương mại điện tử" },
                    { 113, "Quản lý và tối ưu các quy trình vận hành nhằm hỗ trợ hoạt động kinh doanh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7645), 27, "Vận hành chung" },
                    { 114, "Gán nhãn, phân loại và xử lý dữ liệu phục vụ mô hình AI/ML.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7646), 27, "Data Labeling (Gán nhãn dữ liệu)" },
                    { 115, "Quản lý đội ngũ và tối ưu quy trình vận hành của doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7647), 28, "Quản lý/Trưởng phòng vận hành" },
                    { 116, "Lãnh đạo toàn bộ hoạt động vận hành và đảm bảo hiệu quả kinh doanh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7648), 28, "Giám đốc vận hành/COO" },
                    { 117, "Quản lý chiến lược dịch vụ, nâng cao trải nghiệm và sự hài lòng của khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7648), 28, "Giám đốc dịch vụ khách hàng" },
                    { 118, "Các vị trí khác thuộc mảng dịch vụ khách hàng và vận hành.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7649), 28, "Dịch vụ khách hàng - Vận hành khác" },
                    { 119, "Thực hiện quy trình tìm kiếm, sàng lọc và phỏng vấn ứng viên.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7650), 30, "Tuyển dụng" },
                    { 120, "Lập kế hoạch, triển khai và đánh giá chương trình đào tạo nhân sự.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7651), 30, "Đào tạo" },
                    { 121, "Quản lý hồ sơ, hợp đồng lao động và các nghiệp vụ nhân sự chung.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7652), 30, "Nhân sự tổng hợp" },
                    { 122, "Tính lương, thưởng, chế độ và xây dựng chính sách phúc lợi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7653), 30, "Payroll/C&B (Lương/Thưởng/Phúc lợi)" },
                    { 123, "Quản lý bộ phận nhân sự, xây dựng chiến lược và quy trình HR.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7654), 30, "Trưởng phòng nhân sự" },
                    { 124, "Kết nối chiến lược giữa phòng nhân sự và các bộ phận trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7654), 30, "Đối tác nhân sự (HRBP)" },
                    { 125, "Các chuyên môn khác trong lĩnh vực nhân sự và quản lý con người.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7655), 30, "Chuyên môn Nhân sự khác" },
                    { 126, "Lãnh đạo toàn bộ chiến lược nhân sự và văn hoá doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7656), 30, "Giám đốc nhân sự" },
                    { 127, "Xây dựng cấu trúc tổ chức, tối ưu nhân sự và chiến lược tăng trưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7657), 30, "Phát triển tổ chức" },
                    { 128, "Giải quyết tranh chấp, kỷ luật lao động và đảm bảo tuân thủ pháp luật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7657), 30, "Quan hệ lao động" },
                    { 129, "Hỗ trợ lãnh đạo trong công việc hằng ngày, sắp xếp lịch và xử lý thông tin.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7658), 31, "Trợ lý/Thư ký" },
                    { 130, "Thực hiện công tác hành chính kết hợp hỗ trợ các nghiệp vụ nhân sự.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7659), 31, "Hành chính nhân sự" },
                    { 131, "Quản lý văn phòng, hồ sơ, trang thiết bị và hỗ trợ các bộ phận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7660), 31, "Hành chính tổng hợp" },
                    { 132, "Tiếp nhận, kiểm tra và xử lý hồ sơ, giấy tờ hành chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7660), 31, "Xử lý hồ sơ" },
                    { 133, "Phụ trách đưa đón nhân viên, đối tác theo lịch công ty.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7661), 31, "Tài xế lái xe văn phòng" },
                    { 134, "Tiếp nhận khách, hỗ trợ thông tin và thực hiện công tác lễ tân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7662), 31, "Lễ tân/Đón tiếp" },
                    { 135, "Các nghiệp vụ khác thuộc lĩnh vực hành chính – văn phòng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7664), 31, "Chuyên môn Hành chính khác" },
                    { 136, "Quản lý toàn bộ công tác hành chính và điều phối hoạt động văn phòng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7664), 31, "Trưởng phòng hành chính" },
                    { 137, "Quản lý công văn đi – đến, lưu trữ hồ sơ và soạn thảo văn bản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7665), 31, "Văn thư" },
                    { 138, "Đưa đón lãnh đạo, đảm bảo an toàn và lịch trình di chuyển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7666), 31, "Lái xe cho sếp" },
                    { 139, "Thực hiện tư vấn pháp lý và đảm bảo tuân thủ pháp luật trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7667), 32, "Pháp chế" },
                    { 140, "Các nghiệp vụ pháp chế khác liên quan đến hợp đồng, tuân thủ và rủi ro pháp lý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7668), 32, "Chuyên môn Pháp chế khác" },
                    { 141, "Lãnh đạo bộ phận pháp chế, định hướng chiến lược pháp lý và quản trị rủi ro cho doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7668), 32, "Giám đốc pháp chế" },
                    { 142, "Các chuyên môn khác thuộc nhóm Nhân sự, Hành chính và Pháp chế trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7669), 33, "Chuyên môn Nhân sự/Hành chính/Pháp chế khác" },
                    { 143, "Phát triển và duy trì phần mềm theo quy trình kỹ thuật phần mềm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7670), 34, "Software Engineer" },
                    { 144, "Xây dựng API, dịch vụ backend và hệ thống xử lý dữ liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7671), 34, "Backend Developer" },
                    { 145, "Phát triển cả frontend và backend, xây dựng hệ thống hoàn chỉnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7671), 34, "Fullstack Developer" },
                    { 146, "Phát triển ứng dụng mobile trên iOS/Android.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7672), 34, "Mobile Developer" },
                    { 147, "Phát triển giao diện người dùng, tối ưu trải nghiệm và hiệu năng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7673), 34, "Frontend Developer" },
                    { 148, "Phát triển ứng dụng blockchain, smart contract và hệ thống phi tập trung.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7674), 34, "Blockchain Engineer" },
                    { 149, "Thực hiện kiểm thử phần mềm bằng phương pháp thủ công và tự động.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7674), 35, "Software Tester (Automation & Manual)" },
                    { 150, "Kiểm thử phần mềm thủ công, phát hiện lỗi và đảm bảo chất lượng sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7675), 35, "Manual Tester" },
                    { 151, "Viết script và sử dụng công cụ tự động để kiểm thử phần mềm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7676), 35, "Automation Tester" },
                    { 152, "Đảm bảo chất lượng sản phẩm thông qua quy trình kiểm thử và tiêu chuẩn QA.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7677), 35, "QA Engineer" },
                    { 153, "Giám sát quy trình sản xuất phần mềm và đảm bảo tuân thủ tiêu chuẩn chất lượng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7677), 35, "Process Quality Assurance (PQA)" },
                    { 154, "Kiểm thử tính năng, hiệu năng và trải nghiệm trong các sản phẩm game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7678), 35, "Game Tester" },
                    { 155, "Phát triển mô hình AI/ML, xây dựng hệ thống trí tuệ nhân tạo ứng dụng vào sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7679), 36, "AI Engineer" },
                    { 156, "Xử lý, phân loại và gán nhãn dữ liệu phục vụ huấn luyện mô hình AI.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7680), 36, "Data Labeling (Gán nhãn dữ liệu)" },
                    { 157, "Nghiên cứu thuật toán, mô hình và kiến trúc mới trong lĩnh vực trí tuệ nhân tạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7682), 36, "AI Researcher" },
                    { 158, "Phân tích dữ liệu để tạo insight, hỗ trợ quyết định kinh doanh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7683), 37, "Data Analyst" },
                    { 159, "Xây dựng hạ tầng dữ liệu, pipeline ETL và hệ thống xử lý dữ liệu lớn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7684), 37, "Data Engineer" },
                    { 160, "Ứng dụng thuật toán và mô hình thống kê để dự đoán và phân tích chuyên sâu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7684), 37, "Data Scientist" },
                    { 161, "Hỗ trợ kỹ thuật, xử lý sự cố phần mềm và phần cứng cho người dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7685), 38, "IT Helpdesk/IT Support" },
                    { 162, "Triển khai và vận hành hệ thống máy chủ, dịch vụ và hạ tầng CNTT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7686), 38, "System Engineer" },
                    { 163, "Tự động hóa triển khai, tối ưu hệ thống và quản lý CI/CD.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7686), 38, "DevOps Engineer" },
                    { 164, "Quản trị hệ thống, giám sát hoạt động và đảm bảo tính ổn định cho hạ tầng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7687), 38, "System Administrator" },
                    { 165, "Lắp đặt, bảo trì thiết bị CNTT và hỗ trợ vận hành hạ tầng kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7688), 38, "Kỹ thuật IT" },
                    { 166, "Thiết kế, vận hành và bảo trì hệ thống mạng trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7689), 38, "Network Engineer" },
                    { 167, "Quản trị cơ sở dữ liệu, tối ưu hiệu năng và đảm bảo an toàn dữ liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7689), 38, "Database Administrator (DBA)" },
                    { 168, "Triển khai và vận hành hệ thống cloud như AWS, Azure, GCP.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7690), 38, "Cloud Engineer" },
                    { 169, "Triển khai, giám sát và vận hành hệ thống an ninh mạng trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7691), 39, "Quản trị và vận hành bảo mật" },
                    { 170, "Phát hiện, phòng chống và xử lý các mối đe dọa liên quan đến an ninh mạng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7692), 39, "Chuyên viên Cyber Security" },
                    { 171, "Đảm bảo an toàn cho hệ thống CNTT bằng các giải pháp bảo mật kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7693), 39, "Chuyên viên IT Security" },
                    { 172, "Thực hiện PenTest, kiểm thử xâm nhập và đánh giá lỗ hổng bảo mật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7693), 39, "Kiểm thử và đánh giá bảo mật" },
                    { 173, "Đảm bảo hệ thống tuân thủ tiêu chuẩn bảo mật như ISO 27001, PCI-DSS.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7694), 39, "Tuân thủ và kiểm toán bảo mật" },
                    { 174, "Xây dựng chiến lược an ninh mạng và phân tích rủi ro bảo mật doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7695), 39, "Chiến lược và phân tích bảo mật" },
                    { 175, "Theo dõi, phát hiện và xử lý các hành vi gian lận và tấn công mạng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7696), 39, "Phòng chống lừa đảo và an ninh mạng" },
                    { 176, "Tích hợp bảo mật vào quy trình phát triển phần mềm (AppSec, DevSecOps).", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7696), 39, "Bảo mật ứng dụng và phát triển" },
                    { 177, "Ứng dụng mã hóa và giải pháp bảo vệ dữ liệu nhạy cảm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7697), 39, "Mã hóa và bảo mật dữ liệu" },
                    { 178, "Phát triển phần mềm nhúng cho vi điều khiển, thiết bị phần cứng và hệ thống IoT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7698), 40, "Embedded Engineer/Lập trình nhúng" },
                    { 179, "Thiết kế, phát triển và triển khai giải pháp IoT kết nối thiết bị và hệ thống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7699), 40, "Kỹ sư IoT (IoT Engineer)" },
                    { 180, "Quản lý dự án CNTT, điều phối đội ngũ và đảm bảo tiến độ - chất lượng sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7700), 41, "IT Project Manager" },
                    { 181, "Làm cầu nối giữa khách hàng và đội phát triển, phân tích yêu cầu và quản lý giao tiếp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7700), 41, "Kỹ sư cầu nối BrSE" },
                    { 182, "Thông dịch viên IT, hỗ trợ giao tiếp giữa các nhóm kỹ thuật và khách hàng nước ngoài.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7701), 41, "IT Comtor" },
                    { 183, "Dẫn dắt nhóm theo mô hình Agile/Scrum, tối ưu quy trình và loại bỏ cản trở.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7702), 41, "Scrum Master" },
                    { 184, "Dẫn dắt kỹ thuật, định hướng giải pháp và hỗ trợ đội ngũ phát triển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7703), 42, "Technical Leader" },
                    { 185, "Thiết kế kiến trúc tổng thể cho hệ thống, đảm bảo hiệu năng và khả năng mở rộng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7705), 42, "Solution Architect" },
                    { 186, "Quản lý đội kỹ thuật, phân bổ nguồn lực và giám sát tiến độ dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7705), 42, "Technical Manager" },
                    { 187, "Thiết kế kiến trúc ứng dụng phần mềm, đảm bảo chất lượng và tính ổn định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7706), 42, "Software Architect" },
                    { 188, "Lãnh đạo chiến lược công nghệ, định hướng giải pháp và đổi mới sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7707), 42, "Chief Technology Officer (CTO)" },
                    { 189, "Quản lý toàn bộ bộ phận kỹ thuật và phát triển sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7708), 42, "Head of Engineering" },
                    { 190, "Thiết kế và tối ưu kiến trúc hệ thống CNTT quy mô lớn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7708), 42, "System Architect" },
                    { 191, "Quản lý hệ thống thông tin doanh nghiệp và chiến lược công nghệ dài hạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7709), 42, "Chief Information Officer (CIO)" },
                    { 192, "Thiết kế giao diện và trải nghiệm người dùng cho sản phẩm số.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7710), 43, "UI/UX Design" },
                    { 193, "Thiết kế hình ảnh, ấn phẩm và đồ họa phục vụ sản phẩm phần mềm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7711), 43, "Thiết kế đồ họa (Graphic Design)" },
                    { 194, "Thiết kế tương tác để tối ưu trải nghiệm sử dụng sản phẩm số.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7711), 43, "Interaction Designer" },
                    { 195, "Thiết kế chuyển động, animation cho giao diện và sản phẩm kỹ thuật số.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7712), 43, "Animation Design" },
                    { 196, "Thiết kế mô hình 3D phục vụ game, ứng dụng và sản phẩm phần mềm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7713), 43, "3D Modeler" },
                    { 197, "Phân tích yêu cầu, tối ưu quy trình và làm cầu nối giữa nghiệp vụ và kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7714), 44, "Business Analyst (Phân tích nghiệp vụ)" },
                    { 198, "Quản lý sản phẩm, xây dựng roadmap và phối hợp đội ngũ để phát triển tính năng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7714), 44, "Product Owner/Product Manager" },
                    { 199, "Phân tích dữ liệu sản phẩm, nghiên cứu thị trường và đề xuất cải tiến.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7715), 44, "Product Analyst/Research" },
                    { 200, "Thiết kế gameplay, cơ chế, cốt truyện và trải nghiệm game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7716), 45, "Game Design" },
                    { 201, "Lập trình và phát triển tính năng trong trò chơi trên nhiều nền tảng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7717), 45, "Game Developer" },
                    { 202, "Các vị trí khác thuộc lĩnh vực phát triển game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7717), 45, "Vị trí Game Development khác" },
                    { 203, "Thiết kế ý tưởng nhân vật, bối cảnh và đồ họa cho game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7718), 45, "Concept Artist" },
                    { 204, "Phát triển ứng dụng và trò chơi sử dụng công nghệ AR/VR.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7719), 45, "AR/VR Developer" },
                    { 205, "Tư vấn và bán các giải pháp phần mềm cho doanh nghiệp và cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7720), 46, "Kinh doanh phần mềm" },
                    { 206, "Bán dịch vụ domain, hosting, server và giải pháp hạ tầng IT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7720), 46, "Kinh doanh Domain/Hosting/Server" },
                    { 207, "Các hoạt động kinh doanh liên quan đến sản phẩm và dịch vụ IT khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7721), 46, "Sales IT Phần mềm khác" },
                    { 208, "Các chuyên môn khác thuộc lĩnh vực CNTT không nằm trong nhóm cụ thể.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7722), 47, "Chuyên môn Công nghệ thông tin khác" },
                    { 209, "Tư vấn giải pháp CNTT và hỗ trợ doanh nghiệp triển khai công nghệ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7723), 47, "IT Consultant" },
                    { 210, "Tư vấn và bán giải pháp kỹ thuật, thiết bị và hệ thống IT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7724), 47, "Bán hàng kỹ thuật IT" },
                    { 211, "Phát triển và vận hành hệ thống thông tin địa lý (GIS).", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7725), 47, "GIS Engineer" },
                    { 212, "Thực hiện may mặc, vận hành máy may công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7726), 48, "Công nhân may" },
                    { 213, "Gia công, lắp ráp và vận hành thiết bị cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7754), 48, "Công nhân cơ khí" },
                    { 214, "Thi công công trình, vận hành máy và hỗ trợ xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7755), 48, "Công nhân xây dựng" },
                    { 215, "Làm việc theo thời vụ trong các nhà máy hoặc công trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7755), 48, "Công nhân thời vụ" },
                    { 216, "Bốc xếp, vận chuyển và sắp xếp hàng hóa trong kho/xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7756), 48, "Công nhân bốc xếp hàng hóa" },
                    { 217, "Đóng gói sản phẩm theo quy trình của nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7757), 48, "Công nhân đóng gói hàng hóa" },
                    { 218, "Vệ sinh môi trường, thu gom rác và xử lý rác thải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7758), 48, "Công nhân môi trường" },
                    { 219, "Chăm sóc vật nuôi và hỗ trợ công việc tại trang trại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7759), 48, "Công nhân chăn nuôi" },
                    { 220, "Vận hành máy sản xuất nước đá và đóng gói thành phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7759), 48, "Công nhân làm nước đá" },
                    { 221, "Gia công, cắt và lắp ráp các sản phẩm từ gỗ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7760), 48, "Công nhân xưởng gỗ" },
                    { 222, "Sản xuất, đóng gói và kiểm tra chất lượng bao bì.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7761), 48, "Công nhân bao bì" },
                    { 223, "Lắp ráp linh kiện điện tử và kiểm tra chất lượng sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7762), 48, "Công nhân điện tử" },
                    { 224, "Tham gia dây chuyền sản xuất trong nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7762), 48, "Công nhân sản xuất" },
                    { 225, "Vận hành máy ép nhựa và kiểm tra sản phẩm đầu ra.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7763), 48, "Công nhân ép nhựa" },
                    { 226, "Gia công, sản xuất và hoàn thiện các sản phẩm giày da.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7764), 48, "Công nhân giày da" },
                    { 227, "Vận hành máy móc sản xuất theo quy trình tiêu chuẩn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7765), 48, "Công nhân vận hành máy" },
                    { 228, "Khai thác, vận chuyển và xử lý than theo quy định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7765), 48, "Công nhân khai thác than" },
                    { 229, "Lắp ráp linh kiện và sản phẩm theo quy trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7766), 48, "Công nhân lắp ráp" },
                    { 230, "Gấp, phân loại và đóng kiện quần áo trong xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7767), 48, "Công nhân xếp quần áo" },
                    { 231, "Các công việc công nhân phổ thông khác theo nhu cầu doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7768), 48, "Việc làm Công nhân khác" },
                    { 232, "Lái taxi, đưa đón khách theo lộ trình được phân công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7769), 49, "Tài xế taxi" },
                    { 233, "Lái các loại xe theo tiêu chuẩn bằng B2, phục vụ vận tải hoặc cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7769), 49, "Tài xế B2" },
                    { 234, "Vận chuyển hàng hóa bằng xe tải trong và ngoài tỉnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7770), 49, "Tài xế xe tải" },
                    { 235, "Hỗ trợ tài xế bốc xếp hàng hóa và quản lý lộ trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7772), 49, "Phụ xe" },
                    { 236, "Đưa đón lãnh đạo, đảm bảo an toàn và đúng lịch trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7773), 49, "Lái xe cho sếp" },
                    { 237, "Chạy xe công nghệ như Grab, Gojek, Be để đưa đón khách hoặc giao hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7773), 49, "Tài xế công nghệ" },
                    { 238, "Vận hành xe container, vận chuyển hàng hóa nặng và kích thước lớn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7774), 49, "Tài xế container" },
                    { 239, "Lái xe phục vụ nội bộ công ty và các chuyến công tác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7775), 49, "Tài xế lái xe văn phòng" },
                    { 240, "Lái xe chở khách trên các tuyến cố định hoặc hợp đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7777), 49, "Tài xế xe khách" },
                    { 241, "Vận hành xe nâng để di chuyển và sắp xếp hàng hóa trong kho/xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7777), 49, "Tài xế lái xe nâng" },
                    { 242, "Vận chuyển hàng hóa hoặc hành khách trên các tuyến đường dài liên tỉnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7778), 49, "Tài xế lái xe đường dài" },
                    { 243, "Quản lý xuất nhập kho, kiểm kê và sắp xếp hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7779), 50, "Nhân viên kho" },
                    { 244, "Giao nhận hàng hóa theo tuyến hoặc theo yêu cầu khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7780), 50, "Shipper (Nhân viên giao hàng)" },
                    { 245, "Bốc xếp, vận chuyển và sắp xếp hàng hóa trong kho hoặc xe tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7780), 50, "Công nhân bốc xếp hàng hóa" },
                    { 246, "Giao thư, bưu phẩm và xử lý các dịch vụ bưu chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7781), 50, "Bưu tá" },
                    { 247, "Phân loại, sắp xếp và kiểm tra hàng hóa theo quy trình kho vận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7782), 50, "Phân loại/Sắp xếp hàng hoá" },
                    { 248, "Đóng gói sản phẩm theo tiêu chuẩn đóng gói của kho hoặc nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7783), 50, "Công nhân đóng gói hàng hóa" },
                    { 249, "Sửa chữa, thay thế linh kiện và khắc phục lỗi điện thoại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7783), 60, "Sửa chữa điện thoại" },
                    { 250, "Đảm bảo an ninh, kiểm soát ra vào và bảo vệ tài sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7784), 60, "Bảo vệ" },
                    { 251, "Sửa chữa và bảo trì hệ thống điện, nước cho nhà ở hoặc công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7785), 60, "Sửa chữa/Bảo trì điện nước" },
                    { 252, "Sửa chữa, mở khóa và xử lý các vấn đề liên quan đến khóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7786), 60, "Thợ sửa khoá" },
                    { 253, "Lắp đặt và sửa chữa hệ thống điện dân dụng hoặc công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7786), 60, "Thợ điện" },
                    { 254, "Lắp đặt, sửa chữa và bảo trì máy lạnh, tủ lạnh và thiết bị điện lạnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7787), 60, "Thợ điện lạnh" },
                    { 255, "Kiểm tra, bảo trì hệ thống kỹ thuật và cơ sở vật chất tòa nhà.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7788), 60, "Bảo trì tòa nhà" },
                    { 256, "Sửa chữa và bảo trì xe máy hoặc ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7789), 60, "Thợ sửa xe" },
                    { 257, "Vệ sinh và chăm sóc xe theo quy trình của cửa hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7790), 60, "Nhân viên rửa xe" },
                    { 258, "Sửa chữa và bảo trì máy tính, máy in và thiết bị văn phòng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7790), 60, "Sửa chữa máy tính và máy in" },
                    { 259, "Lắp đặt và bảo trì hệ thống thang máy trong các tòa nhà.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7791), 60, "Lắp đặt/bảo trì thang máy" },
                    { 260, "Các công việc khác thuộc nhóm bảo vệ, bảo trì và sửa chữa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7793), 60, "Việc làm Bảo vệ/Bảo trì/Sửa chữa khác" },
                    { 261, "Thực hiện vệ sinh văn phòng, nhà ở và khu vực làm việc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7794), 52, "Vệ sinh/Tạp vụ" },
                    { 262, "Hỗ trợ công việc nhà, dọn dẹp và chăm sóc sinh hoạt gia đình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7795), 52, "Giúp việc" },
                    { 263, "Chăm sóc trẻ nhỏ, hỗ trợ ăn uống và sinh hoạt hằng ngày.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7795), 52, "Bảo mẫu/Người trông trẻ" },
                    { 264, "Dọn dẹp, vệ sinh khu vực theo quy trình tiêu chuẩn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7796), 52, "Nhân viên dọn vệ sinh" },
                    { 265, "Các công việc vệ sinh, chăm sóc nhà cửa khác theo nhu cầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7797), 52, "Dịch vụ vệ sinh/nhà cửa khác" },
                    { 266, "Thực hiện phun xăm, điêu khắc và các kỹ thuật thẩm mỹ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7798), 53, "Phun xăm thẩm mỹ" },
                    { 267, "Thiết kế và xăm hình nghệ thuật theo yêu cầu khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7798), 53, "Thợ xăm (Tattoo Artist)" },
                    { 268, "Thực hiện các liệu trình chăm sóc da và thư giãn tại spa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7799), 53, "Kỹ thuật viên Spa" },
                    { 269, "Cắt, tạo kiểu và chăm sóc tóc cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7801), 53, "Thợ cắt tóc" },
                    { 270, "Làm móng, nối mi và các dịch vụ làm đẹp liên quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7802), 53, "Thợ nail/mi" },
                    { 271, "Thực hiện các liệu pháp massage thư giãn và trị liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7802), 53, "Nhân viên massage" },
                    { 272, "Các công việc khác thuộc lĩnh vực làm đẹp và chăm sóc sức khỏe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7803), 53, "Việc làm Chăm sóc sức khỏe/Làm đẹp khác" },
                    { 273, "Chế biến món ăn và quản lý quy trình bếp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7804), 54, "Đầu bếp" },
                    { 274, "Pha chế đồ uống và phục vụ tại quầy bar hoặc cà phê.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7805), 54, "Pha chế (Barista)" },
                    { 275, "Phục vụ khách hàng, nhận order và hỗ trợ vận hành nhà hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7805), 54, "Phục vụ" },
                    { 276, "Hỗ trợ đầu bếp sơ chế và chuẩn bị nguyên liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7806), 54, "Phụ bếp" },
                    { 277, "Làm bánh, chuẩn bị nguyên liệu và trang trí sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7807), 54, "Thợ làm bánh" },
                    { 278, "Các vị trí khác trong lĩnh vực nhà hàng và dịch vụ ăn uống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7808), 54, "Chuyên môn Nhà hàng/Dịch vụ ăn uống khác" },
                    { 279, "Thực hiện giặt, ủi và xử lý đồ vải trong khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7808), 55, "Giặt là" },
                    { 280, "Tiếp nhận khách, làm thủ tục check-in và check-out.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7809), 55, "Lễ tân/Đón tiếp" },
                    { 281, "Hỗ trợ vận chuyển hành lý và hướng dẫn khách trong khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7810), 55, "Bellman (nhân viên hành lý)" },
                    { 282, "Dọn dẹp phòng, thay vật dụng và đảm bảo tiêu chuẩn sạch sẽ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7811), 55, "Buồng phòng" },
                    { 283, "Nhận và đỗ xe cho khách tại khu vực khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7811), 55, "Nhân viên đỗ xe (Valet Parking)" },
                    { 284, "Giới thiệu sản phẩm, hỗ trợ bán hàng tại sự kiện hoặc điểm bán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7812), 56, "PG" },
                    { 285, "Nhập dữ liệu sản phẩm, đơn hàng hoặc thông tin bán hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7814), 56, "Nhập liệu" },
                    { 286, "Thanh toán, xử lý hóa đơn và hỗ trợ khách hàng tại quầy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7815), 56, "Thu ngân" },
                    { 287, "Tư vấn và chăm sóc khách hàng qua fanpage, chat.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7815), 56, "Trực page" },
                    { 288, "Bán hàng, trưng bày, kiểm hàng trong siêu thị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7816), 56, "Nhân viên siêu thị" },
                    { 289, "Phục vụ và hỗ trợ khách hàng tại cửa hàng tiện lợi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7817), 56, "Bán hàng siêu thị/cửa hàng tiện ích/tiện lợi" },
                    { 290, "Phát tờ rơi quảng bá sản phẩm/dịch vụ tại các khu vực đông người.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7818), 56, "Nhân viên phát tờ rơi" },
                    { 291, "Tư vấn và bán sản phẩm điện thoại, phụ kiện công nghệ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7818), 56, "Bán hàng điện thoại" },
                    { 292, "Bơm xăng, hỗ trợ khách hàng và xử lý giao dịch tại trạm xăng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7819), 56, "Nhân viên cây xăng" },
                    { 293, "May mặc, vận hành máy may công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7820), 57, "Công nhân may" },
                    { 294, "Thiết kế và cắm hoa nghệ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7821), 57, "Thợ cắm hoa" },
                    { 295, "Cắt vải theo mẫu, hỗ trợ quy trình may mặc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7821), 57, "Thợ cắt vải" },
                    { 296, "Làm đồ thủ công, mỹ nghệ, sản phẩm truyền thống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7822), 57, "Thợ thủ công mỹ nghệ" },
                    { 297, "Gia công kim loại và linh kiện cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7823), 58, "Gia công cơ khí" },
                    { 298, "Hàn, gò và lắp ghép các cấu kiện kim loại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7824), 58, "Thợ hàn" },
                    { 299, "Vận hành máy và sản xuất linh kiện cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7824), 58, "Công nhân cơ khí" },
                    { 300, "Tiện chi tiết kim loại theo bản vẽ kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7825), 58, "Thợ tiện" },
                    { 301, "Khoan, tạo lỗ trên vật liệu theo yêu cầu kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7826), 58, "Thợ khoan" },
                    { 302, "Mài, chỉnh sửa và hoàn thiện bề mặt chi tiết.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7827), 58, "Thợ mài" },
                    { 303, "Phay chi tiết kim loại bằng máy phay công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7827), 58, "Thợ phay" },
                    { 304, "Các nghiệp vụ gia công cơ khí khác theo yêu cầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7828), 58, "Thợ Gia công cơ khí khác" },
                    { 305, "Thi công xây dựng, trát, ốp lát và hoàn thiện công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7829), 59, "Thợ xây/Thợ nề/Thợ hồ" },
                    { 306, "Gia công, lắp đặt và sửa chữa đồ gỗ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7830), 59, "Thợ mộc" },
                    { 307, "Sơn, bả và hoàn thiện bề mặt công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7830), 59, "Thợ sơn" },
                    { 308, "Lắp đặt cửa nhôm, vách kính và các sản phẩm liên quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7831), 59, "Thợ nhôm kính" },
                    { 309, "Các công việc xây dựng khác theo nhu cầu công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7832), 59, "Thợ xây dựng khác" },
                    { 310, "Thực hiện phân tích tài chính, quản lý ngân sách và kế hoạch tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7835), 60, "Chuyên môn Tài chính" },
                    { 311, "Lập kế hoạch, dự báo và phân bổ nguồn lực tài chính cho doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7836), 60, "Hoạch định tài chính" },
                    { 312, "Làm việc tại các tổ chức tài chính như quỹ đầu tư, công ty chứng khoán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7836), 60, "Định chế tài chính" },
                    { 313, "Chịu trách nhiệm kiểm soát nội bộ và lập báo cáo tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7837), 60, "Kiểm soát và báo cáo tài chính" },
                    { 314, "Tư vấn giải pháp tài chính cho doanh nghiệp hoặc cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7838), 60, "Tư vấn tài chính" },
                    { 315, "Quản lý chiến lược tài chính và điều hành nguồn vốn doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7839), 60, "Giám đốc tài chính" },
                    { 316, "Tìm kiếm và quản lý nguồn vốn từ các nhà đầu tư hoặc tổ chức tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7839), 60, "Huy động vốn" },
                    { 317, "Tiếp nhận giao dịch, hỗ trợ khách hàng tại quầy ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7840), 61, "Giao dịch viên" },
                    { 318, "Quản lý, thu hồi và xử lý các khoản nợ xấu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7841), 61, "Chuyên viên xử lý nợ" },
                    { 319, "Quản lý và phát triển các hoạt động kinh doanh nguồn vốn ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7842), 61, "Kinh doanh nguồn vốn" },
                    { 320, "Thực hiện giao dịch ngoại hối, vàng và các công cụ phái sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7842), 61, "Kinh doanh ngoại hối, vàng, phái sinh" },
                    { 321, "Xử lý L/C, nhờ thu và các nghiệp vụ tài trợ thương mại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7843), 61, "Tài trợ thương mại" },
                    { 322, "Quản lý mảng khách hàng cá nhân trong ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7844), 61, "Giám đốc khối khách hàng cá nhân" },
                    { 323, "Quản lý mảng khách hàng doanh nghiệp và các dịch vụ liên quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7845), 61, "Giám đốc khối khách hàng doanh nghiệp" },
                    { 324, "Lãnh đạo hoạt động kinh doanh nguồn vốn và giao dịch thị trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7846), 61, "Giám đốc khối nguồn vốn và thị trường" },
                    { 325, "Quản lý hoạt động kinh doanh bảo hiểm tại ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7846), 61, "Giám đốc kinh doanh bảo hiểm" },
                    { 326, "Điều hành toàn bộ hoạt động của chi nhánh ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7847), 61, "Giám đốc ngân hàng" },
                    { 327, "Tư vấn, chăm sóc và phát triển khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7848), 61, "Quan hệ khách hàng cá nhân/doanh nghiệp" },
                    { 328, "Tư vấn các sản phẩm vay trả góp cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7849), 61, "Tư vấn trả góp" },
                    { 329, "Đánh giá hồ sơ tín dụng và khả năng trả nợ của khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7849), 61, "Thẩm định tín dụng" },
                    { 330, "Xử lý thủ tục, hồ sơ và giải ngân khoản vay.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7850), 61, "Tác nghiệp tín dụng" },
                    { 331, "Đảm bảo hoạt động tuân thủ quy định pháp lý và nội bộ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7851), 61, "Kiểm soát tuân thủ" },
                    { 332, "Các nghiệp vụ khác thuộc lĩnh vực ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7852), 61, "Chuyên môn Ngân hàng khác" },
                    { 333, "Phân tích cổ phiếu, thị trường và đưa ra khuyến nghị đầu tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7852), 62, "Phân tích đầu tư chứng khoán" },
                    { 334, "Quản lý tài sản và tối ưu lợi nhuận cho các danh mục đầu tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7853), 62, "Quản lý danh mục đầu tư" },
                    { 335, "Tư vấn giao dịch và chiến lược đầu tư cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7855), 62, "Tư vấn chứng khoán" },
                    { 336, "Các nghiệp vụ khác trong lĩnh vực chứng khoán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7856), 62, "Chuyên môn Chứng khoán khác" },
                    { 337, "Đánh giá và kiểm soát rủi ro tài chính, thị trường và hoạt động.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7857), 63, "Quản trị rủi ro" },
                    { 338, "Theo dõi và đảm bảo tuân thủ quy định pháp luật và nội bộ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7857), 63, "Kiểm soát tuân thủ" },
                    { 339, "Giám sát giao dịch và phòng chống rửa tiền theo chuẩn AML.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7858), 63, "Phòng chống rửa tiền" },
                    { 340, "Tư vấn pháp lý và đảm bảo tuân thủ pháp luật trong hoạt động tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7859), 63, "Pháp chế" },
                    { 341, "Đánh giá khách hàng và quyết định cấp tín dụng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7874), 63, "Thẩm định tín dụng" },
                    { 342, "Đảm bảo khả năng thanh toán và cân đối nguồn vốn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7875), 63, "Quản lý thanh khoản" },
                    { 343, "Định giá tài sản đảm bảo theo tiêu chuẩn thẩm định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7876), 63, "Định giá tài sản" },
                    { 344, "Quản lý và thu hồi các khoản nợ của khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7877), 63, "Thu hồi nợ" },
                    { 345, "Quản lý tuân thủ và pháp lý trong doanh nghiệp tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7877), 63, "Giám đốc tuân thủ và pháp lý" },
                    { 346, "Lãnh đạo chiến lược quản trị rủi ro tổng thể.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7878), 63, "Giám đốc quản lý rủi ro (CRO)" },
                    { 347, "Các nghiệp vụ khác thuộc thẩm định và quản trị rủi ro.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7879), 63, "Chuyên môn Thẩm định và quản trị rủi ro khác" },
                    { 348, "Phân tích cơ hội đầu tư và thị trường tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7880), 64, "Phân tích đầu tư" },
                    { 349, "Xử lý tài trợ thương mại như L/C và nhờ thu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7880), 64, "Tài trợ thương mại" },
                    { 350, "Thực hiện giao dịch M&A và đánh giá doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7881), 64, "Mua bán và sáp nhập (M&A)" },
                    { 351, "Quản lý thông tin và truyền thông với nhà đầu tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7882), 64, "Quan hệ nhà đầu tư" },
                    { 352, "Quản lý danh mục tài sản doanh nghiệp hoặc cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7883), 64, "Quản lý tài sản" },
                    { 353, "Điều hành quỹ đầu tư và tối ưu lợi nhuận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7883), 64, "Quản lý danh mục/quỹ" },
                    { 354, "Lãnh đạo hoạt động đầu tư, chiến lược tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7884), 64, "Giám đốc/Phó giám đốc đầu tư" },
                    { 355, "Cung cấp giải pháp đầu tư và hoạch định tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7885), 64, "Tư vấn đầu tư" },
                    { 356, "Các hoạt động khác thuộc đầu tư và tài trợ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7886), 64, "Chuyên môn đầu tư và tài trợ khác" },
                    { 357, "Xử lý hồ sơ bồi thường và giải quyết quyền lợi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7887), 65, "Bồi thường bảo hiểm" },
                    { 358, "Tính toán phí bảo hiểm dựa trên rủi ro và dữ liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7887), 65, "Định phí bảo hiểm" },
                    { 359, "Xem xét và phát hành hợp đồng cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7888), 65, "Thẩm định và phát hành hợp đồng bảo hiểm" },
                    { 360, "Theo dõi, cập nhật và xử lý thông tin hợp đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7890), 65, "Quản lý hợp đồng bảo hiểm" },
                    { 361, "Tư vấn sản phẩm bảo hiểm nhân thọ và phi nhân thọ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7891), 65, "Tư vấn bảo hiểm" },
                    { 362, "Phân phối sản phẩm bảo hiểm qua kênh ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7891), 65, "Bancassurance" },
                    { 363, "Các nghiệp vụ khác trong lĩnh vực bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7892), 65, "Chuyên môn Bảo hiểm khác" },
                    { 364, "Tư vấn quyền lợi và hỗ trợ ký hợp đồng bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7893), 66, "Tư vấn bảo hiểm" },
                    { 365, "Chăm sóc và phát triển khách hàng tài chính/ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7894), 66, "Quan hệ khách hàng cá nhân/doanh nghiệp" },
                    { 366, "Tư vấn các sản phẩm vay mua sắm trả góp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7895), 66, "Tư vấn trả góp" },
                    { 367, "Tư vấn các gói vay vốn và sản phẩm tín dụng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7895), 66, "Tư vấn tín dụng" },
                    { 368, "Bán bảo hiểm thông qua kênh ngân hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7896), 66, "Bancassurance" },
                    { 369, "Tư vấn giải pháp đầu tư tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7897), 66, "Tư vấn đầu tư" },
                    { 370, "Hỗ trợ giao dịch và chiến lược đầu tư chứng khoán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7898), 66, "Tư vấn chứng khoán" },
                    { 371, "Giao dịch FX, vàng và các sản phẩm phái sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7898), 66, "Kinh doanh ngoại hối, vàng, phái sinh" },
                    { 372, "Phân tích tài chính và đưa ra giải pháp tối ưu cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7899), 66, "Tư vấn tài chính" },
                    { 373, "Các hoạt động kinh doanh khác thuộc nhóm tài chính - ngân hàng - bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7900), 66, "Sales Tài chính/Ngân hàng/Bảo hiểm khác" },
                    { 374, "Lập kế hoạch tài chính, theo dõi ngân sách và phân tích hiệu quả.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7901), 67, "Chuyên viên kế hoạch" },
                    { 375, "Các chuyên môn khác thuộc lĩnh vực tài chính, ngân hàng và bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7901), 67, "Chuyên môn Tài chính/Ngân hàng/Bảo hiểm khác" },
                    { 376, "Điều hành hoạt động tòa nhà, đảm bảo dịch vụ và an ninh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7902), 68, "Quản lý tòa nhà" },
                    { 377, "Bảo trì hệ thống kỹ thuật và cơ sở vật chất trong tòa nhà.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7903), 68, "Bảo trì tòa nhà" },
                    { 378, "Giám sát đội ngũ kỹ thuật và các hoạt động bảo trì.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7904), 68, "Giám sát bảo trì tòa nhà" },
                    { 379, "Quản lý và chăm sóc cảnh quan, cây xanh xung quanh dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7905), 68, "Nhân viên cảnh quan" },
                    { 380, "Bảo trì, kiểm định hệ thống phòng cháy chữa cháy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7905), 68, "Bảo trì PCCC" },
                    { 381, "Theo dõi, vận hành hệ thống kỹ thuật trong tòa nhà.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7906), 68, "Vận hành tòa nhà" },
                    { 382, "Các nghiệp vụ khác trong quản lý và vận hành bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7907), 68, "Quản lý vận hành bất động sản khác" },
                    { 383, "Thiết kế và quy hoạch đô thị, hạ tầng và dự án bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7908), 69, "Quy hoạch và thiết kế đô thị" },
                    { 384, "Thực hiện hồ sơ đấu thầu và quản lý quy trình đấu thầu dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7908), 69, "Đấu thầu bất động sản" },
                    { 385, "Điều phối, giám sát tiến độ và chất lượng dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7910), 69, "Quản lý dự án bất động sản" },
                    { 386, "Phân tích, lập kế hoạch và quy hoạch dự án bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7911), 69, "Quy hoạch bất động sản" },
                    { 387, "Xây dựng và phát triển quỹ đất phục vụ dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7912), 69, "Phát triển mặt bằng" },
                    { 388, "Quản lý và triển khai công tác bồi thường, giải tỏa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7912), 69, "Giải phóng mặt bằng" },
                    { 389, "Định giá bất động sản theo tiêu chuẩn thẩm định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7913), 69, "Thẩm định giá bất động sản" },
                    { 390, "Lập kế hoạch chiến lược cho các dự án bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7914), 69, "Giám đốc kế hoạch bất động sản" },
                    { 391, "Quản lý chiến lược đấu thầu và phát triển dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7915), 69, "Giám đốc đấu thầu bất động sản" },
                    { 392, "Lãnh đạo triển khai và vận hành dự án bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7916), 69, "Giám đốc dự án bất động sản" },
                    { 393, "Tư vấn, giới thiệu và môi giới giao dịch bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7917), 70, "Sales bất động sản/Môi giới bất động sản" },
                    { 394, "Các hoạt động kinh doanh và môi giới bất động sản khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7918), 70, "Sales Bất động sản khác" },
                    { 395, "Các chuyên môn khác trong lĩnh vực bất động sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7918), 71, "Chuyên môn Bất động sản khác" },
                    { 396, "Điều phối, giám sát tiến độ và chất lượng dự án xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7919), 72, "Quản lý dự án thi công xây dựng" },
                    { 397, "Lập dự toán chi phí, khối lượng và giá thành công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7920), 72, "Dự toán công trình" },
                    { 398, "Giám sát thi công, đảm bảo đúng kỹ thuật và an toàn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7921), 72, "Giám sát dự án/công trình/thi công" },
                    { 399, "Quản lý hồ sơ, văn bản và hỗ trợ hành chính công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7921), 72, "Thư ký công trình" },
                    { 400, "Chuẩn bị hồ sơ, nghiệm thu và pháp lý công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7922), 72, "Nhân viên hồ sơ xây dựng" },
                    { 401, "Quản lý vật tư, thiết bị và cung ứng cho công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7923), 72, "Nhân viên vật tư" },
                    { 402, "Đo đạc, khảo sát hiện trường phục vụ thi công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7924), 72, "Nhân viên trắc đạc" },
                    { 403, "Đảm bảo an toàn lao động, giám sát PCCC và nội quy công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7924), 72, "Kỹ sư an toàn lao động (HSE)" },
                    { 404, "Theo dõi thi công, xử lý kỹ thuật tại công trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7925), 72, "Kỹ sư hiện trường" },
                    { 405, "Điều hành đội thi công, phân công công việc cho tổ đội.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7926), 72, "Quản đốc công trình" },
                    { 406, "Kiểm soát chất lượng, nghiệm thu và tiêu chuẩn kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7926), 72, "Quản lý chất lượng công trình" },
                    { 407, "Khảo sát địa chất, đánh giá nền đất và khả năng thi công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7927), 72, "Kỹ sư địa chất" },
                    { 408, "Chuẩn bị hồ sơ và tham gia đấu thầu dự án xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7928), 72, "Đấu thầu xây dựng" },
                    { 409, "Quản lý, bảo dưỡng và vận hành thiết bị thi công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7929), 72, "Quản lý thiết bị công trình" },
                    { 410, "Giám sát thi công hoàn thiện và nội thất công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7930), 72, "Giám sát thi công nội thất" },
                    { 411, "Các nghiệp vụ khác trong quản lý dự án xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7931), 72, "Quản lý dự án xây dựng khác" },
                    { 412, "Thiết kế kết cấu và tính toán an toàn công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7932), 73, "Kỹ sư kết cấu công trình" },
                    { 413, "Thiết kế và giám sát hệ thống hạ tầng đô thị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7933), 73, "Kỹ sư hạ tầng đô thị" },
                    { 414, "Thiết kế sân vườn, cảnh quan và không gian ngoại thất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7933), 73, "Thiết kế cảnh quan" },
                    { 415, "Thiết kế và giám sát thi công nội thất công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7934), 73, "Thiết kế nội thất" },
                    { 416, "Thiết kế kiến trúc tổng thể và công năng công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7935), 73, "Kiến trúc sư" },
                    { 417, "Thiết kế, thi công và giám sát các công trình xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7935), 73, "Kỹ sư xây dựng" },
                    { 418, "Thiết kế và triển khai hệ thống điện nhẹ (ELV).", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7936), 73, "Kỹ sư hệ thống điện nhẹ" },
                    { 419, "Thiết kế, giám sát hệ thống cơ điện M&E.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7937), 73, "Kỹ sư cơ điện" },
                    { 420, "Thiết kế và giám sát hệ thống cấp thoát nước.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7938), 73, "Kỹ sư cấp thoát nước" },
                    { 421, "Thiết kế, lắp đặt và giám sát hệ thống điều hòa HVAC.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7938), 73, "Kỹ sư HVAC" },
                    { 422, "Thiết kế và triển khai bản vẽ nhôm kính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7939), 73, "Kỹ sư thiết kế nhôm kính" },
                    { 423, "Triển khai mô hình thông tin công trình (BIM).", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7940), 73, "BIM Engineer" },
                    { 424, "Thiết kế và giám sát hệ thống phòng cháy chữa cháy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7941), 73, "Kỹ sư PCCC" },
                    { 425, "Thiết kế và thi công công trình giao thông, cầu đường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7941), 73, "Kỹ sư cầu đường" },
                    { 426, "Các công việc khác thuộc nhóm thiết kế và kiến trúc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7942), 73, "Chuyên môn Thiết kế và Kiến trúc khác" },
                    { 427, "Sửa chữa và bảo trì hệ thống điện, nước trong công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7943), 74, "Sửa chữa/Bảo trì điện nước" },
                    { 428, "Lắp đặt và sửa chữa thiết bị điện lạnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7944), 74, "Thợ điện lạnh" },
                    { 429, "Hàn và gia công kim loại trong thi công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7944), 74, "Thợ hàn" },
                    { 430, "Gia công và lắp đặt các kết cấu gỗ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7945), 74, "Thợ mộc" },
                    { 431, "Sơn, bả và hoàn thiện công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7946), 74, "Thợ sơn" },
                    { 432, "Lắp đặt và bảo trì các hệ thống thang máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7946), 74, "Lắp đặt/bảo trì thang máy" },
                    { 433, "Xây dựng, trát và hoàn thiện công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7947), 74, "Thợ xây/Thợ nề/Thợ hồ" },
                    { 434, "Thi công và lắp đặt các sản phẩm nhôm kính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7948), 74, "Thợ nhôm kính" },
                    { 435, "Tham gia thi công công trình theo phân công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7949), 74, "Nhân viên thi công" },
                    { 436, "Làm việc thời vụ tại công trường xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7950), 74, "Công nhân thời vụ" },
                    { 437, "Khai thác và vận chuyển than.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7951), 74, "Công nhân khai thác than" },
                    { 438, "Gia công sản phẩm gỗ phục vụ xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7952), 74, "Công nhân xưởng gỗ" },
                    { 439, "Lắp ráp các bộ phận công trình theo hướng dẫn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7952), 74, "Công nhân lắp ráp" },
                    { 440, "Vận hành máy móc thiết bị trong thi công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7953), 74, "Công nhân vận hành máy" },
                    { 441, "Làm việc trong các hạng mục thi công xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7954), 74, "Công nhân xây dựng" },
                    { 442, "Các công việc khác thuộc nhóm xây dựng và cải tạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7955), 74, "Thợ xây dựng khác" },
                    { 443, "Các công việc công nhân phổ thông khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7955), 74, "Việc làm Công nhân khác" },
                    { 444, "Bán thiết bị, vật liệu phục vụ công trình xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7956), 75, "Kinh doanh thiết bị/vật liệu xây dựng" },
                    { 445, "Bán sản phẩm nội thất và vật liệu hoàn thiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7957), 75, "Kinh doanh nội thất" },
                    { 446, "Tư vấn giải pháp và thiết kế các hạng mục xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7957), 75, "Tư vấn thiết kế xây dựng" },
                    { 447, "Các công việc kinh doanh khác trong lĩnh vực xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7958), 75, "Sales Xây dựng khác" },
                    { 448, "Các chuyên môn khác thuộc lĩnh vực xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7959), 76, "Chuyên môn Xây dựng khác" },
                    { 449, "Tổng hợp số liệu và lập báo cáo tài chính cho doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7960), 77, "Kế toán tổng hợp" },
                    { 450, "Theo dõi chi phí, doanh thu và tài sản nội bộ công ty.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7960), 77, "Kế toán nội bộ" },
                    { 451, "Theo dõi và quản lý công nợ phải thu, phải trả.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7961), 77, "Kế toán công nợ" },
                    { 452, "Kê khai thuế và đảm bảo tuân thủ các quy định pháp luật về thuế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7962), 77, "Kế toán thuế" },
                    { 453, "Tính giá thành sản phẩm và phân tích chi phí sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7962), 77, "Kế toán chi phí/giá thành" },
                    { 454, "Theo dõi doanh thu bán hàng và xuất hóa đơn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8002), 77, "Kế toán bán hàng" },
                    { 455, "Hạch toán doanh thu và lập báo cáo liên quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8003), 77, "Kế toán doanh thu" },
                    { 456, "Quản lý dòng tiền, phân tích tài chính và lập báo cáo tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8004), 77, "Kế toán tài chính" },
                    { 457, "Theo dõi và hạch toán các hoạt động đầu tư tài chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8005), 77, "Kế toán đầu tư" },
                    { 458, "Quản lý và khấu hao tài sản cố định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8005), 77, "Kế toán tài sản cố định" },
                    { 459, "Theo dõi mua hàng, nhập kho và công nợ nhà cung cấp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8006), 77, "Kế toán mua hàng" },
                    { 460, "Xử lý các khoản thanh toán và đối soát chứng từ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8007), 77, "Kế toán thanh toán" },
                    { 461, "Theo dõi xuất nhập tồn và quản lý hàng hóa trong kho.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8008), 77, "Kế toán kho/nguyên vật liệu" },
                    { 462, "Tính lương, bảo hiểm và phúc lợi nhân viên.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8009), 77, "Kế toán tiền lương" },
                    { 463, "Phân tích chi phí – lợi nhuận và hỗ trợ ra quyết định quản trị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8010), 77, "Kế toán quản trị" },
                    { 464, "Quản lý bộ phận kế toán và kiểm soát tài chính doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8011), 77, "Kế toán trưởng" },
                    { 465, "Theo dõi chi phí và hồ sơ kế toán trong dự án xây dựng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8011), 77, "Kế toán công trình" },
                    { 466, "Hạch toán và theo dõi chi phí sản xuất theo từng công đoạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8012), 77, "Kế toán sản xuất" },
                    { 467, "Quản lý chi phí, ngân sách và báo cáo tài chính dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8013), 77, "Kế toán dự án" },
                    { 468, "Hạch toán hoạt động XNK và xử lý chứng từ hải quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8014), 77, "Kế toán xuất nhập khẩu" },
                    { 469, "Theo dõi giao dịch ngân hàng, đối chiếu và quản lý dòng tiền.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8015), 77, "Kế toán ngân hàng" },
                    { 470, "Quản lý tiền mặt và thực hiện thu – chi tại doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8016), 77, "Thủ quỹ" },
                    { 471, "Các công việc kế toán khác theo yêu cầu doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8017), 77, "Kế toán khác" },
                    { 472, "Thực hiện kiểm toán báo cáo tài chính và hệ thống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8017), 78, "Kiểm toán viên" },
                    { 473, "Đánh giá hệ thống kiểm soát nội bộ và rủi ro.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8018), 78, "Kiểm toán nội bộ" },
                    { 474, "Thực hiện kiểm toán cho khách hàng bên ngoài doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8019), 78, "Kiểm toán độc lập" },
                    { 475, "Quản lý nhóm kiểm toán và điều phối dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8020), 78, "Trưởng nhóm kiểm toán" },
                    { 476, "Các nghiệp vụ kiểm toán khác theo yêu cầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8020), 78, "Chuyên môn Kiểm toán khác" },
                    { 477, "Tư vấn, kê khai và xử lý các vấn đề liên quan đến thuế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8021), 79, "Chuyên viên thuế" },
                    { 478, "Các nghiệp vụ khác trong lĩnh vực thuế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8022), 79, "Chuyên môn Thuế khác" },
                    { 479, "Các chuyên môn khác trong lĩnh vực kế toán, kiểm toán và thuế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8022), 80, "Chuyên môn Kế toán/Kiểm toán/Thuế khác" },
                    { 480, "Thực hiện gia công và vận hành máy móc cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8023), 81, "Công nhân cơ khí" },
                    { 481, "Hàn, gò và gia công kim loại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8024), 81, "Thợ hàn" },
                    { 482, "Thực hiện phay chi tiết kim loại theo bản vẽ kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8025), 81, "Thợ phay" },
                    { 483, "Mài và hoàn thiện bề mặt chi tiết cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8026), 81, "Thợ mài" },
                    { 484, "Tiện chi tiết kim loại theo yêu cầu kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8027), 81, "Thợ tiện" },
                    { 485, "Khoan lỗ và gia công chi tiết cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8027), 81, "Thợ khoan" },
                    { 486, "Các công việc khác trong lĩnh vực gia công cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8028), 81, "Thợ Gia công cơ khí khác" },
                    { 487, "Tiện chi tiết máy và gia công kim loại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8029), 82, "Thợ tiện" },
                    { 488, "Lập trình máy CNC và tối ưu quy trình gia công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8030), 82, "Kỹ sư lập trình máy" },
                    { 489, "Thiết kế và vận hành hệ thống tự động hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8030), 82, "Kỹ sư tự động hóa" },
                    { 490, "Thiết kế và chế tạo chi tiết, máy móc cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8031), 82, "Kỹ sư cơ khí" },
                    { 491, "Thiết kế kết cấu và bộ phận máy công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8032), 82, "Kỹ sư kết cấu máy" },
                    { 492, "Xây dựng và tối ưu quy trình sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8032), 82, "Kỹ sư quy trình" },
                    { 493, "Thiết kế, chế tạo và bảo trì khuôn mẫu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8033), 82, "Kỹ sư khuôn mẫu" },
                    { 494, "Thiết kế 3D, mô phỏng và phân tích sản phẩm cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8034), 82, "Kỹ sư thiết kế cơ khí" },
                    { 495, "Nghiên cứu và ứng dụng vật liệu mới vào sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8035), 82, "Kỹ sư vật liệu" },
                    { 496, "Tối ưu sản xuất, công đoạn và hiệu suất hệ thống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8035), 82, "Kỹ sư công nghiệp (IE)" },
                    { 497, "Thiết kế hệ thống điều hòa và thông gió cho nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8036), 82, "Kỹ sư thiết kế HVAC" },
                    { 498, "Các chuyên môn khác trong lĩnh vực thiết kế–chế tạo máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8037), 82, "Chuyên môn Thiết kế/chế tạo máy khác" },
                    { 499, "Thực hiện thí nghiệm, kiểm nghiệm và phân tích hóa chất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8038), 83, "Kỹ thuật viên phòng thí nghiệm" },
                    { 500, "Nghiên cứu, phát triển và vận hành quy trình hóa học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8038), 83, "Kỹ sư hóa học" },
                    { 501, "Nghiên cứu, cải tiến sản phẩm thực phẩm, đồ uống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8039), 83, "Nghiên cứu và phát triển (R&D) thực phẩm/đồ uống" },
                    { 502, "Phát triển và thử nghiệm sản phẩm mỹ phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8040), 83, "Nghiên cứu và phát triển (R&D) mỹ phẩm" },
                    { 503, "Các chuyên môn khác trong ngành hóa chất – mỹ phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8040), 83, "Chuyên môn Hoá chất/Hoá mỹ phẩm khác" },
                    { 504, "Thiết kế rập và phát triển mẫu kỹ thuật cho may mặc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8041), 84, "Thiết kế rập" },
                    { 505, "Thiết kế hoa văn, màu sắc và chất liệu vải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8042), 84, "Thiết kế vải" },
                    { 506, "May sản phẩm theo quy trình công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8043), 84, "Công nhân may" },
                    { 507, "Cắt vải theo mẫu phục vụ sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8043), 84, "Thợ cắt vải" },
                    { 508, "Gấp, phân loại và đóng kiện quần áo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8044), 84, "Công nhân xếp quần áo" },
                    { 509, "Sản xuất và lắp ráp các sản phẩm giày da.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8045), 84, "Công nhân giày da" },
                    { 510, "Các vị trí khác thuộc ngành may mặc – da.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8045), 84, "Chuyên môn May mặc/Dệt may/Da khác" },
                    { 511, "Thiết kế cấu trúc và ngoại thất xe ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8046), 85, "Kỹ sư thiết kế ô tô" },
                    { 512, "Thiết kế và thử nghiệm khung gầm xe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8047), 85, "Kỹ sư khung gầm" },
                    { 513, "Lắp ráp linh kiện và hệ thống xe ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8049), 85, "Kỹ sư lắp ráp ô tô" },
                    { 514, "Các chuyên môn khác trong sản xuất ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8049), 85, "Chuyên môn R&D/Sản xuất ô tô khác" },
                    { 515, "Thiết kế hệ thống điện dân dụng và công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8050), 86, "Kỹ sư thiết kế điện" },
                    { 516, "Gia công và lắp đặt các sản phẩm gỗ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8051), 86, "Thợ mộc" },
                    { 517, "Sơn và hoàn thiện bề mặt công trình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8051), 86, "Thợ sơn" },
                    { 518, "Gia công và chế biến sản phẩm gỗ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8052), 86, "Công nhân xưởng gỗ" },
                    { 519, "Lắp ráp thiết bị, linh kiện hoặc sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8053), 86, "Công nhân lắp ráp" },
                    { 520, "Tham gia sản xuất giày da công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8054), 86, "Công nhân giày da" },
                    { 521, "Sản xuất và đóng gói bao bì sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8054), 86, "Công nhân bao bì" },
                    { 522, "Vận hành máy ép nhựa và kiểm tra sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8055), 86, "Công nhân ép nhựa" },
                    { 523, "Vận hành hệ thống sản xuất nước đá.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8056), 86, "Công nhân làm nước đá" },
                    { 524, "Tham gia dây chuyền sản xuất công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8057), 86, "Công nhân sản xuất" },
                    { 525, "Các công việc khác trong lĩnh vực kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8057), 86, "Thợ kỹ thuật khác" },
                    { 526, "Vận hành xe nâng trong kho/xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8058), 87, "Tài xế lái xe nâng" },
                    { 527, "Lái máy xúc, máy ủi, máy lu trong thi công.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8059), 87, "Tài xế lái máy công trình" },
                    { 528, "Vận hành thiết bị công trình và máy móc nặng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8059), 87, "Vận hành thiết bị nặng/phụ trợ" },
                    { 529, "Vận chuyển hàng hóa bằng xe tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8060), 87, "Tài xế xe tải" },
                    { 530, "Lái container vận chuyển hàng hóa nặng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8061), 87, "Tài xế container" },
                    { 531, "Các công việc vận hành thiết bị nặng khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8062), 87, "Vận hành thiết bị vận tải/thiết bị nặng khác" },
                    { 532, "Xây dựng quy trình và đảm bảo chất lượng sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8062), 88, "Quản lý chất lượng (QA)" },
                    { 533, "Kiểm tra và kiểm soát chất lượng sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8063), 88, "Kiểm soát chất lượng (QC)" },
                    { 534, "Kiểm nghiệm, phân tích chất lượng sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8064), 88, "Kỹ thuật viên phòng thí nghiệm" },
                    { 535, "Phân tích lỗi sản xuất và đề xuất cải tiến.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8066), 88, "Kỹ sư phân tích lỗi (PE)" },
                    { 536, "Thiết kế, tối ưu và kiểm tra chất lượng bao bì sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8067), 88, "Phát triển bao bì" },
                    { 537, "Đánh giá và kiểm soát chất lượng từ nhà cung cấp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8068), 88, "Kỹ sư quản lý chất lượng nhà cung cấp (SQE)" },
                    { 538, "Các hoạt động khác trong quản lý và kiểm soát chất lượng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8069), 88, "Quản lý chất lượng khác" },
                    { 539, "Quản lý toàn bộ hoạt động sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8069), 89, "Giám đốc sản xuất" },
                    { 540, "Điều hành phòng sản xuất và quản lý nhân sự.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8070), 89, "Trưởng phòng sản xuất" },
                    { 541, "Giám sát vận hành phân xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8071), 89, "Quản đốc phân xưởng/nhà máy" },
                    { 542, "Quản lý dây chuyền sản xuất và phân công công việc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8071), 89, "Trưởng chuyền/Tổ trưởng sản xuất" },
                    { 543, "Điều phối sản xuất theo ca làm việc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8072), 89, "Trưởng ca" },
                    { 544, "Theo dõi quy trình sản xuất và đảm bảo chất lượng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8073), 89, "Giám sát sản xuất" },
                    { 545, "Tham gia dây chuyền sản xuất công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8074), 89, "Công nhân sản xuất" },
                    { 546, "Theo dõi tiến độ và chất lượng đơn hàng sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8074), 89, "Theo dõi đơn hàng" },
                    { 547, "Lập kế hoạch sản xuất và điều phối nguyên liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8075), 89, "Kế hoạch sản xuất" },
                    { 548, "Quản lý kho hàng và tồn kho vật tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8076), 89, "Thủ kho/Quản lý kho" },
                    { 549, "Bảo trì và theo dõi thiết bị máy móc sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8076), 89, "Quản lý thiết bị sản xuất" },
                    { 550, "Vận hành và theo dõi máy móc sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8077), 89, "Công nhân vận hành máy" },
                    { 551, "Các công việc khác thuộc vận hành sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8078), 89, "Chuyên môn Vận hành sản xuất khác" },
                    { 552, "Bảo trì, sửa chữa máy móc và thiết bị công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8079), 90, "Sửa chữa/Bảo trì máy công nghiệp" },
                    { 553, "Lắp đặt thiết bị sản xuất và hệ thống kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8079), 90, "Kỹ thuật viên lắp đặt" },
                    { 554, "Các công việc khác thuộc bảo trì và sửa chữa máy móc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8080), 90, "Bảo trì, sửa chữa khác" },
                    { 566, "Bán và tư vấn sản phẩm hóa chất công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8081), 91, "Kinh doanh hoá chất" },
                    { 567, "Tư vấn và bán sản phẩm ngành ô tô – xe máy – xe điện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8081), 91, "Kinh doanh ô tô/xe máy/xe điện" },
                    { 568, "Bán phụ tùng và linh kiện cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8082), 91, "Kinh doanh phụ tùng ô tô/xe máy/xe điện" },
                    { 569, "Các hoạt động kinh doanh liên quan đến sản phẩm công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8083), 91, "Sales Sản xuất khác" },
                    { 570, "Đảm bảo an toàn lao động và phòng chống sự cố.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8084), 92, "Kỹ sư an toàn lao động (HSE)" },
                    { 571, "Đóng gói, phân loại và kiểm tra hàng hóa trong xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8084), 92, "Công nhân đóng gói hàng hóa" },
                    { 572, "Bốc xếp và vận chuyển hàng hóa trong nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8085), 92, "Công nhân bốc xếp hàng hóa" },
                    { 573, "Tư vấn và bán sản phẩm – dịch vụ kỹ thuật cơ khí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8086), 92, "Bán hàng kỹ thuật cơ khí" },
                    { 574, "Hỗ trợ hành chính và điều phối hoạt động sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8086), 92, "Trợ lý/Thư ký sản xuất" },
                    { 575, "Tham gia sản xuất theo thời vụ hoặc ca ngắn hạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8088), 92, "Công nhân thời vụ" },
                    { 576, "Các công việc khác thuộc lĩnh vực sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8089), 92, "Việc làm công nhân khác" },
                    { 577, "Giảng dạy và chăm sóc trẻ mầm non.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8089), 93, "Giáo viên mầm non" },
                    { 578, "Dạy trẻ nhỏ theo phương pháp giáo dục sớm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8090), 93, "Giáo viên giáo dục sớm" },
                    { 579, "Giảng dạy các môn học bậc tiểu học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8091), 93, "Giáo viên tiểu học" },
                    { 580, "Giảng dạy theo hợp đồng tại các cơ sở giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8092), 93, "Giảng viên thỉnh giảng" },
                    { 581, "Giảng dạy môn Toán ở nhiều cấp học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8092), 93, "Giáo viên Toán" },
                    { 582, "Dạy môn Ngữ văn và kỹ năng đọc – viết.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8093), 93, "Giáo viên Tiếng Việt/Ngữ văn" },
                    { 583, "Dạy môn Tin học và kỹ năng CNTT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8094), 93, "Giáo viên Tin học" },
                    { 584, "Dạy môn Thể dục và phát triển thể chất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8095), 93, "Giáo viên Giáo dục thể chất" },
                    { 585, "Dạy các bộ môn nhảy, múa, nghệ thuật biểu diễn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8095), 93, "Giáo viên dạy nhảy/múa" },
                    { 586, "Giảng dạy tiếng Anh cho nhiều độ tuổi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8096), 93, "Giáo viên tiếng Anh" },
                    { 587, "Dạy tiếng Nhật các trình độ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8097), 93, "Giáo viên tiếng Nhật" },
                    { 588, "Dạy tiếng Hàn cho người học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8097), 93, "Giáo viên tiếng Hàn" },
                    { 589, "Dạy tiếng Trung và giao tiếp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8098), 93, "Giáo viên tiếng Trung" },
                    { 590, "Giảng dạy tiếng Đức các cấp độ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8099), 93, "Giáo viên tiếng Đức" },
                    { 591, "Các môn ngoại ngữ khác theo nhu cầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8100), 93, "Giáo viên ngoại ngữ khác" },
                    { 592, "Các môn học khác theo chương trình giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8100), 93, "Giáo viên bộ môn khác" },
                    { 609, "Dạy vẽ, hội họa và nghệ thuật tạo hình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8136), 94, "Giáo viên mỹ thuật" },
                    { 610, "Giảng dạy nhảy và múa nghệ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8137), 94, "Giáo viên dạy nhảy/múa" },
                    { 611, "Giảng dạy nhạc lý, nhạc cụ và thanh nhạc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8138), 94, "Giáo viên âm nhạc" },
                    { 612, "Dạy cờ vua, cờ tướng và tư duy chiến lược.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8139), 94, "Giáo viên dạy chơi cờ" },
                    { 613, "Dạy tích hợp khoa học – công nghệ – kỹ thuật – toán.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8139), 94, "Giáo viên STEAM/STEM" },
                    { 614, "Các lĩnh vực văn hóa – khoa học khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8140), 94, "Giáo viên Văn hóa/Nghệ thuật/Khoa học khác" },
                    { 615, "Hướng dẫn tập luyện và xây dựng giáo án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8141), 95, "Huấn luyện viên Thể hình (PT)" },
                    { 616, "Dạy các bộ môn nhảy/múa vận động.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8142), 95, "Giáo viên dạy nhảy/múa" },
                    { 617, "Giảng dạy thể dục và rèn luyện sức khỏe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8145), 95, "Giáo viên Giáo dục thể chất" },
                    { 618, "Dạy kỹ năng bóng rổ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8146), 95, "Huấn luyện viên bóng rổ" },
                    { 619, "Dạy yoga và thiền.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8147), 95, "Huấn luyện viên Yoga" },
                    { 620, "Dạy bơi và an toàn nước.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8147), 95, "Huấn luyện viên bơi lội" },
                    { 621, "Dạy võ và tự vệ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8148), 95, "Huấn luyện viên võ thuật" },
                    { 622, "Dạy kỹ năng roller skating.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8149), 95, "Huấn luyện viên trượt patin" },
                    { 623, "Dạy bóng bàn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8150), 95, "Huấn luyện viên bóng bàn" },
                    { 624, "Dạy kỹ năng bóng đá.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8150), 95, "Huấn luyện viên bóng đá" },
                    { 625, "Dạy cầu lông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8151), 95, "Huấn luyện viên cầu lông" },
                    { 626, "Dạy boxing.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8152), 95, "Huấn luyện viên quyền anh (Boxing)" },
                    { 627, "Dạy bi-a.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8152), 95, "Huấn luyện viên Bi-a (Billiard)" },
                    { 628, "Các môn thể thao khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8153), 95, "Huấn luyện viên thể thao khác" },
                    { 629, "Quản lý lịch học, hồ sơ, điểm số.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8154), 96, "Quản lý học vụ" },
                    { 630, "Điều phối và phân công giảng dạy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8155), 96, "Chuyên viên điều phối giáo viên" },
                    { 631, "Quản lý cơ sở giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8155), 96, "Hiệu trưởng/Phó hiệu trưởng" },
                    { 632, "Quản lý lớp học và học sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8156), 96, "Giáo viên chủ nhiệm" },
                    { 633, "Quản lý chương trình dạy học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8157), 96, "Quản lý giảng dạy" },
                    { 634, "Đảm bảo chất lượng đào tạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8157), 96, "Quản lý chất lượng giáo dục" },
                    { 635, "Các hoạt động quản lý giáo dục khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8158), 96, "Quản lý giáo dục khác" },
                    { 636, "Hỗ trợ giảng dạy tiếng Anh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8159), 97, "Trợ giảng tiếng Anh" },
                    { 637, "Hỗ trợ giảng dạy tiếng Trung.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8160), 97, "Trợ giảng tiếng Trung" },
                    { 638, "Hỗ trợ giảng dạy tiếng Nhật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8160), 97, "Trợ giảng tiếng Nhật" },
                    { 639, "Hỗ trợ giáo viên tiếng Hàn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8161), 97, "Trợ giảng tiếng Hàn" },
                    { 640, "Hỗ trợ giảng dạy tiếng Đức.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8162), 97, "Trợ giảng tiếng Đức" },
                    { 641, "Hỗ trợ dạy các môn ngoại ngữ khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8163), 97, "Trợ giảng ngoại ngữ khác" },
                    { 642, "Hỗ trợ dạy các môn học khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8164), 97, "Trợ giảng bộ môn khác" },
                    { 643, "Quản lý hoạt động và vận hành lớp học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8165), 98, "Quản lý/Vận hành lớp học" },
                    { 644, "Hỗ trợ học viên và giáo viên trong quá trình học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8166), 98, "Hỗ trợ lớp học" },
                    { 645, "Theo dõi và hỗ trợ học viên trong quá trình học tập.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8166), 98, "Chăm sóc/Hỗ trợ học viên" },
                    { 646, "Các công việc khác thuộc hỗ trợ lớp học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8167), 98, "Quản lý/Hỗ trợ lớp học khác" },
                    { 647, "Tư vấn chương trình học và hỗ trợ tuyển sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8168), 99, "Tư vấn tuyển sinh/khoá học" },
                    { 648, "Tư vấn chương trình du học và hồ sơ liên quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8169), 99, "Tư vấn du học" },
                    { 649, "Các hoạt động kinh doanh liên quan đến giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8169), 99, "Sales Giáo dục/Khoá học khác" },
                    { 650, "Giảng dạy kỹ năng lái xe ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8170), 100, "Giáo viên dạy lái xe ô tô" },
                    { 651, "Dạy các nghề kỹ thuật hoặc đào tạo nghề.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8171), 100, "Giáo viên dạy nghề" },
                    { 652, "Dạy học sinh có nhu cầu đặc biệt.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8172), 100, "Giáo viên giáo dục đặc biệt" },
                    { 653, "Dạy nghệ thuật cắm hoa và trang trí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8172), 100, "Giáo viên dạy cắm hoa" },
                    { 654, "Dạy kỹ năng nấu ăn và ẩm thực.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8173), 100, "Giáo viên dạy nấu ăn" },
                    { 655, "Quản lý thư viện và hỗ trợ học liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8174), 100, "Thủ thư" },
                    { 656, "Thiết kế nội dung học tập và tài liệu giảng dạy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8174), 100, "Phát triển học liệu/Thiết kế khóa học" },
                    { 657, "Hỗ trợ học viên định hướng học tập.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8175), 100, "Cố vấn học tập" },
                    { 658, "Tư vấn nghề nghiệp và định hướng tương lai.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8176), 100, "Tư vấn hướng nghiệp" },
                    { 659, "Hỗ trợ tâm lý và cảm xúc cho học sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8177), 100, "Tư vấn tâm lý học đường" },
                    { 660, "Các chuyên môn khác trong lĩnh vực giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8177), 100, "Chuyên môn Giáo dục/Đào tạo khác" },
                    { 661, "Quản lý bán hàng kênh Modern Trade.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8178), 101, "Kinh doanh kênh MT" },
                    { 662, "Phát triển bán hàng kênh General Trade.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8179), 101, "Kinh doanh kênh GT" },
                    { 663, "Bán hàng tại cửa hàng tiện ích.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8179), 101, "Bán hàng siêu thị/cửa hàng tiện ích/tiện lợi" },
                    { 664, "Tư vấn và bán điện thoại/phụ kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8180), 101, "Bán hàng điện thoại" },
                    { 665, "Bán thiết bị điện máy và gia dụng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8181), 101, "Bán hàng điện máy" },
                    { 666, "Bán sản phẩm thời trang.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8182), 101, "Bán hàng thời trang" },
                    { 667, "Bán vàng bạc – đá quý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8182), 101, "Bán hàng trang sức đá quý" },
                    { 668, "Bán mỹ phẩm và nước hoa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8184), 101, "Bán hàng mỹ phẩm" },
                    { 669, "Bán lẻ thực phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8185), 101, "Kinh doanh thực phẩm" },
                    { 670, "Bán các loại bao bì.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8185), 101, "Kinh doanh bao bì" },
                    { 671, "Bán thẻ tập gym/yoga.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8186), 101, "Sales thẻ tập" },
                    { 672, "Các vị trí bán lẻ khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8187), 101, "Sales Bán lẻ/Dịch vụ tiêu dùng khác" },
                    { 673, "Xử lý thanh toán tại quầy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8188), 101, "Thu ngân" },
                    { 674, "Quản lý đội ngũ thu ngân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8188), 101, "Giám sát thu ngân" },
                    { 675, "Trưng bày, bán hàng và kiểm kho.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8189), 101, "Nhân viên siêu thị" },
                    { 676, "Theo dõi, giảm thất thoát hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8190), 101, "Phòng chống thất thoát" },
                    { 677, "Điều hành hoạt động cửa hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8190), 101, "Quản lý cửa hàng/Cửa hàng trưởng" },
                    { 678, "Quản lý toàn bộ siêu thị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8191), 101, "Giám đốc siêu thị" },
                    { 679, "Vận hành & quản lý TTTM.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8192), 101, "Vận hành trung tâm thương mại" },
                    { 680, "Thực hiện các liệu trình chăm sóc da và trị liệu spa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8193), 102, "Kỹ thuật viên Spa" },
                    { 681, "Quản lý vận hành và dịch vụ tại spa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8193), 102, "Quản lý Spa" },
                    { 682, "Tư vấn dịch vụ làm đẹp và chăm sóc da.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8194), 102, "Tư vấn thẩm mỹ/Spa" },
                    { 683, "Tư vấn dịch vụ nha khoa và chăm sóc răng miệng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8195), 102, "Tư vấn nha khoa" },
                    { 684, "Làm móng, nối mi và chăm sóc thẩm mỹ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8196), 102, "Thợ nail/mi" },
                    { 685, "Thực hiện phun xăm, điêu khắc chân mày/môi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8196), 102, "Phun xăm thẩm mỹ" },
                    { 686, "Xăm hình nghệ thuật theo yêu cầu khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8197), 102, "Thợ xăm (Tattoo Artist)" },
                    { 687, "Cắt tóc, tạo kiểu và chăm sóc tóc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8198), 102, "Thợ cắt tóc" },
                    { 688, "Hỗ trợ thợ chính trong salon tóc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8198), 102, "Trợ lý/Học việc làm tóc" },
                    { 689, "Trang điểm và tư vấn phong cách cá nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8199), 102, "Makeup/Stylist" },
                    { 690, "Các công việc khác trong lĩnh vực làm đẹp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8200), 102, "Việc làm Chăm sóc sức khỏe/Làm đẹp khác" },
                    { 691, "Thực hiện phục hồi chức năng và vật lý trị liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8200), 103, "Chuyên viên vật lý trị liệu" },
                    { 692, "Thực hiện châm cứu, bấm huyệt và trị liệu đông y.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8201), 103, "Kỹ thuật viên châm cứu bấm huyệt" },
                    { 693, "Thực hiện massage thư giãn hoặc trị liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8203), 103, "Nhân viên massage" },
                    { 694, "Các dịch vụ chăm sóc sức khỏe khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8204), 103, "Dịch vụ chăm sóc sức khỏe khác" },
                    { 695, "Dọn dẹp, vệ sinh nhà cửa, văn phòng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8204), 104, "Nhân viên dọn vệ sinh" },
                    { 696, "Quản lý đội vệ sinh và chất lượng dịch vụ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8205), 104, "Giám sát vệ sinh" },
                    { 697, "Hỗ trợ việc nhà và sinh hoạt gia đình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8206), 104, "Giúp việc" },
                    { 698, "Sắp xếp đồ đạc, dọn dẹp không gian sống.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8206), 104, "Sắp xếp tủ quần áo và nhà cửa" },
                    { 699, "Thực hiện vệ sinh trong nhà hàng, khách sạn, văn phòng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8207), 104, "Vệ sinh/Tạp vụ" },
                    { 700, "Các dịch vụ vệ sinh khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8208), 104, "Dịch vụ vệ sinh/nhà cửa khác" },
                    { 701, "Giao thư từ, bưu phẩm tận nơi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8209), 105, "Bưu tá" },
                    { 702, "Giao hàng hóa theo đơn cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8209), 105, "Shipper (Nhân viên giao hàng)" },
                    { 703, "Lái xe theo yêu cầu thuê riêng của khách.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8210), 105, "Tài xế lái xe thuê" },
                    { 704, "Đưa đón khách bằng taxi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8211), 105, "Tài xế taxi" },
                    { 705, "Đưa đón nhân viên hoặc sếp đi công tác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8211), 105, "Tài xế lái xe văn phòng" },
                    { 706, "Chở hành khách trên các tuyến cố định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8212), 105, "Tài xế xe khách" },
                    { 707, "Lái các loại xe du lịch, xe tải nhẹ theo bằng B2.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8213), 105, "Tài xế B2" },
                    { 708, "Đưa đón lãnh đạo, đảm bảo lịch trình và an toàn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8214), 105, "Lái xe cho sếp" },
                    { 709, "Lái xe đường dài, xuyên tỉnh hoặc quốc tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8214), 105, "Tài xế lái xe đường dài" },
                    { 710, "Chạy xe công nghệ cho các ứng dụng như Grab/Be.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8215), 105, "Tài xế công nghệ" },
                    { 711, "Các công việc vận tải khác theo nhu cầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8216), 105, "Dịch vụ vận tải khác" },
                    { 712, "Đảm bảo an ninh khu vực, kiểm soát ra vào.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8217), 106, "Bảo vệ" },
                    { 713, "Kiểm soát an ninh và xử lý sự cố.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8217), 106, "Giám sát an ninh" },
                    { 714, "Theo dõi, vận hành hệ thống phòng cháy chữa cháy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8218), 106, "Nhân viên PCCC" },
                    { 715, "Kiểm tra và bảo trì thiết bị phòng cháy chữa cháy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8219), 106, "Bảo trì PCCC" },
                    { 716, "Sửa chữa và bảo trì thiết bị trong gia đình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8219), 106, "Sửa chữa thiết bị gia dụng" },
                    { 717, "Khắc phục lỗi và sửa chữa điện thoại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8220), 106, "Sửa chữa điện thoại" },
                    { 718, "Sửa chữa thiết bị văn phòng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8221), 106, "Sửa chữa máy tính và máy in" },
                    { 719, "Sửa chữa và bảo trì thiết bị điện lạnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8222), 106, "Thợ điện lạnh" },
                    { 720, "Mở khóa và sửa khóa gia đình/cửa hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8223), 106, "Thợ sửa khoá" },
                    { 721, "Sửa chữa hệ thống điện, nước dân dụng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8224), 106, "Sửa chữa/Bảo trì điện nước" },
                    { 722, "Lắp đặt và bảo trì hệ thống thang máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8225), 106, "Lắp đặt/bảo trì thang máy" },
                    { 723, "Sửa chữa xe máy hoặc ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8226), 106, "Thợ sửa xe" },
                    { 724, "Bảo trì cơ sở vật chất trong tòa nhà.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8226), 106, "Bảo trì tòa nhà" },
                    { 725, "Các công việc khác trong lĩnh vực an ninh – bảo trì.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8227), 106, "Việc làm Bảo vệ/Bảo trì/Sửa chữa khác" },
                    { 726, "Chăm sóc trẻ tại nhà hoặc trường học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8228), 107, "Bảo mẫu/Người trông trẻ" },
                    { 727, "Hỗ trợ chăm sóc mẹ sau sinh và trẻ sơ sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8229), 107, "Chăm sóc mẹ và bé" },
                    { 728, "Các dịch vụ chăm sóc mẹ và bé khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8229), 107, "Dịch vụ bà mẹ trẻ em khác" },
                    { 729, "Sửa chữa và bảo dưỡng xe máy hoặc ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8230), 108, "Thợ sửa xe" },
                    { 730, "Rửa xe, vệ sinh nội ngoại thất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8231), 108, "Nhân viên rửa xe" },
                    { 731, "Độ xe, nâng cấp phụ kiện và ngoại thất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8231), 108, "Thợ độ xe ô tô/xe máy/xe điện" },
                    { 732, "Quản lý vận hành và dịch vụ tại garage.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8232), 108, "Quản lý cửa hàng sửa chữa và bảo trì ô tô/xe máy/xe điện" },
                    { 733, "Kiểm định an toàn kỹ thuật và đăng kiểm xe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8233), 108, "Kiểm định ô tô" },
                    { 734, "Giám định thiệt hại xe và xử lý bồi thường bảo hiểm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8234), 108, "Giám định bồi thường ô tô" },
                    { 735, "Các dịch vụ khác liên quan đến xe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8234), 108, "Dịch vụ ô tô/xe máy/xe điện khác" },
                    { 736, "Tắm, cắt tỉa, chăm sóc thú cưng chuyên nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8235), 109, "Chuyên viên chăm sóc/spa thú cưng" },
                    { 737, "Thăm khám và điều trị cho thú cưng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8260), 109, "Bác sĩ thú y" },
                    { 738, "Các dịch vụ khác liên quan đến thú cưng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8261), 109, "Dịch vụ thú cưng khác" },
                    { 739, "Thiết kế và cắm hoa nghệ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8261), 110, "Thợ cắm hoa" },
                    { 740, "Tạo ra sản phẩm thủ công và mỹ nghệ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8262), 110, "Thợ thủ công mỹ nghệ" },
                    { 741, "Các nghề thủ công khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8263), 110, "Thợ thủ công khác" },
                    { 742, "Lên kế hoạch và điều phối tiệc cưới.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8264), 110, "Tổ chức tiệc cưới (Wedding Planner)" },
                    { 743, "Quản lý hoạt động phòng game/Internet.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8264), 110, "Quản lý quán net" },
                    { 744, "Bán tour và dịch vụ du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8265), 110, "Sales Tour/Kinh doanh du lịch" },
                    { 745, "Đặt vé máy bay và xử lý booking.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8267), 110, "Bán vé máy bay (Ticketing/Booker)" },
                    { 746, "Kinh doanh dịch vụ khách sạn, lưu trú.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8268), 110, "Kinh doanh khách sạn" },
                    { 747, "Đo mắt và tư vấn kính/áp tròng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8268), 110, "Chuyên viên đo thị lực" },
                    { 748, "Chụp ảnh và dựng video.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8269), 110, "Photographer/Video Editor" },
                    { 749, "Hỗ trợ bán vé, phục vụ và vận hành rạp phim.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8270), 110, "Nhân viên rạp chiếu phim" },
                    { 750, "Bơm xăng và hỗ trợ khách tại cửa hàng xăng dầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8270), 110, "Nhân viên cây xăng" },
                    { 751, "Giám sát an toàn tại hồ bơi/bãi biển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8271), 110, "Nhân viên cứu hộ (Lifeguard)" },
                    { 752, "Giảng dạy kỹ năng cắm hoa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8272), 110, "Giáo viên dạy cắm hoa" },
                    { 753, "Dạy nấu ăn và kỹ năng ẩm thực.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8273), 110, "Giáo viên dạy nấu ăn" },
                    { 754, "Dạy kỹ năng lái ô tô.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8273), 110, "Giáo viên dạy lái xe ô tô" },
                    { 755, "Điều khiển drone cho quay phim/chụp ảnh/kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8274), 110, "Chuyên viên điều khiển drone" },
                    { 756, "Lên kế hoạch và điều phối sự kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8275), 110, "Tổ chức sự kiện (Event Planner)" },
                    { 757, "Các công việc khác thuộc nhóm dịch vụ – bán lẻ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8276), 110, "Việc làm Bán lẻ/Dịch vụ đời sống khác" },
                    { 758, "Biên tập nội dung, chỉnh sửa bài viết và tài liệu xuất bản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8276), 111, "Biên tập viên" },
                    { 759, "Quản lý nội dung, kiểm duyệt và định hướng xuất bản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8277), 111, "Tổng biên tập/Phó tổng biên tập" },
                    { 760, "Thu thập thông tin, viết tin bài và biên tập tin tức.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8278), 111, "Phóng viên/Biên tập viên tin tức" },
                    { 761, "Nhập nội dung, dữ liệu và chỉnh sửa cơ bản cho ấn phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8278), 111, "Nhập liệu" },
                    { 762, "Thực hiện dàn trang, sắp chữ và in ấn tài liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8279), 111, "In ấn và sắp chữ" },
                    { 763, "Xử lý chế bản điện tử, chuẩn bị file in ấn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8280), 111, "Nhân viên chế bản" },
                    { 764, "Các vị trí khác trong biên tập, viết và xuất bản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8281), 111, "Chuyên môn Biên tập/Viết/Xuất bản khác" },
                    { 765, "Trang điểm và tạo phong cách cho diễn viên và nhân vật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8281), 112, "Makeup/Stylist" },
                    { 766, "Tham gia diễn xuất trong phim, TVC hoặc sân khấu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8282), 112, "Diễn viên" },
                    { 767, "Lồng tiếng cho nhân vật trong phim hoặc hoạt hình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8283), 112, "Diễn viên lồng tiếng" },
                    { 768, "Quản lý lịch trình và hỗ trợ nghệ sĩ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8283), 112, "Quản lý/Trợ lý nghệ sĩ" },
                    { 769, "Dẫn dắt chương trình truyền hình hoặc sự kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8284), 112, "Dẫn chương trình (MC)" },
                    { 770, "Tham gia chụp hình, quảng cáo và biểu diễn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8286), 112, "Người mẫu/Mẫu ảnh" },
                    { 771, "Chụp ảnh, quay phim và dựng video.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8287), 112, "Photographer/Video Editor" },
                    { 772, "Chỉ đạo sản xuất phim, TVC và chương trình truyền hình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8287), 112, "Đạo diễn" },
                    { 773, "Dàn dựng động tác, cảnh quay và trình diễn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8288), 112, "Biên đạo" },
                    { 774, "Viết kịch bản phim, TVC hoặc chương trình truyền hình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8289), 112, "Biên kịch" },
                    { 775, "Quản lý sản xuất, ekip và tiến độ làm phim.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8290), 112, "Producer (Sản xuất phim)" },
                    { 776, "Phân phối và phát hành phim ra thị trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8290), 112, "Phát hành điện ảnh và truyền hình" },
                    { 777, "Xử lý hậu kỳ phim như dựng, chỉnh màu và âm thanh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8291), 112, "Hậu kỳ sản xuất" },
                    { 778, "Thiết kế hoạt hình và chuyển động hình ảnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8292), 112, "Animation Design" },
                    { 779, "Chỉnh sửa hình ảnh cho sản phẩm truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8292), 112, "Chỉnh sửa ảnh (Retouch)" },
                    { 780, "Thiết lập và điều chỉnh ánh sáng trong quay phim.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8293), 112, "Kỹ thuật viên ánh sáng" },
                    { 781, "Thu âm, xử lý âm thanh cho phim và truyền hình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8294), 112, "Kỹ thuật viên âm thanh" },
                    { 782, "Vận hành hệ thống chiếu phim tại rạp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8295), 112, "Nhân viên chiếu phim" },
                    { 783, "Thiết kế không gian, đạo cụ và mỹ thuật sân khấu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8295), 112, "Thiết kế mỹ thuật sân khấu" },
                    { 784, "Các chuyên môn khác thuộc lĩnh vực phim – truyền hình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8296), 112, "Chuyên môn Phim và truyền hình khác" },
                    { 785, "Các công việc khác thuộc nhóm phim, báo chí và xuất bản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8297), 113, "Chuyên môn Phim và truyền hình/Báo chí/Xuất bản khác" },
                    { 786, "Thiết kế, lắp đặt và vận hành hệ thống điện dân dụng và công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8297), 114, "Kỹ sư điện" },
                    { 787, "Thiết kế bản vẽ điện, hệ thống điện tòa nhà, nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8298), 114, "Kỹ sư thiết kế điện" },
                    { 788, "Thi công, sửa chữa và bảo trì hệ thống điện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8299), 114, "Thợ điện" },
                    { 789, "Thiết kế và vận hành hệ thống tự động hóa, dây chuyền.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8300), 114, "Kỹ sư tự động hóa" },
                    { 790, "Thiết kế, thi công hệ thống M&E tòa nhà, nhà máy.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8300), 114, "Kỹ sư cơ điện" },
                    { 791, "Lập trình PLC/SCADA điều khiển dây chuyền tự động.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8303), 114, "Kỹ sư lập trình PLC/SCADA" },
                    { 792, "Lập trình và vận hành robot công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8303), 114, "Kỹ sư robot" },
                    { 793, "Các vị trí khác trong lĩnh vực điện và tự động hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8304), 114, "Chuyên môn Điện/Tự động hoá khác" },
                    { 794, "Thiết kế và phát triển mạch điện, hệ thống điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8305), 115, "Kỹ sư điện tử" },
                    { 795, "Thiết kế schematic, PCB và vi mạch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8305), 115, "Thiết kế mạch điện/vi mạch" },
                    { 796, "Phát triển bo mạch và phần cứng điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8306), 115, "Kỹ sư phần cứng" },
                    { 797, "Lập trình nhúng trên vi điều khiển và hệ thống nhúng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8307), 115, "Embedded Engineer/Lập trình nhúng" },
                    { 798, "Sửa chữa và bảo trì thiết bị điện tử, viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8308), 115, "Sửa chữa/Bảo trì điện tử/viễn thông" },
                    { 799, "Thiết kế, lập trình FPGA cho xử lý phần cứng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8308), 115, "Phát triển FPGA" },
                    { 800, "Lập trình, thiết kế hệ thống sử dụng vi điều khiển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8309), 115, "Vi điều khiển" },
                    { 801, "Phát triển driver cho thiết bị phần cứng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8310), 115, "Kỹ sư phát triển Driver" },
                    { 802, "Thiết kế, layout và kiểm tra PCB.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8310), 115, "Kỹ sư PCB" },
                    { 803, "Phát triển hệ thống RF và vô tuyến.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8311), 115, "Kỹ sư RF" },
                    { 804, "Tích hợp phần cứng – phần mềm cho sản phẩm điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8312), 115, "Tích hợp hệ thống" },
                    { 805, "Thiết kế và thử nghiệm hệ thống quang học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8313), 115, "Kỹ sư quang học" },
                    { 806, "Phát triển xử lý tín hiệu số DSP.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8313), 115, "Phát triển DSP" },
                    { 807, "Lập trình chip ARM và hệ thống nhúng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8314), 115, "Phát triển ARM" },
                    { 808, "Lắp đặt, sửa chữa và vận hành thiết bị điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8315), 115, "Kỹ thuật điện/điện tử" },
                    { 809, "Lắp ráp và vận hành dây chuyền sản xuất điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8316), 115, "Công nhân điện tử" },
                    { 810, "Các chuyên môn khác thuộc phần cứng – điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8316), 115, "Chuyên môn Điện tử/Phần cứng khác" },
                    { 811, "Thiết kế và giám sát hệ thống điều hòa thông gió.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8317), 116, "Kỹ sư HVAC" },
                    { 812, "Thiết kế và vận hành hệ thống nhiệt lạnh công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8318), 116, "Kỹ sư nhiệt lạnh" },
                    { 813, "Phát triển hệ thống điện lạnh dân dụng và công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8318), 116, "Kỹ sư điện lạnh" },
                    { 814, "Sửa chữa và bảo trì thiết bị điện lạnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8319), 116, "Thợ điện lạnh" },
                    { 815, "Các chuyên môn khác thuộc HVAC-R.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8320), 116, "Chuyên môn Nhiệt/Gió/Điều hoà (HVAC-R)" },
                    { 816, "Thiết kế IC analog, digital hoặc mixed-signal.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8321), 117, "Thiết kế vi mạch IC" },
                    { 817, "Kiểm tra và đánh giá chất lượng IC.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8321), 117, "Kỹ sư kiểm định IC" },
                    { 818, "Thiết kế layout cho IC analog.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8322), 117, "Analog Layout Design Engineer" },
                    { 819, "Test và phân tích các lỗi IC.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8323), 117, "Chip Test Engineer" },
                    { 820, "Thiết kế kiểm thử cho chip (Design For Test).", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8325), 117, "DFT Engineer" },
                    { 821, "Hỗ trợ kỹ thuật chip và bán dẫn cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8326), 117, "FAE" },
                    { 822, "Thiết kế logic số cho IC.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8326), 117, "Digital Front-end Designer" },
                    { 823, "Thiết kế layout và physical design cho chip.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8327), 117, "Back-end Engineer" },
                    { 824, "Thiết kế các mạch analog trên IC.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8328), 117, "Analog IC Design Engineer" },
                    { 825, "Các vị trí khác trong ngành bán dẫn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8329), 117, "Chuyên môn Chất bán dẫn/Chip khác" },
                    { 826, "Quản lý tiến độ và kỹ thuật dự án điện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8329), 118, "Quản lý dự án điện" },
                    { 827, "Điều hành và giám sát các dự án kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8330), 118, "Quản lý dự án kỹ thuật" },
                    { 828, "Hỗ trợ điều phối và quản lý dự án kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8331), 118, "Trợ lý dự án kỹ thuật" },
                    { 829, "Phối hợp triển khai và giám sát dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8331), 118, "Chuyên viên dự án kỹ thuật" },
                    { 830, "Triển khai các hệ thống thiết bị kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8332), 118, "Kỹ sư triển khai" },
                    { 831, "Tư vấn kỹ thuật và hỗ trợ triển khai dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8333), 118, "Tư vấn triển khai" },
                    { 832, "Phân tích yêu cầu kỹ thuật và đề xuất giải pháp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8334), 118, "Kỹ sư phân tích yêu cầu" },
                    { 833, "Điều hành các dự án phát triển phần cứng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8334), 118, "Quản lý dự án phần cứng" },
                    { 834, "Triển khai và giám sát dự án viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8335), 118, "Quản lý dự án viễn thông" },
                    { 835, "Điều hành dự án hệ thống công nghiệp tự động.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8336), 118, "Quản lý dự án hệ thống tự động hóa" },
                    { 836, "Quản lý dự án điện mặt trời, gió và năng lượng sạch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8336), 118, "Quản lý dự án năng lượng tái tạo" },
                    { 837, "Vận hành máy móc trong dây chuyền sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8337), 118, "Công nhân vận hành máy" },
                    { 838, "Các vị trí khác trong quản lý và vận hành dự án kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8338), 118, "Chuyên môn Quản lý/Vận hành dự án kỹ thuật khác" },
                    { 839, "Thiết kế và vận hành hệ thống điện tử viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8340), 119, "Kỹ sư điện tử viễn thông" },
                    { 840, "Thi công, bảo trì hệ thống viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8341), 119, "Kỹ thuật viễn thông" },
                    { 841, "Phát triển và triển khai hệ thống IoT.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8342), 119, "Kỹ sư IoT (IoT Engineer)" },
                    { 842, "R&D các công nghệ và thiết bị viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8343), 119, "Kỹ sư nghiên cứu và phát triển viễn thông" },
                    { 843, "Phát triển và tối ưu hệ thống RF và wireless.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8344), 119, "Kỹ sư truyền thông không dây/vô tuyến (RF)" },
                    { 844, "Làm việc với mạng 4G/5G/6G.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8345), 119, "Kỹ sư truyền thông di động" },
                    { 845, "Triển khai và quản lý mạng viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8345), 119, "Kỹ sư mạng viễn thông" },
                    { 846, "Xây dựng hệ thống truyền dẫn dữ liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8346), 119, "Kỹ sư truyền thông dữ liệu" },
                    { 847, "Kiểm thử thiết bị và hệ thống viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8347), 119, "Kỹ sư kiểm thử viễn thông" },
                    { 848, "Thiết kế và vận hành mạng quang.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8348), 119, "Kỹ sư truyền thông quang học" },
                    { 849, "Triển khai hệ thống cáp quang và truyền dẫn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8349), 119, "Kỹ sư mạng quang" },
                    { 850, "Lắp đặt và bảo trì hệ thống điện – viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8350), 119, "Kỹ sư điện viễn thông" },
                    { 851, "Thi công, kiểm tra đường cáp quang và đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8350), 119, "Kỹ sư truyền dẫn cáp" },
                    { 852, "Vận hành và bảo trì thiết bị viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8351), 119, "Kỹ sư thiết bị viễn thông" },
                    { 853, "Triển khai core network cho hệ thống viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8352), 119, "Kỹ sư mạng lõi" },
                    { 854, "Nghiên cứu và thiết lập tiêu chuẩn kỹ thuật viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8352), 119, "Kỹ sư tiêu chuẩn hóa viễn thông" },
                    { 855, "Quản trị hệ thống mạng và hạ tầng kết nối.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8353), 119, "Kỹ sư mạng" },
                    { 856, "Các chuyên môn khác trong ngành viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8354), 119, "Chuyên môn Viễn thông khác" },
                    { 857, "Sửa chữa và bảo trì thiết bị điện tử, viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8355), 120, "Sửa chữa/Bảo trì điện tử/viễn thông" },
                    { 858, "Vận hành và quản trị hệ thống CNTT hoặc viễn thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8355), 120, "Kỹ sư hệ thống" },
                    { 859, "Soạn thảo tài liệu kỹ thuật và quy trình vận hành.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8356), 120, "Kỹ sư tài liệu kỹ thuật" },
                    { 860, "Vận hành hệ thống điện công nghiệp và tòa nhà.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8357), 120, "Vận hành điện" },
                    { 861, "Lắp đặt và sửa chữa thiết bị điện, điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8357), 120, "Kỹ thuật điện/điện tử" },
                    { 862, "Vận hành dây chuyền và thiết bị sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8358), 120, "Công nhân vận hành máy" },
                    { 863, "Các vị trí khác thuộc vận hành và kỹ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8359), 120, "Chuyên môn Vận hành và bảo trì/Hỗ trợ kỹ thuật khác" },
                    { 864, "Bán thiết bị và linh kiện điện công nghiệp/dân dụng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8359), 121, "Kinh doanh thiết bị/linh kiện điện" },
                    { 865, "Kinh doanh máy móc, thiết bị và giải pháp công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8385), 121, "Kinh doanh thiết bị công nghiệp" },
                    { 866, "Bán dịch vụ viễn thông, Internet và truyền dẫn dữ liệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8386), 121, "Kinh doanh dịch vụ viễn thông" },
                    { 867, "Bán thiết bị và dự án năng lượng mặt trời.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8387), 121, "Kinh doanh điện mặt trời" },
                    { 868, "Bán thiết bị HVAC và giải pháp điều hòa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8388), 121, "Kinh doanh HVAC" },
                    { 869, "Các vị trí kinh doanh khác trong ngành điện – điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8389), 121, "Sales Điện/Điện tử/Viễn thông khác" },
                    { 870, "Tư vấn, bán hàng và hỗ trợ kỹ thuật sản phẩm điện – điện tử.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8389), 122, "Bán hàng kỹ thuật Điện/Điện tử/Viễn thông" },
                    { 871, "Các chuyên môn khác không thuộc nhóm chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8391), 122, "Chuyên môn Điện/Điện tử/Viễn thông khác" },
                    { 872, "Tư vấn, bán dịch vụ logistics và giải pháp vận chuyển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8392), 123, "Sales Logistics" },
                    { 873, "Các vị trí kinh doanh khác trong lĩnh vực logistics.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8393), 123, "Sales Xuất nhập khẩu/Logistics khác" },
                    { 874, "Thực hiện quy trình XNK, chứng từ và logistics.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8394), 124, "Chuyên môn Xuất nhập khẩu/Logistics" },
                    { 875, "Quản lý toàn bộ hoạt động logistics của doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8395), 124, "Giám đốc Logistics" },
                    { 876, "Theo dõi tiến độ nhập/xuất và vận chuyển hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8395), 124, "Theo dõi đơn hàng" },
                    { 877, "Làm việc tại cảng/kho, giám sát xếp dỡ hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8396), 124, "Nhân viên hiện trường Logistics" },
                    { 878, "Vận hành và tối ưu hệ thống quản lý vận tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8397), 124, "Quản lý hệ thống vận tải (TMS)" },
                    { 879, "Điều phối hoạt động kho, vận chuyển và phân phối.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8398), 124, "Giám sát/Điều phối hàng hoá và kho vận" },
                    { 880, "Chuẩn bị và xử lý bộ chứng từ XNK.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8398), 124, "Chứng từ xuất nhập khẩu" },
                    { 881, "Điều phối phương tiện và theo dõi vận chuyển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8399), 125, "Giám sát/Điều phối vận tải" },
                    { 882, "Sắp xếp hàng hóa tại kho hoặc bưu cục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8400), 125, "Phân loại/Sắp xếp hàng hoá" },
                    { 883, "Bốc xếp hàng hóa tại kho hoặc điểm giao nhận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8400), 125, "Công nhân bốc xếp hàng hóa" },
                    { 884, "Vận hành xe nâng trong kho/xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8401), 125, "Tài xế lái xe nâng" },
                    { 885, "Vận chuyển hàng hóa bằng xe tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8402), 125, "Tài xế xe tải" },
                    { 886, "Lái container vận chuyển hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8403), 125, "Tài xế container" },
                    { 887, "Lái xe vận chuyển xuyên tỉnh/quốc tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8403), 125, "Tài xế lái xe đường dài" },
                    { 888, "Lái xe chuyên dụng như xe cẩu, xe bồn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8404), 125, "Tài xế lái xe chuyên dụng" },
                    { 889, "Lái xe khách tuyến cố định hoặc hợp đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8405), 125, "Tài xế xe khách" },
                    { 890, "Hỗ trợ tài xế giao nhận và xếp dỡ hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8406), 125, "Phụ xe" },
                    { 891, "Các công việc khác thuộc lĩnh vực vận tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8406), 125, "Dịch vụ vận tải khác" },
                    { 892, "Giao thư, bưu phẩm đến khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8407), 126, "Bưu tá" },
                    { 893, "Quản lý nhân sự và vận hành bưu cục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8408), 126, "Quản lý trạm giao nhận/bưu cục" },
                    { 894, "Phân loại hàng hóa tại trung tâm/xưởng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8408), 126, "Phân loại/Sắp xếp hàng hoá" },
                    { 895, "Giao hàng theo đơn đến khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8409), 126, "Shipper (Nhân viên giao hàng)" },
                    { 896, "Điều phối shipper và lộ trình giao hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8410), 126, "Điều phối giao hàng" },
                    { 897, "Bốc xếp hàng tại kho giao nhận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8411), 126, "Công nhân bốc xếp hàng hóa" },
                    { 898, "Giao nhận vận chuyển quốc tế và thủ tục xuất nhập khẩu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8412), 126, "Freight Forwarder" },
                    { 899, "Các vị trí khác trong giao nhận – vận chuyển.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8413), 126, "Dịch vụ giao nhận khác" },
                    { 900, "Quản lý xuất/nhập và sắp xếp hàng trong kho.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8414), 127, "Nhân viên kho" },
                    { 901, "Quản lý chứng từ, số liệu và hành chính kho.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8414), 127, "Hành chính kho" },
                    { 902, "Quản lý vận hành kho và nhân sự kho.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8415), 127, "Trưởng kho/Giám sát kho" },
                    { 903, "Giao nhận và xử lý thủ tục xuất nhập khẩu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8416), 127, "Freight Forwarder" },
                    { 904, "Gấp, đóng kiện và phân loại quần áo trong kho.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8417), 127, "Công nhân xếp quần áo" },
                    { 905, "Đóng gói, dán nhãn và kiểm hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8417), 127, "Công nhân đóng gói hàng hóa" },
                    { 906, "Các công việc khác trong lĩnh vực kho vận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8418), 127, "Chuyên môn Kho vận khác" },
                    { 907, "Tìm nguồn cung, báo giá và quản lý nhà cung cấp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8419), 128, "Chuyên môn Thu mua/Mua hàng" },
                    { 908, "Giám sát hoạt động mua hàng và đội ngũ thu mua.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8420), 128, "Quản lý/Giám sát mua hàng" },
                    { 909, "Kiểm soát chất lượng và đánh giá nhà cung cấp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8420), 128, "Kỹ sư quản lý chất lượng nhà cung cấp (SQE)" },
                    { 910, "Điều phối luân chuyển hàng trong chuỗi cung ứng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8421), 128, "Điều phối hàng hóa" },
                    { 911, "Theo dõi sản xuất, chất lượng và tiến độ hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8422), 128, "Quản lý hàng hoá (Merchandiser)" },
                    { 912, "Quản lý chiến lược mua hàng của doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8423), 128, "Giám đốc Thu mua/Mua hàng" },
                    { 913, "Tham gia đấu thầu và mua sắm vật tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8423), 128, "Chuyên viên đấu thầu" },
                    { 914, "Chuẩn bị hồ sơ thầu và tài liệu đấu thầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8424), 128, "Chuyên viên hồ sơ thầu" },
                    { 915, "Thực hiện khai báo hải quan và thủ tục kiểm dịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8425), 128, "Khai báo hải quan và kiểm dịch" },
                    { 916, "Quản lý tiến độ, nguyên liệu và dòng chảy hàng hóa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8426), 129, "Chuyên môn chuỗi cung ứng" },
                    { 917, "Điều hành hoạt động supply chain của doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8426), 129, "Quản lý/Giám sát chuỗi cung ứng" },
                    { 918, "Quản lý chiến lược và toàn bộ hệ thống supply chain.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8427), 129, "Giám đốc chuỗi cung ứng" },
                    { 919, "Điều phối sản xuất và kế hoạch vật tư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8428), 129, "Quản lý sản xuất/Quản lý nguyên vật liệu (PMC)" },
                    { 920, "Các công việc khác thuộc kho vận và giao hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8428), 130, "Việc làm Kho vận/Giao hàng khác" },
                    { 921, "Tư vấn cải thiện vận hành, mô hình tổ chức và quy trình doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8429), 131, "Tư vấn quản lý doanh nghiệp" },
                    { 922, "Xây dựng chiến lược phát triển, mở rộng thị trường và định hướng doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8430), 131, "Tư vấn chiến lược" },
                    { 923, "Tư vấn tài chính doanh nghiệp, đầu tư, phân tích dòng tiền và rủi ro.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8431), 131, "Tư vấn tài chính" },
                    { 924, "Tư vấn giải pháp phần mềm, hệ thống, chuyển đổi số và công nghệ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8432), 131, "Tư vấn CNTT/IT Consultant" },
                    { 925, "Tư vấn cơ cấu nhân sự, đào tạo, C&B và quản trị nhân lực.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8433), 131, "Tư vấn nhân sự" },
                    { 926, "Tìm kiếm nhân sự cấp cao và tư vấn tuyển dụng chuyên sâu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8434), 131, "Tư vấn headhunting" },
                    { 927, "Tư vấn tâm lý cá nhân, gia đình và sức khỏe tinh thần.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8435), 131, "Tư vấn tâm lý" },
                    { 928, "Tư vấn quan hệ, hôn nhân và hòa giải gia đình.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8435), 131, "Tư vấn hôn nhân" },
                    { 929, "Thu thập, phân tích dữ liệu thị trường và hành vi khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8436), 131, "Nghiên cứu thị trường (Market Research)" },
                    { 930, "Phân tích dữ liệu kinh doanh để đề xuất giải pháp tối ưu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8437), 131, "Phân tích dữ liệu" },
                    { 931, "Các công việc tư vấn chuyên môn khác theo nhu cầu doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8437), 131, "Các vị trí tư vấn khác" },
                    { 932, "Chăm sóc bệnh nhân, hỗ trợ bác sĩ và theo dõi tình trạng sức khỏe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8438), 132, "Y tá/Điều dưỡng" },
                    { 933, "Quản lý đội ngũ điều dưỡng và điều phối chăm sóc y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8439), 132, "Y tá trưởng/Điều dưỡng trưởng" },
                    { 934, "Chăm sóc mẹ và bé, hỗ trợ sinh nở và phục hồi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8440), 132, "Hộ lý/Hộ sinh" },
                    { 935, "Khám, điều trị và phẫu thuật các bệnh lý ngoại khoa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8440), 133, "Bác sĩ ngoại khoa" },
                    { 936, "Chẩn đoán và điều trị bệnh lý nội tạng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8441), 133, "Bác sĩ nội khoa" },
                    { 937, "Khám và điều trị bệnh về da liễu và thẩm mỹ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8442), 133, "Bác sĩ da liễu" },
                    { 938, "Chăm sóc sức khỏe sinh sản và thai kỳ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8443), 133, "Bác sĩ sản khoa và phụ khoa" },
                    { 939, "Khám chữa bệnh cho trẻ sơ sinh và trẻ em.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8443), 133, "Bác sĩ nhi khoa" },
                    { 940, "Khám và điều trị bệnh về mắt.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8444), 133, "Bác sĩ nhãn khoa" },
                    { 941, "Tư vấn và điều trị các vấn đề sức khỏe tinh thần.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8445), 133, "Bác sĩ tâm lý" },
                    { 942, "Thực hiện thẩm mỹ nội khoa và ngoại khoa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8445), 133, "Bác sĩ thẩm mỹ" },
                    { 943, "Khám tổng quát và điều trị đa chuyên khoa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8446), 133, "Bác sĩ đa khoa" },
                    { 944, "Điều trị các bệnh về tai, mũi, họng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8447), 133, "Bác sĩ tai mũi họng" },
                    { 945, "Thực hiện siêu âm chẩn đoán hình ảnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8448), 133, "Bác sĩ siêu âm" },
                    { 946, "Gây mê và hồi sức người bệnh trong phẫu thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8448), 133, "Bác sĩ gây mê hồi sức" },
                    { 947, "Khám chữa bệnh bằng Đông y và y học cổ truyền.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8449), 133, "Bác sĩ y học cổ truyền" },
                    { 948, "Khám và điều trị răng hàm mặt.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8450), 133, "Bác sĩ nha khoa" },
                    { 949, "Thực hiện xét nghiệm máu, nước tiểu và mẫu sinh học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8452), 133, "Kỹ thuật viên xét nghiệm" },
                    { 950, "Thực hiện X-ray, CT, MRI và các kỹ thuật hình ảnh khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8452), 133, "Kỹ thuật viên chẩn đoán hình ảnh" },
                    { 951, "Hỗ trợ gây mê và hồi sức trong phẫu thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8453), 133, "Kỹ thuật viên gây mê" },
                    { 952, "Đo mắt và hỗ trợ bác sĩ nhãn khoa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8454), 133, "Kỹ thuật viên đo thị lực" },
                    { 953, "Quản lý bệnh viện, phòng khám và hệ thống y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8454), 133, "Quản lý y tế" },
                    { 954, "Các chuyên khoa khác theo hệ thống y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8455), 133, "Các vị trí bác sĩ khác" },
                    { 955, "Điều trị và phục hồi chức năng cho bệnh nhân.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8456), 134, "Chuyên viên vật lý trị liệu" },
                    { 956, "Xây dựng chế độ dinh dưỡng và tư vấn sức khỏe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8459), 134, "Chuyên gia dinh dưỡng/quản lý sức khoẻ" },
                    { 957, "Thực hiện châm cứu, bấm huyệt phục hồi sức khỏe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8459), 134, "Kỹ thuật viên châm cứu bấm huyệt" },
                    { 958, "Massage trị liệu, thư giãn và hỗ trợ hồi phục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8460), 134, "Nhân viên massage" },
                    { 959, "Hỗ trợ tập luyện và phục hồi cơ – khớp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8461), 134, "Kỹ thuật viên phục hồi chức năng" },
                    { 960, "Chăm sóc sau sinh và chăm sóc trẻ sơ sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8461), 134, "Chăm sóc mẹ và bé" },
                    { 961, "Các vị trí chăm sóc sức khỏe khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8462), 134, "Chuyên môn Vật lý trị liệu và chăm sóc sức khỏe khác" },
                    { 962, "Tư vấn và cấp phát thuốc theo chỉ định.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8463), 135, "Dược sĩ/Bán thuốc" },
                    { 963, "Quản lý hoạt động hiệu thuốc và kiểm soát dược phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8464), 135, "Quản lý cửa hàng thuốc" },
                    { 964, "Nghiên cứu tế bào, sinh học phân tử và vi sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8464), 135, "Nghiên cứu sinh học" },
                    { 965, "Nghiên cứu phát triển thuốc và sản phẩm y dược.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8465), 135, "R&D y dược" },
                    { 966, "Ứng dụng tin sinh học vào nghiên cứu y sinh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8466), 135, "Kỹ sư Bioinformatics" },
                    { 967, "Tham gia sản xuất và kiểm soát chất lượng dược phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8466), 135, "Sản xuất dược phẩm" },
                    { 968, "Đăng ký sản phẩm dược phẩm với cơ quan quản lý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8467), 135, "Đăng ký dược phẩm" },
                    { 969, "Điều phối dự án trong lĩnh vực y dược.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8468), 135, "Quản lý dự án y dược" },
                    { 970, "Thực hiện nuôi cấy tế bào phục vụ nghiên cứu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8469), 135, "Kỹ thuật viên nuôi cấy tế bào" },
                    { 971, "Các vị trí khác thuộc dược phẩm và công nghệ sinh học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8469), 135, "Chuyên môn Dược phẩm/Công nghệ sinh học khác" },
                    { 972, "Quản lý, bảo trì và kiểm định thiết bị y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8470), 136, "Quản lý thiết bị y tế" },
                    { 973, "Phát triển hóa chất, test kit và thuốc thử y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8471), 136, "Phát triển thuốc thử" },
                    { 974, "Thực hiện thí nghiệm và phân tích mẫu trong phòng lab.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8471), 136, "Kỹ thuật viên phòng lab" },
                    { 975, "Quản lý hoạt động, thiết bị và an toàn phòng lab.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8473), 136, "Quản lý phòng lab" },
                    { 976, "Các vị trí khác trong thiết bị y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8474), 136, "Chuyên môn Thiết bị y tế khác" },
                    { 977, "Bán thiết bị y tế và vật tư tiêu hao cho bệnh viện/phòng khám.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8474), 137, "Kinh doanh thiết bị/vật tư y tế" },
                    { 978, "Giới thiệu và phân phối thuốc đến bệnh viện và nhà thuốc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8475), 137, "Trình dược viên" },
                    { 979, "Tư vấn thuốc và chăm sóc sức khỏe cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8476), 137, "Dược sĩ/Bán thuốc" },
                    { 980, "Tư vấn dịch vụ thẩm mỹ và chăm sóc sắc đẹp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8477), 137, "Tư vấn thẩm mỹ/Spa" },
                    { 981, "Tư vấn điều trị răng, dịch vụ nha khoa.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8477), 137, "Tư vấn nha khoa" },
                    { 982, "Bán các dịch vụ liên quan đến y tế và sức khỏe.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8478), 137, "Kinh doanh dịch vụ y tế" },
                    { 983, "Các vị trí kinh doanh khác thuộc ngành y tế – dược – làm đẹp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8479), 137, "Sales Dược/Y tế/Sức khoẻ/Làm đẹp khác" },
                    { 984, "Thực hiện thử nghiệm lâm sàng cho thuốc và sản phẩm y tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8480), 138, "Thử nghiệm lâm sàng" },
                    { 985, "Các vị trí khác trong dược – y tế – sức khỏe – CNSH.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8480), 138, "Chuyên môn Dược/Y tế/Sức khoẻ/Công nghệ sinh học khác" },
                    { 986, "Thiết kế ấn phẩm, poster, banner và nhận diện thương hiệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8481), 139, "Thiết kế đồ họa (Graphic Design)" },
                    { 987, "Minh họa hình ảnh, vẽ digital và concept nghệ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8482), 139, "Illustration" },
                    { 988, "Thiết kế giao diện và tối ưu trải nghiệm người dùng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8483), 139, "UI/UX Design" },
                    { 989, "Dựng mô hình 3D cho game, phim hoặc sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8483), 139, "3D Modeler" },
                    { 990, "Các vị trí khác trong thiết kế đồ hoạ, UI/UX.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8484), 139, "Chuyên môn Thiết kế Đồ hoạ/Giao diện/Trải nghiệm khác" },
                    { 991, "Thiết kế kiến trúc công trình, nhà ở, nội ngoại thất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8485), 140, "Kiến trúc sư" },
                    { 992, "Thiết kế không gian, bố cục nội thất và phối màu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8485), 140, "Thiết kế nội thất" },
                    { 993, "Thiết kế không gian triển lãm, showroom và sự kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8509), 140, "Thiết kế triển lãm/trưng bày" },
                    { 994, "Thiết kế công viên, sân vườn và cảnh quan đô thị.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8510), 140, "Thiết kế cảnh quan" },
                    { 995, "Thiết kế đạo cụ, bối cảnh và không gian sân khấu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8511), 140, "Thiết kế mỹ thuật sân khấu" },
                    { 996, "Triển khai bản vẽ kỹ thuật bằng AutoCAD.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8512), 140, "Vẽ AutoCAD" },
                    { 997, "Các vị trí thiết kế khác thuộc kiến trúc – nội thất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8512), 140, "Chuyên môn Thiết kế Nhà/Nội thất/Môi trường khác" },
                    { 998, "Thiết kế đồ nội thất, mô hình sản phẩm, concept 3D.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8513), 141, "Thiết kế sản phẩm nội thất" },
                    { 999, "Thiết kế sản phẩm và giải pháp công nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8514), 141, "Chuyên môn Thiết kế Công nghiệp" },
                    { 1000, "Thiết kế bao bì sản phẩm, hộp giấy, nhãn mác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8515), 141, "Thiết kế bao bì" },
                    { 1001, "Thiết kế nữ trang, trang sức theo yêu cầu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8516), 141, "Thiết kế đồ trang sức" },
                    { 1002, "Triển khai bản vẽ kỹ thuật cho sản xuất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8517), 141, "Vẽ kỹ thuật" },
                    { 1003, "Thiết kế trang phục, concept thời trang và bộ sưu tập.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8518), 142, "Chuyên môn Thiết kế Thời trang" },
                    { 1004, "Thiết kế rập, mẫu kỹ thuật cho may mặc.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8519), 142, "Thiết kế rập" },
                    { 1005, "Thiết kế hoạ tiết và chất liệu cho vải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8519), 142, "Thiết kế vải" },
                    { 1006, "Minh hoạ nhân vật, bối cảnh hoặc đồ họa game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8520), 143, "Illustration" },
                    { 1007, "Thiết kế hoạt hình 2D/3D cho phim và game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8521), 143, "Animation Design" },
                    { 1008, "Thiết kế chuyển động cho video, TVC và quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8522), 143, "Motion Graphic" },
                    { 1009, "Vẽ manga, comic và truyện minh hoạ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8522), 143, "Hoạ sĩ truyện tranh" },
                    { 1010, "Retouch ảnh phục vụ truyền thông, thương mại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8523), 143, "Chỉnh sửa ảnh (Retouch)" },
                    { 1011, "Vẽ concept nhân vật, môi trường cho game/phim.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8524), 143, "Concept Artist" },
                    { 1012, "Thiết kế gameplay, hệ thống và tài liệu game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8524), 143, "Game Design" },
                    { 1013, "Chụp ảnh và dựng video nghệ thuật.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8525), 143, "Photographer/Video Editor" },
                    { 1014, "Các vị trí khác trong nghệ thuật – hoạt hình – game.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8526), 143, "Chuyên môn Nghệ thuật/Hoạt hình/Game khác" },
                    { 1015, "Thu thập, phân tích hành vi người dùng để tối ưu sản phẩm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8527), 144, "Chuyên môn nghiên cứu người dùng" },
                    { 1016, "Quản lý đội ngũ thiết kế và tiến độ dự án.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8527), 145, "Quản lý/Giám sát thiết kế" },
                    { 1017, "Định hướng thiết kế tổng thể của dự án/thương hiệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8528), 145, "Giám đốc/Đạo diễn thiết kế" },
                    { 1018, "Phụ trách toàn bộ hình ảnh, concept và phong cách thị giác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8529), 145, "Giám đốc thiết kế hình ảnh (Visual)" },
                    { 1019, "Các vị trí quản lý khác trong lĩnh vực thiết kế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8530), 145, "Quản lý thiết kế khác" },
                    { 1020, "Các vị trí thiết kế khác ngoài danh mục chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8530), 146, "Chuyên môn Thiết kế khác" },
                    { 1021, "Phục vụ khách hàng tại nhà hàng, quán ăn, quán cà phê.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8531), 147, "Phục vụ" },
                    { 1022, "Thanh toán, xử lý hóa đơn và hỗ trợ khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8532), 147, "Thu ngân" },
                    { 1023, "Đón tiếp khách, sắp xếp bàn và hỗ trợ thông tin.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8532), 147, "Lễ tân/Đón tiếp" },
                    { 1024, "Quản lý đội lễ tân và vận hành khu vực đón khách.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8533), 147, "Quản lý lễ tân" },
                    { 1025, "Chế biến món ăn theo tiêu chuẩn của nhà hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8534), 147, "Đầu bếp" },
                    { 1026, "Quản lý khu bếp và xây dựng menu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8536), 147, "Bếp trưởng" },
                    { 1027, "Hỗ trợ đầu bếp sơ chế và chế biến món ăn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8537), 147, "Phụ bếp" },
                    { 1028, "Quản lý nhân sự và quy trình vận hành khu bếp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8537), 147, "Quản lý bếp" },
                    { 1029, "Làm bánh mì, bánh ngọt và các sản phẩm liên quan.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8538), 147, "Thợ làm bánh" },
                    { 1030, "Pha chế đồ uống và phục vụ tại quầy bar.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8539), 147, "Pha chế (Barista)" },
                    { 1031, "Tư vấn và phục vụ rượu vang cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8540), 147, "Chuyên gia thẩm rượu" },
                    { 1032, "Quản lý hoạt động và nhân sự của nhà hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8540), 147, "Quản lý nhà hàng" },
                    { 1033, "Giao đồ ăn, thức uống cho khách hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8541), 147, "Shipper (Nhân viên giao hàng)" },
                    { 1034, "Các vị trí khác thuộc nhóm dịch vụ F&B.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8542), 147, "Chuyên môn Nhà hàng/Dịch vụ ăn uống khác" },
                    { 1035, "Đón tiếp khách, làm thủ tục check-in/check-out.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8542), 148, "Lễ tân/Đón tiếp" },
                    { 1036, "Hỗ trợ hành lý và hướng dẫn khách trong khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8543), 148, "Bellman (nhân viên hành lý)" },
                    { 1037, "Dọn phòng và chuẩn bị phòng cho khách.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8546), 148, "Buồng phòng" },
                    { 1038, "Giặt ủi và bảo quản đồ vải khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8546), 148, "Giặt là" },
                    { 1039, "Đỗ xe và hỗ trợ khách tại khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8547), 148, "Nhân viên đỗ xe (Valet Parking)" },
                    { 1040, "Quản lý toàn bộ hoạt động khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8548), 148, "Quản lý khách sạn" },
                    { 1041, "Vận hành homestay, villa và khu lưu trú.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8548), 148, "Quản lý homestay" },
                    { 1042, "Các vị trí khác trong khách sạn và khu lưu trú.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8549), 148, "Chuyên môn Khách sạn/Dịch vụ cư trú khác" },
                    { 1043, "Dẫn đoàn và thuyết minh điểm đến.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8550), 149, "Hướng dẫn viên du lịch" },
                    { 1044, "Xây dựng và vận hành tour du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8551), 149, "Điều hành tour" },
                    { 1045, "Xử lý hồ sơ visa du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8551), 149, "Nhân viên visa" },
                    { 1046, "Tư vấn và bán tour du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8552), 149, "Sales Tour/Kinh doanh du lịch" },
                    { 1047, "Các vị trí khác thuộc ngành du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8553), 149, "Chuyên môn Dịch vụ du lịch khác" },
                    { 1048, "Kinh doanh sản phẩm/dịch vụ cho nhà hàng – khách sạn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8554), 150, "Kinh doanh HORECA" },
                    { 1049, "Bán tour và gói du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8554), 150, "Sales Tour/Kinh doanh du lịch" },
                    { 1050, "Kinh doanh hội nghị – hội thảo – sự kiện.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8555), 150, "Kinh doanh khách đoàn (MICE)" },
                    { 1051, "Đặt vé máy bay và dịch vụ du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8556), 150, "Bán vé máy bay (Ticketing/Booker)" },
                    { 1052, "Kinh doanh phòng ở và dịch vụ lưu trú.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8557), 150, "Kinh doanh khách sạn" },
                    { 1053, "Quản lý bán phòng qua Booking, Agoda,...", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8558), 150, "Kinh doanh OTA" },
                    { 1054, "Các vị trí sale khác thuộc ngành F&B – du lịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8559), 150, "Sales Nhà hàng/Khách sạn/Du lịch khác" },
                    { 1055, "Các vị trí khác ngoài danh mục chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8560), 151, "Chuyên môn Nhà hàng/Khách sạn/Du lịch khác" },
                    { 1056, "Vận hành và tối ưu hệ thống năng lượng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8560), 152, "Kỹ sư năng lượng" },
                    { 1057, "Thiết kế hệ thống điện mặt trời.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8561), 152, "Kỹ sư điện mặt trời" },
                    { 1058, "Thiết kế và quản lý công trình thủy lợi.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8562), 152, "Kỹ sư thủy lợi" },
                    { 1059, "Khảo sát địa chất và thăm dò khoáng sản.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8562), 152, "Kỹ sư địa chất" },
                    { 1060, "Các vị trí khác trong năng lượng – địa chất.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8563), 152, "Chuyên môn Năng lượng/Địa chất khác" },
                    { 1061, "Đảm bảo an toàn lao động và hệ thống HSE trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8564), 153, "Kỹ sư an toàn lao động (HSE)" },
                    { 1062, "Quản lý chất thải, khí thải và giải pháp bảo vệ môi trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8565), 153, "Kỹ sư môi trường" },
                    { 1063, "Xử lý rác thải, vệ sinh công cộng và bảo vệ môi trường.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8565), 153, "Công nhân môi trường" },
                    { 1064, "Vận hành và bảo trì hệ thống xử lý nước thải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8566), 153, "Vận hành hệ thống xử lý nước thải" },
                    { 1065, "Chăm sóc cây trồng và quy trình nông nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8567), 154, "Kỹ thuật viên nông nghiệp/trồng trọt" },
                    { 1066, "Chăm sóc vật nuôi trong trang trại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8567), 154, "Công nhân chăn nuôi" },
                    { 1067, "Quản lý rừng và tài nguyên lâm nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8568), 154, "Kỹ sư lâm nghiệp" },
                    { 1068, "Bảo vệ rừng và đa dạng sinh học.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8569), 154, "Kiểm lâm" },
                    { 1069, "Các vị trí khác thuộc nhóm nông – lâm – ngư.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8570), 154, "Chuyên môn Nông/Lâm/Ngư nghiệp khác" },
                    { 1070, "Các công việc khác trong nhóm này.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8570), 155, "Chuyên môn Năng lượng/Môi trường/Nông nghiệp khác" },
                    { 1071, "Điều phối phương tiện và tài xế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8571), 156, "Giám sát/Điều phối vận tải" },
                    { 1072, "Phân loại hàng hóa tại kho/bưu cục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8572), 156, "Phân loại/Sắp xếp hàng hoá" },
                    { 1073, "Bốc xếp hàng hóa tại kho/cảng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8572), 156, "Công nhân bốc xếp hàng hóa" },
                    { 1074, "Vận hành xe nâng trong kho.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8573), 156, "Tài xế lái xe nâng" },
                    { 1075, "Vận chuyển hàng bằng xe tải.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8574), 156, "Tài xế xe tải" },
                    { 1076, "Lái container vận chuyển hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8575), 156, "Tài xế container" },
                    { 1077, "Lái xe đường dài xuyên tỉnh.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8576), 156, "Tài xế lái xe đường dài" },
                    { 1078, "Lái xe chuyên dụng (xe cẩu, xe bồn,...).", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8577), 156, "Tài xế lái xe chuyên dụng" },
                    { 1079, "Lái xe khách tuyến cố định/hợp đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8578), 156, "Tài xế xe khách" },
                    { 1080, "Hỗ trợ tài xế giao nhận hàng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8578), 156, "Phụ xe" },
                    { 1081, "Các công việc vận tải khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8579), 156, "Dịch vụ vận tải khác" },
                    { 1082, "Lái Grab/Be/Gojek.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8580), 157, "Tài xế công nghệ" },
                    { 1083, "Lái taxi đưa đón khách.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8581), 157, "Tài xế taxi" },
                    { 1084, "Lái xe theo yêu cầu cá nhân/doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8581), 157, "Tài xế lái xe thuê" },
                    { 1085, "Lái xe nội bộ cho công ty.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8582), 157, "Tài xế lái xe văn phòng" },
                    { 1086, "Lái các xe theo bằng B2.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8583), 157, "Tài xế B2" },
                    { 1087, "Lái xe riêng cho lãnh đạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8583), 157, "Lái xe cho sếp" },
                    { 1088, "Đưa đón khách theo tour/hợp đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8584), 157, "Tài xế xe khách" },
                    { 1089, "Các vị trí đưa đón khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8585), 157, "Dịch vụ đưa đón khác" },
                    { 1090, "Biên dịch và phiên dịch tiếng Anh trong doanh nghiệp hoặc tổ chức.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8585), 158, "Biên phiên dịch tiếng Anh" },
                    { 1091, "Biên dịch và phiên dịch tiếng Trung cho tài liệu hoặc hội thoại.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8586), 158, "Biên phiên dịch tiếng Trung" },
                    { 1092, "Thực hiện dịch thuật và phiên dịch tiếng Nhật trong nhiều lĩnh vực.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8587), 158, "Biên phiên dịch tiếng Nhật" },
                    { 1093, "Dịch tài liệu, hợp đồng và phiên dịch giao tiếp tiếng Hàn.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8588), 158, "Biên phiên dịch tiếng Hàn" },
                    { 1094, "Dịch thuật và phiên dịch tiếng Nga cho doanh nghiệp và giáo dục.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8588), 158, "Biên phiên dịch tiếng Nga" },
                    { 1095, "Biên dịch và phiên dịch tiếng Tây Ban Nha cho nhiều lĩnh vực.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8589), 158, "Biên phiên dịch tiếng Tây Ban Nha" },
                    { 1096, "Dịch thuật và phiên dịch tiếng Đức trong doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8590), 158, "Biên phiên dịch tiếng Đức" },
                    { 1097, "Biên phiên dịch tài liệu và hội thoại tiếng Pháp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8590), 158, "Biên phiên dịch tiếng Pháp" },
                    { 1098, "Dịch thuật các ngôn ngữ khác ngoài danh sách chính.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8591), 158, "Biên phiên dịch ngôn ngữ khác" },
                    { 1099, "Thực hiện dịch nhiều ngôn ngữ, hỗ trợ dự án quốc tế.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8592), 158, "Biên phiên dịch đa ngôn ngữ" },
                    { 1100, "Tư vấn giải pháp dịch thuật và tiêu chuẩn ngôn ngữ cho doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8593), 158, "Tư vấn dịch thuật" },
                    { 1101, "Tư vấn pháp lý, đại diện tố tụng và giải quyết tranh chấp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8593), 159, "Luật sư" },
                    { 1102, "Nghiên cứu hồ sơ, soạn thảo hợp đồng và hỗ trợ pháp lý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8594), 159, "Chuyên viên pháp lý" },
                    { 1103, "Hỗ trợ công chứng viên xử lý hồ sơ và giấy tờ pháp lý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8595), 159, "Thư ký công chứng viên" },
                    { 1104, "Hỗ trợ luật sư quản lý hồ sơ, tài liệu và công việc pháp lý.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8595), 159, "Thư ký văn phòng luật sư/Thư ký pháp lý" },
                    { 1105, "Các vị trí pháp lý khác tại Agency/Firm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8596), 159, "Chuyên môn Pháp lý khác" },
                    { 1106, "Tư vấn, rà soát pháp lý và hỗ trợ pháp luật nội bộ doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8597), 160, "Pháp chế" },
                    { 1107, "Quản lý bộ phận pháp chế và chiến lược tuân thủ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8598), 160, "Giám đốc pháp chế" },
                    { 1108, "Các công việc pháp chế nội bộ khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8598), 160, "Chuyên môn Pháp chế khác" },
                    { 1109, "Các vị trí liên quan vận tải biển, kỹ thuật và khai thác tàu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8599), 161, "Chuyên môn Hàng hải" },
                    { 1110, "Các vị trí hoạt động xã hội, cộng đồng, dự án phi lợi nhuận.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8600), 162, "Chuyên môn NGO/Phi chính phủ/Phi lợi nhuận" },
                    { 1111, "Các nghề không thuộc nhóm ngành đã liệt kê.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8601), 163, "Chuyên môn khác" },
                    { 1112, "Thực hiện chiến dịch marketing online.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7577), 18, "Digital Marketing" },
                    { 1113, "Xây dựng nội dung marketing đa nền tảng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7578), 18, "Content Marketing" },
                    { 1114, "Sản xuất nội dung sáng tạo trên mạng xã hội.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7578), 18, "Content Creator" },
                    { 1115, "Các vị trí marketing khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7579), 18, "Chuyên môn Marketing" },
                    { 1116, "Quản lý nội dung và tương tác mạng xã hội.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7580), 18, "Social Media" },
                    { 1117, "Livestream bán hàng và xây dựng tệp người xem.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7581), 18, "Host Livestream/Streamer" },
                    { 1118, "Tối ưu website tăng thứ hạng tìm kiếm.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7581), 18, "SEO" },
                    { 1119, "Quản lý chiến dịch marketing và đội ngũ.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7582), 18, "Marketing Manager" },
                    { 1120, "Xây dựng và phát triển thương hiệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7583), 18, "Brand Marketing" },
                    { 1121, "Chạy quảng cáo Facebook, Google, TikTok...", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7584), 18, "Chạy Ads" },
                    { 1122, "Thiết kế ấn phẩm thương hiệu, visual.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7584), 19, "Thiết kế đồ họa (Graphic Design)" },
                    { 1123, "Chụp ảnh và dựng video quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7585), 19, "Photographer/Video Editor" },
                    { 1124, "Lên kế hoạch và đặt mua quảng cáo truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7586), 19, "Media Planner/Buyer Executive" },
                    { 1125, "Lên ý tưởng và concept sáng tạo cho chiến dịch.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7587), 19, "Creative Planner" },
                    { 1126, "Thiết kế hoạt hình 2D/3D cho quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7588), 19, "Animation Design" },
                    { 1127, "Quản lý chiến dịch quảng cáo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7588), 19, "Campaign Manager" },
                    { 1128, "Quản lý sản xuất TVC, video, shooting.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7589), 19, "Production Manager" },
                    { 1129, "Quản lý kỹ thuật hệ thống quảng cáo số.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7590), 19, "Ad Operations Manager" },
                    { 1130, "Triển khai booking bài PR, quảng cáo báo chí.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7591), 19, "Media Placement Specialist" },
                    { 1131, "Các vị trí sáng tạo khác.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7592), 19, "Quảng cáo - Sáng tạo khác" },
                    { 1132, "Các vị trí khác trong ngành quảng cáo – sáng tạo.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7592), 19, "Chuyên môn Quảng cáo/Sáng tạo khác" },
                    { 1133, "Phụ trách hoạt động quan hệ công chúng và truyền thông thương hiệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7593), 20, "PR Specialist" },
                    { 1134, "Thực hiện các hoạt động PR xây dựng hình ảnh tổ chức.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7594), 20, "Chuyên môn Quan hệ Công chúng" },
                    { 1135, "Quản lý danh tiếng và định vị thương hiệu.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7595), 20, "Xây dựng và bảo vệ thương hiệu" },
                    { 1136, "Kết nối nội bộ và truyền tải thông điệp doanh nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7598), 20, "Truyền thông nội bộ" },
                    { 1137, "Triển khai các hoạt động CSR và kết nối cộng đồng.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7598), 20, "Phát triển cộng đồng" },
                    { 1138, "Truyền thông doanh nghiệp, duy trì hình ảnh chuyên nghiệp.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7599), 20, "Corporate Communication" },
                    { 1139, "Làm việc với báo chí, viết thông cáo và quản lý truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7623), 20, "Quan hệ báo chí" },
                    { 1140, "Quản lý khủng hoảng, xử lý rủi ro truyền thông.", new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7624), 20, "Xử lý khủng hoảng truyền thông" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoCaoNoiDungs_CongViecId",
                table: "BaoCaoNoiDungs",
                column: "CongViecId");

            migrationBuilder.CreateIndex(
                name: "IX_BaoCaoNoiDungs_CVId",
                table: "BaoCaoNoiDungs",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_BaoCaoNoiDungs_NguoiDungId",
                table: "BaoCaoNoiDungs",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_ChungChis_CVId",
                table: "ChungChis",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_ChungChiSinhViens_SinhVienProfileId",
                table: "ChungChiSinhViens",
                column: "SinhVienProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganhs_NgheNghiepId",
                table: "ChuyenNganhs",
                column: "NgheNghiepId");

            migrationBuilder.CreateIndex(
                name: "IX_CongTys_AdminXacMinhId",
                table: "CongTys",
                column: "AdminXacMinhId");

            migrationBuilder.CreateIndex(
                name: "IX_CongTys_TinhThanhId",
                table: "CongTys",
                column: "TinhThanhId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecChuyenNganhs_ChuyenNganhId",
                table: "CongViecChuyenNganhs",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecChuyenNganhs_CongViecId",
                table: "CongViecChuyenNganhs",
                column: "CongViecId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecKhuVucs_CongViecId",
                table: "CongViecKhuVucs",
                column: "CongViecId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecKhuVucs_TinhThanhId",
                table: "CongViecKhuVucs",
                column: "TinhThanhId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_CapBacId",
                table: "CongViecs",
                column: "CapBacId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_ChuyenNganhId",
                table: "CongViecs",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_CongTyId",
                table: "CongViecs",
                column: "CongTyId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_LinhVucId",
                table: "CongViecs",
                column: "LinhVucId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_LoaiCongViecId",
                table: "CongViecs",
                column: "LoaiCongViecId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MucKinhNghiemId",
                table: "CongViecs",
                column: "MucKinhNghiemId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_NguoiDungId",
                table: "CongViecs",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_NguoiDuyetId",
                table: "CongViecs",
                column: "NguoiDuyetId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_NguoiDungId",
                table: "CVs",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_TemplateId",
                table: "CVs",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_DonUngTuyens_CongViecId",
                table: "DonUngTuyens",
                column: "CongViecId");

            migrationBuilder.CreateIndex(
                name: "IX_DonUngTuyens_CvId",
                table: "DonUngTuyens",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_DonUngTuyens_NguoiDungId",
                table: "DonUngTuyens",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_DuAns_CVId",
                table: "DuAns",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_GiaiThuongs_CvId",
                table: "GiaiThuongs",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_HoatDongs_CvId",
                table: "HoatDongs",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_HoatDongSinhViens_SinhVienProfileId",
                table: "HoatDongSinhViens",
                column: "SinhVienProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_HocVans_CVId",
                table: "HocVans",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_HocVanSinhViens_SinhVienProfileId",
                table: "HocVanSinhViens",
                column: "SinhVienProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_KhieuNais_NguoiDungId",
                table: "KhieuNais",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_KinhNghiems_CVId",
                table: "KinhNghiems",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_KinhNghiemSinhViens_SinhVienProfileId",
                table: "KinhNghiemSinhViens",
                column: "SinhVienProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_KyNangChuyenMonSinhViens_SinhVienProfileId",
                table: "KyNangChuyenMonSinhViens",
                column: "SinhVienProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_KyNangs_CVId",
                table: "KyNangs",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_NgheNghieps_LinhVucId",
                table: "NgheNghieps",
                column: "LinhVucId");

            migrationBuilder.CreateIndex(
                name: "IX_NgoaiNguSinhViens_SinhVienProfileId",
                table: "NgoaiNguSinhViens",
                column: "SinhVienProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_CongTyId",
                table: "NguoiDungs",
                column: "CongTyId");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_NguoiXacThucId",
                table: "NguoiDungs",
                column: "NguoiXacThucId");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiThamChieus_CvId",
                table: "NguoiThamChieus",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiThamChieuSinhViens_SinhVienProfileId",
                table: "NguoiThamChieuSinhViens",
                column: "SinhVienProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienProfiles_NguoiDungId",
                table: "SinhVienProfiles",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_SoThichs_CvId",
                table: "SoThichs",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_ThongBaos_NguoiDungId",
                table: "ThongBaos",
                column: "NguoiDungId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoCaoNoiDungs_CVs_CVId",
                table: "BaoCaoNoiDungs",
                column: "CVId",
                principalTable: "CVs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoCaoNoiDungs_CongViecs_CongViecId",
                table: "BaoCaoNoiDungs",
                column: "CongViecId",
                principalTable: "CongViecs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoCaoNoiDungs_NguoiDungs_NguoiDungId",
                table: "BaoCaoNoiDungs",
                column: "NguoiDungId",
                principalTable: "NguoiDungs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChungChis_CVs_CVId",
                table: "ChungChis",
                column: "CVId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChungChiSinhViens_SinhVienProfiles_SinhVienProfileId",
                table: "ChungChiSinhViens",
                column: "SinhVienProfileId",
                principalTable: "SinhVienProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CongTys_NguoiDungs_AdminXacMinhId",
                table: "CongTys",
                column: "AdminXacMinhId",
                principalTable: "NguoiDungs",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CongTys_NguoiDungs_AdminXacMinhId",
                table: "CongTys");

            migrationBuilder.DropTable(
                name: "BaoCaoNoiDungs");

            migrationBuilder.DropTable(
                name: "ChungChis");

            migrationBuilder.DropTable(
                name: "ChungChiSinhViens");

            migrationBuilder.DropTable(
                name: "CongViecChuyenNganhs");

            migrationBuilder.DropTable(
                name: "CongViecKhuVucs");

            migrationBuilder.DropTable(
                name: "DonUngTuyens");

            migrationBuilder.DropTable(
                name: "DuAns");

            migrationBuilder.DropTable(
                name: "GiaiThuongs");

            migrationBuilder.DropTable(
                name: "HeThongCauHinhs");

            migrationBuilder.DropTable(
                name: "HoatDongs");

            migrationBuilder.DropTable(
                name: "HoatDongSinhViens");

            migrationBuilder.DropTable(
                name: "HocVans");

            migrationBuilder.DropTable(
                name: "HocVanSinhViens");

            migrationBuilder.DropTable(
                name: "KhieuNais");

            migrationBuilder.DropTable(
                name: "KinhNghiems");

            migrationBuilder.DropTable(
                name: "KinhNghiemSinhViens");

            migrationBuilder.DropTable(
                name: "KyNangChuyenMonSinhViens");

            migrationBuilder.DropTable(
                name: "KyNangs");

            migrationBuilder.DropTable(
                name: "NgoaiNguSinhViens");

            migrationBuilder.DropTable(
                name: "NguoiThamChieus");

            migrationBuilder.DropTable(
                name: "NguoiThamChieuSinhViens");

            migrationBuilder.DropTable(
                name: "SoThichs");

            migrationBuilder.DropTable(
                name: "ThongBaos");

            migrationBuilder.DropTable(
                name: "TuKhoaTimKiems");

            migrationBuilder.DropTable(
                name: "CongViecs");

            migrationBuilder.DropTable(
                name: "SinhVienProfiles");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "CapBacs");

            migrationBuilder.DropTable(
                name: "ChuyenNganhs");

            migrationBuilder.DropTable(
                name: "LoaiCongViecs");

            migrationBuilder.DropTable(
                name: "MucKinhNghiems");

            migrationBuilder.DropTable(
                name: "CVTemplates");

            migrationBuilder.DropTable(
                name: "NgheNghieps");

            migrationBuilder.DropTable(
                name: "LinhVucs");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "CongTys");

            migrationBuilder.DropTable(
                name: "TinhThanhs");
        }
    }
}
