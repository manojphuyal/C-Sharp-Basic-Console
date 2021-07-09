using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.TernaryConditionExample
{
    public class TernaryConditionExample
    {
        //syntax
        //BooleanExpression/Condition ? TrueFirstStatement : FalseSecondStatement
        static void MainTernaryCondition()
        {
            var data = Console.ReadLine();
            int i = int.Parse(data);

            //if (i < 100 && i > 0)
            //{
            //    Console.WriteLine("The value is greater than 0 and less than 100.");
            //}
            //else if(i<200 && i>100)
            //{
            //    Console.WriteLine("This value is greater than 100 and lessthan than 200.");
            //}else
            //{
            //    Console.WriteLine("This value is less than 1 or greater than 199.");

            //}

            string a = (i < 100 && i > 0) ? "The value is greater than 0 and less than 100." : "This value is less than 1 or greater than 99.";
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
