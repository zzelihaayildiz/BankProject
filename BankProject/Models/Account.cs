namespace BankProject.Models
{
 
        public class Account
        {
            public int Id { get; set; }
            public string AccountNumber { get; set; }
            public decimal Balance { get; set; }
            public int CustomerId { get; set; }  // Hangi müşteri
            public Customer Customer { get; set; }  // İlişki
        }
}
