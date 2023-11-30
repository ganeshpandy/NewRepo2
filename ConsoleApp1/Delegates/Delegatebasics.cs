using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet.Delegates
{
    // [access modifier]     delegate [return type][delegate name]([parameters])

    public delegate void TestDelegate(string Message,string SaveMessage);

    class DelegateBasic

    {
        //static void Main(string[] args)
        //{
        //   // TestDelegate testDelegate = new TestDelegate(Display);

        //    TestDelegate testDelegate1 = new TestDelegate(Print);

        //    //testDelegate.Invoke("I am calling From testDelegate Invoke ");
        //    testDelegate1.Invoke("From Save Message","Seconparameter");

        //    testDelegate1("From Save Message","Seconparameter");
        //}

        static void Display(string Message) 
        {
            Console.WriteLine("Message From Delegate" +  Message);
        }

        static void Save(string SaveMessage)
        {
            Console.WriteLine("Message From SaveMessage" + SaveMessage);
        }


        static void Print(string Message,string adasd)
        {
            Console.WriteLine("Message From Delegate" + Message +",Second Params" + adasd);
        }

    }



  

}
