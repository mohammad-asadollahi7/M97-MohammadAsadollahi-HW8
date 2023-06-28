using BankManagement.Models;

namespace BankManagement.Services
{
    public interface IUserService
    {
        public bool CheckUser(string NationalCode, string PhoneNumber);
        User GetUser(string NationalCode);
        public void SetTurnover(string NationalCode, Turnover turnover);
    }

}