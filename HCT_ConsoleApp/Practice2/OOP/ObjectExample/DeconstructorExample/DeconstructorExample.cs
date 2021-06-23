using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.OOP.ObjectExample.DeconstructorExample
{
    //constructor/object allocate memory and deconstructor de-allocate memory
    //to see result by holding without using Console.ReadLine() you need to press ctrl + F5
    //syntax:
    //~ConstructorName()
    //{
    //    //code;
    //}

    public class DeconstructorExample
    {
        public string carModel;
        public int carYear;
        public DeconstructorExample(string carModel, int carYear)
        {
            this.carModel = carModel;
            this.carYear = carYear;
        }
        public string GetModel()
        {
            return this.carModel;
        }
        public int GetYear()
        {
            return this.carYear;
        }
        ~DeconstructorExample()
        {
            Console.WriteLine("Deconstructor has been invoked!");
        }

    }
    public class ProgramDeconstructorExample
    {
        public static void MainParameterizeConstructor()
        {
            DeconstructorExample carObj = new DeconstructorExample("Fararoi", 2019);
            Console.WriteLine(carObj.GetModel());
            Console.WriteLine(carObj.GetYear());
        }
    }

}
