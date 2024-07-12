namespace AlcoAPI.Models.Entities
{
    public class CategoryType
    {
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public Category Category { get; set; }
        public Type Type { get; set; }
    }
}
