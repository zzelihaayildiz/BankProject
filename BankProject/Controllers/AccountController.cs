using Microsoft.AspNetCore.Mvc;
using BankProject.Models;
using System.Collections.Generic;

namespace BankProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            var accounts = new List<Account>
            {
                new Account { Id = 1, AccountNumber = "TR1234567890", Balance = 1000, CustomerId = 1 },
                new Account { Id = 2, AccountNumber = "TR0987654321", Balance = 2500, CustomerId = 2 }
            };
            return View(accounts);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@test.com" && password == "123")
            {
                HttpContext.Session.SetString("User", email);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Hatalı giriş";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}
