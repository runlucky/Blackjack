using Blackjack.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    internal class Deck : IDeck
    {
        private readonly List<Card> _cards = new List<Card>();

        public Deck()
        {
            Restore();
        }

        public int Count() => _cards.Count;

        public Card Draw()
        {
            if (_cards.IsEmpty()) Restore();

            var card = _cards.RandomAt();
            _cards.Remove(card);
            return card;
        }

        public bool HasCard() => _cards.Any();

        public bool IsEmpty() => _cards.IsEmpty();

        public void Restore()
        {
            _cards.Clear();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in Enumerable.Range(1, 13)) _cards.Add(new Card(suit, rank));
            }
        }
    }
}
