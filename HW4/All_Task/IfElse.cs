using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    static class IfElse
    {
        public static int GetTheResultOfMathActions(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }
        public static string DetermineInWhichQuarter(int x, int y)
        {
            string result;
            if (x > 0 && y > 0)
            {
                result = "FIRST";
            }
            else if (x < 0 && y > 0)
            {
                result = "SECOND"; 
            }
            else if (x < 0 && y < 0)
            {
                result = "THIRD";
            }
            else
            {
                result = "FOURTH";
            }
            return result;
        }

    }
}
