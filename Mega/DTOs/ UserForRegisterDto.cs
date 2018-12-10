using System.ComponentModel.DataAnnotations;

namespace Mega.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [StringLength(8,MinimumLength = 4 , ErrorMessage = "Your password should Length between 4-8 characters.")]
        public string Password { get; set; }
    }
}