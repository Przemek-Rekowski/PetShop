using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShopAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "07d4a071-af65-4558-a1a8-1e2bbc86b03e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1855d772-34c4-40ec-939e-a4e90bc43a53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1df5e091-a5f4-4800-8f97-45624775a8b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "22d0e16e-3257-492c-bb6d-8ab839d55432");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "25066416-6210-4544-8054-00cc7ed6ac02");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "453854a8-8130-44ac-930e-5d982a5e76c5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "58ca2e33-fcbc-4deb-9a43-893fd2cc1657");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8c7c6e8d-2e4d-43e7-bf0c-f422b5e8c4ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98d70b96-6b74-4654-bdd8-93bfeb898762");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9e162bf0-e141-4f3f-93ff-72798a207ca0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "affc3bab-bae4-4dda-94b6-d6f9f7c5adbe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b3493fce-12c1-456a-a70e-3fbf895c1149");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c0639d9f-0592-4d76-a351-163c3660c088");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd1af7ba-b17d-4b8d-9dfb-2007fd000f94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce1e702b-3a7e-431f-a0ab-acaf95407621");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "deede820-74a5-406b-a012-db0df8ab2b2f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "edae72d0-3c11-4d2a-a379-862fcbd9f029");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f065c2f9-e9af-4712-8c71-08d063524b7b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fcd6a322-6498-4eab-9de3-dfd9c3371856");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fdcf97fd-1b0d-4436-8377-4b7ec1930c1a");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { "0148f9c4-2628-44cc-a248-17ea5c608a6d", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/12/500", 12000L, 0, "Product 12" },
                    { "45f72a35-8aed-41a1-ad92-a4506cd1f87b", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/15/500", 15000L, 0, "Product 15" },
                    { "4ee5abf5-2765-4afc-a980-71120431f86b", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/1/500", 1000L, 0, "Product 1" },
                    { "4f1a5567-36d0-4fbd-83f6-113287d57baa", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/14/500", 14000L, 0, "Product 14" },
                    { "592fb52a-b22a-410b-ad60-5028d7fcf918", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/5/500", 5000L, 0, "Product 5" },
                    { "6f72abdd-ef01-4b23-ae18-995e42f63368", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/20/500", 20000L, 0, "Product 20" },
                    { "70dd6bd5-3edc-4771-bf90-ee6cc74c6920", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/9/500", 9000L, 0, "Product 9" },
                    { "783f57b3-54f2-43b2-a2fe-fae7084caf2f", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/3/500", 3000L, 0, "Product 3" },
                    { "8b62f97d-9bde-47b5-a9fb-b72a994f0015", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/6/500", 6000L, 0, "Product 6" },
                    { "92162d3b-f8da-4596-bf3d-09f58dc9d3a0", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/17/500", 17000L, 0, "Product 17" },
                    { "929517f9-8c0d-436a-b1d0-7f362e1e13a6", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/10/500", 10000L, 0, "Product 10" },
                    { "93ca6437-3735-4e3b-ad8a-e380286bac43", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/8/500", 8000L, 0, "Product 8" },
                    { "a0031583-0253-43b6-8f47-9d66eaf54aa3", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/19/500", 19000L, 0, "Product 19" },
                    { "a7873b43-ba4d-4093-a227-9ae49e6e67d9", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/16/500", 16000L, 0, "Product 16" },
                    { "b28f32a5-f4b3-4b26-8b2c-b49e734b445d", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/7/500", 7000L, 0, "Product 7" },
                    { "c164137b-b6fd-4e0b-ae19-ef7c27775634", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/4/500", 4000L, 0, "Product 4" },
                    { "c202c688-fb7f-4b3b-9087-16daba062054", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/13/500", 13000L, 0, "Product 13" },
                    { "c55c6608-8a3b-4224-bc7e-f66fb40ecff8", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/2/500", 2000L, 0, "Product 2" },
                    { "df6e0df8-905e-4960-8282-60ae72b2b3cf", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/18/500", 18000L, 0, "Product 18" },
                    { "f79ce0ed-1791-4566-b8c6-e71b55a18002", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/11/500", 11000L, 0, "Product 11" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0148f9c4-2628-44cc-a248-17ea5c608a6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "45f72a35-8aed-41a1-ad92-a4506cd1f87b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4ee5abf5-2765-4afc-a980-71120431f86b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f1a5567-36d0-4fbd-83f6-113287d57baa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "592fb52a-b22a-410b-ad60-5028d7fcf918");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f72abdd-ef01-4b23-ae18-995e42f63368");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70dd6bd5-3edc-4771-bf90-ee6cc74c6920");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "783f57b3-54f2-43b2-a2fe-fae7084caf2f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8b62f97d-9bde-47b5-a9fb-b72a994f0015");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92162d3b-f8da-4596-bf3d-09f58dc9d3a0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "929517f9-8c0d-436a-b1d0-7f362e1e13a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93ca6437-3735-4e3b-ad8a-e380286bac43");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a0031583-0253-43b6-8f47-9d66eaf54aa3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7873b43-ba4d-4093-a227-9ae49e6e67d9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b28f32a5-f4b3-4b26-8b2c-b49e734b445d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c164137b-b6fd-4e0b-ae19-ef7c27775634");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c202c688-fb7f-4b3b-9087-16daba062054");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c55c6608-8a3b-4224-bc7e-f66fb40ecff8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "df6e0df8-905e-4960-8282-60ae72b2b3cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f79ce0ed-1791-4566-b8c6-e71b55a18002");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { "07d4a071-af65-4558-a1a8-1e2bbc86b03e", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/8/500", 8000L, 0, "Product 8" },
                    { "1855d772-34c4-40ec-939e-a4e90bc43a53", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/20/500", 20000L, 0, "Product 20" },
                    { "1df5e091-a5f4-4800-8f97-45624775a8b0", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/11/500", 11000L, 0, "Product 11" },
                    { "22d0e16e-3257-492c-bb6d-8ab839d55432", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/5/500", 5000L, 0, "Product 5" },
                    { "25066416-6210-4544-8054-00cc7ed6ac02", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/18/500", 18000L, 0, "Product 18" },
                    { "453854a8-8130-44ac-930e-5d982a5e76c5", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/3/500", 3000L, 0, "Product 3" },
                    { "58ca2e33-fcbc-4deb-9a43-893fd2cc1657", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/14/500", 14000L, 0, "Product 14" },
                    { "8c7c6e8d-2e4d-43e7-bf0c-f422b5e8c4ac", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/4/500", 4000L, 0, "Product 4" },
                    { "98d70b96-6b74-4654-bdd8-93bfeb898762", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/7/500", 7000L, 0, "Product 7" },
                    { "9e162bf0-e141-4f3f-93ff-72798a207ca0", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/10/500", 10000L, 0, "Product 10" },
                    { "affc3bab-bae4-4dda-94b6-d6f9f7c5adbe", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/2/500", 2000L, 0, "Product 2" },
                    { "b3493fce-12c1-456a-a70e-3fbf895c1149", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/6/500", 6000L, 0, "Product 6" },
                    { "c0639d9f-0592-4d76-a351-163c3660c088", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/12/500", 12000L, 0, "Product 12" },
                    { "cd1af7ba-b17d-4b8d-9dfb-2007fd000f94", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/19/500", 19000L, 0, "Product 19" },
                    { "ce1e702b-3a7e-431f-a0ab-acaf95407621", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/13/500", 13000L, 0, "Product 13" },
                    { "deede820-74a5-406b-a012-db0df8ab2b2f", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/15/500", 15000L, 0, "Product 15" },
                    { "edae72d0-3c11-4d2a-a379-862fcbd9f029", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/16/500", 16000L, 0, "Product 16" },
                    { "f065c2f9-e9af-4712-8c71-08d063524b7b", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/9/500", 9000L, 0, "Product 9" },
                    { "fcd6a322-6498-4eab-9de3-dfd9c3371856", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/1/500", 1000L, 0, "Product 1" },
                    { "fdcf97fd-1b0d-4436-8377-4b7ec1930c1a", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/17/500", 17000L, 0, "Product 17" }
                });
        }
    }
}
