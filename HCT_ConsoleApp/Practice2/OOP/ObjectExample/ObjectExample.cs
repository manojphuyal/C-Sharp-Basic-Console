using System;

namespace HCT_ConsoleApp.Practice2.OOP.ObjectExample
{
    public class ObjectExample
    {
        public int sum(int inNum1, int inNum2)
        {
            return inNum1 + inNum2;
        }
        static void MainAbstraction()
        {
            ObjectExample obj = new ObjectExample();
            int result= obj.sum(20, 50);
            Console.WriteLine("Sum of the two number is : " + result);
            Console.ReadLine();
        }
    }
}
