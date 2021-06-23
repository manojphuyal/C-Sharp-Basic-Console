using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Statement
{
    //initialization
    //while(condition)
    //{
    // //code
    //increment/decrement
    //}

     public class WhileLoopExample
    {
        static void MainWhileLoop()
        {
            int i = 0;
            while (i<10)
            {
                Console.WriteLine("i : "+ i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
