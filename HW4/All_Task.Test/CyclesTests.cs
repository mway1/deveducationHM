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

        [TestCase(10,3)]
        [TestCase(100,9)]
        [TestCase(27,5)]
        public void GetCountPositiveNumTest(int a, int expected)
        {
            int actual = Cycles.GetCountPositiveNum(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void GetCountPositiveNumTest_WhenAEqualZero_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetCountPositiveNum(a));
        }

        [TestCase(100,50)]
        [TestCase(27,9)]
        [TestCase(2,1)]
        public void OutputLargestDivisorTest(int a, int expected)
        {
            int actual = Cycles.OutputLargestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-27)]
        public void OutputLargestDivisorTest_WhenAEqualZero_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.OutputLargestDivisor(a));
        }

        [TestCase(1,100,735)]
        [TestCase(25,-15,21)]
        [TestCase(47,0,147)]
        public void PrintSumNumFromRangeTest(int a, int b, int expected)
        {
            int actual = Cycles.PrintSumNumFromRange(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4,3)]
        [TestCase(25, 75025)]
        public void GetFromFibonacciSeriesTest(int n, int expected)
        {
            int actual = Cycles.GetFromFibonacciSeries(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-27)]
        public void GetFromFibonacciSeriesTest_WhenNEqualZero_ShouldThrowException(int n)
        {
            Assert.Throws<Exception>(() => Cycles.GetFromFibonacciSeries(n));
        }

        [TestCase(24,100,4)]
        [TestCase(33,45,3)]
        [TestCase(158,987,1)]
        public void GetDivisorFromEuclidAlgoTest(int a, int b, int expected)
        {
            int actual = Cycles.GetDivisorFromEuclidAlgo(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22,-15)]
        [TestCase(100,0)]
        [TestCase(-25,125)]
        [TestCase(0,540)]
        public void GetDivisorFromEuclidAlgoTest_WhenBorALowerOrEqualZero_ShouldThrowException(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.GetDivisorFromEuclidAlgo(a, b));
        }

        [TestCase(27,3)]
        [TestCase(125,5)]
        public void FindRootByHalfDivisionTest(int number, int expected)
        {
            int actual = Cycles.FindRootByHalfDivision(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-27)]
        public void FindRootByHalfDivisionTest_WhenNumLowerOrEqualZero_ShouldThrowException(int number)
        {
            Assert.Throws<Exception>(() => Cycles.FindRootByHalfDivision(number));
        }
    }
}
