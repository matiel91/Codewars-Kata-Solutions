using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitCounting;

namespace BitCount.Tests
{   [TestFixture]
    public class BitCountTests
    {
        [TestCase(0, 0)]
        [TestCase(4, 1)]
        [TestCase(7, 3)]
        [TestCase(9, 2)]
        [TestCase(10, 2)]
        public void isBitCountedPreoperly(int i, int r)
        {
            var expectedResult = Kata.CountBits(i);
            Assert.AreEqual(r, actual: expectedResult);

        }
        [Test]
        public void CountBits()
        {
            Assert.AreEqual(0, Kata.CountBits(0));
            Assert.AreEqual(1, Kata.CountBits(4));
            Assert.AreEqual(3, Kata.CountBits(7));
            Assert.AreEqual(2, Kata.CountBits(9));
            Assert.AreEqual(2, Kata.CountBits(10));
        }
        [TestCase(0, 0)]
        [TestCase(4, 1)]
        [TestCase(7, 3)]
        [TestCase(9, 2)]
        [TestCase(10, 2)]
        public void isBitCountedPreoperly2(int i, int r)
        {
            var expectedResult = Kata.CountBits2(i);
            Assert.AreEqual(r, actual: expectedResult);

        }

    }
}
