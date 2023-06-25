using BankManagement.Models;

namespace BankManagement.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool IsValid(string NationalCode, string PhoneNumber)
        {
            var user = _userRepository.Get(NationalCode, PhoneNumber);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
