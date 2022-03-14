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
    }
}