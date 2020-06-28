using System;
using System.Collections.Generic;
using System.Text;

namespace csharpDemo
{
   public  class StaticDemo
    {
        public int a=10;
        public static int b=20;


        public  void Sum()
        {

            Console.WriteLine("sum non static Method {0}",a+b);
        }

        public  void sub()
        {
            Console.WriteLine("sub non static Method");
        }
        public static void div()
        {
            Console.WriteLine("div  static Method");
        }
        static void Main()
        {
            StaticDemo obj = new StaticDemo();
            obj.sub();// non -static method
            obj.Sum();//instance 
            Console.WriteLine(obj.a);
            Console.WriteLine(b);
            div();//static method
            Console.WriteLine();
        }
    }
}
