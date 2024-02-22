
using AspNetCore_MVC_testing.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_testing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var viewModel = new HomeIndexViewModel();

            ViewData["Title"] = viewModel.Title;
            return View(viewModel);
        }
    }
}
