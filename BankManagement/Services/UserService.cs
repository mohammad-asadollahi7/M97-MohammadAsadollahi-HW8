using BankManagement.Models;

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
}
