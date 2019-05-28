using System;

namespace _03_Singleton
{
    class SingleObject
    {
        private static SingleObject instance = new SingleObject();
        private SingleObject() { }

        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject  instanceA = SingleObject.getInstance();
            instanceA.showMessage();
            Console.WriteLine("Hello World!");
        }

    }
}
