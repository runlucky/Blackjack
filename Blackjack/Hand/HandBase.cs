using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Hand
{
    internal abstract class HandBase : IHand
    {
        private List<Card> _cards = new List<Card>();

        public virtual void AddCard(Card card) => _cards.Add(card);

        public void Hit(Card card)
        {
            AddCard(card);
        }

        public int Point() => _cards.Select(x => x.Point()).Sum();

        public bool IsBust() => Point() > 21;

        public void RefreshHand() => _cards.Clear();

        public abstract void ShowHand();

        public abstract void Setup(Deck deck);

        public string CardList() => string.Join(" ", _cards.Select(x => x.Show()));
    }
}
