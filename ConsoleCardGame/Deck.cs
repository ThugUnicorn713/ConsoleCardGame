using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardGame
{
    internal class Deck
    {
        private List<Card> cards;

        //constructor to create a standard 52 card deck

        public Deck() 
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        // shuffle deck
        public void Shuffle()
        {
            Random random = new Random();
            cards = cards.OrderBy(x => random.Next()).ToList();
        }

        //draw a card from the top of the deck
        public Card DrawCard() 
        {
            if (cards.Count > 0)
            {
                Card drawnCard = cards[0];
                cards.RemoveAt(0);
                return drawnCard;
            }
            else
            {
                return null;    
            }
        }
    }
}
