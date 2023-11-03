using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TpiProg3.Data.Entities
{
    public abstract class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public abstract int Id { get; }

        public abstract string Name { get; }

        public abstract string Email { get; }

        public abstract string Password { get; }
    }
}
