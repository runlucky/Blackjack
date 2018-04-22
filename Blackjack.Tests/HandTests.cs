using Blackjack.Player;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Tests
{
    [TestClass]
    public class HandTests : TestBase
    {
        private Hand _hand;

        [TestInitialize]
        public void HandTestInitialize()
        {
            _hand = new Hand();
        }

        [TestMethod]
        [TestCase(new[] { 2, 10 }, 12)]
        [TestCase(new[] { 2, 3, 4, 5, 6 }, 20)]
        [TestCase(new[] { 1, 10 }, 21)]
        [TestCase(new[] { 2, 13 }, 12)]
        [TestCase(new[] { 1, 1 }, 12)]
        [TestCase(new[] { 1, 1, 10 }, 12)]
        [TestCase(new[] { 1, 1, 9 }, 21)]
        [TestCase(new[] { 11, 12, 13 }, 30)]
        [TestCase(new[] { 10, 10, 1 }, 21)]
        public void 正しく点数計算できるかな()
        {
            TestContext.Run((int[] ranks, int point) =>
            {
                _hand.RefreshHand();
                foreach (var v in ranks) _hand.AddCard(new Card(Suit.Club, v));
                _hand.Point().Is(point);
            });
        }
    }
}
