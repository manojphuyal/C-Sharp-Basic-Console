using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.DynamicBinding
{
    class DynamicBindingExample
    {


        public static dynamic Sum(dynamic d)
        {
            return d;
        }

        static void MainDynamicBinding()
        {

            dynamic b = "abc";
                    //b = 21;

            var a =50;
               // a = "51";
            Console.WriteLine(a);
            Console.WriteLine(DynamicBindingExample.Sum(60));
            Console.WriteLine(b);
            Console.ReadLine();
        }


    }
}
