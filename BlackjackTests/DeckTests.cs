using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void カード引いてみた()
        {
            var deck = new Deck();
            var card = deck.Draw();
        }

        [TestMethod]
        public void カード53枚引く()
        {
            var deck = new Deck();
            foreach (var v in Enumerable.Range(1, 53)) deck.Draw().IsNotNull();
        }
    }
}
