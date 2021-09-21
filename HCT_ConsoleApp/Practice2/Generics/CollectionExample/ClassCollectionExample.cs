using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Generics.CollectionExample
{

    class ClassCollectionExample<H>
    {
        H[] t = new H[5];
        int count = 0;
        public void addItem(H item)
        {
            if (count < 5)
            {
                t[count] = item;
                count++;
            }
            else
            {
                Console.WriteLine("Overflow exists");
            }
        }
        public void displayItem()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Item at index {0} is {1}", i, t[i]);
            }
        }
    }
    class GenericEx
    {
        static void MainClass()
        {
            ClassCollectionExample<int> obj = new ClassCollectionExample<int>();
            obj.addItem(10);
            obj.addItem(20);
            obj.addItem(30);
            obj.addItem(40);
            obj.addItem(50);
            //obj.addItem(60); //overflow exists
            ClassCollectionExample<string> obj1 = new ClassCollectionExample<string>();
            obj1.addItem("Ram");
            obj1.addItem("Sita");
            obj.displayItem();
            obj1.displayItem();
            Console.ReadKey();
        }
    }

}
