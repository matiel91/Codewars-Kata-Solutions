using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tribonacci_Sequence;

namespace TribonacciSequence.Tests
{
    [TestFixture]
    public class Class1
    {
        [TestCase(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, new double[] { 1, 1, 1 }, 10)]
        [TestCase(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, new double[] { 0, 0, 1 }, 10)]
        [TestCase(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, new double[] { 0, 1, 1 }, 10)]
        public void Tests(double[] expectedResult, double[] inputArray,  int n)
        {
            Xbonacci xbonacci = new Xbonacci();
            Assert.AreEqual(expectedResult, xbonacci.Tribonacci(inputArray, n));
           
        }
    }
}
