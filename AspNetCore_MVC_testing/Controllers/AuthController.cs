using AspNetCore_MVC_testing.Models.ViewModels;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_testing.Controllers
{
    public class AuthController(UserService userService) : Controller
    {
       private readonly UserService _userService = userService;


        //signup

        [Route("/signup")]
        [HttpGet]
        public IActionResult SignUp() => View(new SignUpViewModel());
        //public IActionResult SignUp()
        //{
        //    var viewModel = new SignUpViewModel();
        //    return View(viewModel);
        //}

        [Route("/signup")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.CreateUserAsync(viewModel.Form);
                if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
                    return RedirectToAction("SignIn", "Auth");
            }

            return View(viewModel);
        }

        //sign in

        [Route("/signin")]
        [HttpGet]
        public IActionResult SignIn()
        {
            var viewModel = new SignInViewModel();
            return View(viewModel);
        }

        [Route("/signin")]
        [HttpPost]
        public IActionResult SignIn(SignInViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            viewModel.ErrorMessage = "Incorrect email or password";
            return View(viewModel);
        }


        //[HttpGet]
        //[Route("/signin")]
        //public IActionResult SignIn() => View(new SignInViewModel());
        //[HttpPost]
        //[Route("/signin")]
        //public async Task<IActionResult> SignIn(SignInViewModel viewModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var result = await _userService.SignInUserAsync(viewModel.Form);
        //        if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
        //            return RedirectToAction("Details", "Account");
        //    }

        //    viewModel.ErrorMessage = "Incorrect email or password";
        //    return View(viewModel);
        //}







        //public IActionResult SignOut()
        //{
        //    return View();
        //}
    }
}
