using System.ComponentModel.DataAnnotations;

namespace TpiProg3.Data.Dtos
{
    public class LoginDto
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }    
    }
}
