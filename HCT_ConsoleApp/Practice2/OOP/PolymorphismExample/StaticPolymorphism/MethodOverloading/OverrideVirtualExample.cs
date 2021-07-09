using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.OOP.PolymorphismExample.StaticPolymorphism.MethodOverloading
{
    public class Account
    {
        public virtual int Balance()
        {
            return 10;
        }
    }

    public class Amount : Account
    {
        public override  int Balance()
        {
            return 500;
        }
    }

    class Test
    {
        static void MainAmount()
        {
            Amount obj = new Amount(); 
            int balance = obj.Balance();
            Console.WriteLine("Balance is: " + balance); 
            Console.ReadKey();
        }
    }

}
