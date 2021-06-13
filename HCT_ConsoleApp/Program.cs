using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp
{
    class Program
    {
         int val1;
         int val2;
         int result;
         void Add()
        {
            result = val1 + val2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
         void Sub()
        {
            result = val1 - val2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Main()
        {
            Program calc = new Program();
            calc.val1 = 20;
            calc.val2 = 10;
            calc.Add();
            calc.Sub();

        }
    }
}


//[ClassName] [objectName] [=] [new] [ClassName()]

//Function/Method Syntax
//[AccessModifier] [ReturnType] [FunctionName] [parenthesis--(arguments)]