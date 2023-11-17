using System;
using System.Runtime.CompilerServices;

namespace Animals
{
   
    //class Herbivorus
    //{
    //    Animal animal  =    new Animal();
    //    animal.
    //}

  public   class Animal
    {
        string Gender = "Female";
        string breed = "German";
        string Colour = "red";

     

        void Eat()
        {
            Console.WriteLine("I am from Method Eat Method()");
        }

        void Run()
        {
            Console.WriteLine("I am from Method Run Method()");
        }

        void Hunt()
        {
            Console.WriteLine("I am from Method Hunt Method()");
        }
        void Sleep()
        {
            Console.WriteLine("I am from Method Sleep Method()");
        }

    }

}