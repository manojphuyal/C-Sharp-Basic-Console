using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Statement
{
    public class SwitchStatementExample
    {
        static void MainSwitchStatement()
        {
            int a = 5;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Case 2");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Case 5");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("No result found.");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
