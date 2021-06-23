using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.OOP.ObjectExample.ConstructorExample
{
    class DefaultConstructorExample
    {
        public void Demo()
        {

            Console.WriteLine("Example of Default Constructor");
        }
    }
    class ProgramDefaultConstructor
    {
        static void MainDefaultConstructor()
        {
            //the object is created is default constructor
            DefaultConstructorExample obj = new DefaultConstructorExample();
            obj.Demo();
            Console.ReadLine();
        }
    }
}




