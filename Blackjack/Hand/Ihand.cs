using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Hand
{
    internal interface IHand
    {
        void AddCard(Card card);

        int Point();

        void RefreshHand();
    }
}
