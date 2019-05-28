using System;

namespace _15_COMMAND
{


    class Program
    {
        static void Main(string[] args)
        {
            Stock abcStock = new Stock();
            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);
            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.placeOrders();
            Console.WriteLine("Hello World!");
        }
    }
}
