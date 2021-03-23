using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Question3; // note we must reference the project we are testing

namespace Q3Tests
{
    [TestFixture]
    public class DivisibleNbTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(false, Program.Divide(2));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, Program.Divide(3));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, Program.Divide(4));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, Program.Divide(5));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(true, Program.Divide(6));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(true, Program.Divide(10));
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(true, Program.Divide(12));
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(true, Program.Divide(16));
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(true, Program.Divide(100));
        }
        [Test]
        public void Test10()
        {
            Assert.AreEqual(false, Program.Divide(15));
        }

    }
}
