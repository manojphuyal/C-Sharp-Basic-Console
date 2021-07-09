using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.OOP.PolymorphismExample.StaticPolymorphism.OperatorOverloading
{
    public class OperatorOverloadingExample
    {
        public string a;
        public int b;

        public static OperatorOverloadingExample operator +(OperatorOverloadingExample obj1, OperatorOverloadingExample obj2)
        {
            OperatorOverloadingExample obj3 = new OperatorOverloadingExample();
            obj3.a = obj1.a + obj2.a;
            obj3.b = obj1.b + obj2.b;
            return obj3;
        }
    }
    public class Program
    {
        static void MainProgram()
        {
            OperatorOverloadingExample obj1 = new OperatorOverloadingExample();
            obj1.a = "Ram";
            obj1.b = 50;
            OperatorOverloadingExample obj2 = new OperatorOverloadingExample();
            obj2.a = "Paudel";
            obj2.b = 50;
            OperatorOverloadingExample obj3 = new OperatorOverloadingExample();
            obj3 = obj1 + obj2;
            Console.WriteLine(obj3.a);
            Console.WriteLine(obj3.b);
            Console.ReadLine();
        }
    }
}
