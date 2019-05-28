using System;

namespace _11_Facade
{
    public interface IShape
    {
        void draw();
    }
    public class Rectangle : IShape
    {
        public void draw() => Console.WriteLine("Rectangle");
    }

    public class Square : IShape
    {
        public void draw() => Console.WriteLine("Square");
    }

    public class Circle : IShape
    {
        public void draw() => Console.WriteLine("Circle");
    }

}
