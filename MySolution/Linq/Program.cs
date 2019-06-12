using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };
            var myLinqQuery = from name in names where name.Contains('a') select name;


            foreach(var name in myLinqQuery)
            Console.WriteLine("Hello World!" + name);
        }
    }
}
