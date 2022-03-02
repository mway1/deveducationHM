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

        public static int OutputLargestDivisor(int a)
        {
            int maxDivisor = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0 && i != a)
                {
                    if (i > maxDivisor)
                    {
                        maxDivisor = i;
                        i++;
                    }
                }
            }
            return maxDivisor;
        }

        public static int PrintSumNumFromRange(int a, int b)
        {
            int sum = 0;
            int tmp;
            if (b < a)
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            for (int i = a; i < b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static int GetFromFibonacciSeries(int n)
        {
            int num1 = 1;
            int num2 = 1;
            int i = 0;
            int sum = 0;
            while (i < n - 2)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                i++;
            }
            return num2;
        }
    }
}
