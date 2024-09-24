using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Adkisson_Damien
{
   
    class Card
    {
      
        ///creates number and suit
       public string Number { get; }

       public string Suit { get; }

        ///Creates Card constructor
        public Card(string numparam, string suitParam) 
        { 
            Number = numparam;
            Suit = suitParam;
        }

    }
}
