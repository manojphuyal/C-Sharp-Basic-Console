using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Unit4.DelegateExample
{
    //A delegate is like a having general method name that point various
    //methods at different times and invoke the required method at run-time.
    //syntax:
    //[access modifier] delegate [return_type] [delegate_name] ([parameters]);
    public delegate void Calculate(int m, int n);
    public class DelegateExample
    {
        public void Addition(int a, int b)
        {
            b += a;
            //b =b + a;
            Console.WriteLine("The Sum of two no is : " + b);
        }
        public void Subtraction(int a, int b)
        {
            b -= a;
            //b =b - a;
            Console.WriteLine("The Sub of two no is : " + b);
        }
        public void Multipication(int a, int b)
        {
            b *= a;
            //b =b * a;
            Console.WriteLine("The Mul of two no is : " + b);
        }
        public void Division(int a, int b)
        {
            b /= a;
            //b =b / a;
            Console.WriteLine("The Div of two no is : " + b);
        }
        static void MainDelegate(string[] args)
        {
            //1st creating object of class to access non static methods in static member
            DelegateExample classObj = new DelegateExample();
            //creating object1 of delegate
            Calculate delObj1 = new Calculate(classObj.Addition);
            delObj1(20, 30);
            // creating object2 of delegate
            Calculate delObj2 = new Calculate(classObj.Subtraction);
            delObj2(30, 10);
            // creating object3 of delegate
            Calculate delObj3 = new Calculate(classObj.Multipication);
            delObj3(20, 30);
            //creating object4 of delegate
            Calculate delObj4 = new Calculate(classObj.Division);
            delObj4(5, 45);
            Console.ReadLine();
        }
    }
}
