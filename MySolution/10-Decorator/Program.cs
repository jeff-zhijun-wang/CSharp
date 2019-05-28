using System;

namespace _10_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();

            IShape redCircle = new RedDocoratedShape(new Circle());

            IShape redRectangle = new RedDocoratedShape(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();
            Console.WriteLine("Hello World!");
        }
    }
}
