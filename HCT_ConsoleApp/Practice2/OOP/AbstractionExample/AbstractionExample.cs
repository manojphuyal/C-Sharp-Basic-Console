using System;

namespace HCT_ConsoleApp.Practice2.OOP.AbstractionExample
{
   public class AbstractionExample
    {
        //Abstraction is the concept of object-oriented programming
        //that "shows" only essential attributes and "hides"
        //unnecessary information. The main purpose of
        //abstraction is hiding the unnecessary details
        //from the users. Abstraction is selecting data
        //from a larger pool to show only relevant details
        //of the object to the user. It helps in reducing
        //programming complexity and efforts. It is one of
        //the most important concepts of OOPs.

        private int myNum1, myNum2, myNum3;
        public void sum(int inNum1, int inNum2)
        {
            myNum1 = inNum1;
            myNum2 = inNum2;
            myNum3 = myNum1 + myNum2;
            Console.WriteLine("Sum of the two number is : "+ myNum3);
            Console.ReadLine();
        }
        static void MainAbstraction()
        {
            AbstractionExample obj = new AbstractionExample();
            obj.sum(20,50);
        }

    }
}
