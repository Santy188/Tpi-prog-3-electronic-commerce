using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TpiProg3.Data.Entities;

namespace TpiProg3.Data.Dtos
{
    public class OrderCreateDto
    {
        [JsonIgnore]
        public Guid? UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }

        [Required]
        public List<int> ProductsId { get; set; }
    }
}
