

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShopAPI.Data;
using PetShopAPI.Entities;
using PetShopAPI.Exceptions;
using PetShopAPI.Models;
using RestaurantAPI.Models;
using System;
using System.Linq.Expressions;

public interface IProductService
{
    Task<string> Create(CreateProductDto dto);
    PagedResult<ProductDto> GetAll(ProductQuery query);
    Task<ProductDto> GetById(string id);
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

        if (product is null)
            throw new NotFoundException("product not found");

        _dbContext.Remove(product);

        _dbContext.SaveChanges();
    }

    public async Task<ProductDto> GetById(string id)
    {
        var product = _dbContext
            .Products
            .FirstOrDefault(c => c.Id == id);

        if (product is null)
            throw new NotFoundException("product not found");

        var result = _mapper.Map<ProductDto>(product);
        return result;
    }

    public PagedResult<ProductDto> GetAll(ProductQuery query)
    {
        var baseQuery = _dbContext
            .Products
            .Where(p => (query.CategoryId == null || p.CategoryId == query.CategoryId) &&
                        (query.SearchPhrase == null ||
                         (p.Title.ToLower().Contains(query.SearchPhrase.ToLower()) ||
                          p.Description.ToLower().Contains(query.SearchPhrase.ToLower()))));


        if (!string.IsNullOrEmpty(query.SortBy))
        {
            var columnsSelectors = new Dictionary<string, Expression<Func<Product, object>>>
                {
                    { nameof(Product.Title), r => r.Title },
                    { nameof(Product.Description), r => r.Description },
                    { nameof(Product.Price), r => r.Price },
                };

            var selectedColumn = columnsSelectors[query.SortBy];

            baseQuery = query.SortDirection == SortDirection.ASC
                ? baseQuery.OrderBy(selectedColumn)
                : baseQuery.OrderByDescending(selectedColumn);
        }

        var products = baseQuery
            .Skip(query.PageSize * (query.PageNumber - 1))
            .Take(query.PageSize)
            .ToList();

        var totalItemsCount = baseQuery.Count();

        var productDtos = _mapper.Map<List<ProductDto>>(products);

        var result = new PagedResult<ProductDto>(productDtos, totalItemsCount, query.PageSize, query.PageNumber);

        return result;
    }

    public async void Update(string id, UpdateProductDto dto)
    {
        var product = _dbContext
            .Products
            .FirstOrDefault(r => r.Id == id);

        if (product is null)
            throw new NotFoundException("product not found");

        product.Title = dto.Title;
        product.Description = dto.Description;
        product.ImageUrl = dto.ImageUrl;
        product.Price = dto.Price;
        product.Quantity = dto.Quantity;
        product.CategoryId = dto.CategoryId;

        _dbContext.SaveChanges();
    }
}
