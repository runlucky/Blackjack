using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Tests
{
    [TestClass]
    public abstract class TestBase
    {
        public TestContext TestContext { get; set; }
    }
}
