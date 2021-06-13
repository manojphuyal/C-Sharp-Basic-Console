using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice1
{
    public class DataTypeConversion
    {
        private void DataConvert()
        {
            int a = 20;
            double d = 1223.254;
            string s = "12132131";
            double b = a;                   //Implicit data conversion
            int k = (int)d;                 //Explecit data conversion 1
            int i = Convert.ToInt32(s);     //Non-Compatible Data Conversion 1
            int j = int.Parse(s);           //Non-Compatible Data Conversion 2


            Console.WriteLine(b);
            Console.WriteLine(k);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
