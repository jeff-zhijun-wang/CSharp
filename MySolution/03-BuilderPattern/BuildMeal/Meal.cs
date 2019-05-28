using System;
using System.Collections.Generic;

namespace _03_BuilderPattern
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();
        public void addItem(IItem item)
        {
            items.Add(item);
        }
        public float getCost()
        {
            float cost = 0.0f;
            foreach (var item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach(var item in items)
            {
                Console.WriteLine("Item: {0} ", item.name());
                Console.WriteLine("Packing: {0} ", item.Packing().pack());
                Console.WriteLine("Price: {0} ", item.price());
            }
        }

    }
}
