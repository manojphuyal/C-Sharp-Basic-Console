using System;

namespace HCT_ConsoleApp.Practice2.OOP.EncaptulationExample
{
    //Encaptulation Example With Set And Get Properties (C#-Properties)
    public class AccountGetAndSetProperties
    {
        int accountBalance = 1000;
        public int Balance
        {
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Cannot pass negative value");
                }
                else
                {
                    accountBalance = value;
                }
            }
            get
            {
                return accountBalance;
            }
        }
    }
    public class ProgramGetAndSetProperties
    {
        static void MainAccount()
        {
            AccountGetAndSetProperties accountObj = new AccountGetAndSetProperties();
            accountObj.Balance=99;
            Console.WriteLine("Your Account balance is: " + accountObj.Balance);
            Console.ReadLine();
        }
    }
}
