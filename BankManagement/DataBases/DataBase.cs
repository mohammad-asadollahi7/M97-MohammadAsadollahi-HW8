using BankManagement.Models;

namespace BankManagement.DataBases;

public static class DataBase
{
    public static List<User> users = new List<User>()
    {
        new User(){Name="ali", Family="hassani", NationalCode="1234567891",
                   PhoneNumber="09111234567"},
        new User(){Name="elham", Family="ebrahimi", NationalCode="1234567892",
                   PhoneNumber="09121234567"},
        new User(){Name="abbas", Family="karimi", NationalCode="1234567893",
                   PhoneNumber="09131234567"}
    };
}
