using System;

namespace HCT_ConsoleApp.Practice2.OOP.PolymorphismExample
{
    //Polymorphism:1. Overloading
    public class OverloadingExample
    {
       public double result;
       public void Sum()
        {
            result = 0;
        }
        public void Sum(int a)
        {
            result = a;
        }
        public void Sum(int a,int b)
        {
            result = a + b;
        }
        public void Sum(int a, double b)
        {
            result = a + b;
        }
    }
    public class ProgramGetAndSetProperties
    {
        static void MainOverloading()
        {
            OverloadingExample obj = new OverloadingExample();
            obj.Sum();
            obj.Sum(5);
            obj.Sum(5, 7);
            obj.Sum(5, 25.6);
            Console.WriteLine(obj.result);
            Console.ReadLine();
        }
    }
}
