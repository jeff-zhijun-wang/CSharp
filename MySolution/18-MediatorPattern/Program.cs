using System;

namespace _18_MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{user} {message}");
        }
    }

    public class User
    {
        private String name;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public User(String name)
        {
            this.name = name;
        }

        public void sendMessage(String message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.sendMessage("Hi! John!");
            john.sendMessage("Hello! Robert!");
            Console.WriteLine("Hello World!");
        }
    }
}
