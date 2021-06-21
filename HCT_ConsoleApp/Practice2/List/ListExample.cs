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
            List<string> cars = new List<string>();
            cars.Add("Maruti");
            cars.Add("Ford");
            cars.Add("BMW");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }

}
