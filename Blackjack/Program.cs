using Blackjack.Hand;
using System;

namespace Blackjack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var deck = new Deck();

            Console.WriteLine("Game start");

            var player = new Player();
            Console.WriteLine(player.AddCard(deck.Draw()));
            Console.WriteLine(player.AddCard(deck.Draw()));
            Console.WriteLine(player.ShowHand());

            Console.Write("more draw? (y/n)");
            while (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine(player.AddCard(deck.Draw()));
                Console.WriteLine(player.ShowHand());
                Console.Write("more draw? (y/n)");
            }

            var dealer = new Dealer();
            Console.WriteLine(dealer.AddCard(deck.Draw()));
            Console.WriteLine(dealer.AddCard(deck.Draw()));
            Console.WriteLine(dealer.ShowHand());

            while (dealer.ShouldDraw())
            {
                Console.WriteLine(dealer.AddCard(deck.Draw()));
                Console.WriteLine(dealer.ShowHand());
            }

            if (player.Point() > dealer.Point())
            {
                Console.WriteLine("you win.");
            }
            else
            {
                Console.WriteLine("you loose.");
            }

            Console.ReadKey();
        }
    }
}
