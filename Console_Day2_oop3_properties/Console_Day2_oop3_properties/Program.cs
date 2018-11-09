using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Day2_oop3_properties
{
    class Program
    {
        static void Main(string[] args)
        {
           //onsole.WriteLine("enter stud id:");
           //nt Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter stud name");
            string Name = Console.ReadLine();
            Console.WriteLine("enter stud Marks:");
            int Marks = Convert.ToInt32(Console.ReadLine());

            Student obj = new Student(Name,Marks);
            int Sid = obj.PStudentId;
            string Sname = obj.PStudentName;

            Student s1 = new Student("ABC", 80);
            Console.WriteLine(s1.PStudentId);

            Console.WriteLine(Sid + " " + Sname + " " + Marks);

            obj.PStudentMarks = 1020;
            Console.WriteLine(obj.PStudentMarks);

            obj.PStudentMarks = 35;
            Console.WriteLine(obj.PStudentMarks);



            Console.ReadLine();



        }
    }
}
