using Blackjack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Tests
{
    [TestClass]
    public class CardTests : TestBase
    {
        [TestMethod]
        [TestCase(1, "A")]
        [TestCase(2, "2")]
        [TestCase(10, "10")]
        [TestCase(11, "J")]
        [TestCase(12, "Q")]
        [TestCase(13, "K")]
        public void ランクの文字列取得()
        {
            TestContext.Run((int rank, string output) =>
            {
                var card = new Card(Suit.Club, rank);
                var aa = (card.AsDynamic().ShowRank() as string);
                aa.Is(output);
            });
        }

        [TestMethod]
        [TestCase(Suit.Spade, 1, "♠A")]
        [TestCase(Suit.Club, 2, "♣2")]
        [TestCase(Suit.Diamond, 10, "♦10")]
        [TestCase(Suit.Heart, 13, "♥K")]
        public void 表示正しいよね()
        {
            TestContext.Run((Suit suit, int rank, string output) =>
            {
                var card = new Card(suit, rank);
                card.Show().Is(output);
            });
        }
    }
}
