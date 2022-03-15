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

        [TestCase(2,7,5,new int[] {2,5,7})]
        [TestCase(8,0,4,new int[] {0,4,8})]
        [TestCase(-8,24,3,new int[] {-8,3,24})]
        public void SortInAscendingOrderTest(int a, int b, int c, int[] expected)
        {
            int[] actual = IfElse.SortInAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, -4, -5, new double[] { -1, 5 })]
        [TestCase(1, 8, 16, new double[] { -4 })]
        [TestCase(5, 3, 7, new double[] { })]
        public void SolutionOfEquationTest(int a, int b, int c, double[] expected)
        {
            double[] actual = IfElse.SolutionOfEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,15,23)]
        [TestCase(0,-5,7)]
        [TestCase(0,2,0)]
        public void SolutionOfEquationTest_WhenAEqualZero_ShouldThrowException(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => IfElse.SolutionOfEquation(a, b, c));

        }

        [TestCase(22, "Двадцать два")]
        [TestCase(91, "Девяносто один")]
        public void GetTheNumberInWordsTest(int number, string expected)
        {
            string actual = IfElse.GetTheNumberInWords(number);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(7)]
        [TestCase(121)]
        public void GetTheNumberInWordsTest_WhenNumHigerNinetyNineAndLessTen_ShouldThrowException(int number)
        {
            Assert.Throws<Exception>(() => IfElse.GetTheNumberInWords(number));

        }

    }
}
