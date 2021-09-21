using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.ValueTypeAndReferenceType
{
    public class BoxingExample
    {
        static public void MainBoxing()
        {
            int i = 100;
            Object iobj = i;        //boxing process
            i = 200;
            Console.WriteLine(i);
            Console.WriteLine(iobj);
            Console.ReadLine();
        }
    }
}
