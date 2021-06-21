using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Unit4.DelegateExample.SingleCastDelegateExample
{
    //Single cast Delegate is type having 1 deligate function calling only 1 function at a time
    public delegate void Calculate(int m, int n);
    public class SingleCastDelegateExample
    {
            public void Addition(int a, int b)
            {
                b =b + a;
                Console.WriteLine("The Sum of two no is : " + b);
            }
            static void MainDelegate(string[] args)
            {
                //1st creating object of class to access non static methods in static member
                SingleCastDelegateExample classObj = new SingleCastDelegateExample();
                //creating object1 of delegate
                Calculate delObj1 = new Calculate(classObj.Addition);
                delObj1(20, 30);
                Console.ReadLine();
        }
    }
}
