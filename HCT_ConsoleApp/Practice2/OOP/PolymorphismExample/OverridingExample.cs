using System;

namespace HCT_ConsoleApp.Practice2.OOP.PolymorphismExample
{
    class OverridingExample
    {
        public void Sum()
        {
            Console.WriteLine("This is from parent class: OverridingExample");
        }
    }
    class OverridingExample2 : OverridingExample
    {
        public void Sum()
        {
            Console.WriteLine("This is from child class: ProgramOverriding");
        }
    }
    class ProgramOverriding
    {
        static void MainOverriding()
        {
            OverridingExample2 obj = new OverridingExample2();
            obj.Sum();
            Console.ReadLine();
        }
    }
}
