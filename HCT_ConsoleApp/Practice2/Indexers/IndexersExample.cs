using System;

namespace HCT_ConsoleApp.Practice2.Indexers
{
    class IndexersExample
    {
        private string[] a = new string[3];
        public     string this[int i]
        {
            get
            {
                return a[i];
            }
            set
            {
                a[i] = value;
            }
        }
        static void MainIndexersExample()
        {
            IndexersExample obj = new IndexersExample();
            obj[0] = "Anisha";
            obj[1] = "Mukunda";
            obj[2] = "Susmita";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(obj[i]);
            }
            Console.ReadLine();
        }
    }
}
