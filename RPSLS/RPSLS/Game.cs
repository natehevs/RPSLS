using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        /*
            create a game class.
              run game
                choose how many players/computers
                    compare gestures
                    Rock crushes Scissors
                    Scissors cuts Paper
                    Paper covers Rock
                    Rock crushes Lizard
                    Lizard poisons Spock
                    Spock smashes Scissors
                    Scissors decapitates Lizard
                    Lizard eats Paper
                    Paper disproves Spock
                    Spock vaporizes Rock
                        show winner for each round
                            keep track of rounds and loop until someone wins 2/3 rounds
            create a player class
                Get gesture
            create a human class
                write line/readline take in an input 0-4 for move
            create a computer class
                randomly generate a gesture by using a list and grabbing from 0-4 slot

         */
        //member variables (Has A)


        private Player player1;
        private Player player2;
        private Player computer;

        //constructor (Builder)

        public Game()
        {
            player1 = new Human();
            player2 = new Human();
            //player2 = new Computer();
        }
        //member methods (Can Do)

        public void RunGame()
        {
            player2.ChooseGesture();
        }

        public void CompareGestures()
        {
            Console.WriteLine("Here are the gestures chosen for this round.");

            if (player1.gesture == player2.gesture || player1.gesture == computer.gesture)
            {
                Console.WriteLine("Tie. Choose again.");
            } 
            else if ()
            {

            }
            else if ()
            {

            }
            else if ()
            {

            }
            else if ()
            {

            }
            else if ()
            {

            }
            else if ()
            {

            }
        }

        public void DisplayWinner()
        {

        }

    }
}
