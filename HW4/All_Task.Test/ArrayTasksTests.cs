using NUnit.Framework;
using System;

namespace All_Task.Test
{
    class ArrayTasksTests
    {
        [TestCase(new int[] {2,3,4,5,6,7,8},2)]
        [TestCase(new int[] {-5,-4,-3,-2,-1,0},-5)]
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
        [TestCase(new int[] { -5, -4, -3, -2, -1, 0 }, 0)]
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
    }
}
