namespace PetShopAPI.Entities
{
    public class Cart
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
