using System;

namespace _05_Prototype
{

    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Bob";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Sue";

            Console.WriteLine(dev);
            Console.WriteLine(devCopy);

            /* OUTPUT

            Bob - Team Leader - C#
            Sue - Team Leader - C#

            */

            Typist typist = new Typist();
            typist.Name = "Kay";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Tim";
            typistCopy.WordsPerMinute = 115;

            Console.WriteLine(typist);
            Console.WriteLine(typistCopy);

            /* OUTPUT

            Kay - Typist - 120wpm
            Tim - Typist - 115wpm

            */
            Console.WriteLine("Hello World!");
        }
    }
}
