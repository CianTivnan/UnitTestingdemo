using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestingdemo.MyProject; // note we must reference the project we are testing

namespace UnitTestdemo.MyProject.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public static void Test1()
        {
            // arrange
            Calculator c = new Calculator();
            // act
            int actualResult = c.Add(3, 4);
            // assert
            Assert.That(actualResult, Is.EqualTo(7));


        }

        [Test]
        public static void Test2()
        {
            // arrange
            Calculator c = new Calculator();
            // act
            int actualResult = c.Add(0, 0);
            // assert
            Assert.That(actualResult, Is.EqualTo(0));


        }

        // we can also group a number of tests togetheras paramatarised tests cases
        [TestCase(5,5,ExpectedResult = 10)]
        [TestCase(1, 5, ExpectedResult = 6)]
        public static int Test3(int n1, int n2)
        {
            // arrange
            Calculator c = new Calculator();
            // act
            int actualResult = c.Add(n1, n2);
            // assert
            return actualResult;


        }
    }
}

