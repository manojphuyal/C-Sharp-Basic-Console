using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.ThisReferenceExample
{
    public class ThisExample
    {
        public int a;
        public int b;
        public void Demo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    public class Program
    {
        static void MainProgram()
        {
            ThisExample obj = new ThisExample();
            obj.Demo(20, 30);
            Console.WriteLine("From Demo Fn,a : " + obj.a);
            Console.WriteLine("From Demo Fn,b : " + obj.b);
            Console.ReadLine();

        }
    }
}
