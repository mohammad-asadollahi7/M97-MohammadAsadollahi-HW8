using System.Security.Principal;

namespace BankManagement.Models
{
    public class Turnover
    {
        public int Id { get; set; }
        public string NationalCode { get; set; }
        public long? Debit { get; set; }
        public long? Credit { get; set; }
        public DateTime  TransactionDate { get; set; }
        public string Description { get; set; }
        public long  Balance { get; set; }
    }
}
