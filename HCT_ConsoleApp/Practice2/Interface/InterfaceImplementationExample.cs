using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Interface
{
    public class InterfaceImplementationExample : InterfaceExample
    {
        int l, b;
        public void GetData(int i, int j)
        {
            this.l = i;
            this.b = j;
        }
        public int CalculateArea()
        {
            int area = l * b;
            return area;
        }

        public int CalculatePerimeter()
        {
            int peri = 2 * (l+b);
            return peri;
        }
    }
    class Program
    {
        static void MainInterfaceImplementation()
        {
            InterfaceImplementationExample obj = new InterfaceImplementationExample();
            obj.GetData(10,5);
            Console.WriteLine("Area "+obj.CalculateArea());
            Console.WriteLine("Parimeter "+obj.CalculatePerimeter());
            Console.ReadLine();
        }
    }
}
