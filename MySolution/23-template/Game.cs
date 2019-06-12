namespace _23_template
{
    public abstract class Game
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();
        public void play()
        {
            //initialize the game
            initialize();

            //start the game
            startPlay();

            //end game
            endPlay();
        }
    }

}
