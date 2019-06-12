using System;

namespace _17_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.GetIterator(); iter.hasNext();)
            {
                String name = (String)iter.next();
                Console.WriteLine("Name : " + name);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
