using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();

            Console.WriteLine("Deck of Cards");
            deck.ReadDeck();

            Console.WriteLine("Shuffle the deck of cards");

            deck.Shuffle();
            deck.ReadDeck();

            Console.WriteLine("Draw 10 random cards");
            for(var i=0; i<10; i++)
            {
                var dealtCard = deck.DrawCard();
                Console.WriteLine(dealtCard.ToString());
            }

            Console.WriteLine($"Number of cards left: {deck.Cards.Count}");

            Console.WriteLine("Reset the deck");
            deck.Reset();

        }
    }
}
