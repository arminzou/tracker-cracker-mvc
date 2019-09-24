using CapTrackerCracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapTrackerCracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var passwordOpt = new PasswordOptions()
            {
                RequiredLength = 8,
                IncludeDigit = true,
                IncludeLowercase = true,
                IncludeUppercase = true,
                IncludeSymbols = true,
                NoSimilarCharacters = true,
                Quality = 1
            };
            return View(passwordOpt);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}