using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyMoneyMoney;

namespace Kata.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase]
        public void GetNumberOfYears0()
        {
            Assert.AreEqual(0, MoneyMoneyMoney.Kata.CalculateYears(1000, 0.05, 0.18, 1000));
        }

        [TestCase]
        public void GetNumberOfYears1()
        {
            Assert.AreEqual(14, MoneyMoneyMoney.Kata.CalculateYears(1000, 0.01625, 0.18, 1200));
        }
    }
}
