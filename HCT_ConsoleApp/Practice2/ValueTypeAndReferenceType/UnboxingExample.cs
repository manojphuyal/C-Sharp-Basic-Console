using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.ValueTypeAndReferenceType
{
    class UnboxingExample
    {
        static public void MainUnboxing()
        {
            int i = 100;
            Object iobj = i;
            int j = (int)iobj;      //unboxing process
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
