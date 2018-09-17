using NextBigerNumberWithTheSameDigits.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBigerNumberWithTheSameDigits.Test
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(987654321, -1)]
        [TestCase(59884848459853, 59884848483559)]
        [TestCase(769836694, 769836946)]
        public void isCalculatingProperly(long input, long result)
        {
            Assert.AreEqual(Kata.NextBiggerNumber(input), result);
        }
    }
}
