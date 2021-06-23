
//using Admistration_Console.AdminClass;
//using System;

//namespace HCT_ConsoleApp
//{
//    class Program
//    {
//        AdminClass obj = new AdminClass();
//        void Add()
//        {
//            obj.result = obj.val1 + obj.val2;
//            Console.WriteLine(obj.result);
//            Console.ReadLine();
//        }
//        void Sub()
//        {
//            obj.result = obj.val1 - obj.val2;
//            Console.WriteLine(obj.result);
//            Console.ReadLine();
//        }

//        static void Main()
//        {
//            Program calc = new Program();
//            calc.obj.val1 = 20;
//            calc.obj.val2 = 10;
//            calc.Add();
//            calc.Sub();
//        }
//    }
//}

////[ClassName] [objectName] [=] [new] [ClassName()]

////Function/Method Syntax
////[AccessModifier] [ReturnType] [FunctionName] [parenthesis--(arguments)]




using System;


namespace HCT_ConsoleApp.s
{
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
        public static void Main()
        {
            DeconstructorExample carObj = new DeconstructorExample("Fararoi", 2019);
            Console.WriteLine(carObj.GetModel());
            Console.WriteLine(carObj.GetYear());

        }
    }
}
