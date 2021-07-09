using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.PostfixPrefix
{
    public class PostfixPrefixExample
    {
        static void MainPostfixPrefix()
        {
            //Postfix
            int a = 8;
            int b = 15;
            b = a++;   //a++ ===>b= a=a+1;
            //--------->

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(" ");

            //Prefix
            int x = 5;
            int y = 80;
            y = ++x;
            //<--------------
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
