using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    static class Variables
    {
        public static int GetSolvingTheFormula(int a, int b)
        {
            int result = (((5 * a) + (b * b)) / (b - a));
            return result;
        }
    }
}
