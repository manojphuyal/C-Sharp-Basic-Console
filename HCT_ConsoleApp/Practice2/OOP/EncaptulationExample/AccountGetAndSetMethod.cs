using System;

namespace HCT_ConsoleApp.Practice2.OOP.EncaptulationExample
{
    //Encaptulation Example With Set And Get Method/Function

    //Encapsulation is a method of making a complex system easier
    //to handle for end users. The user need not worry about internal
    //details and complexities of the system. Encapsulation is a
    //process of wrapping the data and the code, that operate on
    //the data into a single entity. You can assume it as
    //a protective wrapper that stops random access of code
    //defined outside that wrapper.
    public class AccountGetAndSetMethod
    {
        int accountBalance = 1000;
        public void setBalance(int amount)
        {
            if (amount<0)
            {
                Console.WriteLine("Cannot pass negative value");
            }
            else
            {
                accountBalance = amount;
            }
        }
        public void getBalance()
        {
            Console.WriteLine("Your Account balance is: "+ accountBalance);
        }
    }
    public class ProgramGetAndSetMethod
    {
        static void MainAccount()
        {
            AccountGetAndSetMethod accountObj = new AccountGetAndSetMethod();
            accountObj.setBalance(99);
            accountObj.getBalance();
        }
    }
}
