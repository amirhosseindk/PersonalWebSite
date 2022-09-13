using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EndPoint.Site.Server.Migrations
{
    public partial class variant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Name", "Url" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3203), "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "Name", "ParentCategoryId", "RemoveTime", "UpdateTime", "Url" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3208), false, "Movies", null, null, null, "movies" },
                    { 3, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3210), false, "Video Games", null, null, null, "video-games" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "Name", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3014), false, "Default", null, null },
                    { 2, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3051), false, "Paperback", null, null },
                    { 3, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3054), false, "E-Book", null, null },
                    { 4, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3057), false, "Audiobook", null, null },
                    { 5, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3059), false, "Stream", null, null },
                    { 6, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3061), false, "Blu-ray", null, null },
                    { 7, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3063), false, "VHS", null, null },
                    { 8, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3065), false, "PC", null, null },
                    { 9, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3067), false, "PlayStation", null, null },
                    { 10, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3070), false, "Xbox", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "Displayed", "ImageUrl", "InsertTime", "Name" },
                values: new object[] { "", "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", false, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3231), "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "Displayed", "ImageUrl", "InsertTime", "Inventory", "IsRemoved", "Name", "RemoveTime", "UpdateTime", "ViewCount" },
                values: new object[,]
                {
                    { 2, "", 1, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3235), null, false, "Ready Player One", null, null, null },
                    { 3, "", 1, "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3238), null, false, "Nineteen Eighty-Four", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "Id", "InsertTime", "IsRemoved", "OriginalPrice", "Price", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1, 2, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3376), false, 19.99m, 9.99m, null, null },
                    { 1, 3, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3383), false, 0m, 7.99m, null, null },
                    { 1, 4, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3385), false, 29.99m, 19.99m, null, null },
                    { 2, 2, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3388), false, 14.99m, 7.99m, null, null },
                    { 3, 2, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3390), false, 0m, 6.99m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "Displayed", "ImageUrl", "InsertTime", "Inventory", "IsRemoved", "Name", "RemoveTime", "UpdateTime", "ViewCount" },
                values: new object[,]
                {
                    { 4, "", 2, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3241), null, false, "The Matrix", null, null, null },
                    { 5, "", 2, "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", false, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3243), null, false, "Back to the Future", null, null, null },
                    { 6, "", 2, "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3337), null, false, "Toy Story", null, null, null },
                    { 7, "", 3, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3340), null, false, "Half-Life 2", null, null, null },
                    { 8, "", 3, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3342), null, false, "Diablo II", null, null, null },
                    { 9, "", 3, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", false, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3346), null, false, "Day of the Tentacle", null, null, null },
                    { 10, "", 3, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3349), null, false, "Xbox", null, null, null },
                    { 11, "", 3, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3351), null, false, "Super Nintendo Entertainment System", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "Id", "InsertTime", "IsRemoved", "OriginalPrice", "Price", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 4, 5, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3393), false, 0m, 3.99m, null, null },
                    { 4, 6, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3395), false, 0m, 9.99m, null, null },
                    { 4, 7, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3397), false, 0m, 19.99m, null, null },
                    { 5, 5, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3399), false, 0m, 3.99m, null, null },
                    { 6, 5, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3401), false, 0m, 2.99m, null, null },
                    { 7, 8, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3403), false, 29.99m, 19.99m, null, null },
                    { 7, 9, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3406), false, 0m, 69.99m, null, null },
                    { 7, 10, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3408), false, 59.99m, 49.99m, null, null },
                    { 8, 8, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3410), false, 24.99m, 9.99m, null, null },
                    { 9, 8, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3413), false, 0m, 14.99m, null, null },
                    { 10, 1, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3415), false, 299m, 159.99m, null, null },
                    { 11, 1, 0, new DateTime(2022, 8, 24, 17, 30, 58, 419, DateTimeKind.Local).AddTicks(3418), false, 399m, 79.99m, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(19,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Name", "Url" },
                values: new object[] { new DateTime(2022, 8, 23, 13, 50, 33, 629, DateTimeKind.Local).AddTicks(930), "Cheats", "cheats" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "Displayed", "ImageUrl", "InsertTime", "Name", "Price" },
                values: new object[] { "SteamSale", "See Enemey From Wall.", true, "https://gamingforecast.com/wp-content/uploads/2022/02/e8857a1a9e95526657999f9178196727.png", new DateTime(2022, 8, 23, 13, 50, 33, 629, DateTimeKind.Local).AddTicks(1063), "WallHack", 15m });
        }
    }
}
