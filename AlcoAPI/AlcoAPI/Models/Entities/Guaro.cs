using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlcoAPI.Models.Entities
{
    public class Guaro()
    {
        public int GuaroId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Active { get; set; }
        public decimal Value { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public Category Category { get; set; }
        public Type Type { get; set; }

    }
}
