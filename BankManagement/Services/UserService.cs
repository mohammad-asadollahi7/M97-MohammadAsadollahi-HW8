using BankManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace BankManagement.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;

    }
    public bool CheckUser(string NationalCode, string PhoneNumber)
    {
        var user = _userRepository.GetByNationalCode(NationalCode);
        if (user == null || user.PhoneNumber != PhoneNumber)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public User? GetUser(string NationalCode)
    {
        return _userRepository.GetByNationalCode(NationalCode);
    }

    public void SetTurnover(string NationalCode, Turnover turnover)
    {
        var user = _userRepository.GetByNationalCode(NationalCode);
        var lastId = user.turnovers.Count();
        turnover.Id = lastId + 1;
        turnover.TransactionDate = DateTime.Now;
        if (turnover.Debit == null)
        {
            turnover.Balance = user.turnovers[lastId - 1].Balance + turnover.Credit;
        }
        else
        {
            turnover.Balance = user.turnovers[lastId - 1].Balance - turnover.Debit;
        }
        _userRepository.AddTurnover(user, turnover);

    }
}
