using System.ComponentModel.DataAnnotations;

namespace WCP.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;

        public bool? RememberMe { get; set; }
    }
}
