namespace _03_BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string name();

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float price();
    }

}
