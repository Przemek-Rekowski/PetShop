namespace PetShopAPI.Entities;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Title { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public long Price { get; set; }

    public int Quantity { get; set; }
}
