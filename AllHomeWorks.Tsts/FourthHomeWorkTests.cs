using NUnit.Framework;
using System;
using FourthHomeWork;

namespace AllHomeWorks.Tests
{
    public class FourthHomeWorkTests
    {
        private FourthHW _hw4;

        [SetUp]
        public void Setup()
        {
            _hw4 = new FourthHW();
        }

        [TestCase(new int[] { 1, 3, 5 }, "1[0]")]
        public void SearchMinElementAndItsIndexTest(int[] array, string expected)
        {
            //arrange

            //act
            string actual = _hw4.SearchMinElementAndItsIndex(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5 }, "5[2]")]
        public void SearchMaxElementAndItsIndexTest(int[] array, string expected)
        {
            //arrange

            //act
            string actual = _hw4.SearchMaxElementAndItsIndex(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        public void FindTheSumOddIndexedElementsTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.FindTheSumOddIndexedElements(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 4 }, new int[] { 4, 5, 3, 1 })]
        public void ReverseTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.Reverse(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { 1, 3, 5, 4 }, 3)]
        [TestCase(new int[] { 2, 6, 12, 8 }, 0)]
        public void GetCountOfOddElementsTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetCountOfOddElements(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 5, 3, 4 }, new int[] { 3, 4, 5, 1, 2 })]
        public void SwapTheFirstAndSecondHalfOfTheArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SwapTheFirstAndSecondHalfOfTheArray(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { 5, 4, 3, 1 }, new int[] { 1, 3, 4, 5 })]
        public void SortArrayAscendingUsingSelectTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SortArrayAscendingUsingSelect(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { 4, 5, 1, 3 }, new int[] { 5, 4, 3, 1 })]
        public void SortArrayDescendingUsingInsertTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SortArrayDescendingUsingInsert(array);

            //assert
            Assert.AreEqual(expected, array);
        }
    }
}
