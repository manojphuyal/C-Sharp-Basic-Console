using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.OOP.ObjectExample.ConstructorExample
{
    class StaticConstructorExample
    {
        public static string personName;
        public static int personAge;

        public StaticConstructorExample()
        {
            Console.WriteLine("Default Constructor is called.");
        }
        static StaticConstructorExample()
        {
            personName = "Mukunda";
            personAge = 21;
            Console.WriteLine("Static constructor is called.");
        }
        public static void GetDetails()
        {
            Console.WriteLine("Person Name is : " + personName);
            Console.WriteLine("Person Name is : " + personAge);
        }
    }
    class Program
    {
        static void MainStaticConstructor()
        {
            StaticConstructorExample obj = new StaticConstructorExample();
            StaticConstructorExample obj1 = new StaticConstructorExample();
            StaticConstructorExample obj2 = new StaticConstructorExample();
            StaticConstructorExample.GetDetails();
            Console.ReadLine();
        }
    }
}
