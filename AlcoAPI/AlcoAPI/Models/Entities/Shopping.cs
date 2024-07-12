namespace AlcoAPI.Models.Entities
{
    public sealed class Shopping
    {
        public Shopping() { }

        public int ShoppingId { get; set; }
        public string Products { get; set; }
        public int ClientId { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public Client Client { get; set; }
        public Category Category { get; set; }
        public Type Type { get; set; }
    }
}
