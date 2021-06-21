using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Unit4
{
    //Anonymous delegate
    public delegate void Calculation(int a, int b);
    public class AnonymousExample
    {
        static void MainAnonymous()
        {

            Calculation obj = delegate (int m, int n)
            {
                m = m + n;
                Console.WriteLine("The sum of two no is : " + m);
            };
            obj(20, 50);
            Console.ReadLine();
        }
    }
}
