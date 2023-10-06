using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShopAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

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
        }
    }
}
