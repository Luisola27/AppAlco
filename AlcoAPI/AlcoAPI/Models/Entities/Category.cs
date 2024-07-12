namespace AlcoAPI.Models.Entities
{
    public sealed class Category
    {
        public Category() { }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Shopping> Shopping { get; set; }
        public ICollection<Guaro> Guaro { get; set; }
        public ICollection<CategoryType> CategoryTypes { get; set; }
    }
}
