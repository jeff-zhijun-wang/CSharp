using System;

namespace _02_AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IShape getShape(string shapeType);
    }

    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapeType)
        {
            if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }
    }

    public class ShapeFactory: AbstractFactory
    {
        public override IShape getShape(string shapeType)
        {
            switch (shapeType.ToUpper())
            {
                case "RECTANGLE":
                    return new Rectangle();
                case "SQUARE":
                    return new Square();
                case "CIRCLE":
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
