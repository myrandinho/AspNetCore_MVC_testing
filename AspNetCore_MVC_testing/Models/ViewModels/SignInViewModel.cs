namespace AspNetCore_MVC_testing.Models.ViewModels;

public class SignInViewModel
{
    public string Title = "Sign in";
    public SignInModel Form { get; set; } = new SignInModel();
    public string? ErrorMessage { get; set; }
}
