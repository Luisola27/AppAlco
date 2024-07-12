using System.ComponentModel.DataAnnotations;

namespace AlcoAPI.Models
{
    public class Guaro
    {
        public int GuaroId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Active { get; set; }
        public decimal Value { get; set; }
        public string? Image { get; set; }
        public int TypeId { get; set; }
        public int CategoryId { get; set; }
    }
}
