using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Player
{
    internal class Hand : IHand
    {
        private readonly List<Card> _cards = new List<Card>();

        public virtual void AddCard(Card card) => _cards.Add(card);

        public int Point() => _cards.Select(x => x.Point()).Sum();

        public bool IsBust() => Point() > 21;

        public void RefreshHand() => _cards.Clear();

        public string ShowCards() => string.Join(" ", _cards.Select(x => x.Show()));

        public string ShowFirstCard() => _cards.FirstOrDefault()?.Show() ?? "";
    }
}
