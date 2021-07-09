using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Properties
{
    class PropertiesGetSet
    {
            public int a { get; set; }
            public int b { get; set; }
            public int sum
            {
                get
                {
                    return a + b;
                }
            }

        }

        class ProgramPropertiesGetSet
    {
            static void MainPropertiesGetSet()
            {
            PropertiesGetSet obj = new PropertiesGetSet();
                obj.a = 10;
                obj.b = 5;
                Console.WriteLine("Sum of " + obj.a + " and " + obj.b + " = " + obj.sum);
                Console.ReadKey();
            }
        }
    }

