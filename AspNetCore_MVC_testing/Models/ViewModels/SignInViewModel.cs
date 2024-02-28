

using Infrastructure.Models;

public class SignInViewModel
{
    public string Title = "Sign in";
    public SignInModel Form { get; set; } = new SignInModel();
    public string? ErrorMessage { get; set; }
}
