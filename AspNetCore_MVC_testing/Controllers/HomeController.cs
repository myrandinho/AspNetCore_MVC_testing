

using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_testing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
