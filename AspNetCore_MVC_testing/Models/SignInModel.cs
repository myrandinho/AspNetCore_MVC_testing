using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC_testing.Models;

public class SignInModel
{
    [Display(Name = "Email adress", Prompt = "Enter email", Order = 0)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    

    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter password", Order = 1)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    
    public string Password { get; set; } = null!;

    [Display(Name = "Remember me", Order = 2)]

    public bool RememberMe { get; set; }
}
