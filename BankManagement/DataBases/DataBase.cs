using BankManagement.Models;

namespace BankManagement.DataBases
{
    public class DataBase
    {
        public static List<User> users = new List<User>()
        {
            new User(){Name="ali", Family="hassani", NationalCode="123456781",
                       PhoneNumber="09111234567"},
            new User(){Name="elham", Family="ebrahimi", NationalCode="123456782",
                       PhoneNumber="09121234567"},
            new User(){Name="abbas", Family="karimi", NationalCode="123456783",
                       PhoneNumber="09131234567"}
        };
    }
}
