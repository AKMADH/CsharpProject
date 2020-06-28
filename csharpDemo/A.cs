using System;
using System.Collections.Generic;
using System.Text;

namespace csharpDemo
{
    public class A
    {
        public void PublicMethod()
        {
            Console.WriteLine("Public Method ");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method ");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("protected Method ");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }
        protected internal void ProtectedInternsalMethod()
        {
            Console.WriteLine("ProtectedInternal Method");
        }
        static void Main() { 
            //obj creation 
             A obj= new A();
            obj.PrivateMethod();obj.PublicMethod();obj.ProtectedMethod();
            obj.InternalMethod();
            obj.ProtectedInternsalMethod();
            Console.ReadLine();
        }

    }

}
