namespace PetShopAPI.Entities
{
    public class Cart
    {
        public int UserId { get; set; }
        public virtual User User { get; set; } = default!;
        public string ProductId { get; set; } = default!;
        public virtual Product Product { get; set; } = default!;
    }
}
