using System;
using System.Collections.Generic;

namespace _12_flyweight
{
    public class ShapeFactory
    {
        //store 5 typicalCircle here, the rest are the variation of those 5 Circles
        private static Dictionary<Color, Circle> mDictionary = new Dictionary<Color, Circle>();

        public static IShape GetCircle(Color color)
        {
            Circle circle = new Circle(color);
            if (!mDictionary.ContainsKey(color))
            {
                mDictionary.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            return circle;
        }
    }
}


