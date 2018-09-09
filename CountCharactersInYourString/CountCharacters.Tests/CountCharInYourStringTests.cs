using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountCharactersInYourString;
namespace CountCharacters.Tests
{
    [TestFixture]
    public class CountCharInYourStringTests
    {
        [Test]
        public static void FixedTest_aaaa1st()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.AreEqual(d, Kata.Count("aaaa"));
        }

        [Test]
        public static void FixedTest_aabb1st()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.AreEqual(d, Kata.Count("aabb"));
        }

        [Test]
        public static void FixedTest_aaaa2nd()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.AreEqual(d, Kata.Count2("aaaa"));
        }

        [Test]
        public static void FixedTest_aabb2nd()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.AreEqual(d, Kata.Count2("aabb"));
        }
    }
}
