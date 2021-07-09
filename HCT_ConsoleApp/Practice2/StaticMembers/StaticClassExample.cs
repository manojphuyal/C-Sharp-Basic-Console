using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.StaticMembers
{
    public static class StaticClassExample
    {
        public static int a = 10;
        public static int Sum()
        {
            return a;
        }
    }

    class ProgramStatic
    {
        static int b = 20;
        public static int Display()
        {
            return b;
        }

        public static void MainStatic()
        {
            int c = StaticClassExample.Sum();
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
