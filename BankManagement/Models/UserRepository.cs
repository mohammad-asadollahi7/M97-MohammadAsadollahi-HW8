using BankManagement.DataBases;


namespace BankManagement.Models;

public class UserRepository : IUserRepository
{
    private readonly DataBase _db;
    public UserRepository(DataBase dataBase)
    {
        _db = dataBase;
    }
    public User GetUser(string NationalCode)
    {
        return null;
    }
}
