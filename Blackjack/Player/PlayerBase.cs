using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Player
{
    internal abstract class PlayerBase
    {
        protected readonly Hand hand = new Hand();

        public void Hit(Card card) => hand.AddCard(card);

        public int Point() => hand.Point();

        public bool IsBust() => hand.IsBust();

        public void RefreshHand() => hand.RefreshHand();

        public abstract void ShowHand();

        public void Deal(Deck deck)
        {
            RefreshHand();
            Hit(deck.Draw());
            Hit(deck.Draw());
        }

        public string CardList() => hand.ShowCards();
    }
}
