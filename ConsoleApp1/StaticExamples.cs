using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet
{
     class StaticExamples
    {
      //static void Main(string[] args)
      //  {
      //      TestSample test = new TestSample();
      //      test.ID = "100";
      //      test.Print();

      //      //Access Static Class 

      //      StaticSample.ID = "20001";
      //      StaticSample.StaticGet();
      //      StaticSample.StaticPost();
      //  }

    }


    public class TestSample
    {
        public string ID { get; set; }

        public void Print()
        {

        }

    }


    public static class StaticSample
    {
        public static string ID { get; set; }

       

        public static void StaticGet()
        {
            Console.WriteLine("I am from StaticGet");
        }

        public static void StaticPost()
        {
            Console.WriteLine("I am from StaticPost");
        }

    }
   
}
