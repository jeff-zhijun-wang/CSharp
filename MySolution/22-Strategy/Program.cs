using System;

namespace _22_Strategy
{

    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.executeStrategy(10, 5));

            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context.executeStrategy(10, 5));

            context = new Context(new OperationMultipy());
            Console.WriteLine("10 * 5 = " + context.executeStrategy(10, 5));
            Console.WriteLine("Hello World!");
        }
    }
}

