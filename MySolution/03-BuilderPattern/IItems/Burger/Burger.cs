namespace _03_BuilderPattern
{
    public abstract class Burger: IItem
    {
       public abstract string name();

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float price();
    }

}
