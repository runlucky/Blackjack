using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Hand
{
    internal class Player : HandBase
    {
        public override string ShowHand()
        {
            return "your points is " + Point();
        }
    }
}
