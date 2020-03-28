using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M.Model.Migrations
{
    public partial class Update_Table_BackGroundImageInfo_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 84, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg1.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg2.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg3.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg4.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg5.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg6.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg7.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg8.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg9.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg10.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg11.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg12.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg13.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg14.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg15.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg16.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg17.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg18.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg19.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg20.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg21.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg22.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg23.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg24.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg25.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg26.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg27.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg28.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg29.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg30.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg31.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg32.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg33.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg34.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg35.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg36.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg37.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg38.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg39.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg40.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg41.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg42.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg43.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg44.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg45.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg46.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg47.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg48.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg49.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg50.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg51.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg52.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg53.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg54.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg55.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg56.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg57.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg58.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg59.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg60.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg61.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg62.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg63.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg64.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg65.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg66.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg67.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg68.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg69.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg70.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg71.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg72.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg73.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg74.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg75.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg76.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg77.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg78.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg79.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg80.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg81.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg82.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg83.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg84.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg85.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg86.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg87.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg88.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg89.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg90.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg91.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg92.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg93.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg94.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg95.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg96.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg97.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg98.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg99.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/assets/images/background/bg100.jpg", new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 86, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 28, 17, 23, 14, 85, DateTimeKind.Local).AddTicks(8415));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 217, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 229, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg1", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg2", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg3", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg4", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg5", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg6", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg7", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg8", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg9", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg10", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg11", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg12", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg13", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg14", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg15", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg16", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg17", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg18", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg19", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg20", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg21", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg22", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg23", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg24", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg25", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg26", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg27", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg28", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg29", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg30", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg31", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg32", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg33", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg34", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg35", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg36", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg37", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg38", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg39", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg40", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg41", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg42", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg43", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg44", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg45", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg46", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg47", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg48", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg49", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg50", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg51", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg52", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg53", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg54", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg55", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg56", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg57", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg58", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg59", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg60", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg61", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg62", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg63", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg64", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg65", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg66", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg67", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg68", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg69", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg70", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg71", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg72", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg73", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg74", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg75", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg76", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg77", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg78", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg79", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg80", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg81", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg82", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg83", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg84", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg85", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg86", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg87", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg88", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg89", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg90", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg91", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg92", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg93", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg94", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg95", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg96", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg97", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg98", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg99", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime" },
                values: new object[] { "http://mchen.vip/accsets/images/background/bg100", new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 229, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5021));
        }
    }
}
