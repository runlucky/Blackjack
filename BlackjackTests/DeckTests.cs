using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Tests
{
    [TestClass]
    public class DeckTests : TestBase
    {
        [TestMethod]
        public void 全カード取得してみた()
        {
            var deck = new Deck();
            deck.Count().Is(52);
        }
    }
}
