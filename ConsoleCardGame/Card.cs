using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardGame
{
    internal class Card
    {
        //private fields to store a card
        private Suit suit;
        private Rank rank;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
        public Suit Suit
        {
            get { return Suit; }
        }

        public Rank Rank
        {
            get { return rank; }
        }

        //Overloaded tostring method for displaying card info

        public override string ToString() 
        {
            return $"{rank} of {suit}";
        
        }

        public int Value()
        {
            int value = (int)rank;

            if (value > 10)
            {
                value = 10;
            }
            return value;
        }
    }
    
}
