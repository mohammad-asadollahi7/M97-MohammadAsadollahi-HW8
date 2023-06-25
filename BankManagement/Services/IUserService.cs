namespace BankManagement.Services
{
    public interface IUserService
    {
        public bool IsValid(string NationalCode, string PhoneNumber);
    }
}
