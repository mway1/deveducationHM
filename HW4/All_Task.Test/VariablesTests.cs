using NUnit.Framework;
using System;

namespace All_Task.Test
{
    public class VariablesTests
    {
        [TestCase(10,5,2,0)]
        [TestCase(21,2,10,1)]
        [TestCase(47,3,15,2)]
        [TestCase(-10,-5,2,0)]
        [TestCase(-10,5,-2,0)]
        public void GetResultsDivRemainderTest(int a, int b, int expected1, int expected2)
        {
            int actual1;
            int actual2;

            Variables.GetResultsDivRemainder(a, b, out actual1, out actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }

        [TestCase(2,3,19)]
        [TestCase(15,4,-8)]
        [TestCase(11,22,49)]
        [TestCase(-1,4,2)]
        [TestCase(0,7,7)]
        public void GetSolvingTheFormulaTest(int a, int b, int expected)
        {
            int actual = Variables.GetSolvingTheFormula(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(2,3,3,2)]
        [TestCase(-1,7,7,-1)]
        [TestCase(23,0,0,23)]
        [TestCase(157,24,24,157)]
        [TestCase(2031,-57,-57,2031)]
        public void SwapNumbersTest(int a, int b, int expected1, int expected2)
        {
            int actual1;
            int actual2;

            Variables.SwapNumbers(a, b, out actual1, out actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }



    }
}