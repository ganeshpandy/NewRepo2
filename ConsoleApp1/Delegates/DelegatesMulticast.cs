using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet.Delegates
{
    public delegate void MyDelegateMulticast(string msg); //declaring a delegate

    class ProgramMyDelegateMulticast
    {
        //static void Main(string[] args)
        //{
        //    MyDelegateMulticast del1 = ClassMulticast1.MethodA;
        //    MyDelegateMulticast del2 = ClassMulticast2.MethodB;

        //    MyDelegateMulticast del = del1 + del2; // combines del1 + del2
        //    del("Hello World");

        //    MyDelegateMulticast del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        //    del += del3; // combines del1 + del2 + del3
        //    del("Hello World");

           
        //}
    }

    class ClassMulticast1
    {
      public   static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassMulticast2
    {
       public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}
