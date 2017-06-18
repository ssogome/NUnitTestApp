using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using NUnitTestApp;

namespace NUnitTestApp.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        ICalculator sut;

        [TestFixtureSetUp]
        public void TestSetUp()
        {
            sut = new Calculator();
        }

        //Simultaneous tests
        [TestCase(1,2,3)]
        [TestCase(1,-2,1)]
        public void multipleShouldAddTests(int x, int y, int result)
        {
            int expectedResult = sut.Add(x, y);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [Test]
        public void ShouldAddTwoNumbers()
        {
            //ICalculator sut = new Calculator();
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
           // ICalculator sut = new Calculator();
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        [TestFixtureTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}
