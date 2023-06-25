namespace BankManagement.Models
{
    public interface IUserRepository
    {
        User GetUser(string NationalCode);
    }
}
