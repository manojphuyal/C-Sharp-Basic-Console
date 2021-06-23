using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.ThisReferenceExample
{
    public class ThisReferenceExample
    {
        int x = 34;
        int y;
        public void input(int x, int y)
        {
            Console.WriteLine("From input function parameter: x= " + x);
            Console.WriteLine("From outside and inside ThisReferenceExample class: x= " + this.x);
            this.y = y;
        }
        public void output()
        {
            Console.WriteLine("From output function x= "+x);
            Console.WriteLine("From output function y= " + y);
        }
    }
    public class ProgramThisReferenceExample
    {
        public static void MainThisReferenceExample()
        {
            ThisReferenceExample obj = new ThisReferenceExample();
            obj.input(2,5);
            obj.output();
            Console.ReadLine();
        }
    }
}
