using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Program.Core;

namespace Program.Tests
{

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTest()
        {
            var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
            Assert.AreEqual(12, Kata.HighestRank(arr));
        }
        [Test]
        public void BasicTest2()
        {
            var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10,  };
            Assert.AreEqual(12, Kata.HighestRank(arr));
        }
        [Test]
        public void BasicTest3()
        {
            var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 8, 8, 8, 8 };
            Assert.AreEqual(8, Kata.HighestRank(arr));
        }
    }
}
