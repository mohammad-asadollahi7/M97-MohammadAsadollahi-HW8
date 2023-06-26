namespace BankManagement.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalCode { get; set; }
        public List<Turnover>? turnovers { get; set; }
    }
}
