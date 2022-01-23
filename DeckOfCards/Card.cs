using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public enum Suit
    {
        Heart,
        Spade,
        Diamond,
        Club
    }
    public enum Value
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
    public class Card
    {
        public Suit Suit;
        public Value Val;
        public int NumVal;
        public Card(Suit suit, Value val, int numVal)
        {
            Suit = suit;
            Val = val;
            NumVal = numVal;
        }
        public override string ToString()
        {
            return $"{Val} of {Suit} with a val of {NumVal}";
        }
    }
}
