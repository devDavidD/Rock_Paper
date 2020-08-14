using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
            Console.ReadLine();
        }
    }
}
