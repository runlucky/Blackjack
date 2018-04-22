using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Cards
{
    internal interface ICard
    {
        string Show();
        int ToNumber();
    }
}
