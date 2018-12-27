using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata;

namespace Kata2.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", Kata.Kata.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", Kata.Kata.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Kata.Kata.TowerBuilder(3)));
        }

        [Test]
        public void isFirstFloorCalculatedProperly()
        {
            
            Assert.AreEqual(1, Kata.Kata.NumberOfCharsInFirstFloor(1));
            Assert.AreEqual(3, Kata.Kata.NumberOfCharsInFirstFloor(2));
            Assert.AreEqual(5, Kata.Kata.NumberOfCharsInFirstFloor(3));
            Assert.AreEqual(7, Kata.Kata.NumberOfCharsInFirstFloor(4));
            Assert.AreEqual(9, Kata.Kata.NumberOfCharsInFirstFloor(5));
            Assert.AreEqual(11, Kata.Kata.NumberOfCharsInFirstFloor(6));

        }
        [TestCase(1, Result = 1)]
        [TestCase(2, Result = 3)]
        [TestCase(3, Result = 5)]
        [TestCase(4, Result = 7)]
        [TestCase(5, Result = 9)]
        [TestCase(6, Result = 11)]
        public int isFirstFloorCalculatedProperly2(int f)
        {
            return Kata.Kata.NumberOfCharsInFirstFloor(f);
        }
    }
}
