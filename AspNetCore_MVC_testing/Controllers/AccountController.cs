﻿using AspNetCore_MVC_testing.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_testing.Controllers
{
    public class AccountController : Controller
    {

        [Route("/account")]
        public IActionResult Details()
        {
            var viewModel = new AccountDetailsViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
        {
            //return RedirectToAction(nameof(Details));
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AdressInfo(AccountDetailsViewModel viewModel)
        {
            //return RedirectToAction(nameof(Details));
            return View(viewModel);
        }
    }
}
