using NUnit.Framework;
using System;

namespace All_Task.Test
{
    public class IfElseTests
    {
        [TestCase(3,4,-1)]
        [TestCase(2,2,4)]
        [TestCase(7,2,9)]
        public void GetTheResultOfMathActionsTest(int a, int b, int expected)
        {
            int actual = IfElse.GetTheResultOfMathActions(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
