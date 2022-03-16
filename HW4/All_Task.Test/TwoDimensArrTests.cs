using NUnit.Framework;
using System;

namespace All_Task.Test
{
    class TwoDimensArrTests
    {
        [TestCase(TDAMockType.first,-5)]
        [TestCase(TDAMockType.second,-24)]
        [TestCase(TDAMockType.third,-67)]
        public void GetMinElementTwoDimArrayTest(TDAMockType type, int expected)
        {
            int[,] array = TDMock.GetMock(type);
            int actual = TwoDimensArr.GetMinElementTwoDimArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void GetMinElementTwoDimArrayTest_WhenLenghtLessOne_ShouldThrowException(TDAMockType type)
        {
            int[,] array = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArr.GetMinElementTwoDimArray(array));
        }

        [TestCase(TDAMockType.first, 23)]
        [TestCase(TDAMockType.second, 11)]
        [TestCase(TDAMockType.third, 10)]
        public void GetMaxElementTwoDimArrayTest(TDAMockType type, int expected)
        {
            int[,] array = TDMock.GetMock(type);
            int actual = TwoDimensArr.GetMaxElementTwoDimArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void GetMaxElementTwoDimArrayTest_WhenLenghtLessOne_ShouldThrowException(TDAMockType type)
        {
            int[,] array = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArr.GetMaxElementTwoDimArray(array));
        }

    }
}
