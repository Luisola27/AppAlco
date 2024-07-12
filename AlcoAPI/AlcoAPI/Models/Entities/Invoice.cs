namespace AlcoAPI.Models.Entities
{
    public sealed class Invoice
    {
        public Invoice() { }

        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public string Products { get; set; }
        public decimal Total { get; set; }
        public DateTime DateCreation { get; set; }
        public Client Client { get; set; }
    }
}
