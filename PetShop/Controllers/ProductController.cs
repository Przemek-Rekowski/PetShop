using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShopAPI.Entities;

namespace Server.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product productToCreate)
    {
        _productService.CreateProduct(productToCreate);

        return Ok();
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> GetAll()
    {
        var products = _productService.GetProducts();

        return Ok(products);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<Product> GetById(string id)
    {
        var product = _productService.GetProductById(id);

        return Ok(product);
    }

    [HttpPut]
    public async Task<IActionResult> Update(Product updatedProduct)
    {
        _productService.UpdateProduct(updatedProduct);

        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        _productService.DeleteProduct(id);

        return NoContent();
    }
}