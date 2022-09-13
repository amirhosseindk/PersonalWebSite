using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 0, 51, 4, 550, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "ProductId", "RemoveTime", "Src", "UpdateTime" },
                values: new object[] { 1, new DateTime(2022, 8, 23, 0, 51, 4, 550, DateTimeKind.Local).AddTicks(1758), false, 1, null, "https://gamingforecast.com/wp-content/uploads/2022/02/e8857a1a9e95526657999f9178196727-800x503.png", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 0, 51, 4, 550, DateTimeKind.Local).AddTicks(1737));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 0, 28, 58, 866, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 0, 28, 58, 866, DateTimeKind.Local).AddTicks(7086));
        }
    }
}
