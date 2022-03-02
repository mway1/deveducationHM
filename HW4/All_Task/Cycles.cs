﻿using System;
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
        
        public static int GetDivisorFromEuclidAlgo(int a, int b)  
        {
            int nod;
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            nod = a + b;
            return nod;
        } 
        public static int GetNumberByHalfDivision(int n)
        {
            int a = 0;
            int b = n;
            int tmp = 0;

            while (Math.Pow(tmp, 3) != n)
            {
                tmp = (a + b) / 2;
                if (Math.Pow(tmp, 3) < n)
                {
                    a = tmp;
                }
                else
                {
                    b = tmp;
                }
            }
            return tmp;
        }
        
        public static int FindNumberOfOdd(int a)
        {
            int tmp;
            int count = 0;
            while (a != 0)
            {
                tmp = a % 10;
                a /= 10;
                if (tmp % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int PrintNumberInReverse(int a)
        {
            int tmp;
            int NewNum = 0;
            while (a != 0)
            {
                tmp = a % 10;
                NewNum *= 10;
                NewNum += tmp;
                a /= 10;
            }
            return NewNum;
        }
        public static bool FindOutIdenticalNum(int a, int b)
        {
            int tmp1 = 0;
            int tmp2 = 0;
            bool res = false;

            while (b != 0)
            {
                tmp1 = a % 10;
                for (int i = b; i != 0; i /= 10)
                {
                    tmp2 = i % 10;
                    if (tmp1 == tmp2)
                    {
                        res = true;
                    }
                }
                a /= 10;
            }
            return res;
        }


    }
}
