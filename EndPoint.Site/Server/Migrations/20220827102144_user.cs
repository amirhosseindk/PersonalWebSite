using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2022, 8, 27, 14, 51, 43, 666, DateTimeKind.Local).AddTicks(5124));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3209));

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
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3224));

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
                column: "InsertTime",
                value: new DateTime(2022, 8, 25, 16, 42, 58, 3, DateTimeKind.Local).AddTicks(3237));

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
    }
}
