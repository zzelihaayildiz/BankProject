using System.Security.Principal;

namespace BankProject.Models
{
    public class Customer
    {
        public int Id { get; set; }  // Müşteri ID
        public string FullName { get; set; }  // Müşteri Ad Soyad
        public string Email { get; set; }  // Müşteri E-posta
        public List<Account> Accounts { get; set; } = new List<Account>(); // Hesapları
    }
}

