using System;

namespace _20_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            subject.attach(new HexaObserver(subject));
            subject.attach(new OctalObserver(subject));
            subject.attach(new BinaryObserver(subject));

            Console.WriteLine("First state change: 15");
            subject.setState(15);
            Console.WriteLine("Second state change: 10");
            subject.setState(10);
            Console.WriteLine("Hello World!");
        }
    }
}
