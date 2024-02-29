

using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class SignInModel
{
    [Display(Name = "Email adress", Prompt = "Enter email")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]

    public string Password { get; set; } = null!;

    [Display(Name = "Remember me")]

    public bool RememberMe { get; set; }
}
