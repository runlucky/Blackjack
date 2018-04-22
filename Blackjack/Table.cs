using Blackjack.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal class Table
    {
        private readonly Deck _deck = new Deck();
        private readonly Challenger _challenger = new Challenger();
        private readonly Dealer _dealer = new Dealer();

        public void StartGame()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Game start.");

            _challenger.Deal(_deck);
            _challenger.ShowHand();
            _dealer.Deal(_deck);
            _dealer.ShowFirstHand();

            Console.WriteLine("");

            _challenger.Action(_deck);
            if (_challenger.IsBust())
            {
                Console.WriteLine("You Lose");
                return;
            }

            _dealer.Action(_deck);
            Console.WriteLine("");

            Console.WriteLine(Judge());
        }

        private string Judge()
        {
            if (IsPlayerWin()) return "You win!";
            else if (_challenger.Point() == _dealer.Point()) return "Draw Game...";
            else return "You Loose.";
        }

        private bool IsPlayerWin()
        {
            if (_dealer.IsBust()) return true;
            return _challenger.Point() > _dealer.Point();
        }

        public bool ShouldContinue()
        {
            Console.WriteLine("Continue? (y/n)");
            try
            {
                while (true)
                {
                    var key = Console.ReadKey().Key;
                    if (key == ConsoleKey.Y) return true;
                    if (key == ConsoleKey.N) return false;
                }
            }
            finally
            {
                Console.WriteLine("\n");
            }
        }
    }
}
