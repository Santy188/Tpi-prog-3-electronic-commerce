using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TpiProg3.Data.Enums;

namespace TpiProg3.Data.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public OrderState State { get; set; }

        public Guid UserId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
