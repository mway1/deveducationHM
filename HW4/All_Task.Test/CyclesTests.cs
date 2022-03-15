using NUnit.Framework;
using System;

namespace All_Task.Test
{
    public class CyclesTests
    {
        [TestCase(2,3,8)]
        [TestCase(8,1,8)]
        [TestCase(5,4,625)]
        public void RaiseNumberToDegreeTest(int a, int b, int expected)
        {
            int actual = Cycles.RaiseNumberToDegree(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,0)]
        [TestCase(8,-1)]
        public void RaiseNumberToDegreeTest_WhenBLowerOrEqualZero_ShouldThrowException(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.RaiseNumberToDegree(a, b));
        }
    }
}
