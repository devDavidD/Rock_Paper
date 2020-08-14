using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RPS
{
    class Human : Player
    {
        public Human(  )
        {
            name = "E";
        }
        public override void ChooseMove(  )
        {
            Console.WriteLine("rock", "paper", "scissors", "lizard", "spock");
            string response = Console.ReadLine(  );
        }
    }
}
