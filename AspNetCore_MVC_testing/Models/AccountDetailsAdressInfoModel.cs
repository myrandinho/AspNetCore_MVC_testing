using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC_testing.Models
{
    public class AccountDetailsAdressInfoModel
    {
        [Display(Name = "Adress line 1", Prompt = "Enter your adress line", Order = 0)]
        [Required(ErrorMessage = "First name is required")]
        public string AdressLine_1 { get; set; } = null!;


        [Display(Name = "Adress line 2", Prompt = "Enter your second adress line", Order = 1)]
        [Required(ErrorMessage = "Last name is required")]
        public string? AdressLine_2 { get; set; }

        [Display(Name = "Postal Code", Prompt = "Enter your postal code", Order = 2)]
        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { get; set; } = null!;


        [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = null!;
    }
}
