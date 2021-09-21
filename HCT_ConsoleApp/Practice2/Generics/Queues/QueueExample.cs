using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Queues
{
    class QueueExample
    {
        static void MainQueue(string[] args)
        {
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("MCA");
            queue1.Enqueue("MBA");
            queue1.Enqueue("BCA");
            queue1.Enqueue("BBA");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            queue1.Dequeue(); //Removes the first element that enter in the queue here the first element is MCA
            queue1.Dequeue(); //Removes MBA
            Console.WriteLine("After removal the elements in the queue are: ");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
    }
}

}
