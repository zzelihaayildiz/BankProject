using BankProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BankProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var user = HttpContext.Session.GetString("User");

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Dashboard kartlarý için örnek veriler
            ViewData["MonthlyEarnings"] = 40000;
            ViewData["AnnualEarnings"] = 215000;
            ViewData["TaskProgress"] = 50;
            ViewData["PendingRequests"] = 18;

            // Chart için veriler
            ViewBag.Months = new string[] { "Jan", "Feb", "Mar", "Apr" };
            ViewBag.Earnings = new int[] { 10000, 15000, 12000, 20000 };

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
