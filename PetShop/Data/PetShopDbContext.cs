using Microsoft.EntityFrameworkCore;
using PetShopAPI.Entities;

namespace PetShopAPI.Data
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            const int amountOfProductsToSeed = 20;

            var productsToSeed = new Product[amountOfProductsToSeed];

            for (int i = 1; i <= amountOfProductsToSeed; i++)
            {
                productsToSeed[i - 1] = new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = $"Product {i}",
                    Description = $"Product {i} description. This is an amazing product with a price-quality balance you won't find anywhere else.",
                    ImageUrl = $"https://picsum.photos/id/{i}/500",
                    Price = 1000 * i,
                };
            }

            modelBuilder.Entity<Product>().HasData(productsToSeed);
            modelBuilder.Entity<Cart>(c => c.HasNoKey());
        }
    }
}
