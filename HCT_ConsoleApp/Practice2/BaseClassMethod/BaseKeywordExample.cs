using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.BaseClassMethod
{
        public class Animal
        {
            public string color = "white";
        }
        public class Animal2 : Animal
        {
            public string color = "red";
        }
        public class Dog : Animal2
        {
            string color = "black";
            public void showColor()
            {
                Console.WriteLine(base.color); //displays white------------base in Keyword
                Console.WriteLine(color); //displays black
            }

        }
        public class TestBase
        {
            public static void MainTestBase()
            {
                Dog d = new Dog(); 
                d.showColor();
                Console.ReadLine();
            }
        }

    }

