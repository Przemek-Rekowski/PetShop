using Microsoft.AspNetCore.Mvc;
using PetShopAPI.Entities;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _cartService.Add(product);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            var products = await _cartService.GetCart();
            return Ok(products);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveProduct(string id)
        {
            _cartService.Remove(id);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCart(int userId)
        {
            _cartService.DeleteCart(userId);
            return NoContent();
        }
    }
}
