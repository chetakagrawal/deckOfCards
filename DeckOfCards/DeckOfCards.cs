using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class DeckOfCards
    {
        public List<Card> Cards = new List<Card>();
        public DeckOfCards()
        {
            CreateDeckOfCards();
        }
        
        public void CreateDeckOfCards()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                var num = 1;
                foreach (Value val in Enum.GetValues(typeof(Value)))
                {
                    Cards.Add(new Card(suit, val, num));
                    num++;
                }
            }
        }
        public void ReadDeck()
        {
            foreach (var c in Cards)
            {
                Console.WriteLine($"{c.Val} of {c.Suit} with a val of {c.NumVal}");
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (var i = 0; i < Cards.Count; i++)
            {
                var newIdx = rand.Next(Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[newIdx];
                Cards[newIdx] = temp;
            }
        }
        public Card DrawCard()
        {
            Random rand = new Random();
            var idx = rand.Next(Cards.Count);
            if (Cards.Count <= 0)
                Console.WriteLine("No more cards to deal");
            var dealtCard = Cards[idx];
            Cards.RemoveAt(idx);
            return dealtCard;
        }
        public void Reset()
        {
            Cards.Clear();
            CreateDeckOfCards();
        }
    }
}
