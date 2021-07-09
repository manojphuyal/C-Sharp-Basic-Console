using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCT_ConsoleApp.Practice2.AbstractClassMember
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string PhoneNo;
        public abstract void PrintDetails();

    }
    public class Student : Person
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Age: " + Age);
            Console.WriteLine("Student PhoneNo: " + PhoneNo);
            Console.WriteLine("Student RollNo: " + RollNo);
            Console.WriteLine("Student Fees: " + Fees);
        }
    }
    public class Teacher : Person
    {
        public string Qualification;
        public int Salary;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Teacher Name: " + name);
            Console.WriteLine("Teacher Age: " + Age);
            Console.WriteLine("Teacher PhoneNo: " + PhoneNo);
            Console.WriteLine("Teacher Qualification: " + Qualification);
            Console.WriteLine("Teacher Salary: " + Salary);
        }
    }
    public class Program
        {
            static void MainAbstractClassMember()
            {
                Student std = new Student();
                std.FirstName = "Salina";
                std.LastName = "Khadki";
                std.Age = 21;
                std.PhoneNo = "9855656565465";
                std.RollNo = 20;
                std.Fees = 15000;
                std.PrintDetails();

            Console.WriteLine("--------------------------------------------------------");

            Teacher teach = new Teacher();
            teach.FirstName = "Deepak";
            teach.LastName = "Shah";
            teach.Age = 27;
            teach.PhoneNo = "98556565655";
            teach.Qualification = "Master Degree";
            teach.Salary = 50000;
            teach.PrintDetails();

            Console.ReadLine();
            }
        }
}
