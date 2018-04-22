using Blackjack.Cards;
using Blackjack.Cards.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal class Card : ICard
    {
        private readonly Suits _suit;
        private readonly Rank _rank;

        public Card(Suit suit, int rank)
        {
            _suit = new Suits(suit);
            _rank = new Rank(rank);
        }

        public string Show() => _suit.Show() + _rank.Show();

        public int Point() => _rank.Point();
        public bool IsAce() => _rank.IsAce();
    }
}
