using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.Generics.CollectionExample
{
    public class MethodCollectionExample
    {
        public static void ShowData<T>(T[] arr)
        {
            for (int i= 0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class Program
    {
        static void MainMethod()
        {
            int[] numbers = new int[3];
            numbers[0] = 11;
            numbers[1] = 12;
            numbers[2] = 13;
            string[] Names = {"Anisa","Ram", "Sita","Salina" };
            double[] DoubleNum = {2.558,89.485 };
            MethodCollectionExample.ShowData(numbers);
            MethodCollectionExample.ShowData(Names);
            MethodCollectionExample.ShowData(DoubleNum);
            Console.ReadLine();
        }
    }
}
