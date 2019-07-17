using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card //one class per file
    {
        public Card() //Constructor
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; } //property
        public string Face { get; set; } //property


    }
}
