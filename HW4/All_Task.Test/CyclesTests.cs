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

        [TestCase(100,new int[] {100,200,300,400,500,600,700,800,900,1000})]
        [TestCase(250,new int[] {250,500,750,1000})]
        public void GetSequenceThatMultipleOfATest(int a, int[] expected)
        {
            int[] actual = Cycles.GetSequenceThatMultipleOfA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetSequenceThatMultipleOfATest_WhenAEqualZero_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetSequenceThatMultipleOfA(a));
        }

    }
}
