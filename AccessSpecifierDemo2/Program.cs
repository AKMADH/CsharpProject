using csharpDemo;
using System;

namespace AccessSpecifierDemo2
{
    class Program : A
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.ProtectedInternsalMethod();
            P.PublicMethod();
            P.ProtectedMethod();
           // P.InternalMethod();
        }
    }
}
