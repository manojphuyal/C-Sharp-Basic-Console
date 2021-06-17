using System;

namespace HCT_ConsoleApp.Practice2.OOP.InheritanceExample
{
    class MultiLevelInheritanceExample
    {
        protected int a = 20;
    }
    class MultiLevelInheritanceExample1 : MultiLevelInheritanceExample
    {
        protected int b = 30;
    }
    class MultiLevelInheritanceExample2 : MultiLevelInheritanceExample1
    {
        private int c = 40;
        static void MainMultiLevelInheritance()
        {
            MultiLevelInheritanceExample2 obj = new MultiLevelInheritanceExample2();
            Console.WriteLine("a :" + obj.a);
            Console.WriteLine("b :" + obj.b);
            Console.WriteLine("c :" + obj.c);
            Console.ReadLine();
        }
    }
}
