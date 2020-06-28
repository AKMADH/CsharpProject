using System;
using System.Collections.Generic;
using System.Text;

namespace csharpDemo
{
  public   class StaticConstructorDemo
    {
        // call only once 
        static StaticConstructorDemo()
        {
            Console.WriteLine("Static Constrctor");

        }
        //non-static will called as many times we are creating the instance
        public StaticConstructorDemo()
        {
            Console.WriteLine("Non-static Constructor ");

        }
        //public StaticConstructorDemo(int a)
        //{
        //    Console.WriteLine("Non-static Constructor ");

        //}
        //public StaticConstructorDemo(int a,float b)
        //{
        //    Console.WriteLine("Non-static Constructor ");

        //}
        //constructor overloading
        static void Main()
        {
            StaticConstructorDemo obj = new StaticConstructorDemo();
            StaticConstructorDemo obj1 = new StaticConstructorDemo();
            StaticConstructorDemo obj2 = new StaticConstructorDemo();
            Console.ReadLine();
        }
    }
}
