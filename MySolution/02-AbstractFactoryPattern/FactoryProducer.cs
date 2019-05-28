namespace _02_AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(bool rounded)
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
