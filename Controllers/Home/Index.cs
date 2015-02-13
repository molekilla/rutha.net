using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Rutha.Controllers.Home
{
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            //return RedirectToAction("Index", "Account");
            return View();
        }

        [HttpGet("/about")]
        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet("/contact")]
        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet("/error")]
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}