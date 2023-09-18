using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShopAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0989e87b-9251-45e3-a4b7-47cfeb9205dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "10fb21fb-7824-42e8-9e53-ec2fefbe2559");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "12f8057d-4b2c-4b4d-8212-ec9c9e46ea44");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "192e940d-b9da-45e9-9f52-0a94101c8040");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "30aead17-b9e8-4855-9196-a703faee2d48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "374909a2-ad58-4b0a-a655-968df4d4600c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "42b02437-3ae6-4aa3-93bb-f234f1b5aaee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "807d8044-8a5d-4bff-b2db-eba3813aa59f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8c4ef39a-1ed2-49c4-ad2c-84b6a9db4794");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8c992c52-3807-492d-9a50-903ea50a1296");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9a01c118-6935-418b-b57a-02f48c018515");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9b7c363d-8314-42be-bb23-463e7ac35bac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f2f10a-8f44-430f-9bf9-547fe3150d08");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad30e429-842b-4167-bca5-8d3b1eaf205c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bf19b623-b0f1-492a-b7cb-3e5bd8c48914");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c1886aa6-48ec-4a0d-8398-6a4e2d63ccac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc4453df-e049-48eb-9df1-175c8fad325c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d9026a5c-782d-4114-86c2-de772fe42f6b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9a7b12d-984e-42ad-bb5b-400d68af2d86");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f06e4412-9f00-4b58-b911-62a94f609b88");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
    }
}
