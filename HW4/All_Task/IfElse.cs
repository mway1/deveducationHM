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
    }
}
