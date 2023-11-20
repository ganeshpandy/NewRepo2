using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet
{
     class GenericsBacis
    {

        //static void Main(string[] args)
        //{

        //    StudentTest studentTest = new StudentTest();
        //    studentTest.Name = "studentTest";
        //    studentTest.Id = "ST1001";   // Can not pass Other DataTypes


        //    Student<string> student = new Student<string>();  //Object Creation Generic
        //    student.Name = "Test";
        //    student.Id = "100";

        //    Student<int> studentInt = new Student<int>();  //Object Creation Generic
        //    studentInt.Id = 10001;
        //    studentInt.Name = 20001;



        //    Student<DateTime> studenBoolObje = new Student<DateTime>();  //Object Creation Generic
        //    studenBoolObje.Id = DateTime.Now;
        //    studenBoolObje.Name = DateTime.Now; 
        //}

    }


    class StudentTest // No code Reusability - normal class
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }


    class StudentTest1 // No code Reusability - normal class
    {
        public DateTime Id { get; set; }
        public DateTime Name { get; set; }

    }

    class StudentTestInt    // No code Reusability - normal class
    {
        public int Id { get; set; }
        public int Name { get; set; }

    }


        class Student<T>   //  code Reusability - Runtime T class Change 
    {
        public T Id { get; set; }
        public T Name { get; set; }

    }
}
