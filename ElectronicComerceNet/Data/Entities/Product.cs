using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TpiProg3.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }

        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}
