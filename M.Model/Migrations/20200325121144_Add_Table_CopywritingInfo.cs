using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M.Model.Migrations
{
    public partial class Add_Table_CopywritingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CopywritingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CopywritingInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CopywritingInfo",
                columns: new[] { "Id", "Content", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。", new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6043), 0 },
                    { 2, "脏的人多了，干净反倒成了一种错。", new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6774), 0 },
                    { 3, "你羡慕的生活都是你没熬过的苦。", new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6781), 0 },
                    { 4, "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。", new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6782), 0 },
                    { 5, "生活便是寻求新的知识。——门捷列夫", new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6782), 0 },
                    { 6, "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。", new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6783), 0 },
                    { 7, "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。", new DateTime(2020, 3, 25, 20, 11, 43, 959, DateTimeKind.Local).AddTicks(6784), 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CopywritingInfo");

            migrationBuilder.UpdateData(
                table: "DevLoveInfo",
                keyColumn: "DLId",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 312, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 313, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2020, 3, 25, 19, 58, 53, 314, DateTimeKind.Local).AddTicks(774));
        }
    }
}
