using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Struct
{
    struct Coordinate
    {
        public int x;
        public int y;

    }
    public class StructExample
    {
        static void MainCoordinate()
        {
            Coordinate point = new Coordinate();
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.ReadLine();
        }
    }
}
