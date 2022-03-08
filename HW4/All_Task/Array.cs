using System;
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


    }
}
