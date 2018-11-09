using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Day2_oop3_properties
{
    class Student
    {
        private int StudentId;
        private string StudentName;
        private int StudentMarks;

    public int PStudentMarks
        {
            get
            {
                return this.StudentMarks;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    this.StudentMarks = value;
                }
                else
                {
                    this.StudentMarks = 0;
                }
            }
        }
        //read only property
        public int PStudentId
        {
            get
            {
                return this.StudentId;
            }
        }
        //read only property
        public string PStudentName
        {
            get
            {
                return this.StudentName;
            }
        }

        private static int count = 1000;

        public Student(string StudentName,int StudentMarks)
        {
            Student.count++;
            this.StudentId = Student.count;
            this.StudentName = StudentName;
            this.StudentMarks = StudentMarks;
            Console.WriteLine("object const");
        }
        static Student()
        {
            Student.count = 1000;
            Console.WriteLine("static const");
        }
    }
}
