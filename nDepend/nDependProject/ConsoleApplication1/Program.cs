using System;
using ClassLibrary1;
using ClassLibrary2;

namespace ConsoleApplication1
{
    class MyClass
    {
        public int F1()
        {
            return 1;
        }
        public int F2()
        {
            return 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var x = new MyClass();
            Console.WriteLine(x.F1() + ""+ x.F2());
            
           IClass1 cl = new Class1();

            cl.A();
            Console.WriteLine(cl.Path());
        }
    }
}
