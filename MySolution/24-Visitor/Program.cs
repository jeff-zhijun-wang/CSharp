using System;

namespace _24_Visitor
{

    class Program
    {
        static void Main(string[] args)
        {
            IPart computer = new Computer();
            computer.accept(new Visitor());
            Console.WriteLine("Hello World!");
        }
    }
}
