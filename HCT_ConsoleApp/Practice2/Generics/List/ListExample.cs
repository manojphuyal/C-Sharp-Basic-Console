using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.List
{
    public class ListExample
    {
        static void MainList()
        {
            // List<datatype> nameOfList = new List<datatype>();
            //syntax
            List<string> cars = new List<string>();
            cars.Add("Maruti");
            cars.Add("Ford");
            cars.Add("BMW");
            cars.Add("Tyota");
            cars.Add("Tata");
            cars.RemoveAt(3);
            cars.Remove("Ford");
            cars.Insert(0,"Fordasdsad");
            //cars.Clear();
            Console.WriteLine(cars.Count());
            cars.Sort();

            foreach (string car in cars)
            {
                Console.WriteLine(car); 
            }
            
            Console.ReadLine();
        }
    }

}
