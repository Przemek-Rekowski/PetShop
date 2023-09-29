namespace PetShopAPI.Models
{
    public class ProductDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
    }
}
