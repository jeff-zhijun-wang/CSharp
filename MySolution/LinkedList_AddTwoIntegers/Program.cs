using System;
using System.Collections.Generic;

namespace LinkedList_AddTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>() ;
            LinkedList<int> l2 = new LinkedList<int>();
            l1.AddFirst(3);
            l1.AddFirst(4);
            l1.AddFirst(2);

            l2.AddFirst(4);
            l2.AddFirst(6);
            l2.AddFirst(5);

            string sl1 = string.Empty;
            string sl2 = string.Empty;

            foreach(int x in l1)
            {
                sl1 += x.ToString();
            }
            foreach (int x in l2)
            {
                sl2 +=x.ToString();
            }

            int a = Convert.ToInt32(sl1);
            int b = Convert.ToInt32(sl2);
            int c = a + b;
            Console.WriteLine($"Hello World! {c.ToString()}");
        }
    }
}
