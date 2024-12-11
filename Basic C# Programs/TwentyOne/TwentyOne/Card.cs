using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //create constructor (values assigned upon creation
        public Card() 
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit {  get; set; }
        public string Face { get; set; }
    }
}
