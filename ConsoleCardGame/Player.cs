using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardGame
{
    internal class Player
    {
        private string name;
        private List<Card> hand;

        //constructor to initialize a player
        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }

        //add card to players hand
        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        //display the players hand
        public void ShowHand()
        {
            Console.WriteLine($"{name}'s hand: ");
            foreach (Card card in hand)
            {
                Console.WriteLine(card);
            }
        }

        public void PrintScore() 
        {
            int score = 0;
            foreach (Card card in hand)
            {
                score += card.Value();
            }



            Console.WriteLine($"{name}'s score: {score} \n");

        }
        public int Score()
        {
            int score = 0;
            foreach (Card card in hand)
            {
                score += card.Value();
            }

            return score;
        }


        
    }
}
