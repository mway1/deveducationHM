using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    static class TwoDimensArr
    {
        public static int[,] CreateAnTwoDimArrayWithRandom(int n,int m)
        {
            if (n < 0 || m < 0)
            {
                throw new Exception("lenght must be < 0");
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

    }
}
