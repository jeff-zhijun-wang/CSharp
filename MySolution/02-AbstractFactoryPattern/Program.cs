using System;

namespace _02_AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //get rounded shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory(false);
            //get an object of Shape Rounded Rectangle
            IShape shape1 = shapeFactory.getShape("RECTANGLE");
            //call draw method of Shape Rectangle
            shape1.draw();
            //get an object of Shape Rounded Square 
            IShape shape2 = shapeFactory.getShape("SQUARE");
            //call draw method of Shape Square
            shape2.draw();
            //get rounded shape factory
            AbstractFactory shapeFactory1 = FactoryProducer.getFactory(true);
            //get an object of Shape Rectangle
            IShape shape3 = shapeFactory1.getShape("RECTANGLE");
            //call draw method of Shape Rectangle
            shape3.draw();
            //get an object of Shape Square 
            IShape shape4 = shapeFactory1.getShape("SQUARE");
            //call draw method of Shape Square
            shape4.draw();
            Console.WriteLine("Hello World!");
        }
    }
}
