using System.ComponentModel.DataAnnotations;

namespace VjezbaDeja.Controllers
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [MinLength(10)]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
