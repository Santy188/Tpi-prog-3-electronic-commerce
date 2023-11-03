using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TpiProg3.Data.Enums;

namespace TpiProg3.Data.Dtos
{
    public class OrderUpdateDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public OrderState State { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [JsonIgnore]
        public UserDto? User { get; set; }

        [Required]
        public List<int> ProductsId { get; set; }
    }
}
