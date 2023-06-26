namespace BankManagement.Models
{
    public interface IUserRepository
    {
        public User? GetByNationalCode(string nationalCode);
    }
}
