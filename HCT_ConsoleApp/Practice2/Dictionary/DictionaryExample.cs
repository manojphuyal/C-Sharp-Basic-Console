using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Dictionary
{
    public class DictionaryExample
    {
        static void MainDictionary(string[] args)
        {
            //define Dictionary collection
            Dictionary<string, string> dObj = new Dictionary<string,string>();

            //add elements to Dictionary
            dObj.Add("percentage", "a rate, number, or amount in each hundred.");
            dObj.Add("image", "a representation of the external form of a person or thing in art.");
            dObj.Add("data", "facts and statistics collected together for reference or analysis.");

            //print data
            //for (int i = 1; i <= dObj.Count; i++)
            //{
            //    Console.WriteLine(dObj[i]);
            //}
            foreach (var data in dObj)
            {
                Console.WriteLine(data);
            }

            Console.ReadKey();
        }
    }

}
