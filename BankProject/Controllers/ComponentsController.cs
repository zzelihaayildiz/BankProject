using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Cards()
        {
            return View();
        }
    }
}
