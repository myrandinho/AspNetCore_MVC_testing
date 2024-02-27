using AspNetCore_MVC_testing.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_testing.Controllers
{
    public class AuthController : Controller
    {
       


        //signup

        [Route("/signup")]
        [HttpGet]
        public IActionResult SignUp()
        {
            var viewModel = new SignUpViewModel();
            return View(viewModel);
        }

        [Route("/signup")]
        [HttpPost]
        public IActionResult SignUp(SignUpViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            return RedirectToAction("SignIn", "Auth");
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










        public IActionResult SignOut()
        {
            return View();
        }
    }
}
