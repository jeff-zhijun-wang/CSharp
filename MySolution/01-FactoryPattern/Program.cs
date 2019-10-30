using System;

namespace _01_FactoryPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.createShape("RECTANGLE");
            shape1.draw();
            IShape shape2 = shapeFactory.createShape("CIRCLE");
            shape2.draw();
            IShape shape3 = shapeFactory.createShape("SQUARE");
            shape3.draw();
            Console.WriteLine("Hello World!");
        }
    }
}
