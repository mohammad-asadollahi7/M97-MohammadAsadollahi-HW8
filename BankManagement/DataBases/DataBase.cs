using BankManagement.Models;

namespace BankManagement.DataBases;

public static class DataBase
{
    public static List<User> users = new List<User>()
    {
        new User()
        {
            Name="علی",
            Family="حسنی",
            NationalCode="11",
            PhoneNumber="11",
            turnovers = new List<Turnover>()
            {
                new Turnover()
                {
                    Id=1,
                    Debit=1000000,
                    TransactionDate=Convert.ToDateTime("1389-02-03"),
                    Description="خرید از کارت خوان",
                    Balance=12000000
                },


                 new Turnover()
                {
                    Id=2,
                    Credit=2000000,
                    TransactionDate=Convert.ToDateTime("1389-05-06"),
                    Description="نقدی",
                    Balance=14000000
                },

                 new Turnover()
                 {
                        Id=3,
                        Credit=1500000,
                        TransactionDate=Convert.ToDateTime("1389-06-09"),
                        Description="چک نقدی",
                        Balance=15500000
                 }
            }
        },


        new User()
        {
            Name="الهام",
            Family="ابراهیمی",
            NationalCode="1234567892",
            PhoneNumber="09121234567"
        },
        new User()
        {
            Name="عباس",
            Family="کریمی",
            NationalCode="1234567893",
            PhoneNumber="09131234567"
        }
    };
}
