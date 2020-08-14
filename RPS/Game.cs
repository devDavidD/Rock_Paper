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
        public void DeterminePlayer2()
        {
            Console.WriteLine("Type 1 to play friend on console. Type 2 to play computer");
            string response =
            Console.ReadLine();
            if (response == "1")
            {
                player2 = new Human();
            }
            else 
            {
                player2 = new AI();
            }
            public void CompareMove()
            {
                //p1 gets a point
                //p2 gets a point
                //tie round

            }
            public void DisplayWinnerOfGame()
            {
                
            }
            public void RunGame()
            {
                //Remember to validate
                //Insert Intro
                //Welcome
                Welcome();
                DisplayRules();
                //Display rules
                DeterminePlayer2();
                //optional game variables : 
                //player name, number of          ''rounds

                //Rounds of gameplay, use loop
                //display CHOOSE MOVE OPT
                //Player 1 makes choice
                player1.ChooseMove();
                //display move opt if human

                player2.ChooseMove();
                //player 2 makes gesture choice
                CompareMove();
                //winner gets point
                //move to next round if no one has won yet
                DisplayWinnerOfGame();
                // Do you want to play again ?
            }





        }


        //member variables (can do)

    }
}
