namespace PetShopAPI.Entities
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public long Price { get; set; }
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = default!;
    }
}
