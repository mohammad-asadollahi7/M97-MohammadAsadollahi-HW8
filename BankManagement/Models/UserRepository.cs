using BankManagement.DataBases;


namespace BankManagement.Models;

public class UserRepository : IUserRepository
{
    public User? GetByNationalCode(string nationalCode)
    {
        return DataBase.users.FirstOrDefault(u => u.NationalCode == nationalCode);
    }
  
    
}
