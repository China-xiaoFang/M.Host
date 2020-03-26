using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace M.Model.Migrations
{
    public partial class Add_Table_DevLoveInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevLoveInfo",
                columns: table => new
                {
                    DLId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DLName = table.Column<string>(maxLength: 20, nullable: false),
                    DLoveName = table.Column<string>(maxLength: 20, nullable: false),
                    DLInfo = table.Column<string>(maxLength: 128, nullable: false),
                    DLoveInfo = table.Column<string>(maxLength: 10, nullable: true),
                    DLYear = table.Column<string>(nullable: false),
                    DLMonth = table.Column<string>(nullable: false),
                    DLDay = table.Column<string>(nullable: false),
                    DLQQ = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevLoveInfo", x => x.DLId);
                });

            migrationBuilder.InsertData(
                table: "DevLoveInfo",
                columns: new[] { "DLId", "CreateTime", "DLDay", "DLInfo", "DLMonth", "DLName", "DLQQ", "DLYear", "DLoveInfo", "DLoveName", "IsDeleted" },
                values: new object[] { 1, new DateTime(2020, 3, 19, 23, 11, 55, 572, DateTimeKind.Local).AddTicks(1076), "6", "希望以后和你的生活，温柔，有趣，不必太激烈，三餐，四季，不必太匆忙，毕竟我有一生的时间要和你浪费。", "3", "Mr.Fang", "2875616188", "2017", "我永远在！", "文洁", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevLoveInfo");
        }
    }
}