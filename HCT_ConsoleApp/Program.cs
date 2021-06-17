
using Admistration_Console.AdminClass;
using HCT_ConsoleApp.Practice1;
using System;

namespace HCT_ConsoleApp
{
    class Program
    {
        AdminClass obj = new AdminClass();
        void Add()
        {
            obj.result = obj.val1 + obj.val2;
            Console.WriteLine(obj.result);
            Console.ReadLine();
        }
        void Sub()
        {
            obj.result = obj.val1 - obj.val2;
            Console.WriteLine(obj.result);
            Console.ReadLine();
        }

        static void Main()
        {
            Program calc = new Program();
            calc.obj.val1 = 20;
            calc.obj.val2 = 10;
            calc.Add();
            calc.Sub();
        }
    }
}

//[ClassName] [objectName] [=] [new] [ClassName()]

//Function/Method Syntax
//[AccessModifier] [ReturnType] [FunctionName] [parenthesis--(arguments)]

