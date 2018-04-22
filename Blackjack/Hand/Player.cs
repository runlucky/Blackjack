using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Hand
{
    internal class Player : HandBase
    {
        public override void Setup(Deck deck)
        {
            RefreshHand();
            Console.Write("Player Draw Cards: ");

            AddCard(deck.Draw());
            Console.Write(", ");
            AddCard(deck.Draw());
            Console.WriteLine("");
        }

        public override void AddCard(Card card)
        {
            Console.Write(card.Show());
            base.AddCard(card);
        }

        public override void ShowHand() => Console.WriteLine($"Your points is {Point()}.");
    }
}
