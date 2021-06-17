using System;

namespace HCT_ConsoleApp.Practice2.OOP.InheritanceExample
{
    //this example shows single inheritance and protected members
    class SingleInheritanceExample1
    {
        protected int val = 30;
        protected int sum(string a)
        {
            int i = int.Parse(a);
            return val + i;
        }
    }
    class SingleInheritanceExample2 : SingleInheritanceExample1
    {
        static void MainSingleInheritance()
        {
            var data = Console.ReadLine();
            SingleInheritanceExample2 obj = new SingleInheritanceExample2();
            int z = obj.sum(data);
            Console.WriteLine("Value : " + obj.val);
            Console.WriteLine("Input Value :" + data);
            Console.WriteLine("Sum : " + z);
            Console.ReadLine();
        }
    }
}
