using BankManagement.DataBases;


namespace BankManagement.Models;

public class UserRepository : IUserRepository
{
    public User? Get(string NationalCode, string PhoneNumber)
    {
        return DataBase.users.FirstOrDefault(u => u.NationalCode == NationalCode &&
                                                u.PhoneNumber == PhoneNumber);
    }
}
