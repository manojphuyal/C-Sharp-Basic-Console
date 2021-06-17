using System;

namespace HCT_ConsoleApp.Practice2.OOP.InheritanceExample
{
    class HierarchicalInheritanceExample0
    {
        protected int a = 20;
    }
    class HierarchicalInheritanceExampleA1 : HierarchicalInheritanceExample0
    {
        protected int b = 30;
        public void A1()
        {
            Console.WriteLine("a -A1 from 0= " + a);
            Console.WriteLine("b -A1 from A1= " + b);
        }
    }
    class HierarchicalInheritanceExampleB1 : HierarchicalInheritanceExample0
    {
        protected int c = 40;
        static void MainHierarchicalInheritance()
        {
            HierarchicalInheritanceExampleA1 objFn = new HierarchicalInheritanceExampleA1();
            objFn.A1();
            HierarchicalInheritanceExampleB1 obj2 = new HierarchicalInheritanceExampleB1();
            Console.WriteLine("a -B1 from 0= " + obj2.a);
            Console.WriteLine("c -B1 from B1= " + obj2.c);
            Console.ReadLine();

        }
    }
}
