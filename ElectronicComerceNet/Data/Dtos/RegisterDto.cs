using System.ComponentModel.DataAnnotations;

namespace TpiProg3.Data.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required] 
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
