using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    class Game
    {
        //member variables (has a)
        public Player player1;
        public Player player2;
        //ctor
        public Game()
        {
            player1 = new Human();
        }

        public void Welcome()
        {
            Console.WriteLine
                ("Welcome to the Game");
        }

        public void DisplayRules()
        {
            Console.WriteLine("Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard,Lizard poisons Spock, Spock smashes Scissors, Scissors decapitate Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
                    
                 
                
        }


        //member variables (can do)

    }
}
