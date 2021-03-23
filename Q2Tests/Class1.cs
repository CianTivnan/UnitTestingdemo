using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Question2; // note we must reference the project we are testing


namespace Q2Tests
{
    [TestFixture]
    public class DivisibleNbTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, Program.IsDivisible(12, 4, 3));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, Program.IsDivisible(3, 3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, Program.IsDivisible(8, 3, 4));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, Program.IsDivisible(3, 3, 4));
        }

    }

}
