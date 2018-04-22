using Blackjack.Hand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal class Table
    {
        private readonly Deck _deck = new Deck();
        private readonly Player _player = new Player();
        private readonly Dealer _dealer = new Dealer();

        public void StartGame()
        {
            Console.WriteLine("Game start.");

            _player.Setup(_deck);
            _dealer.Setup(_deck);

            PlayerAction();
            if (_player.IsBust())
            {
                Console.WriteLine("You Lose");
                return;
            }

            DealerAction();

            Console.WriteLine(Judge());
        }

        private string Judge()
        {
            if (IsPlayerWin()) return "You win!";
            else if (_player.Point() == _dealer.Point()) return "Draw Game...";
            else return "You Loose.";
        }

        private bool IsPlayerWin()
        {
            if (_dealer.IsBust()) return true;
            return _player.Point() > _dealer.Point();
        }

        private void PlayerAction()
        {
            while (ShouldHit())
            {
                _player.Hit(_deck.Draw());
                if (_player.IsBust()) return;
            }
        }

        private void DealerAction()
        {
            while (_dealer.ShouldDraw())
            {
                var card = _deck.Draw();
                Console.Write(card.Show() + ", ");
                _dealer.AddCard(_deck.Draw());
                _dealer.ShowHand();
            }
        }

        private bool ShouldHit()
        {
            Console.WriteLine("");
            _player.ShowHand();
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
                Console.WriteLine("");
            }
        }
    }
}
