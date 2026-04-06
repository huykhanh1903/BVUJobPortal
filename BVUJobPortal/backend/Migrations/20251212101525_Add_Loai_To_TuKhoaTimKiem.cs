using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BVUJobPortal.Migrations
{
    /// <inheritdoc />
    public partial class Add_Loai_To_TuKhoaTimKiem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Loai",
                table: "TuKhoaTimKiems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 164,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 165,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 166,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 167,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 168,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 169,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 170,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 171,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 172,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 173,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 174,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 175,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 176,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 177,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 178,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 179,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 180,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 181,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 182,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 183,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 184,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 185,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 186,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 187,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 188,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 189,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 190,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 191,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 192,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 193,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 194,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 195,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 196,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 197,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 198,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 199,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 200,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 201,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 202,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 203,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 204,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 205,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 206,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 207,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 208,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 209,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 210,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 211,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 212,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 213,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 214,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 215,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 216,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 217,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 218,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 219,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 220,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 221,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 222,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 223,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 224,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 225,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 226,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 227,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 228,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 229,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 230,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 231,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 232,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 233,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 234,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 235,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 236,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 237,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 238,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 239,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 240,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 241,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 242,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 243,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 244,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 245,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 246,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 247,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 248,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 249,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 250,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 251,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 252,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 253,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 254,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 255,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 256,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 257,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 258,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 259,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 260,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 261,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 262,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 263,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 264,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 265,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 266,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 267,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 268,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 269,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 270,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 271,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 272,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 273,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 274,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 275,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 276,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 277,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 278,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 279,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 280,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 281,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 282,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 283,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 284,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 285,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 286,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 287,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 288,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 289,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 290,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 291,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 292,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 293,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 294,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 295,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 296,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 297,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 298,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 299,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 300,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 301,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 302,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 303,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 304,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 305,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 306,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 307,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 308,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 309,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 310,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 311,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 312,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 313,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 314,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 315,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 316,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 317,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 318,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 319,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 320,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 321,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 322,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 323,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 324,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 325,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 326,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 327,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 328,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 329,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 330,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 331,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 332,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 333,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 334,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 335,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 336,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 337,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 338,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 339,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 340,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 341,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 342,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 343,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 344,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 345,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 346,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 347,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 348,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 349,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 350,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 351,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 352,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 353,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 354,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 355,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 356,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 357,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 358,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 359,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 360,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 361,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 362,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 363,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 364,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 365,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 366,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 367,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 368,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 369,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 370,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 371,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 372,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 373,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 374,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 375,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 376,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 377,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 378,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 379,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 380,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 381,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 382,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 383,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 384,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 385,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 386,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 387,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 388,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 389,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 390,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 391,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 392,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 393,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 394,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 395,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 396,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 397,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 398,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 399,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 400,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 401,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 402,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 403,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 404,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 405,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 406,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 407,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 408,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 409,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 410,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 411,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 412,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 413,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 414,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 415,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 416,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 417,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 418,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 419,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 420,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 421,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 422,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 423,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 424,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 425,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 426,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 427,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 428,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 429,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 430,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 431,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 432,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 433,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 434,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 435,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 436,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 437,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 438,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 439,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 440,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 441,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 442,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 443,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 444,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 445,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 446,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 447,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 448,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 449,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 450,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 451,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 452,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 453,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 454,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 455,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 456,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 457,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 458,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 459,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 460,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 461,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 462,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 463,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 464,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 465,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 466,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 467,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 468,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 469,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 470,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 471,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 472,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 473,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 474,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 475,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 476,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 477,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 478,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 479,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 480,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 481,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 482,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 483,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 484,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 485,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 486,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 487,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 488,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 489,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 490,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 491,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 492,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 493,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 494,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 495,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 496,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 497,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 498,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 499,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 500,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 501,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 502,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 503,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 504,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 505,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 506,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 507,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 508,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 509,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 510,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 511,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 512,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 513,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 514,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 515,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 516,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 517,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 518,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 519,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 520,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 521,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 522,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 523,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 524,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 525,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 526,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 527,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 528,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 529,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 530,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 531,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 532,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 533,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 534,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 535,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 536,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 537,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 538,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 539,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 540,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 541,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 542,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 543,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 544,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 545,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 546,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 547,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 548,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 549,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 550,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 551,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 552,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 553,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 554,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 566,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 567,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 568,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 569,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 570,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 571,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 572,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 573,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 574,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 575,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 576,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 577,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 578,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 579,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 580,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 581,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 582,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 583,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 584,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 585,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 586,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 587,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 588,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 589,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 590,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 591,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 592,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 609,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 610,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 611,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 612,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 613,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 614,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 615,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 616,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 617,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 618,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 619,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 620,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 621,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 622,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 623,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 624,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 625,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 626,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 627,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 628,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 629,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 630,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 631,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 632,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 633,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 634,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 635,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 636,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 637,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 638,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 639,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 640,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 641,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 642,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 643,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 644,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 645,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 646,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 647,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 648,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 649,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 650,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 651,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 652,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 653,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 654,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 655,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 656,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 657,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 658,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 659,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 660,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 661,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 662,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 663,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 664,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 665,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 666,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 667,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 668,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 669,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 670,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 671,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 672,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 673,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 674,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 675,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 676,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 677,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 678,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 679,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 680,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 681,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 682,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 683,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 684,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 685,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 686,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 687,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 688,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 689,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 690,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 691,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 692,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 693,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 694,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 695,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 696,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 697,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 698,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 699,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 700,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 701,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 702,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 703,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 704,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 705,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 706,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 707,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 708,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 709,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 710,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 711,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 712,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 713,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 714,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 715,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 716,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 717,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 718,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 719,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 720,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 721,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 722,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 723,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 724,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 725,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 726,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 727,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 728,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 729,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 730,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 731,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 732,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 733,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 734,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 735,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 736,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 737,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 738,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 739,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 740,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 741,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 742,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 743,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 744,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 745,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 746,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 747,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 748,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 749,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 750,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 751,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 752,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 753,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 754,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 755,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 756,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 757,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 758,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 759,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 760,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 761,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 762,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 763,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 764,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 765,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 766,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 767,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 768,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 769,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 770,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 771,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 772,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 773,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 774,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 775,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 776,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 777,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 778,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 779,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 780,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 781,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 782,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 783,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 784,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 785,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 786,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 787,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 788,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 789,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 790,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 791,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 792,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 793,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 794,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 795,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 796,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 797,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 798,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 799,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 800,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 801,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 802,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 803,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 804,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 805,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 806,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 807,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 808,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 809,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 810,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 811,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 812,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 813,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 814,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 815,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 816,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 817,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 818,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 819,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 820,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 821,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 822,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 823,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 824,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 825,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 826,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 827,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 828,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 829,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 830,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 831,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 832,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 833,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 834,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 835,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 836,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 837,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 838,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 839,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 840,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 841,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 842,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 843,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 844,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 845,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 846,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 847,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 848,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 849,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 850,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 851,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 852,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 853,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 854,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 855,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 856,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 857,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 858,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 859,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 860,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 861,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 862,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 863,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 864,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 865,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 866,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 867,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 868,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 869,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 870,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 871,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 872,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 873,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 874,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 875,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 876,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 877,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 878,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 879,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 880,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 881,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 882,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 883,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 884,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 885,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 886,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 887,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 888,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 889,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 890,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 891,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 892,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 893,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 894,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 895,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 896,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 897,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 898,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 899,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 900,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 901,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 902,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 903,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 904,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 905,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 906,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 907,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 908,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 909,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 910,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 911,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 912,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 913,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 914,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 915,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 916,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 917,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 918,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 919,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 920,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 921,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 922,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 923,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 924,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 925,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 926,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 927,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 928,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 929,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 930,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 931,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 932,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 933,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 934,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 935,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 936,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 937,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 938,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 939,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 940,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 941,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 942,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 943,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 944,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 945,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 946,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 947,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 948,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 949,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 950,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 951,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 952,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 953,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 954,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 955,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 956,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 957,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 958,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 959,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 960,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 961,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 962,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 963,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 964,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 965,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 966,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 967,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 968,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 969,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 970,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 971,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 972,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 973,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 974,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 975,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 976,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 977,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 978,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 979,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 980,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 981,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 982,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 983,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 984,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 985,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 986,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 987,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 988,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 989,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 990,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 991,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 992,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 993,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 994,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 995,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 996,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 997,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 998,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 999,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1000,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1001,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1002,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1003,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1004,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1005,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1006,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1007,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1008,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1009,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1010,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1011,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1012,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1013,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1014,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1015,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1016,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1017,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1018,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1019,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1020,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1021,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1022,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1023,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1024,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1025,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1026,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1027,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1028,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1029,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1030,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1031,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1032,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1033,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1034,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1035,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1036,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1037,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1038,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1039,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1040,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1041,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1042,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1043,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1044,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1045,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1046,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1047,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1048,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1049,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1050,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1051,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1052,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1053,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1054,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1055,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1056,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1057,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1058,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1059,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1060,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1061,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1062,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1063,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1064,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1065,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1066,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1067,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1068,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1069,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1070,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1071,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1072,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1073,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1074,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1075,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1076,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1077,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1078,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1079,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1080,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1081,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1082,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1083,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1084,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1085,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1086,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1087,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1088,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1089,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1090,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1091,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1092,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1093,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1094,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1095,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1096,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1097,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1098,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1099,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 10, 15, 24, 107, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$H8zpna/QHTZoOTDQd5j.Re1gwQIWG6yfSxWsZpwUoOUgAAN0Z4Mvy", new DateTime(2025, 12, 12, 10, 15, 24, 219, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$K01xXMyg9Po3r6UqwaNHCu23.o5we7XRDFQaJ8GWRpxgpCoLEmo7u", new DateTime(2025, 12, 12, 10, 15, 24, 336, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$2n1hdPBIilIF8rcB9RamJOigeggOUgwHNfZA8fe6xlc41B6Fn62vS", new DateTime(2025, 12, 12, 10, 15, 24, 563, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$yAi3f7etUYJKGYrn/9jWdu23Cgszso1tN/EXNBE0OTVg23FCLMwVK", new DateTime(2025, 12, 12, 10, 15, 24, 451, DateTimeKind.Utc).AddTicks(2291) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loai",
                table: "TuKhoaTimKiems");

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 164,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 165,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 166,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 167,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 168,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 169,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 170,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 171,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 172,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 173,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 174,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 175,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 176,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 177,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 178,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 179,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 180,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 181,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 182,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 183,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 184,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 185,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 186,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 187,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 188,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 189,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 190,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 191,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 192,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 193,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 194,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 195,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 196,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 197,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 198,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 199,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 200,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 201,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 202,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 203,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 204,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 205,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 206,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 207,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 208,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 209,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 210,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 211,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 212,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 213,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 214,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 215,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 216,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 217,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 218,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 219,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 220,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 221,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 222,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 223,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 224,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 225,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 226,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 227,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 228,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 229,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 230,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 231,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 232,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 233,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 234,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 235,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 236,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 237,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 238,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 239,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 240,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 241,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 242,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 243,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 244,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 245,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 246,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 247,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 248,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 249,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 250,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 251,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 252,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 253,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 254,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 255,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 256,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 257,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 258,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 259,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 260,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 261,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 262,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 263,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 264,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 265,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 266,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 267,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 268,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 269,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 270,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 271,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 272,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 273,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 274,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 275,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 276,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 277,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 278,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 279,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 280,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 281,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 282,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 283,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 284,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 285,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 286,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 287,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 288,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 289,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 290,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 291,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 292,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 293,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 294,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 295,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 296,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 297,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 298,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 299,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 300,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 301,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 302,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 303,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 304,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 305,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 306,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 307,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 308,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 309,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 310,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 311,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 312,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 313,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 314,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 315,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 316,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 317,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 318,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 319,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 320,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 321,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 322,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 323,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 324,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 325,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 326,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 327,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 328,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 329,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 330,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 331,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 332,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 333,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 334,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 335,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 336,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 337,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 338,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 339,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 340,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 341,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 342,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 343,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 344,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 345,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 346,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 347,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 348,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 349,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 350,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 351,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 352,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 353,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 354,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 355,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 356,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 357,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 358,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 359,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 360,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 361,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 362,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 363,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 364,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 365,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 366,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 367,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 368,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 369,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 370,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 371,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 372,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 373,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 374,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 375,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 376,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 377,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 378,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 379,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 380,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 381,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 382,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 383,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 384,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 385,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 386,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 387,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 388,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 389,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 390,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 391,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 392,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 393,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 394,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 395,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 396,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 397,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 398,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 399,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 400,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 401,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 402,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 403,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 404,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 405,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 406,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 407,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 408,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 409,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 410,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 411,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 412,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 413,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 414,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 415,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 416,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 417,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 418,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 419,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 420,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 421,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 422,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 423,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 424,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 425,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 426,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 427,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 428,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 429,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 430,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 431,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 432,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 433,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 434,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 435,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 436,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 437,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 438,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 439,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 440,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 441,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 442,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 443,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 444,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 445,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 446,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 447,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 448,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 449,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 450,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 451,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 452,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 453,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 454,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 455,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 456,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 457,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 458,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 459,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 460,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 461,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 462,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 463,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 464,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 465,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 466,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 467,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 468,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 469,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 470,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 471,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 472,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 473,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 474,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 475,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 476,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 477,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 478,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 479,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 480,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 481,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 482,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 483,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 484,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 485,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 486,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 487,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 488,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 489,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 490,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 491,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 492,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 493,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 494,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 495,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 496,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 497,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 498,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 499,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 500,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 501,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 502,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 503,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 504,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 505,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 506,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 507,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 508,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 509,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 510,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 511,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 512,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 513,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 514,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 515,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 516,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 517,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 518,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 519,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 520,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 521,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 522,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 523,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 524,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 525,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 526,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 527,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 528,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 529,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 530,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 531,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 532,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 533,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 534,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 535,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 536,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 537,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 538,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 539,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 540,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 541,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 542,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 543,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 544,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 545,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 546,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 547,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 548,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 549,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 550,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 551,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 552,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 553,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 554,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 566,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 567,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 568,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 569,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 570,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 571,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 572,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 573,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 574,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 575,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 576,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 577,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 578,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 579,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 580,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 581,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 582,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 583,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 584,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 585,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 586,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 587,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 588,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 589,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 590,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 591,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 592,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 609,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 610,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 611,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 612,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 613,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 614,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 615,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 616,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 617,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 618,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 619,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 620,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 621,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 622,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 623,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 624,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 625,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 626,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 627,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 628,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 629,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 630,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 631,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 632,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 633,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 634,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 635,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 636,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 637,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 638,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 639,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 640,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 641,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 642,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 643,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 644,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 645,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 646,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 647,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 648,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 649,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 650,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 651,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 652,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 653,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 654,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 655,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 656,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 657,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 658,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 659,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 660,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 661,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 662,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 663,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 664,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 665,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 666,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 667,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 668,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 669,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 670,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 671,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 672,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 673,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 674,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 675,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 676,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 677,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 678,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 679,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 680,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 681,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 682,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 683,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 684,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 685,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 686,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 687,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 688,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 689,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 690,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 691,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 692,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 693,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 694,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 695,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 696,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 697,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 698,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 699,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 700,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 701,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 702,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 703,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 704,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 705,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 706,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 707,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 708,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 709,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 710,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 711,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 712,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 713,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 714,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 715,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 716,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 717,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 718,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 719,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 720,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 721,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 722,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 723,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 724,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 725,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 726,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 727,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 728,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 729,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 730,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 731,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 732,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 733,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 734,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 735,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 736,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 737,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 738,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 739,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 740,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 741,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 742,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 743,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 744,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 745,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 746,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 747,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 748,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 749,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 750,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 751,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 752,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 753,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 754,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 755,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 756,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 757,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 758,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 759,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 760,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 761,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 762,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 763,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 764,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 765,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 766,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 767,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 768,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 769,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 770,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 771,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 772,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 773,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 774,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 775,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 776,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 777,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 778,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 779,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 780,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 781,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 782,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 783,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 784,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 785,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 786,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 787,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 788,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 789,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 790,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 791,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 792,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 793,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 794,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 795,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 796,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 797,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 798,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 799,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 800,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 801,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 802,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 803,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 804,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 805,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 806,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 807,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 808,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 809,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 810,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 811,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 812,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 813,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 814,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 815,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 816,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 817,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 818,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 819,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 820,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 821,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 822,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 823,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 824,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 825,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 826,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 827,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 828,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 829,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 830,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 831,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 832,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 833,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 834,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 835,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 836,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 837,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 838,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 839,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 840,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 841,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 842,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 843,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 844,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 845,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 846,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 847,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 848,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 849,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 850,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 851,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 852,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 853,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 854,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 855,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 856,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 857,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 858,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 859,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 860,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 861,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 862,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 863,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 864,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 865,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 866,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 867,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 868,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 869,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 870,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 871,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 872,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 873,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 874,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 875,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 876,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 877,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 878,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 879,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 880,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 881,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 882,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 883,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 884,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 885,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 886,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 887,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 888,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 889,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 890,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 891,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 892,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 893,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 894,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 895,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 896,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 897,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 898,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 899,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 900,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 901,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 902,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 903,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 904,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 905,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 906,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 907,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 908,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 909,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 910,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 911,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 912,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 913,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 914,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 915,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 916,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 917,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 918,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 919,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 920,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 921,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 922,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 923,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 924,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 925,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 926,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 927,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 928,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 929,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 930,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 931,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 932,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 933,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 934,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 935,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 936,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 937,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 938,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 939,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 940,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 941,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 942,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 943,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 944,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 945,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 946,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 947,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 948,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 949,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 950,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 951,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 952,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 953,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 954,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 955,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 956,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 957,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 958,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 959,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 960,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 961,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 962,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 963,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 964,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 965,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 966,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 967,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 968,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 969,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 970,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 971,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 972,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 973,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 974,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 975,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 976,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 977,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 978,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 979,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 980,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 981,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 982,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 983,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 984,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 985,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 986,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 987,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 988,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 989,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 990,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 991,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 992,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 993,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 994,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 995,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 996,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 997,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 998,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 999,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1000,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1001,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1002,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1003,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1004,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1005,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1006,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1007,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1008,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1009,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1010,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1011,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1012,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1013,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1014,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1015,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1016,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1017,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1018,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1019,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1020,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1021,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1022,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1023,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1024,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1025,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1026,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1027,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1028,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1029,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1030,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1031,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1032,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1033,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1034,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1035,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1036,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1037,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1038,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1039,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1040,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1041,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1042,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1043,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1044,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1045,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1046,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1047,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1048,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1049,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1050,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1051,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1052,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1053,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1054,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1055,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1056,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1057,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1058,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1059,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1060,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1061,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1062,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1063,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1064,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1065,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1066,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1067,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1068,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1069,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1070,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1071,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1072,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1073,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1074,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1075,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1076,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1077,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1078,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1079,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1080,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1081,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1082,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1083,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1084,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1085,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1086,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1087,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1088,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1089,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1090,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1091,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1092,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1093,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1094,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1095,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1096,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1097,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1098,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1099,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 12, 9, 52, 33, 715, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$gWelvN9oeAw.9haOVWxWxuBcrd8sby0cPMZ1i/NIGv/gJWpX86anG", new DateTime(2025, 12, 12, 9, 52, 33, 831, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$/EUPUZiYYZBCAVCAh6huKevU1jw50YhDBURdDw0/Kgc9eD.hht/02", new DateTime(2025, 12, 12, 9, 52, 33, 943, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$29hUgJv2qzEJBTrHb1WkZuV0BgzXEdWycU88giLMBMTaqsgHW/PlW", new DateTime(2025, 12, 12, 9, 52, 34, 185, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$xHr3Sj5DpDAbOtLz/KBrQO/i8wc9JvmuyWhNj0oVUuy0LOF38mLwm", new DateTime(2025, 12, 12, 9, 52, 34, 59, DateTimeKind.Utc).AddTicks(3575) });
        }
    }
}
