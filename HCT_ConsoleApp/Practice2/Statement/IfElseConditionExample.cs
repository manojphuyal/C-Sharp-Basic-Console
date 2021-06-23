using System;


namespace HCT_ConsoleApp.Practice2.Statement
{
    public class IfElseConditionExample
    {
        static void MainIfElseCondition()
        {
            string a = Console.ReadLine();
            if (a == "10")
            {
                Console.WriteLine("This is from if statememt {0}", a);
                Console.ReadLine();
            }
            else if (a == "20")
            {
                Console.WriteLine("This is from 1st else if statememt {0}", a);
                Console.ReadLine();
            }
            else if (a == "30")
            {
                Console.WriteLine("This is from 2nd if statememt {0}", a);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This is from without if statememt {0}", a);
                Console.ReadLine();
            }

        }
    }
}
