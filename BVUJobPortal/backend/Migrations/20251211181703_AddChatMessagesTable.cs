using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BVUJobPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddChatMessagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ChatMessages",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "IsFromAdmin",
                table: "ChatMessages",
                newName: "IsFromAI");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ChatMessages",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ChatMessages",
                newName: "Message");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "ChatMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 164,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 165,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 166,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 167,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 168,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 169,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 170,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 171,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 172,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 173,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 174,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 175,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 176,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 177,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 178,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 179,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 180,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 181,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 182,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 183,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 184,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 185,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 186,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 187,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 188,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 189,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 190,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 191,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 192,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 193,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 194,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 195,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 196,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 197,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 198,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 199,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 200,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 201,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 202,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 203,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 204,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 205,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 206,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 207,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 208,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 209,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 210,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 211,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 212,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 213,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 214,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 215,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 216,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 217,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 218,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 219,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 220,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 221,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 222,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 223,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 224,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 225,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 226,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 227,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 228,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 229,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 230,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 231,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 232,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 233,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 234,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 235,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 236,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 237,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 238,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 239,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 240,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 241,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 242,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 243,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 244,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 245,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 246,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 247,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 248,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 249,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 250,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 251,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 252,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 253,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 254,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 255,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 256,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 257,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 258,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 259,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 260,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 261,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 262,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 263,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 264,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 265,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 266,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 267,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 268,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 269,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 270,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 271,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 272,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 273,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 274,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 275,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 276,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 277,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 278,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 279,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 280,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 281,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 282,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 283,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 284,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 285,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 286,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 287,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 288,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 289,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 290,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 291,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 292,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 293,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 294,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 295,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 296,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 297,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 298,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 299,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 300,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 301,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 302,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 303,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 304,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 305,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 306,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 307,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 308,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 309,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 310,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 311,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 312,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 313,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 314,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 315,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 316,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 317,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 318,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 319,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 320,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 321,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 322,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 323,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 324,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 325,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 326,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 327,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 328,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 329,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 330,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 331,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 332,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 333,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 334,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 335,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 336,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 337,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 338,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 339,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 340,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 341,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 342,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 343,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 344,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 345,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 346,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 347,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 348,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 349,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 350,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 351,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 352,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 353,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 354,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 355,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 356,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 357,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 358,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 359,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 360,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 361,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 362,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 363,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 364,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 365,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 366,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 367,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 368,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 369,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 370,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 371,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 372,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 373,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 374,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 375,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 376,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 377,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 378,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 379,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 380,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 381,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 382,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 383,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 384,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 385,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 386,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 387,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 388,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 389,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 390,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 391,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 392,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 393,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 394,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 395,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 396,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 397,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 398,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 399,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 400,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 401,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 402,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 403,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 404,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 405,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 406,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 407,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 408,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 409,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 410,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 411,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 412,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 413,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 414,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 415,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 416,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 417,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 418,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 419,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 420,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 421,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 422,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 423,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 424,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 425,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 426,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 427,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 428,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 429,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 430,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 431,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 432,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 433,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 434,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 435,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 436,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 437,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 438,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 439,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 440,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 441,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 442,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 443,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 444,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 445,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 446,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 447,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 448,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 449,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 450,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 451,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 452,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 453,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 454,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 455,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 456,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 457,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 458,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 459,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 460,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 461,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 462,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 463,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 464,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 465,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 466,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 467,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 468,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 469,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 470,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 471,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 472,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 473,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 474,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 475,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 476,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 477,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 478,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 479,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 480,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 481,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 482,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 483,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 484,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 485,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 486,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 487,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 488,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 489,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 490,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 491,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 492,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 493,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 494,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 495,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 496,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 497,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 498,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 499,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 500,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 501,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 502,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 503,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 504,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 505,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 506,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 507,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 508,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 509,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 510,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 511,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 512,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 513,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 514,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 515,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 516,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 517,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 518,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 519,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 520,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 521,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 522,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 523,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 524,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 525,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 526,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 527,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 528,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 529,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 530,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 531,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 532,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 533,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 534,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 535,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 536,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 537,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 538,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 539,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 540,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 541,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 542,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 543,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 544,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 545,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 546,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 547,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 548,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 549,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 550,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 551,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 552,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 553,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 554,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 566,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 567,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 568,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 569,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 570,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 571,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 572,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 573,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 574,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 575,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 576,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 577,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 578,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 579,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 580,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 581,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 582,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 583,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 584,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 585,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 586,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 587,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 588,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 589,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 590,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 591,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 592,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 609,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 610,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 611,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 612,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 613,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 614,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 615,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 616,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 617,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 618,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 619,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 620,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 621,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 622,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 623,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 624,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 625,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 626,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 627,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 628,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 629,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 630,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 631,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 632,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 633,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 634,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 635,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 636,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 637,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 638,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 639,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 640,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 641,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 642,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 643,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 644,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 645,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 646,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 647,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 648,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 649,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 650,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 651,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 652,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 653,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 654,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 655,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 656,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 657,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 658,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 659,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 660,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 661,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 662,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 663,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 664,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 665,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 666,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 667,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 668,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 669,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 670,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 671,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 672,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 673,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 674,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 675,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 676,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 677,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 678,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 679,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 680,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 681,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 682,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 683,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 684,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 685,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 686,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 687,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 688,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 689,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 690,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 691,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 692,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 693,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 694,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 695,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 696,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 697,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 698,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 699,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 700,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 701,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 702,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 703,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 704,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 705,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 706,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 707,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 708,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 709,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 710,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 711,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 712,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 713,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 714,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 715,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 716,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 717,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 718,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 719,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 720,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 721,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 722,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 723,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 724,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 725,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 726,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 727,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 728,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 729,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 730,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 731,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 732,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 733,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 734,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 735,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 736,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 737,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 738,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 739,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 740,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 741,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 742,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 743,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 744,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 745,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 746,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 747,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 748,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 749,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 750,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 751,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 752,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 753,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 754,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 755,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 756,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 757,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 758,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 759,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 760,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 761,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 762,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 763,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 764,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 765,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 766,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 767,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 768,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 769,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 770,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 771,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 772,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 773,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 774,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 775,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 776,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 777,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 778,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 779,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 780,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 781,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 782,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 783,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 784,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 785,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 786,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 787,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 788,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 789,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 790,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 791,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 792,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 793,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 794,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 795,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 796,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 797,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 798,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 799,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 800,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 801,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 802,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 803,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 804,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 805,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 806,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 807,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 808,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 809,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 810,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 811,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 812,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 813,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 814,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 815,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 816,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 817,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 818,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 819,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 820,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 821,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 822,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 823,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 824,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 825,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 826,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 827,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 828,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 829,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 830,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 831,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 832,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 833,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 834,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 835,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 836,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 837,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 838,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 839,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 840,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 841,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 842,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 843,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 844,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 845,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 846,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 847,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 848,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 849,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 850,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 851,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 852,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 853,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 854,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 855,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 856,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 857,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 858,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 859,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 860,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 861,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 862,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 863,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 864,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 865,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 866,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 867,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 868,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 869,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 870,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 871,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 872,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 873,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 874,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 875,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 876,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 877,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 878,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 879,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 880,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 881,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 882,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 883,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 884,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 885,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 886,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 887,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 888,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 889,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 890,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 891,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 892,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 893,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 894,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 895,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 896,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 897,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 898,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 899,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 900,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 901,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 902,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 903,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 904,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 905,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 906,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 907,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 908,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 909,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 910,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 911,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 912,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 913,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 914,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 915,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 916,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 917,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 918,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 919,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 920,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 921,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 922,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 923,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 924,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 925,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 926,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 927,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 928,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 929,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 930,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 931,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 932,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 933,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 934,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 935,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 936,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 937,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 938,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 939,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 940,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 941,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 942,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 943,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 944,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 945,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 946,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 947,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 948,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 949,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 950,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 951,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 952,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 953,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 954,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 955,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 956,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 957,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 958,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 959,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 960,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 961,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 962,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 963,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 964,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 965,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 966,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 967,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 968,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 969,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 970,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 971,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 972,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 973,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 974,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 975,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 976,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 977,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 978,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 979,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 980,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 981,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 982,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 983,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 984,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 985,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 986,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 987,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 988,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 989,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 990,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 991,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 992,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 993,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 994,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 995,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 996,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 997,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 998,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 999,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1000,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1001,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1002,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1003,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1004,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1005,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1006,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1007,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1008,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1009,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1010,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1011,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1012,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1013,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1014,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1015,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1016,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1017,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1018,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1019,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1020,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1021,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1022,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1023,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1024,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1025,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1026,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1027,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1028,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1029,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1030,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1031,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1032,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1033,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1034,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1035,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1036,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1037,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1038,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1039,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1040,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1041,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1042,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1043,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1044,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1045,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1046,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1047,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1048,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1049,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1050,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1051,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1052,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1053,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1054,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1055,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1056,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1057,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1058,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1059,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1060,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1061,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1062,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1063,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1064,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1065,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1066,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1067,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1068,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1069,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1070,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1071,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1072,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1073,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1074,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1075,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1076,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1077,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1078,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1079,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1080,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1081,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1082,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1083,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1084,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1085,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1086,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1087,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1088,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1089,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1090,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1091,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1092,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1093,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1094,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1095,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1096,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1097,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1098,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1099,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "ChuyenNganhs",
                keyColumn: "Id",
                keyValue: 1140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "LinhVucs",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 1,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 2,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 3,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 4,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 5,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 6,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 7,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 8,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 9,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 10,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 11,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 12,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 13,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 14,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 15,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 16,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 17,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 18,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 19,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 20,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 21,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 22,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 23,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 24,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 25,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 26,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 27,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 28,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 29,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 30,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 31,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 32,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 33,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 34,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 35,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 36,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 37,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 38,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 39,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 40,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 41,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 42,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 43,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 44,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 45,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 46,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 47,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 48,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 49,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 50,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 51,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 52,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 53,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 54,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 55,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 56,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 57,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 58,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 59,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 60,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 61,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 62,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 63,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 64,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 65,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 66,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 67,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 68,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 69,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 70,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 71,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 72,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 73,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 74,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 75,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 76,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 77,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 78,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 79,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 80,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 81,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 82,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 83,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 84,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 85,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 86,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 87,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 88,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 89,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 90,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 91,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 92,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 93,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 94,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 95,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 96,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 97,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 98,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 99,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 100,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 101,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 102,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 103,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 104,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 105,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 106,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 107,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 108,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 109,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 110,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 111,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 112,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 113,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 114,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 115,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 116,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 117,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 118,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 119,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 120,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 121,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 122,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 123,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 124,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 125,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 126,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 127,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 128,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 129,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 130,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 131,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 132,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 133,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 134,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 135,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 136,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 137,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 138,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 139,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 140,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 141,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 142,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 143,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 144,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 145,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 146,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 147,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 148,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 149,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 150,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 151,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 152,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 153,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 154,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 155,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 156,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 157,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 158,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 159,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 160,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 161,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 162,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "NgheNghieps",
                keyColumn: "Id",
                keyValue: 163,
                column: "NgayTao",
                value: new DateTime(2025, 12, 11, 18, 17, 1, 536, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$aXfylk1AqjXJEQx26I3ZQeld1MEdMlBpXv5v0TlQY0cW4Z4DjfGci", new DateTime(2025, 12, 11, 18, 17, 1, 657, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$8ro/T1cEsbwL3GnfSSUid.1TTTbThTDF6ZRZlWRRLeZsyxohDEvU2", new DateTime(2025, 12, 11, 18, 17, 1, 775, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$L4Kiw/G49kx1kzP3gSdyPOj8PsHHzh63Fjbnot/VXRGKMsXpDeE2W", new DateTime(2025, 12, 11, 18, 17, 2, 23, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MatKhauHash", "NgayTao" },
                values: new object[] { "$2a$11$b32BSc8WVWjInjg585.39.y/430aF5kIacTdJAPlCq9NBBUPg0Uz6", new DateTime(2025, 12, 11, 18, 17, 1, 893, DateTimeKind.Utc).AddTicks(5401) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "ChatMessages");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "ChatMessages",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "ChatMessages",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "ChatMessages",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "IsFromAI",
                table: "ChatMessages",
                newName: "IsFromAdmin");

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
    }
}
