using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.OOP.InheritanceExample.Sealed
{
    public sealed class SealedClassExample
    {
        public void getData()
        {
            Console.WriteLine("Method is sealed");
        }
    }
    class SealedClassExample2 //: SealedClassExample   // this is compile time error we are not able to inherite sealed class
    {
      public void getData()
        {
            Console.WriteLine("Method is Derived class/Child Class Method");
        }
    }
    class ProgramSealedClass
    {
        static void MainSealedClass()
        {
            SealedClassExample2 obj = new SealedClassExample2();
            obj.getData();
            Console.ReadLine();
        }
    }
}
