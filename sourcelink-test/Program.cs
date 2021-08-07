using System;
using dependency_with_sourcelink;

namespace sourcelink_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var x = new Class1();
            Console.WriteLine(x.GetHelloText("Slawomir"));
        }
    }
}
