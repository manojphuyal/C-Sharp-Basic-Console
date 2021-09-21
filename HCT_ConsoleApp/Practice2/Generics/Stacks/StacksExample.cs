using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Stacks
{
    class StacksExample
    {
    static void MainStacks(string[] args)
    {
        Stack<string> stack1 = new Stack<string>();
        stack1.Push("************");
        stack1.Push("MCA");
        stack1.Push("MBA");
        stack1.Push("BCA");
        stack1.Push("BBA");
        stack1.Push("***********");
        stack1.Push("**Courses**");
        stack1.Push("***********");
        Console.WriteLine("The elements in the stack1 are as:");
        foreach (string s in stack1)
        {
            Console.WriteLine(s);
        }
        //For remove/or pop the element pop() method is used
        stack1.Pop();
        stack1.Pop();
        stack1.Pop();
        Console.WriteLine("After removal/or pop the element the stack is as:");
        //the element that inserted in last is remove firstly.
        foreach (string s in stack1)
        {
            Console.WriteLine(s);
        }
            Console.ReadLine();
    }
    }

}
