using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal interface IDeck
    {
        int Count();

        bool IsEmpty();

        bool HasCard();

        Card Draw();

        void Refill();
    }
}
