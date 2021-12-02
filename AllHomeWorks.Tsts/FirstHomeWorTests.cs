using NUnit.Framework;
using FirstHomeWork;
using System;

namespace AllHomeWorks.Tests
{
    public class FirstHomeWorTests
    {
        private FirstHW _hw1;

        [SetUp]
        public void Setup()
        {
            _hw1 = new FirstHW();
        }

        [TestCase(5, 9, 26.5)]
        public void SolveExampleFirstTaskTest(double a, double b, double expected)
        {
            //arrange

            //act
            double actual = _hw1.SolveExampleFirstTask(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 6)]
        public void SolveExampleFirstTaskNegativeTest(double a, double b)
        {
            //arrange

            //act,assert
            Assert.Throws<DivideByZeroException>(() => _hw1.SolveExampleFirstTask(a, b));
        }

        [TestCase(30, 6, new int[] { 5, 6 })]
        [TestCase(30, 4, new int[] { 7, 4 })]
        public void DivideAByBTest(int a, int b, int[] expected)
        {
            int[] actual = _hw1.DivideAByB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(30, 0)]
        [TestCase(4, 30)]
        public void DivideAByBNegativeTest(int a, int b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _hw1.DivideAByB(a, b));
        }

        [TestCase(2, 4, 10, 3)]
        [TestCase(3, 4, 10, 2)]
        public void SolveExampleSecondTaskTest(double a, double b, double c, double expected)
        {
            double actual = _hw1.SolveExampleSecondTask(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 2)]
        public void SolveExampleSecondTaskNegativeTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentNullException>(() => _hw1.SolveExampleSecondTask(a, b, c));
        }

        [TestCase(5, 5, 6, 5, " Y = 5")]
        [TestCase(5, 5, 6, 6, " Y = 1X")]
        [TestCase(9, 3, 8, 4, " Y = -1X + 12 ")]
        [TestCase(8, 3, 9, 4, " Y = 1X - 5")]
        public void FindAnEquationTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = _hw1.FindAnEquation(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5, 5, 5)]
        public void FindAnEquationNegativeTest(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _hw1.FindAnEquation(x1, y1, x2, y2));
        }
    }
}