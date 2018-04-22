using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    internal class Deck : IDeck
    {
        private List<Card> _cards = new List<Card>();

        public Deck()
        {
            Restore();
        }

        public int Count() => _cards.Count;

        public Card Draw()
        {
            throw new NotImplementedException();
        }

        public bool HasCard()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

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
