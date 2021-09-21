using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.EnumsExample
{
   public enum Month
    {
        jan,
        feb,
        mar = 8,
        apr,
        may,
        jun,
        jul
    }
    public class EnumExample
    {

        static void MainEnums()
        {
            Console.WriteLine((int)Month.jan);
            Console.WriteLine((int)Month.feb);
            Console.WriteLine((int)Month.mar);
            Console.WriteLine((int)Month.apr);
            Console.WriteLine((int)Month.may);
            Console.WriteLine((int)Month.jun);
            Console.WriteLine((int)Month.jul);
            Console.ReadLine();
        }
    }
}
