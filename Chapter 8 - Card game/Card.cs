using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___Card_game
{
    class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public string Name
        {
            get { return $"{Value} of {Suit}"; }
        }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
