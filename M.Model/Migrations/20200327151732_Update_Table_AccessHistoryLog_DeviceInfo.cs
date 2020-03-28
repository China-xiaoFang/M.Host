using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M.Model.Migrations
{
    public partial class Update_Table_AccessHistoryLog_DeviceInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeviceInfo",
                table: "AccessHistoryLog",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

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
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                column: "CreateTime",
                value: new DateTime(2020, 3, 27, 23, 17, 32, 230, DateTimeKind.Local).AddTicks(7734));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeviceInfo",
                table: "AccessHistoryLog",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 704, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 26, 16, 10, 53, 705, DateTimeKind.Local).AddTicks(5223));
        }
    }
}
