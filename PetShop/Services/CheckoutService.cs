using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Hosting.Server;
using PetShopAPI.Entities;
using Stripe.Checkout;

public interface ICheckoutService
{
    Task<CheckoutOrderResponse> Order(PetShopAPI.Entities.Product product, IServiceProvider sp);
    void Success(string sessionId);
}

public class CheckoutService : ICheckoutService
{
    private readonly IConfiguration _configuration;

    public CheckoutService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> CheckOut(PetShopAPI.Entities.Product product, string thisApiUrl)
    {
        // Create a payment flow from the items in the cart.
        // Gets sent to Stripe API.
        var options = new SessionCreateOptions
        {
            // Stripe calls the URLs below when certain checkout events happen such as success and failure.
            SuccessUrl = $"{thisApiUrl}/checkout/success?sessionId=" + "{CHECKOUT_SESSION_ID}", // Customer paid.
            PaymentMethodTypes = new List<string> // Only card available in test mode?
            {
                "card"
            },
            LineItems = new List<SessionLineItemOptions>
            {
                new()
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = product.Price, // Price is in USD cents.
                        Currency = "USD",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = product.Title,
                            Description = product.Description,
                            Images = new List<string> { product.ImageUrl }
                        },
                    },
                    Quantity = 1,
                },
            },
            Mode = "payment" // One-time payment. Stripe supports recurring 'subscription' payments.
        };

        var service = new SessionService();
        var session = await service.CreateAsync(options);

        return session.Id;
    }

    // This method gets the order details for the given session ID.
    public async Task<CheckoutOrderResponse> Order(PetShopAPI.Entities.Product product, IServiceProvider sp)
    {
        // Build the URL to which the customer will be redirected after paying.
        var server = sp.GetRequiredService<IServer>();

        var serverAddressesFeature = server.Features.Get<IServerAddressesFeature>();

        string? thisApiUrl = null;

        if (serverAddressesFeature is not null)
        {
            thisApiUrl = serverAddressesFeature.Addresses.FirstOrDefault();
        }

        var sessionId = await CheckOut(product, thisApiUrl);
        var pubKey = _configuration["Stripe:PubKey"];

        var checkoutOrderResponse = new CheckoutOrderResponse()
        {
            SessionId = sessionId,
            PubKey = pubKey
        };

        return checkoutOrderResponse;
    }

    // This method handles a successful checkout.
    public void Success(string sessionId)
    {
        var sessionService = new SessionService();
        var session = sessionService.Get(sessionId);

        var total = session.AmountTotal.Value;
        var customerEmail = session.CustomerDetails.Email;
    }
}