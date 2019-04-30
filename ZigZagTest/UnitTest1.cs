using System;
using NUnit.Framework;

namespace ZigZagTest
{
    [TestFixture]
    public class ZigZagTest
    {
        [Test]
        public void Case1()
        {
            var solution = new ZigZagConversion.ZigZagConversion();
            Assert.AreEqual("aaaa", solution.Convert("aaaa", 1));
        }

        [Test]
        public void Case2()
        {
            var solution = new ZigZagConversion.ZigZagConversion();
            Assert.AreEqual("PAHNAPLSIIGYIR", solution.Convert("PAYPALISHIRING", 3));
        }

        [Test]
        public void Case3()
        {
            var solution = new ZigZagConversion.ZigZagConversion();
            Assert.AreEqual("PINALSIGYAHRPI", solution.Convert("PAYPALISHIRING", 4));
        }
    }
}
