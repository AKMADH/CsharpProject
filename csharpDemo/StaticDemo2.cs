using System;
using System.Collections.Generic;
using System.Text;

namespace csharpDemo
{
   public class StaticDemo2
    {
        static void Main()
        {
            Console.WriteLine("static Demo 2");
            StaticDemo.div();
            StaticDemo obj = new StaticDemo();
            obj.sub();
            obj.Sum();
            int c=obj.a;
            int a = StaticDemo.b;
            Console.ReadLine();
        }
    }
}
