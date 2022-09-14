using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "IsVisible" },
                values: new object[] { new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3602), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "IsVisible" },
                values: new object[] { new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3606), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "IsVisible" },
                values: new object[] { new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3608), true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 21, 9, 45, 658, DateTimeKind.Local).AddTicks(3661));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 17, 41, 36, 452, DateTimeKind.Local).AddTicks(2967));
        }
    }
}
