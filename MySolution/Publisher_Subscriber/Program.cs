using System;

namespace SampleApp
{

    class EventProgram
    {
        public delegate void MyDelegate(string str); //define the pointer to function
        public event MyDelegate MyEvent;  //instantiate a object

        public EventProgram()
        {
            this.MyEvent += new MyDelegate(this.WelcomeUser); //assign
            this.MyEvent += new MyDelegate(this.WelcomeUser);
        }

        public void WelcomeUser(string username)   //this is the actual function
        {
            Console.WriteLine("Welcome " + username);
        }

            static void Main(string[] args)
            {
                EventProgram obj1 = new EventProgram();
                obj1.MyEvent("test");
                //Console.WriteLine(result);
            }
    }
}
