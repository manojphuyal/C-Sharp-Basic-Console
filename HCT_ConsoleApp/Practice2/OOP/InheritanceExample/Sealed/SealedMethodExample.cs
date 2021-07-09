using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.OOP.InheritanceExample.Sealed
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("This is method of class A");
        }
    }
    class B : A
    {
        public sealed override void Print()
        {
            Console.WriteLine("This is method of class B");
        }
    }
    class C : B
    {
        //public override void Print() //this cannot be overide
        //{
        //    Console.WriteLine("This is method of class C");
        //}
    }
    class ProgramA
    {
        static void MainA()
        {
            C obj = new C();
            obj.Print();
            Console.ReadLine();
        }
    }
}
