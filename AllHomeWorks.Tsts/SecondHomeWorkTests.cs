using NUnit.Framework;
using System;
using SecondHomeWork;

namespace AllHomeWorks.Tests
{
    public class SecondHomeWorkTests
    {
        private SecondHW _hw2;

        [SetUp]
        public void Setup()
        {
            _hw2 = new SecondHW();
        }

        [TestCase(6, 6, "при A = B , A * B = 36")]
        [TestCase(7, 6, "при A > B , A + B = 13")]
        [TestCase(6, 7, "при A < B , A - B = -1")]
        public void FindASolutionByConditionTest(double a, double b, string expected)
        {
            //arrange

            //act
            string actual = _hw2.FindASolutionByCondition(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 3, 8)]
        [TestCase(0, -3, 6)]
        [TestCase(3, 3, 1)]
        [TestCase(3, 0, 7)]
        [TestCase(3, -3, 4)]
        [TestCase(-3, -3, 3)]
        [TestCase(-3, 0, 5)]
        [TestCase(-3, 3, 2)]
        public void SearchQuarterXAndSearchQuarterYTest(double x, double y, int expected)
        {
            //arrange

            //act
            int actual = _hw2.SearchQuarterX(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, " начальной точке Оси координат.")]
        [TestCase(8, " верхней части Оси Y.")]
        [TestCase(6, " нижней части Оси Y.")]
        [TestCase(1, " I четверти Оси координат.")]
        [TestCase(7, " правой части Оси X.")]
        [TestCase(4, " IV четверти Оси координат.")]
        [TestCase(3, " III четверти Оси координат.")]
        [TestCase(2, " II четверти Оси координат.")]
        [TestCase(5, " левой части Оси X.")]
        public void ReturnTheMessageWithTheResultTest(int a, string expected)
        {
            //arrange

            //act
            string actual = _hw2.ReturnTheMessageWithTheResult(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 1, "1 2 3")]
        [TestCase(3, 1, 2, "1 2 3")]
        [TestCase(1, 3, 2, "1 2 3")]
        [TestCase(2, 3, 1, "1 2 3")]
        [TestCase(1, 2, 3, "1 2 3")]
        [TestCase(2, 1, 3, "1 2 3")]
        public void SortVariablesAscendingTest(double a, double b, double c, string expected)
        {
            //arrange

            //act
            string actual = _hw2.SortVariablesAscending(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 4, 2, new double[] {-1})]
        [TestCase(2, 11, 5, new double[] { -0.5, -5 })]
        public void SolveSquareEquationTest(double a, double b, double c, double[] expected)
        {
            //arrange

            //act
            double[] actual = _hw2.SolveSquareEquation(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 6, 3)]
        public void SolveSquareEquationNegativeTest(double a, double b, double c)
        {
            //arrange

            //act,assert
            Assert.Throws<ArithmeticException>(() => _hw2.SolveSquareEquation(a, b, c));
        }

        [TestCase(10, "Десять")]
        [TestCase(27, "Двадцать Семь")]
        public void ReturnTheAlphabeticDesignationOfANumberTest(int a, string expected)
        {
            //arrange

            //act
            string actual = _hw2.ReturnTheAlphabeticDesignationOfANumber(a);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(6)]
        [TestCase(110)]
        public void ReturnTheAlphabeticDesignationOfANumberNegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _hw2.ReturnTheAlphabeticDesignationOfANumber(a));
        }
    }
}
