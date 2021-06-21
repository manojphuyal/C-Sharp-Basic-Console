using System;


namespace HCT_ConsoleApp.Practice2.Array
{
    public class ArrayExample
    {
        // datatype[] name_of_array;
        //string[] studentName;
        // datatype[] name_of_array = new datatype[size]  {val1,val2}

        string[] studentNames = new string[4] { "Salina", "Mukanda", "Anisha", "Karta" };
        static void MainArray()
        {
            ArrayExample obj = new ArrayExample();

            //for (int i=0;i<= obj.studentName.Length; i++)
            //{
            //    Console.WriteLine(obj.studentName[i]);
            //}

            foreach (string studentName in obj.studentNames)
            {
                Console.WriteLine(studentName);
            }
            Console.ReadLine();

            //foreach(datatype Your_foreach_Name in ArrayName)
            //{  ........  }
        }
    }
}
