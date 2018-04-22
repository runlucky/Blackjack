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

        public abstract void ShowHand();

        public void Deal(Deck deck)
        {
            hand.Discard();;
            Hit(deck.Draw());
            Hit(deck.Draw());
        }

        protected string CardList() => hand.ShowCards();
    }
}
