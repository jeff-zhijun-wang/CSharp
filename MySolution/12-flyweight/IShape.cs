﻿using System;

namespace _12_flyweight
{
    public interface IShape
    {
        void Draw();
    }


    public class Circle : IShape
    {
        private Color color;
        private int x;
        private int y;
        private int radius;

        public Circle(Color color)
        {
            this.color = color;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setRadius(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + color + ", x : " + x + ", y :" + y + ", radius :" + radius);
        }
    }
}
