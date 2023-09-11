using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;
using PetShopAPI.Entities;
using Stripe.Checkout;

namespace Server.Controllers;

[ApiController]
[Route("api/checkout")]
public class CheckoutController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ICheckoutService _checkoutService;
    private static string s_wasmClientURL = string.Empty;

    public CheckoutController(IConfiguration configuration, ICheckoutService checkoutService)
    {
        _configuration = configuration;
        _checkoutService = checkoutService;
    }

    [HttpPost]
    public async Task<ActionResult> CheckoutOrder([FromBody] Product product, [FromServices] IServiceProvider sp)
    {

        var checkoutOrderResponse = _checkoutService.Order(product, sp);

        return Ok(checkoutOrderResponse);

    }

    [HttpGet("success")]
    // Automatic query parameter handling from ASP.NET.
    // Example URL: https://localhost:7051/checkout/success?sessionId=si_123123123123
    public ActionResult CheckoutSuccess(string sessionId)
    {
        _checkoutService.Success(sessionId);

        return Redirect(s_wasmClientURL + "success");
    }
}