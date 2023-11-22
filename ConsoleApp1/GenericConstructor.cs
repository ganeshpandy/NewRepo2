using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet
{
     class GenericConstructor
    {
        //static void Main(string[] args)
        //{
        //    //StudentConstructor<string> studentConstructor = new StudentConstructor<string>("TestData");

        //    //StudentConstructor<int> studentConstructornew = new StudentConstructor<int>(100);


        //    //StudentConstructor<DateTime> studentConstructorDt = new StudentConstructor<DateTime>(DateTime.Now);

        //    //Employee<string> employee = new Employee<string>();
        //    //employee.DisplayEmployee("Generic String Type");

        //    //Employee<int> employeeInt = new Employee<int>();
        //    //employeeInt.DisplayEmployee(13123);


        //}

    }


    //public class StudentConstructor
    //{
    //    // define a variable of type T 
    //    public string dataLocal;

    //    // define a constructor of the Student class 
    //    public StudentConstructor(string data)
    //    {
    //        this.dataLocal = data;
    //        Console.WriteLine("Data passed: " + this.dataLocal);
    //    }
    //}



    public class StudentConstructor<T>
    {
        // define a variable of type T 
        public T dataLocal;

        // define a constructor of the Student class 
        public StudentConstructor(T data)
        {
            this.dataLocal = data;
            Console.WriteLine("Data passed: " + this.dataLocal);
        }
    }

    //public class Employee<T>
    //{
        
    //    public void DisplayEmployee(T data)
    //    {
            
    //        Console.WriteLine("Data passed: " + data);
    //    }
    //}


}
