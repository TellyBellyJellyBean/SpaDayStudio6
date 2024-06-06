
using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModel;

public class AddUserViewModel
{
    [Required(ErrorMessage = "Username is required")]
    [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters long.")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Must put in a valid password between 6-20 characters.")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Must be between 6-20 characters.")]
    public string? Password { get; set; }

    [EmailAddress(ErrorMessage = "Email is optional, but it must be a valid email.")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Must verify password.")]

    public string? VerifyPassword { get; set; }
}
