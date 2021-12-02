using NUnit.Framework;
using System;
using FifthHomeWork;

namespace AllHomeWorks.Tests
{
    public class FifthHomeWorkTests
    {
        private FifthHW _hw5;

        [SetUp]
        public void Setup()
        {
            _hw5 = new FifthHW();
        }

        [TestCase(0, "1[ 1;1 ]")]
        public void SearchMinElementAndItsIndexTest(int arrayIndex, string expected)
        {
            //arrange
            int[,] actualArray = TestDataFifthHW.GetArrayForTest(arrayIndex);
            
            //act
            string actual = _hw5.SearchMinElementAndItsIndex(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, " 6[ 1;2 ]")]
        public void SearchMaxElementAndItsIndexTest(int arrayIndex, string expected)
        {
            //arrange
            int[,] actualArray = TestDataFifthHW.GetArrayForTest(arrayIndex);

            //act
            string actual = _hw5.SearchMaxElementAndItsIndex(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "2: 8 [0,1] ; 9 [2,2] ;")]
        public void GetElementsLargerThanNeighborsTest(int arrayIndex, string expected)
        {
            //arrange
            int[,] actualArray = TestDataFifthHW.GetArrayForTest(arrayIndex);

            //act
            string actual = _hw5.GetElementsLargerThanNeighbors(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2)]
        [TestCase(3)]
        public void FlipAnArrayAlongTheMainDiagonal(int arrayIndex)
        {
            //arrange
            int[,] actual = TestDataFifthHW.GetArrayForTest(arrayIndex);
            int[,] expected = TestDataFifthHW.GetExpectedArrayForTest(arrayIndex);

            //act
            _hw5.FlipAnArrayAlongTheMainDiagonal(actual);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
