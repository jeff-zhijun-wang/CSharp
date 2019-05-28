using System;

namespace _01_FactoryPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.getShape("RECTANGLE");
            shape1.draw();
            IShape shape2 = shapeFactory.getShape("CIRCLE");
            shape2.draw();
            IShape shape3 = shapeFactory.getShape("SQUARE");
            shape3.draw();
            Console.WriteLine("Hello World!");
        }
    }
}
