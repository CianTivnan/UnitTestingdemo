using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Question4;

namespace Q4Tests
{
    [TestFixture]
    public class DivisibleNbTests
    {

        [Test]
        public void Test1()
        {
            Assert.That(Program.CalculateTip(10, "terrible"), Is.EqualTo(0));
        }
        [Test]
        public void Test2()
        {
            Assert.That(Program.CalculateTip(10, "GoOd"), Is.EqualTo(1));
        }
        [Test]
        public void Test3()
        {
            Assert.That(Program.CalculateTip(100, "EXCELLENT"), Is.EqualTo(20));
        }
        [Test]
        public void Test4()
        {
            Assert.That(Program.CalculateTip(20, "good"), Is.EqualTo(2));
        }
        [Test]
        public void Test5()
        {
            Assert.That(Program.CalculateTip(10, "hello"), Is.EqualTo(-10));
        }
    }
}
