using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(19,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductTypeId",
                table: "OrderItems",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2022, 9, 13, 21, 3, 21, 209, DateTimeKind.Local).AddTicks(8212));
        }
    }
}
