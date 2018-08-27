using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Disaster.Core;

namespace Zoo_Disaster.Tests
{
    [TestFixture]
    public class DinglemouseTests
    {
        [TestCase("fox,bug,chicken,grass,sheep",
          new string[] {"fox,bug,chicken,grass,sheep",
          "chicken eats bug",
          "fox eats chicken",
          "sheep eats grass",
          "fox eats sheep",
          "fox"})]
        [TestCase("bear,grass,grass,grass,grass,sheep,bug,chicken,little-fish,little-fish,little-fish,little-fish,big-fish,big-fish,big-fish",
          new string[] { "bear,grass,grass,grass,grass,sheep,bug,chicken,little-fish,little-fish,little-fish,little-fish,big-fish,big-fish,big-fish",
              "sheep eats grass",
              "sheep eats grass",
              "sheep eats grass",
              "sheep eats grass",
              "bear eats sheep",
              "bear eats bug",
              "bear eats chicken",
              "big-fish eats little-fish",
              "big-fish eats little-fish",
              "big-fish eats little-fish",
              "big-fish eats little-fish",
              "bear eats big-fish",
              "bear eats big-fish",
              "bear eats big-fish",
              "bear" })]
        public void IsShowingProperlyWhoEatsWhoAndWhoLeft(string input, string[] expectedResult)
        {
            //Dinglemouse cut = new Dinglemouse();
            Assert.AreEqual(Dinglemouse.WhoEatsWho(input), expectedResult);
        }
        [TestCase("fox,chicken,tree,chicken,bug,banana,bug,bear",
          new string[] { "fox,chicken,tree,chicken,bug,banana,bug,bear",
              "fox eats chicken",
              "chicken eats bug",
              "bear eats bug",
              "fox,tree,chicken,banana,bear" })]
        public void KnowsAndUnknowThing(string input, string[] expectedResult)
        {
            //Dinglemouse cut = new Dinglemouse();
            Assert.AreEqual(Dinglemouse.WhoEatsWho(input), expectedResult);
        }

        [TestCase("fox,grass,chicken,lion,panda",
          new string[] { "fox,grass,chicken,lion,panda",
              "fox,grass,chicken,lion,panda" })]
        public void NobodyEatsAnything(string input, string[] expectedResult)
        {
            //Dinglemouse cut = new Dinglemouse();
            Assert.AreEqual(Dinglemouse.WhoEatsWho(input), expectedResult);
        }

        [TestCase("wtf",
          new string[] { "wtf",
              "wtf" })]
        public void SingleUnknownThings(string input, string[] expectedResult)
        {
            //Dinglemouse cut = new Dinglemouse();
            Assert.AreEqual(Dinglemouse.WhoEatsWho(input), expectedResult);
        }
    }
}
