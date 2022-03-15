using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    public static class Cycles
    {
        public static int RaiseNumberToDegree(int a, int b)//HW3-Task1
        {
            if (b <= 0)
            {
                throw new Exception("B should be >0");
            }
            int number = 1;
            for (int i = 0; i < b; i++)
            {
                number *= b;
            }
            return number;
        }

        public static int[] GetSequenceThatMultipleOfA(int a)//HW3-Task2
        {
            if (a == 0)
            {
                throw new Exception("Cannot be divided by zero");
            }
            int count=0;
            for (int i = a; i <= 1000; i+=a)
            {
                count++;
            }
            int[] array = new int[count];
            int tmp=0;
            for (int i = a; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    array[tmp] = i;
                    tmp++;
                }
            }
            return array;

        }

        public static int GetCountPositiveNum(int a)//HW3-Task3
        {
            if (a <= 0)
            {
                throw new Exception(" A must be > 0");
            }
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

        public static int OutputLargestDivisor(int a)//HW3-Task4
        {
            if (a <= 0)
            {
                throw new Exception(" A must be > 0");
            }
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

        public static int PrintSumNumFromRange(int a, int b)//HW3-Task5
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

        public static int GetFromFibonacciSeries(int n)//HW3-Task6
        {
            if (n <= 0)
            {
                throw new Exception(" N must be > 0");
            }
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

        public static int GetDivisorFromEuclidAlgo(int a, int b)//HW3-Task7
        {
            if (a <= 0 || b <= 0)
            {
                throw new Exception("A and B should be >0");
            }

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

        public static int FindRootByHalfDivision(int n)//HW3-Task8 
        {
            if (n <= 0)
            {
                throw new Exception(" N must be > 0");
            }
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

        public static int FindNumberOfOdd(int a)//HW3-Task9
        {
            if (a <= 0)
            {
                throw new Exception("A must be >0");
            }
            int tmp;
            int count = 0;
            while (a != 0)
            {
                tmp = a % 10;
                if (tmp % 2 != 0)
                {
                    count++;
                }
                a /= 10;
            }
            return count;
        }

        public static int PrintNumberInReverse(int a)//HW3-Task10
        {
            if (a <= 0)
            {
                throw new Exception("A must be >0");
            }
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

        public static int FindEvenNum(int n)
        {
            int decade;
            int countEven = 0;
            for (int i = 0; i < n; i++)
            {

                int tmp = i;
                int summEven = 0;
                int summOdd = 0;
                while (tmp != 0)
                {
                    decade = tmp % 10;
                    if (tmp % 2 == 0)
                    {
                        summEven += decade;
                    }
                    else
                    {
                        summOdd += decade;
                    }
                    tmp /= 10;
                }
                if (summEven > summOdd)
                {
                    countEven++;
                }
            }
            return countEven;
        }
        public static int[] GetNumWithMostEvenDigits(int n)//HW3-Task 11
        {
            if (n < 0)
            {
                throw new Exception("N must be > 0");
            }
            int countEven = FindEvenNum(n);
            int decade;
            int[] array = new int[countEven];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int tmp = i;
                int summEven = 0;
                int summOdd = 0;
                while (tmp != 0)
                {
                    decade = tmp % 10;
                    if (tmp % 2 == 0)
                    {
                        summEven += decade;
                    }
                    else
                    {
                        summOdd += decade;
                    }
                    tmp /= 10;
                }
                if (summEven > summOdd)
                {
                    array[count] = i;
                    count++;
                }
            }

            return array;

        }
        public static bool FindOutIdenticalNum(int a, int b)//HW3-Task12
        {
            if (a <= 0 || b <= 0)
            {
                throw new Exception("A and B should be >0");
            }
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
