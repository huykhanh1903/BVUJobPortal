using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BVUJobPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddTrangThaiTimViecSinhVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ChoPhepNhaTuyenDungTim",
                table: "SinhVienProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DangTimViec",
                table: "SinhVienProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 164,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 165,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 166,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 167,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 168,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 169,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 170,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 171,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 172,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 173,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 174,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 175,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 176,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 177,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 178,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 179,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 180,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 181,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 182,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 183,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 184,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 185,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 186,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 187,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 188,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 189,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 190,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 191,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 192,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 193,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 194,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 195,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 196,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 197,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 198,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 199,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 200,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 201,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 202,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 203,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 204,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 205,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 206,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 207,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 208,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 209,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 210,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 211,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 212,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 213,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 214,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 215,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 216,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 217,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 218,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 219,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 220,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 221,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 222,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 223,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 224,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 225,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 226,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 227,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 228,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 229,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 230,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 231,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 232,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 233,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 234,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 235,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 236,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 237,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 238,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 239,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 240,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 241,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 242,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 243,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 244,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 245,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 246,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 247,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 248,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 249,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 250,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 251,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 252,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 253,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 254,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 255,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 256,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 257,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 258,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 259,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 260,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 261,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 262,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 263,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 264,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 265,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 266,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 267,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 268,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 269,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 270,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 271,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 272,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 273,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 274,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 275,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 276,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 277,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 278,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 279,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 280,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 281,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 282,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 283,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 284,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 285,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 286,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 287,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 288,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 289,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 290,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 291,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 292,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 293,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 294,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 295,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 296,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 297,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 298,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 299,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 300,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 301,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 302,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 303,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 304,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 305,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 306,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 307,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 308,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 309,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 310,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 311,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 312,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 313,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 314,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 315,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 316,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 317,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 318,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 319,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 320,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 321,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 322,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 323,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 324,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 325,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 326,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 327,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 328,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 329,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 330,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 331,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 332,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 333,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 334,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 335,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 336,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 337,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 338,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 339,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 340,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 341,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 342,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 343,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 344,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 345,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 346,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 347,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 348,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 349,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 350,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 351,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 352,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 353,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 354,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 355,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 356,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 357,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 358,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 359,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 360,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 361,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 362,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 363,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 364,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 365,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 366,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 367,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 368,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 369,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 370,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 371,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 372,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 373,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 374,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 375,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 376,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 377,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 378,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 379,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 380,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 381,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 382,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 383,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 384,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 385,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 386,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 387,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 388,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 389,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 390,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 391,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 392,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 393,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 394,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 395,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 396,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 397,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 398,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 399,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 400,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 401,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 402,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 403,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 404,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 405,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 406,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 407,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 408,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 409,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 410,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 411,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 412,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 413,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 414,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 415,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 416,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 417,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 418,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 419,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 420,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 421,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 422,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 423,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 424,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 425,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 426,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 427,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 428,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 429,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 430,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 431,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 432,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 433,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 434,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 435,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 436,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 437,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 438,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 439,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 440,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 441,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 442,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 443,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 444,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 445,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 446,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 447,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 448,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 449,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 450,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 451,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 452,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 453,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 454,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 455,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 456,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 457,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 458,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 459,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 460,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 461,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 462,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 463,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 464,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 465,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 466,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 467,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 468,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 469,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 470,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 471,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 472,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 473,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 474,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 475,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 476,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 477,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 478,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 479,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 480,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 481,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 482,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 483,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 484,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 485,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 486,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 487,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 488,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 489,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 490,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 491,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 492,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 493,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 494,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 495,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 496,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 497,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 498,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 499,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 500,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 501,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 502,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 503,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 504,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 505,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 506,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 507,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 508,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 509,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 510,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 511,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 512,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 513,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 514,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 515,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 516,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 517,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 518,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 519,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 520,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 521,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 522,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 523,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 524,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 525,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 526,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 527,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 528,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 529,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 530,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 531,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 532,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 533,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 534,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 535,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 536,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 537,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 538,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 539,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 540,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 541,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 542,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 543,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 544,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 545,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 546,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 547,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 548,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 549,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 550,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 551,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 552,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 553,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 554,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 566,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 567,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 568,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 569,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 570,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 571,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 572,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 573,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 574,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 575,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 576,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 577,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 578,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 579,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 580,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 581,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 582,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 583,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 584,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 585,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 586,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 587,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 588,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 589,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 590,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 591,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 592,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 609,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 610,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 611,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 612,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 613,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 614,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 615,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 616,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 617,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 618,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 619,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 620,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 621,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 622,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 623,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 624,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 625,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 626,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 627,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 628,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 629,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 630,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 631,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 632,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 633,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 634,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 635,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 636,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 637,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 638,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 639,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 640,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 641,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 642,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 643,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 644,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 645,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 646,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 647,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 648,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 649,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 650,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 651,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 652,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 653,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 654,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 655,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 656,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 657,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 658,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 659,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 660,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 661,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 662,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 663,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 664,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 665,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 666,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 667,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 668,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 669,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 670,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 671,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 672,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 673,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 674,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 675,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 676,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 677,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 678,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 679,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 680,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 681,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 682,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 683,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 684,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 685,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 686,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 687,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 688,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 689,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 690,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 691,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 692,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 693,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 694,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 695,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 696,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 697,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 698,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 699,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 700,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 701,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 702,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 703,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 704,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 705,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 706,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 707,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 708,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 709,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 710,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 711,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 712,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 713,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 714,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 715,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 716,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 717,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 718,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 719,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 720,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 721,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 722,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 723,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 724,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 725,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 726,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 727,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 728,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 729,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 730,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 731,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 732,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 733,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 734,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 735,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 736,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 737,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 738,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 739,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 740,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 741,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 742,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 743,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 744,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 745,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 746,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 747,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 748,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 749,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 750,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 751,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 752,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 753,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 754,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 755,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 756,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 757,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 758,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 759,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 760,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 761,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 762,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 763,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 764,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 765,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 766,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 767,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 768,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 769,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 770,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 771,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 772,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 773,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 774,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 775,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 776,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 777,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 778,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 779,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 780,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 781,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 782,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 783,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 784,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 785,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 786,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 787,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 788,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 789,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 790,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 791,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 792,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 793,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 794,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 795,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 796,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 797,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 798,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 799,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 800,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 801,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 802,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 803,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 804,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 805,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 806,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 807,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 808,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 809,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 810,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 811,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 812,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 813,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 814,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 815,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 816,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 817,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 818,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 819,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 820,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 821,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 822,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 823,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 824,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 825,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 826,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 827,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 828,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 829,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 830,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 831,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 832,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 833,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 834,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 835,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 836,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 837,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 838,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 839,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 840,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 841,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 842,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 843,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 844,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 845,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 846,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 847,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 848,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 849,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 850,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 851,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 852,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 853,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 854,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 855,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 856,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 857,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 858,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 859,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 860,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 861,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 862,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 863,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 864,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 865,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 866,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 867,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 868,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 869,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 870,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 871,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 872,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 873,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 874,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 875,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 876,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 877,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 878,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 879,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 880,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 881,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 882,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 883,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 884,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 885,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 886,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 887,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 888,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 889,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 890,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 891,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 892,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 893,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 894,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 895,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 896,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 897,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 898,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 899,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 900,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 901,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 902,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 903,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 904,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 905,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 906,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 907,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 908,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 909,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 910,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 911,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 912,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 913,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 914,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 915,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 916,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 917,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 918,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 919,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 920,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 921,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 922,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 923,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 924,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 925,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 926,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 927,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 928,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 929,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 930,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 931,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 932,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 933,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 934,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 935,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 936,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 937,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 938,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 939,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 940,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 941,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 942,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 943,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 944,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 945,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 946,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 947,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 948,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 949,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 950,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 951,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 952,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 953,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 954,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 955,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 956,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 957,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 958,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 959,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 960,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 961,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 962,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 963,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 964,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 965,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 966,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 967,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 968,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 969,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 970,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 971,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 972,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 973,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 974,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 975,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 976,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 977,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 978,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 979,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 980,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 981,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 982,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 983,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 984,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 985,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 986,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 987,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 988,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 989,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 990,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 991,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 992,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 993,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 994,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 995,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 996,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 997,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 998,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 999,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1000,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1001,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1002,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1003,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1004,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1005,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1006,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1007,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1008,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1009,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1010,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1011,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1012,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1013,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1014,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1015,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1016,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1017,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1018,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1019,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1020,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1021,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1022,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1023,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1024,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1025,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1026,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1027,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1028,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1029,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1030,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1031,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1032,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1033,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1034,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1035,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1036,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1037,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1038,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1039,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1040,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1041,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1042,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1043,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1044,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1045,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1046,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1047,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1048,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1049,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1050,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1051,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1052,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1053,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1054,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1055,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1056,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1057,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1058,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1059,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1060,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1061,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1062,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1063,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1064,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1065,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1066,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1067,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1068,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1069,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1070,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1071,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1072,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1073,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1074,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1075,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1076,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1077,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1078,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1079,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1080,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1081,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1082,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1083,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1084,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1085,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1086,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1087,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1088,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1089,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1090,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1091,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1092,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1093,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1094,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1095,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1096,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1097,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1098,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1099,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 13, 16, 56, 9, 586, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$GQhgC/TTD9WgjC8p2YKyZe4zIsZQCaWMP.x3Fw/mZPGRiXdiUpHqa", new DateTime(2025, 12, 13, 16, 56, 9, 704, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$VLxkjYJ11QNJ4a5VqrxKAeXBvSBhESfZckSsF.oVanN9.MI50Bmxi", new DateTime(2025, 12, 13, 16, 56, 9, 819, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$Nhjy5.DVDLt/TtAmPo3oUeNNKuVwHr.95GoQUkVhKG2GirO5NAeoG", new DateTime(2025, 12, 13, 16, 56, 10, 78, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$seiFbnOr27/eqy4ldaamEO1j2cBTZlCwEDT9dnUk.sljlIZ58fxa2", new DateTime(2025, 12, 13, 16, 56, 9, 949, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienProfiles_TinhThanhId",
                table: "SinhVienProfiles",
                column: "TinhThanhId");

            migrationBuilder.AddForeignKey(
                name: "FK_SinhVienProfiles_TinhThanhs_TinhThanhId",
                table: "SinhVienProfiles",
                column: "TinhThanhId",
                principalTable: "TinhThanhs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinhVienProfiles_TinhThanhs_TinhThanhId",
                table: "SinhVienProfiles");

            migrationBuilder.DropIndex(
                name: "IX_SinhVienProfiles_TinhThanhId",
                table: "SinhVienProfiles");

            migrationBuilder.DropColumn(
                name: "ChoPhepNhaTuyenDungTim",
                table: "SinhVienProfiles");

            migrationBuilder.DropColumn(
                name: "DangTimViec",
                table: "SinhVienProfiles");

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 164,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 165,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 166,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 167,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 168,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 169,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 170,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 171,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 172,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 173,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 174,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 175,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 176,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 177,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 178,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 179,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 180,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 181,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 182,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 183,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 184,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 185,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 186,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 187,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 188,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 189,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 190,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 191,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 192,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 193,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 194,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 195,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 196,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 197,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 198,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 199,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 200,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 201,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 202,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 203,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 204,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 205,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 206,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 207,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 208,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 209,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 210,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 211,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 212,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 213,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 214,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 215,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 216,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 217,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 218,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 219,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 220,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 221,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 222,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 223,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 224,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 225,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 226,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 227,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 228,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 229,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 230,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 231,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 232,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 233,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 234,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 235,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 236,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 237,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 238,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 239,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 240,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 241,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 242,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 243,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 244,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 245,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 246,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 247,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 248,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 249,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 250,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 251,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 252,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 253,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 254,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 255,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 256,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 257,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 258,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 259,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 260,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 261,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 262,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 263,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 264,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 265,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 266,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 267,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 268,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 269,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 270,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 271,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 272,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 273,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 274,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 275,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 276,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 277,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 278,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 279,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 280,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 281,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 282,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 283,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 284,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 285,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 286,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 287,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 288,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 289,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 290,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 291,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 292,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 293,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 294,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 295,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 296,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 297,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 298,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 299,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 300,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 301,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 302,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 303,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 304,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 305,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 306,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 307,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 308,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 309,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 310,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 311,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 312,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 313,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 314,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 315,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 316,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 317,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 318,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 319,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 320,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 321,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 322,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 323,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 324,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 325,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 326,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 327,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 328,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 329,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 330,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 331,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 332,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 333,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 334,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 335,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 336,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 337,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 338,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 339,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 340,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 341,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 342,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 343,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 344,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 345,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 346,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 347,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 348,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 349,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 350,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 351,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 352,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 353,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 354,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 355,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 356,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 357,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 358,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 359,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 360,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 361,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 362,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 363,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 364,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 365,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 366,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 367,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 368,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 369,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 370,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 371,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 372,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 373,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 374,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 375,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 376,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 377,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 378,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 379,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 380,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 381,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 382,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 383,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 384,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 385,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 386,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 387,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 388,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 389,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 390,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 391,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 392,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 393,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 394,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 395,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 396,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 397,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 398,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 399,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 400,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 401,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 402,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 403,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 404,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 405,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 406,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 407,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 408,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 409,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 410,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 411,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 412,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 413,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 414,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 415,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 416,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 417,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 418,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 419,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 420,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 421,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 422,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 423,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 424,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 425,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 426,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 427,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 428,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 429,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 430,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 431,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 432,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 433,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 434,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 435,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 436,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 437,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 438,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 439,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 440,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 441,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 442,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 443,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 444,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 445,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 446,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 447,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 448,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 449,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 450,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 451,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 452,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 453,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 454,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 455,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 456,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 457,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 458,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 459,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 460,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 461,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 462,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 463,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 464,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 465,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 466,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 467,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 468,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 469,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 470,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 471,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 472,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 473,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 474,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 475,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 476,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 477,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 478,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 479,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 480,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 481,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 482,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 483,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 484,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 485,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 486,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 487,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 488,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 489,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 490,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 491,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 492,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 493,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 494,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 495,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 496,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 497,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 498,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 499,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 500,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 501,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 502,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 503,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 504,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 505,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 506,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 507,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 508,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 509,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 510,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 511,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 512,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 513,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 514,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 515,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 516,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 517,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 518,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 519,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 520,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 521,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 522,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 523,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 524,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 525,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 526,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 527,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 528,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 529,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 530,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 531,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 532,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 533,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 534,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 535,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 536,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 537,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 538,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 539,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 540,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 541,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 542,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 543,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 544,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 545,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 546,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 547,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 548,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 549,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 550,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 551,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 552,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 553,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 554,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 566,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 567,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 568,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 569,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 570,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 571,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 572,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 573,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 574,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 575,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 576,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 577,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 578,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 579,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 580,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 581,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 582,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 583,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 584,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 585,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 586,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 587,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 588,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 589,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 590,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 591,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 592,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 609,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 610,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 611,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 612,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 613,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 614,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 615,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 616,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 617,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 618,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 619,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 620,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 621,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 622,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 623,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 624,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 625,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 626,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 627,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 628,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 629,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 630,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 631,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 632,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 633,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 634,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 635,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 636,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 637,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 638,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 639,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 640,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 641,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 642,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 643,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 644,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 645,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 646,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 647,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 648,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 649,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 650,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 651,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 652,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 653,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 654,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 655,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 656,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 657,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 658,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 659,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 660,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 661,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 662,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 663,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 664,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 665,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 666,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 667,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 668,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 669,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 670,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 671,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 672,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 673,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 674,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 675,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 676,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 677,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 678,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 679,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 680,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 681,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 682,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 683,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 684,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 685,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 686,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 687,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 688,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 689,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 690,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 691,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 692,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 693,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 694,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 695,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 696,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 697,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 698,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 699,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 700,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 701,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 702,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 703,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 704,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 705,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 706,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 707,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 708,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 709,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 710,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 711,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 712,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 713,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 714,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 715,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 716,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 717,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 718,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 719,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 720,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 721,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 722,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 723,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 724,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 725,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 726,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 727,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 728,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 729,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 730,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 731,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 732,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 733,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 734,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 735,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 736,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 737,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 738,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 739,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 740,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 741,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 742,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 743,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 744,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 745,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 746,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 747,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 748,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 749,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 750,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 751,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 752,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 753,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 754,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 755,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 756,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 757,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 758,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 759,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 760,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 761,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 762,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 763,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 764,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 765,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 766,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 767,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 768,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 769,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 770,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 771,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 772,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 773,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 774,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 775,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 776,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 777,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 778,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 779,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 780,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 781,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 782,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 783,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 784,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 785,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 786,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 787,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 788,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 789,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 790,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 791,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 792,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 793,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 794,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 795,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 796,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 797,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 798,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 799,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 800,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 801,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 802,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 803,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 804,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 805,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 806,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 807,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 808,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 809,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 810,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 811,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 812,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 813,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 814,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 815,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 816,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 817,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 818,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 819,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 820,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 821,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 822,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 823,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 824,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 825,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 826,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 827,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 828,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 829,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 830,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 831,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 832,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 833,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 834,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 835,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 836,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 837,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 838,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 839,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 840,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 841,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 842,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 843,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 844,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 845,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 846,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 847,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 848,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 849,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 850,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 851,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 852,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 853,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 854,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 855,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 856,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 857,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 858,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 859,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 860,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 861,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 862,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 863,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 864,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 865,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 866,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 867,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 868,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 869,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 870,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 871,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 872,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 873,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 874,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 875,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 876,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 877,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 878,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 879,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 880,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 881,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 882,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 883,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 884,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 885,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 886,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 887,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 888,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 889,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 890,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 891,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 892,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 893,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 894,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 895,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 896,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 897,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 898,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 899,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 900,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 901,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 902,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 903,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 904,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 905,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 906,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 907,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 908,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 909,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 910,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 911,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 912,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 913,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 914,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 915,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 916,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 917,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 918,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 919,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 920,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 921,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 922,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 923,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 924,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 925,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 926,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 927,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 928,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 929,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 930,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 931,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 932,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 933,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 934,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 935,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 936,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 937,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 938,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 939,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 940,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 941,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 942,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 943,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 944,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 945,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 946,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 947,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 948,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 949,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 950,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 951,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 952,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 953,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 954,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 955,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 956,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 957,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 958,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 959,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 960,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 961,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 962,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 963,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 964,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 965,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 966,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 967,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 968,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 969,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 970,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 971,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 972,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 973,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 974,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 975,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 976,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 977,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 978,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 979,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 980,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 981,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 982,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 983,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 984,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 985,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 986,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 987,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 988,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 989,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 990,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 991,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 992,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 993,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 994,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 995,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 996,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 997,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 998,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 999,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1000,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1001,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1002,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1003,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1004,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1005,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1006,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1007,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1008,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1009,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1010,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1011,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1012,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1013,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1014,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1015,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1016,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1017,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1018,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1019,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1020,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1021,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1022,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1023,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1024,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1025,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1026,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1027,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1028,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1029,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1030,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1031,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1032,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1033,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1034,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1035,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1036,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1037,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1038,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1039,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1040,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1041,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1042,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1043,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1044,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1045,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1046,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1047,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1048,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1049,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1050,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1051,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1052,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1053,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1054,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1055,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1056,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1057,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1058,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1059,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1060,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1061,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1062,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1063,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1064,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1065,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1066,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1067,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1068,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1069,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1070,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1071,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1072,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1073,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1074,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1075,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1076,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1077,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1078,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1079,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1080,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1081,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1082,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1083,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1084,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1085,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1086,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1087,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1088,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1089,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1090,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1091,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1092,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1093,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1094,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1095,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1096,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1097,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1098,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1099,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 15, 0, 56, 776, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$JKnGWZCryfMzYUZhV8vEBedsoPuBSYN.MEdVEKSlty0Qes5bUPT.2", new DateTime(2025, 12, 12, 15, 0, 56, 892, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$uvnKlSDwUlKpg5Nc8aY2l.On9b83Oi8L9YHxPfmzy4o5AqwSEcYJy", new DateTime(2025, 12, 12, 15, 0, 57, 12, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$aC3bBsU/3QdbvjhjVB7iO.9uInhTQtFigvAtdE1.cax.21aNRTjXu", new DateTime(2025, 12, 12, 15, 0, 57, 238, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$RjBp1HCHEPpSF0609d4i0.7AZo/B0pJdin26Iuh9jL45J5Wgk5xPO", new DateTime(2025, 12, 12, 15, 0, 57, 124, DateTimeKind.Utc).AddTicks(5397) });
        }
    }
}
