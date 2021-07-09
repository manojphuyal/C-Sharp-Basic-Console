using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.BaseClassMethod
{
    class BaseClassConstructorExample
    {
            public BaseClassConstructorExample(int a, int b)
            {
                Console.WriteLine("Base Class: Value of a={0} and b={1}", a, b);
            }
        }
        class DerivedClass : BaseClassConstructorExample
    {
            public DerivedClass(int x, int y) : base(x, y)
            {

                Console.WriteLine("Derived Class: Value of x={0} and y={1}", x, y);
            }
        }
        class ProgramBaseClassConstructor
    {
            static void MainBaseClassConstructor()
            {
                new DerivedClass(10, 5);
                Console.ReadLine();
            }
        }

    }

