using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet.Delegates
{
    public delegate void MyDelegatetest(string msg); //declaring a delegate

    class ProgramDelegate
    {
        //static void Main(string[] args)
        //{
        //    MyDelegatetest delTest = ClassOne.MethodA;
        //    InvokeDelegate(delTest);

        //    delTest = ClassB.MethodB;
        //    InvokeDelegate(delTest);

        //    delTest = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        //    InvokeDelegate(delTest);
        //}

        public static void InvokeDelegate(MyDelegatetest del) // MyDelegate type parameter
        {
            del("Hello World");
        }
    }

    class ClassOne
    {
       public  static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassTwo
    {
        static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}
