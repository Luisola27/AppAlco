namespace AlcoAPI.Models.Entities
{
    public sealed class Client
    {
        public Client() { }

        public int ClientId { get; set; }
        public string? Name { get; set; }
        public ICollection<Invoice?> Invoice { get; set; }
        public ICollection<Shopping?> Shopping { get; set; }
    }
}
