using Blackjack.Cards;
using Blackjack.Cards.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    internal class NullCard : ICard, NullObject
    {
        public string Show() => "";

        public int Point() => 0;
    }
}
