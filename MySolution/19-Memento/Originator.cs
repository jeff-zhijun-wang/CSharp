namespace _19_Memento
{
    public class Originator
    {
        private string state;

        public void setState(string state)
        {
            this.state = state;
        }

        public string getState()
        {
            return state;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(state);
        }

        public void getStateFromMemento(Memento memento)
        {
            state = memento.getState();
        }
    }

}
