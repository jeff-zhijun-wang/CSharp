namespace _01_FactoryPattern
{
    public class ShapeFactory
    {
        public IShape getShape(string shapeType)
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
