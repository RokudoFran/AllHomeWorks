using NUnit.Framework;
using System;
using ThirdHomeWork;

namespace AllHomeWorks.Tests
{
    public class ThirdHomeWorkTests
    {
        private ThirdHW _hw3;

        [SetUp]
        public void Setup()
        {
            _hw3 = new ThirdHW();
        }

        [TestCase(6, 2, 36)]
        [TestCase(10, -2, 0.01)]
        [TestCase(6, 0, 1)]
        public void RaiseNumberAToPowerBTest(double a, int b, double expected)
        {
            //arrange

            //act
            double actual = _hw3.RaiseNumberAToPowerB(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,6)]
        public void RaiseNumberAToPowerBNegativeTest(double a, int b)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentNullException>(() => _hw3.RaiseNumberAToPowerB(a,b));
        }

        [TestCase(500, new int[] {500, 1000})]
        public void GetNumbersDivisibleByATest(int a, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw3.GetNumbersDivisibleByA(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1001)]
        public void GetNumbersDivisibleByANegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _hw3.GetNumbersDivisibleByA(a));
        }

        [TestCase(20, 4)]
        public void FindTheSomeNumberOfPositiveIntegersWhoseSquareIsLessThanATest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindTheSomeNumberOfPositiveIntegersWhoseSquareIsLessThanA(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-200)]
        public void FindTheSomeNumberOfPositiveIntegersWhoseSquareIsLessThanANegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _hw3.FindTheSomeNumberOfPositiveIntegersWhoseSquareIsLessThanA(a));
        }

        [TestCase(100, 50)]
        public void FindGreatestDivisorTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindGreatestDivisor(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FindGreatestDivisorNegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentNullException>(() => _hw3.FindGreatestDivisor(a));
        }

        [TestCase(0, 9, 7)]
        [TestCase(10, 0, 7)]
        public void FindMultiplesOfSevenTest(int a,int b, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindMultiplesOfSeven(ref a, ref b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        public void FindMultiplesOfSevenNegativeTest(int a, int b)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentNullException>(() => _hw3.FindMultiplesOfSeven(ref a, ref b));
        }

        [TestCase(7, 13)]
        [TestCase(-7, 13)]
        public void FindFibonacciNumberTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindFibonacciNumber(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 16, 8)]
        public void FindGreatestCommonDivisorOfTwoIntegersTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindGreatestCommonDivisorOfTwoIntegers( a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(0, 16)]
        [TestCase(16, 0)]
        public void FindGreatestCommonDivisorOfTwoIntegersNegativeTest(int a, int b)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentException>(() => _hw3.FindGreatestCommonDivisorOfTwoIntegers(a, b));
        }

        [TestCase(27, 3)]
        public void FindTheRootOfACubeByHalfDivisionTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindTheRootOfACubeByHalfDivision(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-27)]
        public void FindTheRootOfACubeByHalfDivisionNegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentException>(() => _hw3.FindTheRootOfACubeByHalfDivision(a));
        }

        [TestCase(27, 1)]
        [TestCase(22, 0)]
        [TestCase(273, 2)]
        public void FindTheSomeOddDigitsOfANumberTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindTheSomeOddDigitsOfANumber(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FindTheSomeOddDigitsOfANumberNegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentNullException>(() => _hw3.FindTheSomeOddDigitsOfANumber(a));
        }

        [TestCase(27, 72)]
        [TestCase(-27, -72)]
        [TestCase(273, 372)]
        [TestCase(-273, -372)]
        public void SearchBackwardNumberTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.SearchBackwardNumber(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void SearchBackwardNumberNegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentNullException>(() => _hw3.SearchBackwardNumber(a));
        }

        [TestCase(14, " 2 ; 4 ; 6 ; 8 ; 12 ; 14 ;")]
        public void FindNumbersByConditionTest(int a, string expected)
        {
            //arrange

            //act
            string actual = _hw3.FindNumbersByCondition(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-27)]
        public void FindNumbersByConditionNegativeTest(int a)
        {
            //arrange

            //act,assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _hw3.FindNumbersByCondition(a));
        }

        [TestCase(14, 31, "YES")]
        [TestCase(-143, 31, "YES")]
        [TestCase(44, -31, "NO")]
        [TestCase(-445, -361, "NO")]
        public void CheckForDuplicateNumbers(int a, int b, string expected)
        {
            //arrange

            //act
            string actual = _hw3.CheckForDuplicateNumbers(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
