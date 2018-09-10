using MergedStringChecker.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergedStringChecker.Test
{
    [TestFixture]
    public class StringMergerTests
    {
        [Test]
        public void HappyPath1()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
        }

        [Test]
        public void HappyPath2()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
        }

        [Test]
        public void SadPath1()
        {
            Assert.IsFalse(StringMerger.isMerge("codewars", "cod", "wars"), "Codewars are not codwars");
        }
        [Test]
        public void CanHandleBananas()
        {
            Assert.IsTrue(StringMerger.isMerge("Bananas from Bahamas", "Bahas", "Bananas from am"));
        }
        [Test]
        public void CanHandleBananas2()
        {
            Assert.IsTrue(StringMerger.isMerge("Bananas from Bahamas", "Bananas from am", "Bahas"));
        }
        [Test]
        public void CanHandleEmpty()
        {
            Assert.IsFalse(StringMerger.isMerge("", "code", "wars"));
        }
        [Test]
        public void CanHandleEmpty2()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "codewars", ""));
        }
        [Test]
        public void CanHandleEmpty3()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "", "codewars"));
        }
        [Test]
        public void CanHandleExtraChars()
        {
            Assert.IsFalse(StringMerger.isMerge("codewars", "code", "warss"));
        }
        [Test]
        public void CanHandleTooFewChars()
        {
            Assert.IsFalse(StringMerger.isMerge("codewars", "code", "war"));
        }
        [Test]
        public void IsTrueInBelowCase0()
        {
            Assert.IsTrue(StringMerger.isMerge("Can we merge it? Yes, we can!", "n ee tYw n!", "Cawe mrgi? es, eca"));
        }
        [Test]
        public void IsTrueInBelowCase1()
        {
            Assert.IsTrue(StringMerger.isMerge("Can we", "n e", "Caw"));
        }
        [Test]
        public void IsTrueInBelowCase2()
        {
            Assert.IsTrue(StringMerger.isMerge("Bananas from Bahamas", "aa fomam", "Bnnasr Bhaas"));
        }
        [Test]
        public void IsTrueInBelowHardCase()
        {
            Assert.IsTrue(StringMerger.isMerge("Bananas from Bahamas", "anas as", "Ban fromBahma"));
        }
        [Test]
        public void IsTrueInBelowHardCase2()
        {
            Assert.IsTrue(StringMerger.isMerge("Bananas from Bahamas", "aans o Ba", "Bnafrmhamas"));
        }
        [Test]
        public void FalseForBananas()
        {
            Assert.IsFalse(StringMerger.isMerge("Bananas from Bahamas", "QsP Baamk", "Bbanhbfr3Ua"));
        }
    }
}
