using System;

namespace HCT_ConsoleApp.Practice2.OOP.ObjectExample.ConstructorExample
{
    public class ParameterizeConstructorExample
    {
        string carModel;
        string carYear;
        ParameterizeConstructorExample(string a, string b)
        {
            carModel = a;
            carYear = b;
            Console.WriteLine("From Up Userdefined");
        }
        public static void MainParameterizeConstructor()
        {

            ParameterizeConstructorExample carObj = new ParameterizeConstructorExample("Fararoi", "2019");
            Console.WriteLine(carObj.carModel + " " + carObj.carYear);
            Console.ReadLine();
        }
    }
}
