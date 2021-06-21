using System;

namespace HCT_ConsoleApp.Practice2.Unit4.DelegateExample.MultiCastDelegateExample
{
    public delegate void Calculate(int m, int n);
    public class MultiCastDelegateExample
    {
            //delegate wrapped/point with more than 1 function at one time
            //that is known as multi cast delegate
            //we use += and -= assignment operator to use multi cast delegate
            public void Addition(int a, int b)
            {
                b =b + a;
                Console.WriteLine("The Sum of two no is : " + b);
            }
            public void Subtraction(int a, int b)
            {
                b =b - a;
                Console.WriteLine("The Sub of two no is : " + b);
            }
            public void Multipication(int a, int b)
            {
                b =b * a;
                Console.WriteLine("The Mul of two no is : " + b);
            }
            public void Division(int a, int b)
            {
                b =b / a;
                Console.WriteLine("The Div of two no is : " + b);
            }
            static void MainDelegate(string[] args)
            {
                //1st creating object of class to access non static methods in static member
                MultiCastDelegateExample classObj = new MultiCastDelegateExample();
                //creating object1 of delegate
                Calculate delObj = new Calculate(classObj.Addition);
                delObj += classObj.Subtraction;
                delObj += classObj.Multipication;
                delObj += classObj.Division;
                delObj(30,40);
                Console.ReadLine();
            }
        }
    }
