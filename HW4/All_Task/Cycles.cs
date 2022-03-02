using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    static class Cycles
    {
        public static int RaiseNumberToDegree(int a, int b)
        {
            int number = 1;
            for (int i = 0; i < b; i++)
            {
                number *= b;
            }
            return number;
        }

        public static int GetCountPositiveNum(int a)
        {
            int count = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
