using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class fea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Featured", "InsertTime" },
                values: new object[] { true, new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Featured", "InsertTime" },
                values: new object[] { true, new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Featured", "InsertTime" },
                values: new object[] { true, new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3242));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3351));
        }
    }
}
