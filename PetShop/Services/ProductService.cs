

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShopAPI.Data;
using PetShopAPI.Entities;
using PetShopAPI.Models;
using System;

public interface IProductService
{
    Task<string> Create(CreateProductDto dto);
    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(string id);
    void Update(string id, UpdateProductDto dto);
    void Delete(string id);
}

public class ProductService : IProductService
{
    private readonly PetShopDbContext _dbContext;
    private readonly IMapper _mapper;

    public ProductService(PetShopDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<string> Create(CreateProductDto dto)
    {
        var product = _mapper.Map<Product>(dto);

        await _dbContext.AddAsync(product);
        await _dbContext.SaveChangesAsync();

        return product.Id;
    }

    public async void Delete(string id)
    {
        var product = _dbContext
            .Products
            .FirstOrDefault(p => p.Id == id);

        _dbContext.Remove(product);

        _dbContext.SaveChanges();
    }

    public async Task<Product> GetById(string id)
    {
        var product = _dbContext
            .Products
            .FirstOrDefault(c => c.Id == id);

        return product;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        var product = await _dbContext.Products.ToListAsync();
        return product;
    }

    public async void Update(string id, UpdateProductDto dto)
    {
        var product = _dbContext
            .Products
            .FirstOrDefault(r => r.Id == id);

        product.Title = dto.Title;
        product.Description = dto.Description;
        product.ImageUrl = dto.ImageUrl;
        product.Price = dto.Price;
        product.Quantity = dto.Quantity;

        _dbContext.SaveChanges();
    }
}
