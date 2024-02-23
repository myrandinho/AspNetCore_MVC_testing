using AspNetCore_MVC_testing.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_testing.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/signin")]
        public IActionResult SignIn()
        {
            return View();
        }

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
            if (ModelState.IsValid)
                return View(viewModel);

            return RedirectToAction("SignIn", "Auth");
        }

        public IActionResult SignOut()
        {
            return View();
        }
    }
}
