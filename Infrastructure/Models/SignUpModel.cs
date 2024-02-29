

using Infrastructure.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class SignUpModel
{
    [DataType(DataType.Text)]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "First name is required")]
    [MinLength(2, ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;

    [DataType(DataType.Text)]
    [Display(Name = "Last name", Prompt = "Enter your Last name")]
    [Required(ErrorMessage = "Last name is required")]
    [MinLength(2, ErrorMessage = "First name is required")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email adress", Prompt = "Enter email")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your email is invalid")]

    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Invalid password, must be strong password")]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm Password", Prompt = "Confirm password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords does not match")]
    [Required(ErrorMessage = "Password must be confirmed")]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "I agree to the Terms & Condotions.")]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions to proceed.")]
    public bool TermsAndConditions { get; set; } = false;
}
