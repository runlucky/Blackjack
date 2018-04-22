using System;
namespace Blackjack.Cards.Card
{
    internal enum Suit
    {
        Spade,
        Club,
        Diamond,
        Heart
    }

    internal class Suits
    {
		private readonly Suit _suit;

        public Suits(Suit suit)
        {
            _suit = suit;
        }

        public string Show()
        {
            switch (_suit)
            {
                case Suit.Spade: return "♠";
                case Suit.Club: return "♣";
                case Suit.Diamond: return "♦";
                case Suit.Heart: return "♥";
                default: return "";
            }
        }

    }
}
