using System;

namespace _02_AbstractFactoryPattern
{
    public interface IShape
    {
        void draw();
    }
    public class RoundedRectangle : IShape
    {
        public void draw() => Console.WriteLine("RoundedRectangle");
    }

    public class RoundedSquare : IShape
    {
        public void draw() => Console.WriteLine("Square");
    }

    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }

    public class Square: IShape
    {
        public void draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Circle : IShape
    {
        public void draw() => Console.WriteLine("Circle");
    }

}
