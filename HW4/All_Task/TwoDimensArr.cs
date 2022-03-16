using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    public static class TwoDimensArr
    {
        public static int[,] CreateAnTwoDimArrayWithRandom(int n,int m)
        {
            if (n < 0 || m < 0)
            {
                throw new Exception("lenght must be > 0");
            }
            int[,] array = new int[n,m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                array[i,j] = rnd.Next(-10,10);
                }
            }
            return array;
        }

        public static void OutputAnTwoDimArrayToTheConsole(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        Console.Write(" " + array[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("" + array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void SolveTask1()
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = CreateAnTwoDimArrayWithRandom(n,m);
            Console.WriteLine("Your array: ");
            OutputAnTwoDimArrayToTheConsole(array);
            Console.Write($"Minimum array element: {GetMinElementTwoDimArray(array)}");
        }

        public static int GetMinElementTwoDimArray(int[,] a)
        {
            if (a.GetLength(0) < 1 || a.GetLength(1) < 1)
            {
                throw new Exception("rows and columns should be >0");
            }
            int min = a[0,0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j< a.GetLength(1); j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i,j];
                    }
                }
            }
            return min;
        }

        public static void SolveTask2()
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = CreateAnTwoDimArrayWithRandom(n, m);
            Console.WriteLine("Your array: ");
            OutputAnTwoDimArrayToTheConsole(array);
            Console.Write($"Maximum array element: {GetMaxElementTwoDimArray(array)}");
        }

        public static int GetMaxElementTwoDimArray(int[,] a)
        {
            if (a.GetLength(0) < 1 || a.GetLength(1) < 1)
            {
                throw new Exception("rows and columns should be >0");
            }
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            return max;
        }

        public static void SolveTask3()
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = CreateAnTwoDimArrayWithRandom(n, m);
            Console.WriteLine("Your array: ");
            OutputAnTwoDimArrayToTheConsole(array);
            Console.Write($"Index of min element: {GetIndexOfMinElement(array)}");
        }

        public static string GetIndexOfMinElement(int[,] a)
        {
            if (a.GetLength(0) < 1 || a.GetLength(1) < 1)
            {
                throw new Exception("rows and columns should be >0");
            }
            int min = a[0, 0];
            string indexMin = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        indexMin = $"({i},{j})";
                    }
                }
            }
            return indexMin;
        }
        public static void SolveTask4()
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = CreateAnTwoDimArrayWithRandom(n, m);
            Console.WriteLine("Your array: ");
            OutputAnTwoDimArrayToTheConsole(array);
            Console.Write($"Index of max element: {GetIndexOfMaxElement(array)}");
        }

        public static string GetIndexOfMaxElement(int[,] a)
        {
            if (a.GetLength(0) < 1 || a.GetLength(1) < 1)
            {
                throw new Exception("rows and columns should be >0");
            }
            int max = a[0, 0];
            string indexMax = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        indexMax = $"({i},{j})";
                    }
                }
            }
            return indexMax;
        }

        public static void SolveTask5()
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = CreateAnTwoDimArrayWithRandom(n, m);
            Console.WriteLine("Your array: ");
            OutputAnTwoDimArrayToTheConsole(array);
            Console.Write($"Count of max element: {FindCountBiggerElementsOfNeighbours(array)}");
        }

        public static int FindCountBiggerElementsOfNeighbours(int[,] a)
        {
            if (a.GetLength(0) < 1 || a.GetLength(1) < 1)
            {
                throw new Exception("rows and columns should be >0");
            }
            int count = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i == 0 || a[i, j] > a[i - 1, j])
                        && (i == a.GetLength(0) - 1 || a[i, j] > a[i + 1, j])
                        && (j == 0 || a[i, j] > a[i, j - 1])
                        && (j == a.GetLength(1) - 1 || a[i, j] > a[i, j + 1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static void SolveTask6()
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = CreateAnTwoDimArrayWithRandom(n, m);
            Console.WriteLine("Your array: ");
            OutputAnTwoDimArrayToTheConsole(array);
            int[,] tmp = ReflectMainDiagonal(array);
            Console.WriteLine($"Reflected relative to the main diagonal of the array: ");
            OutputAnTwoDimArrayToTheConsole(tmp);
        }

        public static int[,] ReflectMainDiagonal(int[,] a)
        {
            if (a.GetLength(0) < 1 || a.GetLength(1) < 1)
            {
                throw new Exception("rows and columns should be >0");
            }
            int tmp;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = i+1; j < a.GetLength(1); j++)
                {
                    tmp = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = tmp;
                }
            }
            return a;
        }

    }
}
