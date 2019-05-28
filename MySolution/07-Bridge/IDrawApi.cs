using System;

namespace _07_Bridge
{
    public interface IDrawApi
    {
        void drawCircle(int radius, int x, int y);
    }

    public class RedCircleDraw : IDrawApi
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Red circle draw api");
        }
    }

    public class GreenCircleDraw : IDrawApi
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Green circle draw api");
        }
    }
}
