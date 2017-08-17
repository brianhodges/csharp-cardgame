using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cardgame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] suits = new string[]{ "Clubs", "Spades", "Hearts", "Diamonds" };
            string[] ranks = new string[]{ "Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
            List<Card> Deck = new List<Card>();

            //Build Card Deck
            for (int x = 0; x < suits.Length; x++)
            {
                for (int y = 0; y < ranks.Length; y++)
                {
                    Card card = new Card { Suit = suits[x], Rank = ranks[y] };
                    Deck.Add(card);
                }
            }

            //Shuffle Deck of Cards
            var rnd = new Random();
            var ShuffledDeck = Deck.OrderBy(item => rnd.Next());

            //Display All Cards
            foreach (Card c in ShuffledDeck) { Console.WriteLine("{0} of {1}", c.Rank, c.Suit); }
            
            Console.WriteLine("Deck Size: {0}", Deck.Count);
            Console.ReadKey();
        }
    }
}
