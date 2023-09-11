using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShopAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { "0989e87b-9251-45e3-a4b7-47cfeb9205dc", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/10/500", 10000L, 0, "Product 10" },
                    { "10fb21fb-7824-42e8-9e53-ec2fefbe2559", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/14/500", 14000L, 0, "Product 14" },
                    { "12f8057d-4b2c-4b4d-8212-ec9c9e46ea44", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/11/500", 11000L, 0, "Product 11" },
                    { "192e940d-b9da-45e9-9f52-0a94101c8040", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/12/500", 12000L, 0, "Product 12" },
                    { "30aead17-b9e8-4855-9196-a703faee2d48", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/15/500", 15000L, 0, "Product 15" },
                    { "374909a2-ad58-4b0a-a655-968df4d4600c", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/16/500", 16000L, 0, "Product 16" },
                    { "42b02437-3ae6-4aa3-93bb-f234f1b5aaee", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/3/500", 3000L, 0, "Product 3" },
                    { "807d8044-8a5d-4bff-b2db-eba3813aa59f", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/13/500", 13000L, 0, "Product 13" },
                    { "8c4ef39a-1ed2-49c4-ad2c-84b6a9db4794", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/7/500", 7000L, 0, "Product 7" },
                    { "8c992c52-3807-492d-9a50-903ea50a1296", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/9/500", 9000L, 0, "Product 9" },
                    { "9a01c118-6935-418b-b57a-02f48c018515", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/6/500", 6000L, 0, "Product 6" },
                    { "9b7c363d-8314-42be-bb23-463e7ac35bac", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/1/500", 1000L, 0, "Product 1" },
                    { "a9f2f10a-8f44-430f-9bf9-547fe3150d08", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/17/500", 17000L, 0, "Product 17" },
                    { "ad30e429-842b-4167-bca5-8d3b1eaf205c", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/18/500", 18000L, 0, "Product 18" },
                    { "bf19b623-b0f1-492a-b7cb-3e5bd8c48914", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/2/500", 2000L, 0, "Product 2" },
                    { "c1886aa6-48ec-4a0d-8398-6a4e2d63ccac", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/19/500", 19000L, 0, "Product 19" },
                    { "cc4453df-e049-48eb-9df1-175c8fad325c", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/5/500", 5000L, 0, "Product 5" },
                    { "d9026a5c-782d-4114-86c2-de772fe42f6b", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/20/500", 20000L, 0, "Product 20" },
                    { "e9a7b12d-984e-42ad-bb5b-400d68af2d86", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/8/500", 8000L, 0, "Product 8" },
                    { "f06e4412-9f00-4b58-b911-62a94f609b88", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/4/500", 4000L, 0, "Product 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
