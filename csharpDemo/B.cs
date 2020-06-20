using System;
using System.Collections.Generic;
using System.Text;

namespace csharpDemo
{
    class B : A
    {
        static void Main()
        {
           B  obj=new B();

            obj.PublicMethod();
            obj.ProtectedMethod();
            obj.ProtectedInternsalMethod();
            obj.InternalMethod();
            

        }
    }
}
