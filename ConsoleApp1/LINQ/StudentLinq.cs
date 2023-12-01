using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet.LINQ
{
     class StudentLinq
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students = StudentMain.LoadStudent();

            var FilterStdId = from std in students
                              where std.Id == 1001
                              select std;
        }


       
    }


    class StudentMain
    {
        public static List<Student> LoadStudent()
        {

            List<Student> students = new List<Student>() 
            {
                new Student(){Id=1000,Name="Peter",Email="Peter@gmail.com",Address="Texas,USA"},
                 new Student(){Id=1001,Name="Mark",Email="Mark@gmail.com",Address="Munich,German"},
                  new Student(){Id=1002,Name="Matt",Email="Matt@gmail.com",Address="Lords,UK"},
                   new Student(){Id=1003,Name="Rithik",Email="Rithik@gmail.com",Address="Bangalore,India"}
            };

            return students;
        }

    }

    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
            public string Email { get; set; }
        public string Address { get; set; }
    }
}
