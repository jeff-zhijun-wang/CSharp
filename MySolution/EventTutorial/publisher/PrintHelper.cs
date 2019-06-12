using System;

namespace EventTutorial
{
    //publisher includes event and notifier (raise the event)
    //subscriber includes the subscriber and event handler for this subscriber
    public class PrintHelper
    {
        // declare delegate 
        public delegate void BeforePrint(string message);

        //declare event of type delegate
        public event BeforePrint beforePrintEvent;

        //declare another delegate
        public delegate void AfterPrint();

        //declare an event type of AfterPrint
        public event AfterPrint afterPrintEvent;

        public PrintHelper()
        {

        }

        //actually function 1 with the same signature
        public void PrintNumber(int num)
        {
            //call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent("Print Number"); //notifier here
//to pass information when raising an event from a publisher to subscriber

            Console.WriteLine("Number: {0,-12:N0}", num);

            //the event handler is in the subscriber, here just to raise the event
            if (afterPrintEvent != null)
                afterPrintEvent(); //or afterPrintEvent.Invoke();  //notifier here
        }

        //actually function 2 with the same signature

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("Print decimal");//notifier is actually call the event handler

            Console.WriteLine("Decimal: {0:G}", dec);

            //the event handler is in the subscriber, here just to raise the event
            if (afterPrintEvent != null)
                afterPrintEvent(); //or afterPrintEvent.Invoke();
            //notifier is actually call the event handler
        }

        //actually function 3 with the same signature

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("Print Money");
            //notifier is actually call the event handler
            Console.WriteLine("Money: {0:C}", money);

            //the event handler is in the subscriber, here just to raise the event
            if (afterPrintEvent != null)
                afterPrintEvent(); //or afterPrintEvent.Invoke();
            //notifier is actually call the event handler
        }

        //actually function 4 with the same signature

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("Print Temperature");
            //notifier is actually call the event handler
            Console.WriteLine("Temperature: {0,4:N1} F", num);

            //the event handler is in the subscriber, here just to raise the event
            if (afterPrintEvent != null)
                afterPrintEvent(); //or afterPrintEvent.Invoke();
            //notifier is actually call the event handler
        }

        //actually function 5 with the same signature

        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("Print Hexadecimal");
            //notifier is actually call the event handler
            Console.WriteLine("Hexadecimal: {0:X}", dec);

//the event handler is in the subscriber, here just to raise the event
            if (afterPrintEvent != null)
                afterPrintEvent(); //or afterPrintEvent.Invoke();
            //notifier is actually call the event handler
        }
    }
}
