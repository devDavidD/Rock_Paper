using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RPS
{
    class Human : Player
    {
        //member variables (has a)
        //Human has all member variables of Player clas because it inherits it

        //ctor
        public Human()
        {
            

            name = "Aaron";
           
            



            //member variable (can do)

        }

        public override void ChooseMove(Human  )
        {
            //display choices - Console.WriteLine
            //get user input - Console.ReadLine
            Console.WriteLine("rock", "paper", "scissors", "lizard", "spock");
            Console.ReadLine();
            //we want to take that user input and set this object's chosenGesture member variable to that string
            //chosenGesture = our previous user input
        }
    }
}
