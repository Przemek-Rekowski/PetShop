

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShopAPI.Data;
using PetShopAPI.Entities;
using PetShopAPI.Exceptions;
using PetShopAPI.Models;
using System;

public interface ICartService
{
    Task<IEnumerable<Cart>> GetCart();
    void Add(Product product);
    void Remove(string id);
    void DeleteCart(int userId);
}

public class CartService : ICartService
{
    private readonly PetShopDbContext _dbContext;
    private readonly IMapper _mapper;

    public CartService(PetShopDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async void Add(Product product)
    {
        var cart = new Cart()
        {
            ProductId = product.Id,
            UserId = 1 //test
        };

        await _dbContext.AddAsync(cart);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Cart>> GetCart()
    {
        var user = new User();

        var cart = _dbContext
            .Carts
            .Where(c => c.UserId == user.Id)
            .ToList();

        if (cart is null)
            throw new NotFoundException("cart not found");

        return cart;
    }

    public void Remove(string productId)
    {
        var cartItem = _dbContext
            .Carts
            .FirstOrDefault(c => c.ProductId == productId);

        if (cartItem is null)
            throw new NotFoundException("product not found");

        _dbContext.Remove(cartItem);

        _dbContext.SaveChanges();
    }

    public async void DeleteCart(int userId)
    {
        var cart = _dbContext
            .Carts
            .Where(c => c.UserId == userId)
            .ToList();

        if (cart is null)
            throw new NotFoundException("cart not found");

        _dbContext.Remove(cart);

        _dbContext.SaveChanges();
    }
}
