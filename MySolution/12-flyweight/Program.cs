using System;

namespace _12_flyweight
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(getRandomColor());
                circle.setX(getRandomX());
                circle.setY(getRandomY());
                circle.setRadius(100);
                circle.Draw();
            }

        }
        private static Color getRandomColor()
        {
            Random random = new Random();
            return (Color)random.Next(5);
        }
        private static int getRandomX()
        {
            Random random = new Random();
            return random.Next(100);
        }
        private static int getRandomY()
        {
            Random random = new Random();
            return random.Next(100);
        }

    }
}


