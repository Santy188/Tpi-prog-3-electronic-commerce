using System.ComponentModel.DataAnnotations;
using TpiProg3.Data.Enums;

namespace TpiProg3.Data.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required] 
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public float Price { get; set; }

        [Required]
        public ProductState State { get; set; }

    }
}
