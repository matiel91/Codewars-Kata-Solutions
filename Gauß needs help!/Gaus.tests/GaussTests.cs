using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauß_needs_help_;

namespace Gaus.tests
{
    [TestFixture]
    public class GaussTests
    {
        //Test for 1st solution
        [TestCase(100L, 5050L)]
        [TestCase(300L, 45150L)]
        [TestCase(50000L, 1250025000L)]
        public void isCalculateProperly(long input, long expectedResult)
        {
            Assert.AreEqual(expectedResult, Kata.RangeSum(input));

        }
        //Test for second solution
        [TestCase(100L, 5050L)]
        [TestCase(300L, 45150L)]
        [TestCase(50000L, 1250025000L)]
        public void isCalculateProperly2(long input, long expectedResult)
        {
            Assert.AreEqual(expectedResult, Kata.RangeSumWithMathFormula(input));

        }
        //Test for third solution
        [TestCase(100L, 5050L)]
        [TestCase(300L, 45150L)]
        [TestCase(50000L, 1250025000L)]
        public void isCalculateProperly3(long input, long expectedResult)
        {
            Assert.AreEqual(expectedResult, Kata.RangeSumWithMathFormula2(input));

        }
    }
}
