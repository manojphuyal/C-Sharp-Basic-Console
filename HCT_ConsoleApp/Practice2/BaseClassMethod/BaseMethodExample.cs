using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.BaseClassMethod
{
    class BaseMethodExample
    {
            public virtual void BaseMethod()
            {
                Console.WriteLine("I am inside base class");
            }
        }
        class Derived : BaseMethodExample
    {
            public override void BaseMethod()
            {
                base.BaseMethod();          ////-------------base in Method
                Console.WriteLine("I am inside derived class");
            }
        }
        class ProgramBaseMethod
    {
            static void MainProgramBaseMethod()
            {
                Derived obj = new Derived(); 
                obj.BaseMethod(); 
                Console.ReadKey();
            }
        }

    }

