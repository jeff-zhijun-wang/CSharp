using System;

namespace EventTutorial
{
    class Number
    {
        private PrintHelper _printHelper;  //publisher

        public Number(int val)
        {
            _value = val;

            _printHelper = new PrintHelper();
            //subscribe to beforePrintEvent event  //here to subscribe the event
            //each new object(subscriber) will have a publisher object
            //here the link between events and event handlers
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;//SUBSCRIBER before event
            _printHelper.afterPrintEvent += printHelper_afterPrintEvent;  //subscriber after enevt
        }

        //beforePrintevent event handler, subscriber has the event handler
        void printHelper_beforePrintEvent(string message)
        {
            Console.WriteLine("BeforePrintEvent fires from {0}", message);
        }



        //afterPrintevent event handler, publiher has the event and subscriber has the event handler
        void printHelper_afterPrintEvent()
        {
            Console.WriteLine("afterPrintEvent fires!");
        }
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }
}
