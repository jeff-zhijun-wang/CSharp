using System.Collections.Generic;

namespace _20_Observer
{
    public class Subject //state changer
    {

        private List<Observer> observers = new List<Observer>();
        private int state;

        public int getState()
        {
            return state;
        }

        public void setState(int state) //here to change the state
        {
            this.state = state;
            notifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }
    }
}
