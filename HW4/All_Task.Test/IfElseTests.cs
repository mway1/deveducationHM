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

        
        [TestCase(1,2, Quarters.I)]
        [TestCase(-1,2, Quarters.II)]
        [TestCase(-3,-4, Quarters.III)]
        [TestCase(5,-6, Quarters.IV)]
        [TestCase(0,-7, Quarters.OnAxis)]
        public void DetermineInWhichQuarterTest(int x, int y, Quarters expected)
        {
            Quarters actual = IfElse.DetermineInWhichQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
