using System.Collections.Generic;

namespace _15_COMMAND
{
    public class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();
        public void TakeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {
            foreach(IOrder order in orderList)
            {
                order.Execute();
            }
        }
    }
}
