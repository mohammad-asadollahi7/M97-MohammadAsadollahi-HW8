namespace BankManagement.Models
{
    public interface IUserRepository
    {
        User Get(string NationalCode, string PhoneNumber);
    }
}
