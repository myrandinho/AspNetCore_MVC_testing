using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC_testing.Helpers;

public class CheckBoxRequired : ValidationAttribute
{

        public override bool IsValid(object? value) => value is bool b && b;
    
}
