namespace _17_iterator
{
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
}
