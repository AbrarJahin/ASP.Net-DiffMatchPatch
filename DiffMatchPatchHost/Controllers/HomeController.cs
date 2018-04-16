using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiffMatchPatchHost.Models;

namespace DiffMatchPatchHost.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult DiffMatchPatch(string firstString, string secondString)
        {
            ViewData["Message"] = firstString + " " + secondString;

            return Json(ViewData["Message"]);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
