using System.ComponentModel.DataAnnotations;

namespace App.Controllers.Resources
{
    public class RegisterResource
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}