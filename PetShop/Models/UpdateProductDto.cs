namespace PetShopAPI.Models
{
    public class UpdateProductDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public long Price { get; set; }

        public int Quantity { get; set; }
    }
}
