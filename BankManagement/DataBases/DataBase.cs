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

    public static List<Turnover> turnovers = new List<Turnover>()
    {
        new Turnover()
        {
            Id=1,
            NationalCode="1234567891",
            Debit=1000000,
            TransactionDate=Convert.ToDateTime("1389-02-03"),
            Description="خرید از کارت خوان",
            Balance=12000000
        },

        new Turnover()
        {
            Id=2,
            NationalCode="1234567891",
            Credit=2000000,
            TransactionDate=Convert.ToDateTime("1389-05-06"),
            Description="نقدی",
            Balance=14000000
        },

        new Turnover()
        {
            Id=1,
            NationalCode="1234567891",
            Credit=1500000,
            TransactionDate=Convert.ToDateTime("1389-03-09"),
            Description="چک نقدی",
            Balance=15500000
        }
    };
}
