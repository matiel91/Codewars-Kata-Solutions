using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vasya___Clerk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasya___Clerk.Tests
{
    [TestClass()]
    public class LineTests
    {
        [TestMethod()]
        public void TicketsTest()
        {
            Line line = new Line();
            int[] peopleInLine = { 25, 25, 25, 50, 100 };
            string properResult = "YES";
            string result =  line.Tickets(peopleInLine);


            Assert.AreEqual(properResult, result);
        }
    }
}