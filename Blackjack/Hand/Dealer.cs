using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Hand
{
    internal class Dealer : HandBase
    {
        public override void ShowHand() => Console.WriteLine($"Dealer points is {Point()}.");

        public bool ShouldDraw() => Point() < 17;

        public override void Setup(Deck deck)
        {
            RefreshHand();

            var card = deck.Draw();
            Console.WriteLine($"Dealer Draw Cards: {card.Show()}, ?");
            AddCard(card);
            AddCard(deck.Draw());
        }
    }
}
