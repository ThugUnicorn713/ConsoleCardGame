using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a deck and shuffle it
            Deck deck = new Deck();
            deck.Shuffle();

            //creates two players
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            //Deal two cards to each player
            for (int i = 0; i < 10; i++)
            {
                player1.AddCard(deck.DrawCard());
                player2.AddCard(deck.DrawCard());

            }

            //show the players' hands
            player1.ShowHand();
            player1.PrintScore();

            player2.ShowHand();
            player2.PrintScore();

            Console.ReadKey();


            // add more game logic here (drawing more cards, compare hands, etc)

            if (player1.Score() > player2.Score() && player1.Score() <= 21)
            {
                Console.WriteLine("Player 1, You are the Winner!");
            }
            else if (player2.Score() > player1.Score() && player2.Score() <= 21)
            {
                Console.WriteLine("Player 2, You are the Winner!");
            }
            else if (player1.Score() == player2.Score())
            {
                Console.WriteLine("A Tie");  
            }
            else
            {
                Console.WriteLine("Bust!!!");
            }


          

            Console.ReadKey();
        }
    }
}
