using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Player
{
    internal class Dealer : PlayerBase
    {
        public override void ShowHand() => Console.WriteLine($"Dealer Hand : {CardList()} ({Point()})");

        public void ShowFirstHand() => Console.WriteLine($"Dealer Hand : {hand.ShowFirstCard()} ?");

        public bool ShouldDraw() => Point() < 17;

        public void Action(Deck deck)
        {
            while (ShouldDraw()) Hit(deck.Draw());
            ShowHand();
        }
    }
}
