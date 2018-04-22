using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Hand
{
    internal abstract class HandBase : IHand
    {
        private List<Card> _cards = new List<Card>();

        public string AddCard(Card card)
        {
            _cards.Add(card);
            return "draw: " + card.Show();
        }

        public int Point() => _cards.Select(x => x.Point()).Sum();

        public bool IsBust() => Point() > 21;

        public void RefreshHand() => _cards.Clear();

        public abstract string ShowHand();
    }
}
