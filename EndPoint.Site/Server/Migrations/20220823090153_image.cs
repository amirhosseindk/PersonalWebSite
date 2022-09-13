using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 13, 31, 53, 8, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Src" },
                values: new object[] { new DateTime(2022, 8, 23, 13, 31, 53, 8, DateTimeKind.Local).AddTicks(4350), "https://gamingforecast.com/wp-content/uploads/2022/02/e8857a1a9e95526657999f9178196727.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 13, 31, 53, 8, DateTimeKind.Local).AddTicks(4325));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 0, 51, 4, 550, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Src" },
                values: new object[] { new DateTime(2022, 8, 23, 0, 51, 4, 550, DateTimeKind.Local).AddTicks(1758), "https://gamingforecast.com/wp-content/uploads/2022/02/e8857a1a9e95526657999f9178196727-800x503.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 23, 0, 51, 4, 550, DateTimeKind.Local).AddTicks(1737));
        }
    }
}
