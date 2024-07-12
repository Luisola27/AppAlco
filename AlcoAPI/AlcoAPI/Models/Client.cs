using System.ComponentModel.DataAnnotations;

namespace AlcoAPI.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string? Name { get; set; }
    }
}
