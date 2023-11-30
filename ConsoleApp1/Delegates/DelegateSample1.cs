using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet.Delegates
{
    public delegate void MyDelegate(string msg); //declaring a delegate

    class Program
    {
        //static void Main(string[] args)
        //{
        //    MyDelegate del = ClassA.MethodA;
        //    del("Hello World from MethodA");

        //    del = ClassB.MethodB;
        //    del("Hello World from MethodB");

        //    del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        //    del("Hello World");
        //}
    }

    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }


}
