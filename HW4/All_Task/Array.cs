﻿using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    static class Array
    {
        public static int[] CreateAnArrayWithRandom(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }

        public static void OutputAnArrayToTheConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void SolveTask1()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write( $"Array: ");
            OutputAnArrayToTheConsole(array);
            Console.Write($"\nMinimum array element: {GetMinElementArray(array)}");
        }

        public static int GetMinElementArray(int[] a)
        {

            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        public static void SolveTask2()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Array: ");
            OutputAnArrayToTheConsole(array);
            Console.Write($"\nMaximum array element: {GetMaxElementArray(array)}");
        }

        public static int GetMaxElementArray(int[] a)
        {

            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }


    }
}
