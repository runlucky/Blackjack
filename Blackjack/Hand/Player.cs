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

        public void Action(Deck deck)
        {
            while (ShouldHit())
            {
                Hit(deck.Draw());
                if (IsBust()) return;
            }
        }

        private bool ShouldHit()
        {
            Console.WriteLine("");
            ShowHand();
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
                Console.WriteLine("");
            }
        }

        public override void ShowHand() => Console.WriteLine($"Your Hand : {CardList()} ({Point()})");
    }
}
