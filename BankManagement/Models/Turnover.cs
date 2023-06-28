using System.Security.Principal;

namespace BankManagement.Models
{
    public class Turnover
    {
        public int Id { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public DateTime  TransactionDate { get; set; }
        public string? Description { get; set; }
        public decimal?  Balance { get; set; }
    }
}
