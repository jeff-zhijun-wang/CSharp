namespace _03_BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override string name()
        {
            return "Chicken Burger";
        }

        public override float price()
        {
            return 10.0f;
        }
    }

}
