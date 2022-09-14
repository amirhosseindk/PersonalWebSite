using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2022, 9, 14, 14, 42, 53, 942, DateTimeKind.Local).AddTicks(5518));
        }
    }
}
