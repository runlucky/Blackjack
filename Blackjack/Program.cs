using Blackjack.Hand;
using System;

namespace Blackjack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var table = new Table();
            do
            {
                table.StartGame();
            } while (table.ShouldContinue());
        }
    }
}
