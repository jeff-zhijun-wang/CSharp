using System;

namespace _15_COMMAND
{
    public class Stock 
    {
        private string Name = "ABC";
        private int Quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock [ Name  {Name} Quantity:  {Quantity} bought]");
        }
        public void Sell()
        {
            Console.WriteLine($"Stock [ Name  {Name} Quantity:  {Quantity} Sold]");
        }
    }
}
