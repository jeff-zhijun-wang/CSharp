using System;

namespace _20_Observer
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void update();
    }

    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
 //           this.subject.attach(this);//miracle here, good example to understand this
        }

        public override void update()
        {
            Console.WriteLine("Binary String: " + subject.getState().ToString()); ;
        }
    }

    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Octal String: " + subject.getState().ToString()); ;
        }
    }

    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Hexa String: " + subject.getState().ToString()); ;
        }
    }
}
