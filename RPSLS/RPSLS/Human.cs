using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //member variables (Has A)



        //constructor (Builder)

        public Human()
        {

        }
        //member methods (Can Do)

        public void ChooseGesture()
        {
            Console.WriteLine("Please select a move. Rock, Paper, Scissors, Lizard, Spock");
            gesture = Console.ReadLine();
        }
    }

    }
}
