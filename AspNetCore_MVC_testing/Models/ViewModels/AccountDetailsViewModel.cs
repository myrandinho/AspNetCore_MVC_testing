namespace AspNetCore_MVC_testing.Models.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "images/profile-image.svg",
        FirstName = "Victor",
        LastName = "Rönnbäck",
        Email = "victor@xxl.se"
    };
    public AccountDetailsAdressInfoModel AdressInfo { get; set; } = new AccountDetailsAdressInfoModel();

}
