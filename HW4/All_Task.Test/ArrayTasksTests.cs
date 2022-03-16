using NUnit.Framework;
using System;

namespace All_Task.Test
{
    class ArrayTasksTests
    {
        [TestCase(new int[] {2,3,4,5,6,7,8},2)]
        [TestCase(new int[] {-5,-4,7,-2,-1,0},-5)]
        public void GetMinElementArrayTest(int[] a, int expected)
        {
            int actual = ArrayTasks.GetMinElementArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] {})]
        public void GetMinElementArrayTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.GetMinElementArray(a));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8 }, 8)]
        [TestCase(new int[] { -5, -4, 7, -2, -1, 0 }, 7)]
        public void GetMaxElementArrayTest(int[] a, int expected)
        {
            int actual = ArrayTasks.GetMaxElementArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void GetMaxElementArrayTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.GetMaxElementArray(a));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(new int[] { -5, -4, 7, -2, -1, 0 }, 0)]
        public void GetMinElementIndexTest(int[] a, int expected)
        {
            int actual = ArrayTasks.GetMinIndexArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void GetMinElementIndexTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.GetMinIndexArray(a));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8 }, 6)]
        [TestCase(new int[] { -5, -4, 7, -2, -1, 0 }, 2)]
        public void GetMaxElementIndexTest(int[] a, int expected)
        {
            int actual = ArrayTasks.GetMaxIndexArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void GetMaxElementIndexTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.GetMaxIndexArray(a));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8 }, 15)]
        [TestCase(new int[] { -5, -4, 7, -2, -1, 0 }, -6)]
        public void GetSumElementWithOddIndexArrayTest(int[] a, int expected)
        {
            int actual = ArrayTasks.GetSumElementWithOddIndexArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void GetSumElementWithOddIndexArrayTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.GetSumElementWithOddIndexArray(a));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8 }, new int[] {8, 7 ,6 ,5 ,4 ,3 ,2})]
        [TestCase(new int[] { -5, -4, 7, -2, -1, 0 }, new int[] {0, -1, -2, 7, -4, -5})]
        public void GetReverseOfArrayTest(int[] a, int[] expected)
        {
            int[] actual = ArrayTasks.GetReverseOfArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void GetReverseOfArrayTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.GetReverseOfArray(a));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8 }, 3)]
        [TestCase(new int[] { -6, -4, 14, -2, 0 }, 0)]
        public void GetCountOddElementOfArrayTest(int[] a, int expected)
        {
            int actual = ArrayTasks.GetCountOddElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void GetCountOddElementOfArrayTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.GetCountOddElementOfArray(a));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8 }, new int[] {6,7,8,5,2,3,4})]
        [TestCase(new int[] { -6, -4, 14, -2}, new int[] {14,-2,-6,-4})]
        public void SwapHalfsOfArrTest(int[] a, int[] expected)
        {
            int[] actual = ArrayTasks.SwapHalfsOfArr(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void SwapHalfsOfArrTest_WhenALowerOne_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => ArrayTasks.SwapHalfsOfArr(a));
        }
    }
}
