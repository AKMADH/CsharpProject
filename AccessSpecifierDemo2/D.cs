using csharpDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifierDemo2
{
    class D
    {
        static void Main()
        {
            A obj = new A();
            obj.PublicMethod();
           
        }
    }
}
