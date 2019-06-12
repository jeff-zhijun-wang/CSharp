using System;

namespace EventTutorial
{

    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber1 = new Number(100000); //subscriber 1
            myNumber1.PrintMoney();
            myNumber1.PrintNumber();

            Number myNumber2 = new Number(10000); //subscriber 2
            myNumber2.PrintMoney();
            myNumber2.PrintNumber();

            Console.WriteLine("Hello World!");
        }
    }
}
