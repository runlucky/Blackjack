using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal interface IDeck
    {
        bool IsEmpty();
        bool HasCard();
        Card Draw();
        void Restore();
    }
}
