namespace BankManagement.Models
{
    public interface IUserRepository
    {
        public User? GetByNationalCode(string nationalCode);
        public void AddTurnover(User user, Turnover turnover);
    }
}
