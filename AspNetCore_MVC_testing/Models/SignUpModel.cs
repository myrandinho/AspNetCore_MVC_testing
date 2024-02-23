using AspNetCore_MVC_testing.Helpers;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC_testing.Models;

public class SignUpModel
{
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your Last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email adress", Prompt = "Enter email", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your email is invalid")]

    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter password", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Invalid password, must be strong password")]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm Password", Prompt = "Confirm password", Order = 4)]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords does not match")]
    [Required(ErrorMessage = "Password must be confirmed")]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "I agree to the Terms & Conditions", Order = 5)]
    [Required(ErrorMessage = "You must accept the terms and conditions.")]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions.")]
    public bool TermsAndConditions { get; set; } = false;
}

