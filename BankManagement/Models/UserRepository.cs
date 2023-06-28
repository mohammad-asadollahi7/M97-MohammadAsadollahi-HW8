using BankManagement.DataBases;


namespace BankManagement.Models;

public class UserRepository : IUserRepository
{
    public User? GetByNationalCode(string nationalCode)
    {
        return DataBase.users.FirstOrDefault(u => u.NationalCode == nationalCode);
    }

    public void AddTurnover(User user, Turnover turnover)
    {
        user.turnovers?.Add(turnover);
    }
    
}
