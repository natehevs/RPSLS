using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //member variables (Has A)

        public string gesture;


        //constructor (Builder)

        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };



        public Player()
        {
             
        }
        //member methods (Can Do)

        public void GetGesture()
        {

        }
    }
}
