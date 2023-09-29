using Microsoft.AspNetCore.Mvc;
using PetShopAPI.Models;
using RestaurantAPI.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto dto)
        {
            var id = await _productService.Create(dto);
            return Created($"/api/{id}", null);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetAllProducts([FromQuery] ProductQuery query)
        {
            var products =  _productService.GetAll(query);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var product = await _productService.GetById(id);
            return Ok(product);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, UpdateProductDto dto)
        {
            _productService.Update(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            _productService.Delete(id);
            return NoContent();
        }
    }
}
