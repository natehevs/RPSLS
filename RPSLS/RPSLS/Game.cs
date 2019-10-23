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
        private Computer computer;

        //constructor (Builder)

        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            computer = new Computer();
        }
        //member methods (Can Do)

        public void RunGame()
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayWinner()
        {

        }

    }
}
