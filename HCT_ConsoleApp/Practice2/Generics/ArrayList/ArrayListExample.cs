using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Generics.ArrayList
{
    public class ArrayListExample
    {
        static void MainArrayList()
        {
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(1.25+526);
            arrayList.Add("hello 2");
            arrayList.Add("hello 3");
            arrayList.Add("hello 4");
            arrayList.Remove("hello 4");
            //arrayList.RemoveAt(0);
            arrayList.Insert(0,"Hello insert");
            //arrayList.Sort();
            //arrayList.Clear();
            foreach (var a in arrayList)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();

        }
    }
}
