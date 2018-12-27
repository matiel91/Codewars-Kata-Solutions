using NUnit.Framework;
using System;

namespace Kata.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", Kata.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", Kata.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Kata.TowerBuilder(3)));
        }

        [Test]
        public void isFirstFloorCalculatedProperly()
        {
            Assert.AreEqual(1, Kata.NumberOfCharsInFirstFloor(1));
            Assert.AreEqual(2, Kata.NumberOfCharsInFirstFloor(3));
            Assert.AreEqual(3, Kata.NumberOfCharsInFirstFloor(5));
            Assert.AreEqual(4, Kata.NumberOfCharsInFirstFloor(7));
            Assert.AreEqual(5, Kata.NumberOfCharsInFirstFloor(9));
            Assert.AreEqual(6, Kata.NumberOfCharsInFirstFloor(11));

        }
    }
}
