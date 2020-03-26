using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace M.Model.Migrations
{
    public partial class Add_Table_GuidePagesMenuInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuidePagesMenuInfo",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    MenuName = table.Column<string>(nullable: false),
                    MenuUrl = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    MenuOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuidePagesMenuInfo", x => x.MenuID);
                });

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 14, 57, 48, 531, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.InsertData(
                table: "GuidePagesMenuInfo",
                columns: new[] { "MenuID", "CreateTime", "IsDeleted", "MenuName", "MenuOrder", "MenuUrl", "ParentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 25, 14, 57, 48, 532, DateTimeKind.Local).AddTicks(9300), 0, "首页", 1, "http://home.mchen.vip", 0 },
                    { 2, new DateTime(2020, 3, 25, 14, 57, 48, 533, DateTimeKind.Local).AddTicks(651), 0, "Mr.Fang♥Mrs.Zhou", 2, "http://fh.mchen.vip", 0 },
                    { 3, new DateTime(2020, 3, 25, 14, 57, 48, 533, DateTimeKind.Local).AddTicks(663), 0, "QQ", 3, "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes", 0 },
                    { 4, new DateTime(2020, 3, 25, 14, 57, 48, 533, DateTimeKind.Local).AddTicks(664), 0, "微信", 4, "http://mchen.vip/accsets/images/weixin.jpg", 0 },
                    { 5, new DateTime(2020, 3, 25, 14, 57, 48, 533, DateTimeKind.Local).AddTicks(665), 0, "表白小工具", 5, "http://devlove.mchen.vip", 0 },
                    { 6, new DateTime(2020, 3, 25, 14, 57, 48, 533, DateTimeKind.Local).AddTicks(666), 0, "实用小工具", 6, "http://tool.mchen.vip", 0 },
                    { 7, new DateTime(2020, 3, 25, 14, 57, 48, 533, DateTimeKind.Local).AddTicks(667), 0, "休闲小游戏", 7, "http://game.mchen.vip", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuidePagesMenuInfo");

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 19, 23, 12, 21, 111, DateTimeKind.Local).AddTicks(3682));
        }
    }
}