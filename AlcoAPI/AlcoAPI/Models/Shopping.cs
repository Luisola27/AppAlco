using System.ComponentModel.DataAnnotations;

namespace AlcoAPI.Models
{
    public class Shopping
    {
        public int ShoppingId { get; set; }
        public string Products { get; set; }
        public int ClientId { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
    }
}
