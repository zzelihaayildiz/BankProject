using Microsoft.AspNetCore.Mvc;
using BankProject.Models;
using System.Collections.Generic;

namespace BankProject.Controllers
{
    public class CustomerController : Controller
    {
        // Örnek müşteri listesi
        public IActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, FullName = "Ali Veli", Email = "ali@example.com" },
                new Customer { Id = 2, FullName = "Ayşe Yılmaz", Email = "ayse@example.com" }
            };

            return View(customers);
        }
    }
}
