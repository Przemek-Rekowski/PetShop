﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShopAPI.Data;

#nullable disable

namespace PetShopAPI.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    [Migration("20230918131918_AddUsers")]
    partial class AddUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetShopAPI.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "fcd6a322-6498-4eab-9de3-dfd9c3371856",
                            Description = "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/1/500",
                            Price = 1000L,
                            Quantity = 0,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = "affc3bab-bae4-4dda-94b6-d6f9f7c5adbe",
                            Description = "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/2/500",
                            Price = 2000L,
                            Quantity = 0,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = "453854a8-8130-44ac-930e-5d982a5e76c5",
                            Description = "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/3/500",
                            Price = 3000L,
                            Quantity = 0,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = "8c7c6e8d-2e4d-43e7-bf0c-f422b5e8c4ac",
                            Description = "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/4/500",
                            Price = 4000L,
                            Quantity = 0,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = "22d0e16e-3257-492c-bb6d-8ab839d55432",
                            Description = "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/5/500",
                            Price = 5000L,
                            Quantity = 0,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = "b3493fce-12c1-456a-a70e-3fbf895c1149",
                            Description = "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/6/500",
                            Price = 6000L,
                            Quantity = 0,
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = "98d70b96-6b74-4654-bdd8-93bfeb898762",
                            Description = "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/7/500",
                            Price = 7000L,
                            Quantity = 0,
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = "07d4a071-af65-4558-a1a8-1e2bbc86b03e",
                            Description = "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/8/500",
                            Price = 8000L,
                            Quantity = 0,
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = "f065c2f9-e9af-4712-8c71-08d063524b7b",
                            Description = "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/9/500",
                            Price = 9000L,
                            Quantity = 0,
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = "9e162bf0-e141-4f3f-93ff-72798a207ca0",
                            Description = "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/10/500",
                            Price = 10000L,
                            Quantity = 0,
                            Title = "Product 10"
                        },
                        new
                        {
                            Id = "1df5e091-a5f4-4800-8f97-45624775a8b0",
                            Description = "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/11/500",
                            Price = 11000L,
                            Quantity = 0,
                            Title = "Product 11"
                        },
                        new
                        {
                            Id = "c0639d9f-0592-4d76-a351-163c3660c088",
                            Description = "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/12/500",
                            Price = 12000L,
                            Quantity = 0,
                            Title = "Product 12"
                        },
                        new
                        {
                            Id = "ce1e702b-3a7e-431f-a0ab-acaf95407621",
                            Description = "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/13/500",
                            Price = 13000L,
                            Quantity = 0,
                            Title = "Product 13"
                        },
                        new
                        {
                            Id = "58ca2e33-fcbc-4deb-9a43-893fd2cc1657",
                            Description = "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/14/500",
                            Price = 14000L,
                            Quantity = 0,
                            Title = "Product 14"
                        },
                        new
                        {
                            Id = "deede820-74a5-406b-a012-db0df8ab2b2f",
                            Description = "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/15/500",
                            Price = 15000L,
                            Quantity = 0,
                            Title = "Product 15"
                        },
                        new
                        {
                            Id = "edae72d0-3c11-4d2a-a379-862fcbd9f029",
                            Description = "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/16/500",
                            Price = 16000L,
                            Quantity = 0,
                            Title = "Product 16"
                        },
                        new
                        {
                            Id = "fdcf97fd-1b0d-4436-8377-4b7ec1930c1a",
                            Description = "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/17/500",
                            Price = 17000L,
                            Quantity = 0,
                            Title = "Product 17"
                        },
                        new
                        {
                            Id = "25066416-6210-4544-8054-00cc7ed6ac02",
                            Description = "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/18/500",
                            Price = 18000L,
                            Quantity = 0,
                            Title = "Product 18"
                        },
                        new
                        {
                            Id = "cd1af7ba-b17d-4b8d-9dfb-2007fd000f94",
                            Description = "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/19/500",
                            Price = 19000L,
                            Quantity = 0,
                            Title = "Product 19"
                        },
                        new
                        {
                            Id = "1855d772-34c4-40ec-939e-a4e90bc43a53",
                            Description = "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/20/500",
                            Price = 20000L,
                            Quantity = 0,
                            Title = "Product 20"
                        });
                });

            modelBuilder.Entity("PetShopAPI.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
