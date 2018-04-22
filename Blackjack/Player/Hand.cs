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

        public int Point(){
            var point = _cards.Select(x => x.Point()).Sum();
            foreach (var v in _cards.Where(x => x.Point() == 1))
            {
                if (point + 10 <= 21)
                {
                    point += 10;
                }
            }
            return point;
        }

        public bool IsBust() => Point() > 21;

        public void RefreshHand() => _cards.Clear();

        public string ShowCards() => string.Join(" ", _cards.Select(x => x.Show()));

        public string ShowFirstCard() => _cards.FirstOrDefault()?.Show() ?? "";
    }
}
