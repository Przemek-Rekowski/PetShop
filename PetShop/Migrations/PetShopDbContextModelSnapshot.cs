﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShopAPI.Data;

#nullable disable

namespace PetShopAPI.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    partial class PetShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetShopAPI.Entities.Cart", b =>
                {
                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

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
                            Id = "4ee5abf5-2765-4afc-a980-71120431f86b",
                            Description = "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/1/500",
                            Price = 1000L,
                            Quantity = 0,
                            Title = "Product 1"
                        },
                        new
                        {
                            Id = "c55c6608-8a3b-4224-bc7e-f66fb40ecff8",
                            Description = "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/2/500",
                            Price = 2000L,
                            Quantity = 0,
                            Title = "Product 2"
                        },
                        new
                        {
                            Id = "783f57b3-54f2-43b2-a2fe-fae7084caf2f",
                            Description = "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/3/500",
                            Price = 3000L,
                            Quantity = 0,
                            Title = "Product 3"
                        },
                        new
                        {
                            Id = "c164137b-b6fd-4e0b-ae19-ef7c27775634",
                            Description = "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/4/500",
                            Price = 4000L,
                            Quantity = 0,
                            Title = "Product 4"
                        },
                        new
                        {
                            Id = "592fb52a-b22a-410b-ad60-5028d7fcf918",
                            Description = "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/5/500",
                            Price = 5000L,
                            Quantity = 0,
                            Title = "Product 5"
                        },
                        new
                        {
                            Id = "8b62f97d-9bde-47b5-a9fb-b72a994f0015",
                            Description = "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/6/500",
                            Price = 6000L,
                            Quantity = 0,
                            Title = "Product 6"
                        },
                        new
                        {
                            Id = "b28f32a5-f4b3-4b26-8b2c-b49e734b445d",
                            Description = "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/7/500",
                            Price = 7000L,
                            Quantity = 0,
                            Title = "Product 7"
                        },
                        new
                        {
                            Id = "93ca6437-3735-4e3b-ad8a-e380286bac43",
                            Description = "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/8/500",
                            Price = 8000L,
                            Quantity = 0,
                            Title = "Product 8"
                        },
                        new
                        {
                            Id = "70dd6bd5-3edc-4771-bf90-ee6cc74c6920",
                            Description = "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/9/500",
                            Price = 9000L,
                            Quantity = 0,
                            Title = "Product 9"
                        },
                        new
                        {
                            Id = "929517f9-8c0d-436a-b1d0-7f362e1e13a6",
                            Description = "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/10/500",
                            Price = 10000L,
                            Quantity = 0,
                            Title = "Product 10"
                        },
                        new
                        {
                            Id = "f79ce0ed-1791-4566-b8c6-e71b55a18002",
                            Description = "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/11/500",
                            Price = 11000L,
                            Quantity = 0,
                            Title = "Product 11"
                        },
                        new
                        {
                            Id = "0148f9c4-2628-44cc-a248-17ea5c608a6d",
                            Description = "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/12/500",
                            Price = 12000L,
                            Quantity = 0,
                            Title = "Product 12"
                        },
                        new
                        {
                            Id = "c202c688-fb7f-4b3b-9087-16daba062054",
                            Description = "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/13/500",
                            Price = 13000L,
                            Quantity = 0,
                            Title = "Product 13"
                        },
                        new
                        {
                            Id = "4f1a5567-36d0-4fbd-83f6-113287d57baa",
                            Description = "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/14/500",
                            Price = 14000L,
                            Quantity = 0,
                            Title = "Product 14"
                        },
                        new
                        {
                            Id = "45f72a35-8aed-41a1-ad92-a4506cd1f87b",
                            Description = "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/15/500",
                            Price = 15000L,
                            Quantity = 0,
                            Title = "Product 15"
                        },
                        new
                        {
                            Id = "a7873b43-ba4d-4093-a227-9ae49e6e67d9",
                            Description = "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/16/500",
                            Price = 16000L,
                            Quantity = 0,
                            Title = "Product 16"
                        },
                        new
                        {
                            Id = "92162d3b-f8da-4596-bf3d-09f58dc9d3a0",
                            Description = "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/17/500",
                            Price = 17000L,
                            Quantity = 0,
                            Title = "Product 17"
                        },
                        new
                        {
                            Id = "df6e0df8-905e-4960-8282-60ae72b2b3cf",
                            Description = "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/18/500",
                            Price = 18000L,
                            Quantity = 0,
                            Title = "Product 18"
                        },
                        new
                        {
                            Id = "a0031583-0253-43b6-8f47-9d66eaf54aa3",
                            Description = "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                            ImageUrl = "https://picsum.photos/id/19/500",
                            Price = 19000L,
                            Quantity = 0,
                            Title = "Product 19"
                        },
                        new
                        {
                            Id = "6f72abdd-ef01-4b23-ae18-995e42f63368",
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

            modelBuilder.Entity("PetShopAPI.Entities.Cart", b =>
                {
                    b.HasOne("PetShopAPI.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShopAPI.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
