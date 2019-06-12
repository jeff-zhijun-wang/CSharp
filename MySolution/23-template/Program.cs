using System;

namespace _23_template
{


    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.play();
            game = new Football();
            game.play();
        }
    }
}
