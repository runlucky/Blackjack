using System;
namespace Blackjack.Cards.Card
{
    internal class Rank
    {
        private readonly int _rank;

		public Rank(int rank)
		{
            _rank = rank;
		}

        public string Show()
        {
            switch (_rank)
            {
                case 1: return "A";
                case 11: return "J";
                case 12: return "Q";
                case 13: return "K";
                default: return _rank.ToString();
            }
        }

        public int Point() => Math.Min(_rank, 10);

        public bool IsAce() => _rank == 1;

    }
}
