using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
   
    abstract class Player 
    {
        //member variables (has a)
        public string name;
        public int score;
        public string chosenGesture;
        public List<string> moves;


        //ctor
        public Player()
        {
            score = 0;
            moves = new List<string>() {"rock", "paper", "scissors", "lizard", "spock" };
        }
        //member variables (can do)
        public abstract void ChooseMove();

       

    }
}
