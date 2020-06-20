using System;
using System.Collections.Generic;
using System.Text;

namespace csharpDemo
{
    class C
    {

        static void Main()
        {
            A obj = new A();
            obj.InternalMethod();
            obj.PublicMethod();
            obj.ProtectedInternsalMethod();
            //obj.ProtectedMethod();
        }
    }
}
