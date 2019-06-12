using System;

namespace CSharpTutorial
{
    class Program
    {
    public enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine("Hello World!");
        }
    }
}
