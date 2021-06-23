using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Statement
{
    public class DoWhileLoopExample
    {
        //initialization
        //do
        //{
        // //codes
        //increment/decrement
        //}
        //while(condition)

        static void MainDoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine("i : " + i);
                i++;
            }
            while (i <= 5);
            Console.ReadLine();
        }


    }
}
