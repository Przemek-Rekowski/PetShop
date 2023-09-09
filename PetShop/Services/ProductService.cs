

using Microsoft.EntityFrameworkCore;
using PetShopAPI.Data;
using PetShopAPI.Entities;
using System;

public interface IProductService
{
    Task<string> CreateProduct(Product product);
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> GetProductById(string id);
    void UpdateProduct(Product updatedProduct);
    void DeleteProduct(string productId);
}

public class ProductService : IProductService
{
    private readonly PetShopDbContext _dbContext;

    public ProductService(PetShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<string> CreateProduct(Product product)
    {
        product.Id = Guid.NewGuid().ToString();

        await _dbContext.AddAsync(product);

        await _dbContext.SaveChangesAsync();

        return product.Id;
    }

    public async void DeleteProduct(string productId)
    {
        var productToDelete = await _dbContext.Products.FindAsync(productId);

        _dbContext.Remove(productToDelete);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<Product> GetProductById(string id)
    {
        var product = await _dbContext.Products.FindAsync(id);
        return product;
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        var product = await _dbContext.Products.ToListAsync();
        return product;
    }

    public async void UpdateProduct(Product updatedProduct)
    {
        _dbContext.Update(updatedProduct);

        await _dbContext.SaveChangesAsync();
    }
}
