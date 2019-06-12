namespace _15_COMMAND
{
    public class SellStock : IOrder
    {
        private Stock abcStock;
        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }


        public void Execute()
        {
            abcStock.Sell();
        }
    }
}
