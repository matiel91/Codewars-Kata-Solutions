using Find_The_Odd_Int;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddInT.Tests
{
    [TestFixture]
    public class Class1
    {
    [Test]
    public void isShowingProperlyOddIntAmount()
    {
        var kata = new Kata();

        int[] testInput = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
        Assert.AreEqual(5, kata.find_it(testInput));
    }

    }
}

