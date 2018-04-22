using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Hand
{
    internal interface IHand
    {
        string AddCard(Card card);

        int Point();

        void RefreshHand();
    }
}
