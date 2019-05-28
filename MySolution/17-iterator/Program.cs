using System;

namespace _17_iterator
{
    public interface Iterator
    {
        Boolean hasNext();
        object next();
    }

    public interface Container
    {
        Iterator GetIterator();
    }

    public class NameRepository : Container
    {
        private static string[] names = { "Robert", "John", "julie", "Lora" };

        public Iterator GetIterator()
        {
            return new NameIterator();
        }
        private class NameIterator : Iterator
        {
            int index;

            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
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
