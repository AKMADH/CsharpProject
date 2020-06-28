using System;
using System.Collections.Generic;
using System.Text;

namespace csharpDemo
{
  public  class InheritanceDemo
    {
        public InheritanceDemo()
        {
            Console.WriteLine("parent clASS constructor");
        }
        public void print()
        {
            Console.WriteLine("parent clASS");
        }
    }

    public class child: InheritanceDemo
    {
        public child()
        {
            Console.WriteLine("Child clASS constructor");
        }
        static void Main()
        {
            child c = new child();
            c.print();
        }
    }
}
