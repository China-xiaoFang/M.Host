using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace M.Model.Migrations
{
    public partial class Update_Table_Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Admin",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Admin",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 809, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 810, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 810, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 810, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 14, 16, 36, 811, DateTimeKind.Local).AddTicks(708));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Admin");

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 958, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(3051));
        }
    }
}