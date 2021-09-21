using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.TypeofAndGetType
{
    public class Point
    {
        public int X, Y;
        public string Z="Hello";
    }
    public class TypeofAndGetTypeExample
    {
        static void MainTypeofAndGetType()
        {
            Point p = new Point();
            Console.WriteLine(p.GetType().Name);
            Console.WriteLine(typeof(Point).Name);
            Console.WriteLine(p.GetType().Name==typeof(Point).Name);
            Console.WriteLine(p.X.GetType().Name);
            Console.WriteLine(p.Y.GetType().FullName);
            Console.WriteLine(p.Z.GetType().Name);
            Console.ReadLine();
        }
    }
}
