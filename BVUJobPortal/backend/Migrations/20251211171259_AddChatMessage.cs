using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BVUJobPortal.Migrations
{
    public partial class AddChatMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFromAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 164,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 165,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 166,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 167,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 168,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 169,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 170,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 171,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 172,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 173,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 174,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 175,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 176,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 177,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 178,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 179,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 180,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 181,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 182,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 183,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 184,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 185,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 186,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 187,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 188,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 189,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 190,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 191,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 192,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 193,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 194,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 195,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 196,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 197,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 198,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 199,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 200,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 201,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 202,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 203,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 204,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 205,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 206,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 207,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 208,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 209,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 210,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 211,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 212,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 213,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 214,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 215,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 216,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 217,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 218,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 219,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 220,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 221,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 222,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 223,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 224,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 225,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 226,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 227,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 228,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 229,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 230,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 231,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 232,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 233,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 234,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 235,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 236,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 237,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 238,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 239,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 240,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 241,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 242,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 243,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 244,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 245,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 246,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 247,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 248,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 249,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 250,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 251,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 252,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 253,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 254,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 255,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 256,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 257,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 258,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 259,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 260,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 261,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 262,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 263,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 264,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 265,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 266,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 267,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 268,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 269,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 270,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 271,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 272,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 273,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 274,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 275,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 276,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 277,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 278,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 279,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 280,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 281,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 282,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 283,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 284,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 285,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 286,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 287,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 288,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 289,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 290,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 291,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 292,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 293,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 294,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 295,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 296,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 297,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 298,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 299,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 300,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 301,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 302,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 303,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 304,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 305,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 306,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 307,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 308,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 309,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 310,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 311,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 312,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 313,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 314,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 315,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 316,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 317,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 318,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 319,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 320,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 321,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 322,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 323,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 324,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 325,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 326,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 327,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 328,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 329,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 330,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 331,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 332,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 333,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 334,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 335,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 336,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 337,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 338,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 339,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 340,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 341,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 342,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 343,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 344,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 345,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 346,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 347,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 348,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 349,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 350,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 351,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 352,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 353,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 354,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 355,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 356,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 357,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 358,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 359,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 360,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 361,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 362,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 363,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 364,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 365,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 366,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 367,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 368,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 369,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 370,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 371,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 372,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 373,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 374,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 375,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 376,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 377,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 378,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 379,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 380,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 381,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 382,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 383,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 384,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 385,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 386,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 387,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 388,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 389,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 390,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 391,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 392,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 393,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 394,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 395,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 396,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 397,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 398,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 399,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 400,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 401,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 402,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 403,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 404,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 405,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 406,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 407,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 408,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 409,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 410,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 411,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 412,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 413,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 414,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 415,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 416,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 417,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 418,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 419,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 420,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 421,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 422,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 423,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 424,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 425,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 426,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 427,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 428,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 429,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 430,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 431,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 432,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 433,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 434,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 435,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 436,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 437,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 438,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 439,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 440,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 441,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 442,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 443,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 444,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 445,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 446,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 447,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 448,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 449,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 450,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 451,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 452,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 453,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 454,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 455,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 456,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 457,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 458,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 459,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 460,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 461,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 462,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 463,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 464,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 465,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 466,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 467,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 468,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 469,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 470,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 471,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 472,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 473,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 474,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 475,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 476,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 477,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 478,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 479,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 480,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 481,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 482,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 483,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 484,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 485,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 486,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 487,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 488,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 489,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 490,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 491,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 492,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 493,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 494,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 495,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 496,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 497,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 498,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 499,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 500,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 501,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 502,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 503,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 504,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 505,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 506,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 507,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 508,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 509,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 510,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 511,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 512,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 513,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 514,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 515,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 516,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 517,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 518,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 519,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 520,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 521,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 522,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 523,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 524,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 525,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 526,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 527,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 528,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 529,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 530,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 531,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 532,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 533,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 534,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 535,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 536,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 537,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 538,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 539,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 540,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 541,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 542,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 543,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 544,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 545,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 546,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 547,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 548,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 549,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 550,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 551,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 552,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 553,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 554,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 566,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 567,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 568,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 569,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 570,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 571,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 572,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 573,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 574,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 575,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 576,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 577,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 578,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 579,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 580,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 581,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 582,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 583,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 584,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 585,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 586,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 587,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 588,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 589,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 590,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 591,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 592,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 609,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 610,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 611,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 612,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 613,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 614,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 615,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 616,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 617,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 618,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 619,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 620,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 621,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 622,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 623,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 624,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 625,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 626,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 627,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 628,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 629,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 630,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 631,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 632,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 633,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 634,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 635,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 636,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 637,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 638,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 639,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 640,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 641,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 642,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 643,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 644,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 645,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 646,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 647,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 648,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 649,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 650,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 651,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 652,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 653,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 654,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 655,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 656,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 657,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 658,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 659,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 660,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 661,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 662,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 663,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 664,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 665,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 666,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 667,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 668,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 669,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 670,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 671,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 672,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 673,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 674,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 675,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 676,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 677,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 678,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 679,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 680,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 681,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 682,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 683,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 684,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 685,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 686,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 687,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 688,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 689,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 690,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 691,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 692,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 693,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 694,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 695,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 696,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 697,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 698,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 699,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 700,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 701,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 702,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 703,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 704,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 705,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 706,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 707,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 708,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 709,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 710,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 711,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 712,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 713,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 714,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 715,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 716,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 717,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 718,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 719,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 720,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 721,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 722,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 723,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 724,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 725,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 726,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 727,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 728,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 729,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 730,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 731,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 732,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 733,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 734,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 735,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 736,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 737,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 738,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 739,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 740,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 741,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 742,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 743,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 744,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 745,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 746,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 747,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 748,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 749,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 750,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 751,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 752,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 753,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 754,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 755,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 756,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 757,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 758,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 759,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 760,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 761,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 762,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 763,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 764,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 765,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 766,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 767,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 768,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 769,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 770,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 771,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 772,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 773,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 774,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 775,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 776,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 777,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 778,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 779,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 780,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 781,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 782,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 783,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 784,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 785,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 786,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 787,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 788,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 789,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 790,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 791,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 792,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 793,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 794,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 795,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 796,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 797,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 798,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 799,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 800,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 801,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 802,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 803,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 804,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 805,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 806,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 807,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 808,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 809,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 810,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 811,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 812,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 813,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 814,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 815,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 816,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 817,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 818,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 819,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 820,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 821,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 822,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 823,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 824,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 825,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 826,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 827,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 828,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 829,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 830,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 831,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 832,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 833,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 834,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 835,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 836,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 837,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 838,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 839,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 840,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 841,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 842,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 843,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 844,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 845,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 846,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 847,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 848,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 849,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 850,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 851,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 852,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 853,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 854,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 855,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 856,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 857,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 858,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 859,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 860,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 861,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 862,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 863,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 864,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 865,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 866,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 867,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 868,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 869,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 870,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 871,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 872,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 873,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 874,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 875,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 876,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 877,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 878,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 879,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 880,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 881,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 882,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 883,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 884,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 885,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 886,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 887,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 888,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 889,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 890,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 891,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 892,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 893,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 894,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 895,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 896,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 897,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 898,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 899,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 900,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 901,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 902,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 903,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 904,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 905,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 906,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 907,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 908,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 909,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 910,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 911,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 912,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 913,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 914,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 915,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 916,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 917,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 918,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 919,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 920,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 921,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 922,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 923,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 924,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 925,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 926,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 927,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 928,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 929,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 930,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 931,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 932,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 933,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 934,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 935,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 936,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 937,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 938,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 939,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 940,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 941,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 942,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 943,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 944,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 945,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 946,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 947,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 948,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 949,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 950,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 951,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 952,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 953,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 954,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 955,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 956,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 957,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 958,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 959,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 960,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 961,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 962,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 963,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 964,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 965,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 966,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 967,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 968,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 969,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 970,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 971,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 972,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 973,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 974,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 975,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 976,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 977,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 978,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 979,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 980,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 981,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 982,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 983,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 984,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 985,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 986,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 987,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 988,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 989,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 990,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 991,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 992,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 993,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 994,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 995,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 996,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 997,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 998,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 999,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1000,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1001,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1002,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1003,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1004,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1005,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1006,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1007,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1008,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1009,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1010,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1011,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1012,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1013,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1014,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1015,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1016,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1017,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1018,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1019,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1020,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1021,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1022,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1023,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1024,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1025,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1026,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1027,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1028,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1029,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1030,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1031,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1032,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1033,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1034,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1035,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1036,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1037,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1038,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1039,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1040,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1041,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1042,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1043,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1044,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1045,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1046,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1047,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1048,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1049,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1050,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1051,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1052,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1053,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1054,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1055,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1056,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1057,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1058,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1059,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1060,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1061,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1062,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1063,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1064,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1065,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1066,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1067,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1068,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1069,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1070,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1071,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1072,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1073,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1074,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1075,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1076,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1077,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1078,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1079,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1080,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1081,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1082,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1083,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1084,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1085,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1086,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1087,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1088,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1089,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1090,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1091,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1092,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1093,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1094,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1095,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1096,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1097,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1098,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1099,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 996, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 17, 12, 57, 995, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$ZDcR0g4p44C5HlMtaWZyOunuLzTkrZeT3sm8.fkW2PDGIz.2YhpLm", new DateTime(2025, 12, 11, 17, 12, 58, 134, DateTimeKind.Utc).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$4.SYkcM2n8jCjH2SOm8LX.8eBAC0XNAvetT/82bpaIrOlODbSZiD2", new DateTime(2025, 12, 11, 17, 12, 58, 279, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$EYfjgeWy3ANkfF5y/I/9weI7R8fDJ0foNImNaC/XqrWL88KXmI02e", new DateTime(2025, 12, 11, 17, 12, 58, 561, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$8BmSqDputT/aoAsXnKR6Luq1H5IVApvQEl5CFII825o0TIX..H3K.", new DateTime(2025, 12, 11, 17, 12, 58, 425, DateTimeKind.Utc).AddTicks(71) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 164,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 165,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 166,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 167,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 168,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 169,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 170,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 171,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 172,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 173,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 174,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 175,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 176,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 177,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 178,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 179,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 180,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 181,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 182,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 183,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 184,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 185,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 186,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 187,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 188,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 189,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 190,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 191,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 192,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 193,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 194,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 195,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 196,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 197,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 198,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 199,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 200,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 201,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 202,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 203,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 204,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 205,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 206,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 207,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 208,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 209,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 210,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 211,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 212,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 213,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 214,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 215,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 216,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 217,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 218,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 219,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 220,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 221,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 222,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 223,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 224,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 225,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 226,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 227,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 228,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 229,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 230,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 231,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 232,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 233,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 234,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 235,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 236,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 237,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 238,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 239,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 240,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 241,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 242,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 243,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 244,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 245,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 246,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 247,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 248,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 249,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 250,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 251,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 252,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 253,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 254,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 255,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 256,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 257,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 258,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 259,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 260,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 261,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 262,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 263,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 264,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 265,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 266,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 267,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 268,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 269,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 270,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 271,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 272,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 273,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 274,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 275,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 276,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 277,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 278,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 279,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 280,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 281,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 282,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 283,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 284,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 285,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 286,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 287,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 288,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 289,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 290,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 291,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 292,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 293,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 294,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 295,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 296,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 297,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 298,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 299,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 300,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 301,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 302,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 303,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 304,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 305,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 306,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 307,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 308,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 309,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 310,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 311,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 312,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 313,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 314,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 315,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 316,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 317,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 318,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 319,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 320,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 321,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 322,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 323,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 324,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 325,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 326,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 327,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 328,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 329,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 330,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 331,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 332,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 333,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 334,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 335,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 336,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 337,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 338,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 339,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 340,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 341,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 342,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 343,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 344,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 345,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 346,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 347,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 348,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 349,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 350,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 351,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 352,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 353,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 354,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 355,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 356,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 357,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 358,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 359,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 360,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 361,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 362,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 363,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 364,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 365,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 366,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 367,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 368,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 369,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 370,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 371,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 372,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 373,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 374,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 375,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 376,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 377,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 378,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 379,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 380,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 381,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 382,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 383,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 384,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 385,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 386,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 387,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 388,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 389,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 390,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 391,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 392,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 393,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 394,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 395,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 396,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 397,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 398,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 399,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 400,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 401,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 402,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 403,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 404,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 405,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 406,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 407,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 408,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 409,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 410,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 411,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 412,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 413,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 414,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 415,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 416,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 417,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 418,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 419,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 420,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 421,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 422,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 423,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 424,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 425,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 426,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 427,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 428,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 429,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 430,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 431,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 432,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 433,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 434,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 435,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 436,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 437,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 438,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 439,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 440,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 441,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 442,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 443,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 444,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 445,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 446,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 447,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 448,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 449,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 450,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 451,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 452,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 453,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 454,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 455,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 456,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 457,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 458,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 459,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 460,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 461,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 462,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 463,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 464,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 465,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 466,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 467,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 468,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 469,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 470,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 471,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 472,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 473,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 474,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 475,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 476,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 477,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 478,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 479,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 480,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 481,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 482,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 483,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 484,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 485,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 486,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 487,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 488,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 489,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 490,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 491,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 492,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 493,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 494,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 495,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 496,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 497,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 498,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 499,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 500,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 501,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 502,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 503,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 504,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 505,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 506,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 507,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 508,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 509,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 510,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 511,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 512,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 513,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 514,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 515,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 516,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 517,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 518,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 519,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 520,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 521,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 522,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 523,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 524,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 525,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 526,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 527,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 528,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 529,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 530,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 531,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 532,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 533,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 534,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 535,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 536,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 537,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 538,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 539,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 540,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 541,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 542,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 543,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 544,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 545,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 546,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 547,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 548,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 549,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 550,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 551,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 552,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 553,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 554,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 566,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 567,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 568,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 569,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 570,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 571,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 572,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 573,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 574,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 575,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 576,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 577,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 578,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 579,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 580,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 581,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 582,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 583,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 584,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 585,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 586,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 587,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 588,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 589,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 590,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 591,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 592,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 609,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 610,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 611,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 612,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 613,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 614,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 615,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 616,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 617,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 618,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 619,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 620,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 621,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 622,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 623,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 624,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 625,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 626,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 627,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 628,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 629,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 630,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 631,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 632,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 633,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 634,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 635,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 636,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 637,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 638,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 639,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 640,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 641,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 642,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 643,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 644,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 645,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 646,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 647,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 648,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 649,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 650,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 651,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 652,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 653,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 654,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 655,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 656,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 657,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 658,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 659,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 660,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 661,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 662,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 663,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 664,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 665,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 666,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 667,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 668,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 669,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 670,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 671,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 672,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 673,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 674,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 675,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 676,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 677,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 678,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 679,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 680,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 681,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 682,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 683,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 684,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 685,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 686,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 687,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 688,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 689,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 690,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 691,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 692,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 693,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 694,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 695,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 696,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 697,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 698,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 699,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 700,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 701,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 702,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 703,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 704,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 705,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 706,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 707,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 708,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 709,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 710,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 711,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 712,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 713,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 714,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 715,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 716,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 717,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 718,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 719,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 720,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 721,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 722,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 723,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 724,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 725,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 726,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 727,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 728,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 729,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 730,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 731,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 732,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 733,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 734,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 735,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 736,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 737,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 738,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 739,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 740,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 741,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 742,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 743,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 744,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 745,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 746,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 747,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 748,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 749,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 750,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 751,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 752,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 753,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 754,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 755,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 756,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 757,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 758,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 759,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 760,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 761,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 762,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 763,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 764,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 765,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 766,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 767,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 768,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 769,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 770,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 771,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 772,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 773,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 774,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 775,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 776,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 777,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 778,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 779,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 780,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 781,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 782,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 783,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 784,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 785,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 786,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 787,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 788,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 789,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 790,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 791,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 792,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 793,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 794,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 795,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 796,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 797,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 798,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 799,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 800,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 801,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 802,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 803,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 804,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 805,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 806,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 807,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 808,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 809,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 810,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 811,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 812,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 813,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 814,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 815,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 816,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 817,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 818,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 819,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 820,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 821,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 822,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 823,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 824,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 825,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 826,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 827,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 828,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 829,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 830,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 831,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 832,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 833,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 834,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 835,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 836,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 837,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 838,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 839,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 840,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 841,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 842,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 843,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 844,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 845,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 846,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 847,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 848,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 849,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 850,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 851,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 852,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 853,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 854,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 855,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 856,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 857,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 858,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 859,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 860,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 861,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 862,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 863,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 864,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 865,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 866,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 867,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 868,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 869,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 870,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 871,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 872,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 873,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 874,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 875,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 876,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 877,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 878,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 879,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 880,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 881,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 882,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 883,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 884,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 885,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 886,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 887,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 888,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 889,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 890,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 891,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 892,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 893,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 894,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 895,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 896,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 897,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 898,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 899,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 900,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 901,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 902,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 903,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 904,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 905,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 906,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 907,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 908,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 909,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 910,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 911,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 912,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 913,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 914,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 915,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 916,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 917,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 918,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 919,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 920,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 921,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 922,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 923,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 924,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 925,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 926,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 927,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 928,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 929,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 930,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 931,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 932,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 933,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 934,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 935,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 936,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 937,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 938,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 939,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 940,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 941,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 942,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 943,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 944,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 945,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 946,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 947,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 948,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 949,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 950,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 951,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 952,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 953,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 954,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 955,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 956,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 957,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 958,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 959,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 960,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 961,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 962,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 963,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 964,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 965,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 966,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 967,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 968,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 969,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 970,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 971,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 972,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 973,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 974,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 975,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 976,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 977,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 978,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 979,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 980,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 981,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 982,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 983,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 984,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 985,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 986,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 987,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 988,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 989,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 990,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 991,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 992,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 993,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 994,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 995,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 996,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 997,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 998,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 999,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1000,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1001,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1002,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1003,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1004,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1005,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1006,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1007,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1008,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1009,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1010,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1011,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1012,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1013,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1014,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1015,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1016,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1017,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1018,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1019,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1020,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1021,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1022,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1023,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1024,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1025,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1026,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1027,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1028,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1029,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1030,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1031,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1032,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1033,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1034,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1035,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1036,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1037,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1038,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1039,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1040,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1041,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1042,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1043,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1044,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1045,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1046,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1047,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1048,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1049,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1050,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1051,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1052,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1053,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1054,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1055,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1056,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1057,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1058,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1059,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1060,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1061,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1062,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1063,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1064,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1065,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1066,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1067,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1068,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1069,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1070,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1071,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1072,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1073,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1074,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1075,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1076,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1077,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1078,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1079,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1080,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1081,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1082,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1083,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1084,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1085,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1086,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1087,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1088,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1089,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1090,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1091,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1092,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1093,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1094,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1095,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1096,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1097,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1098,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1099,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 13, 10, 28, 109, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$.JFW/4VpsyKeO937./7vuezVmvOSm4ZELUnnFFvdPp3toet2f0dna", new DateTime(2025, 12, 11, 13, 10, 28, 226, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$wtPxRhZV7P0PTGhOJMNmIeI4oGwwwW6sCbo5mNuk/2SbS./csFICa", new DateTime(2025, 12, 11, 13, 10, 28, 341, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$pFvrRrSvPdhhhJU2XnDXluARvPWcnVIaeAkCWAwMkpwjj.8EBwsK6", new DateTime(2025, 12, 11, 13, 10, 28, 570, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$OS1HjeUSUDJhOfdDr5BbAeFxPUibFhsWe7j67BZuF3JVOEJEfsKqa", new DateTime(2025, 12, 11, 13, 10, 28, 455, DateTimeKind.Utc).AddTicks(691) });
        }
    }
}
