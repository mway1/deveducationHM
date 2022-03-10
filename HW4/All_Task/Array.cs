using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    static class ArrayTasks
    {
        public static int[] CreateAnArrayWithRandom(int count)
        {
            if (count < 0)
            {
                throw new Exception("lenght must be < 0");
            }
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

        public static int[] CopyArray(int[] a)
        {
            int[] newArray = new int[a.Length];
            Array.Copy(a, newArray, a.Length);
            return newArray;
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
        
        public static void SolveTask3()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Array: ");
            OutputAnArrayToTheConsole(array);
            Console.Write($"\nIndex of the minimum element: {GetMinIndexArray(array)}");
        }

        public static int GetMinIndexArray(int[] a)
        {

            int min = a[0];
            int minIndex = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        
        public static void SolveTask4()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Array: ");
            OutputAnArrayToTheConsole(array);
            Console.Write($"\nIndex of the maximum element: {GetMaxIndexArray(array)}");
        }

        public static int GetMaxIndexArray(int[] a)
        {

            int max = a[0];
            int maxIndex = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static void SolveTask5()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Array: ");
            OutputAnArrayToTheConsole(array);
            Console.Write($"\nSum of array elements with odd indexes: {GetSumElementWithOddIndexArray(array)}");
        }

        public static int GetSumElementWithOddIndexArray(int[] a)
        {

            int sumIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i%2!=0)
                {
                    sumIndex += a[i];
                }
            }
            return sumIndex;
        }

        public static void SolveTask6()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Array: ");
            OutputAnArrayToTheConsole(array);
            int[] tmp = GetReverseOfArray(array);
            Console.Write($"\nReverse array: ");
            OutputAnArrayToTheConsole(tmp);

        }

        public static int[] GetReverseOfArray(int[] a)
        {
            int[] newArr = CopyArray(a);
            for (int i = 0; i < newArr.Length / 2; i++)
            {
                int tmp = newArr[i];
                newArr[i] = newArr[newArr.Length - (1 + i)];
                newArr[newArr.Length - (1 + i)] = tmp;
            }

            return newArr;
        }

        public static void SolveTask7()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Array: ");
            OutputAnArrayToTheConsole(array);
            Console.Write($"\nCount of odd array elements: {GetCountOddElementOfArray(array)}");
        }

        public static int GetCountOddElementOfArray(int[] a)
        {

            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void SolveTask9()
        {
            Console.Write("Enter the length of the array: ");
            int[] array = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Array: ");
            OutputAnArrayToTheConsole(array);
            int[] tmp = SortAscendingBubbleSort(array);
            Console.Write($"\nSort by bubble sort array: ");
            OutputAnArrayToTheConsole(tmp);
        }

        public static int[] SortAscendingBubbleSort(int[] a)
        {

            int[] newArr = CopyArray(a);
            int temp;
            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (newArr[i] > newArr[j])
                    {
                        temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }
            return newArr;
        }






    }
}
