using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet
{
   
    public class StaticExample1
    {
        //static void Main(string[] args)
        //{
        //    var result = Calculator.Sum(10, 25); // calling static method
        //    Console.WriteLine(result);
        //    Calculator.Store(result);

        //    var calcType = Calculator.Type; // accessing static variable
        //    Calculator.Type = "Scientific"; // assign value to static variable

        //    Console.WriteLine(Calculator.Type);
        //}
    }
    
    
    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }

   



}
