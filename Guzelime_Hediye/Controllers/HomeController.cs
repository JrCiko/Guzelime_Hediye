using Guzelime_Hediye.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guzelime_Hediye.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Surprise()
        {
            return View();
        }
        public IActionResult Anilar()
        {
            return View();
        }

    }
}
