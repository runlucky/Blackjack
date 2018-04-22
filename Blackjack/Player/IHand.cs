using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Player
{
    internal interface IHand
    {
        void AddCard(Card card);

        bool IsBust();

        int Point();

        void RefreshHand();
    }
}
