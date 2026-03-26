using Microsoft.AspNetCore.Mvc;
using BankProject.Models;

namespace BankProject.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            var transactions = new List<Transaction>
            {
                new Transaction { Id = 1, FromAccountId = 1, ToAccountId = 2, Amount = 200, Date = DateTime.Now },
                new Transaction { Id = 2, FromAccountId = 2, ToAccountId = 1, Amount = 150, Date = DateTime.Now }
            };

            return View(transactions);
        }
    }
}
