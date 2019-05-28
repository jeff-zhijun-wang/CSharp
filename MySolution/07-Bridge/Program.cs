using System;

namespace _07_Bridge
{

    class Program
    {
        static void Main(string[] args)
        {
            //decouple an abstraction "Shape" class from its implementation "Circle" class so that the two can vary independently.
            //in Shape, we contain drawApi
            Shape redCircle = new Circle(100, 100, 10, new RedCircleDraw());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircleDraw());
            Console.WriteLine("Hello World!");
        }
    }
}
