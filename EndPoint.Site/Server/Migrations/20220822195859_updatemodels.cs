using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class updatemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Inventory",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "Name", "ParentCategoryId", "RemoveTime", "UpdateTime", "Url" },
                values: new object[] { 1, new DateTime(2022, 8, 23, 0, 28, 58, 866, DateTimeKind.Local).AddTicks(6735), false, "Cheats", null, null, null, "cheats" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "Displayed", "InsertTime", "Inventory", "IsRemoved", "Name", "Price", "RemoveTime", "UpdateTime", "ViewCount" },
                values: new object[] { 1, "SteamSale", 1, "See Enemey From Wall.", true, new DateTime(2022, 8, 23, 0, 28, 58, 866, DateTimeKind.Local).AddTicks(7086), null, false, "WallHack", 15m, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Inventory",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
