using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Player
{
    internal class Challenger : PlayerBase
    {
        public override void ShowHand() => Console.WriteLine($"Your Hand : {CardList()} ({Point()})");

        public void Action(Deck deck)
        {
            while (ShouldHit())
            {
                Hit(deck.Draw());
                ShowHand();
                if (IsBust()) return;
            }
        }

        private bool ShouldHit()
        {
            Console.WriteLine("Hit or Stand? (h/s)");

            try
            {
                while (true)
                {
                    var key = Console.ReadKey().Key;
                    if (key == ConsoleKey.H) return true;
                    if (key == ConsoleKey.S) return false;
                }
            }
            finally
            {
                Console.WriteLine("\n");
            }
        }
    }
}
