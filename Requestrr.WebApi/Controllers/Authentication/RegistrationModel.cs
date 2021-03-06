using System.ComponentModel.DataAnnotations;

namespace Requestrr.WebApi.Controllers
{
    public class RegistrationModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordConfirmation { get; set; }
    }
}
