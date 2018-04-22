using Blackjack.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal enum Suit
    {
        Spade,
        Club,
        Diamond,
        Heart
    }

    internal class Card: ICard
    {
        private Suit _suit;
        private int _rank; 


        public Card(Suit suit, int rank)
        {
            _suit = suit;
            _rank = rank;
        }

        public string Show()
        {

            Console.WriteLine(ShowSuit() + ShowRank());
            throw new NotImplementedException();
        }

        private string ShowRank()
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

        private string ShowSuit()
        {
            switch (_suit)
            {
                case Suit.Spade: return "♠";
                case Suit.Club: return "♣";
                case Suit.Diamond: return "♦";
                case Suit.Heart: return "♥";
                default: return "";
            }
        }

        public int ToNumber()
        {
            throw new NotImplementedException();
        }
    }
}
