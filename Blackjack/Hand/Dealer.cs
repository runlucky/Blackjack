using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Hand
{
    internal class Dealer : HandBase
    {
        public override string ShowHand()
        {
            return "dealer points is " + Point();
        }

        public bool ShouldDraw() => Point() < 17;
    }
}
