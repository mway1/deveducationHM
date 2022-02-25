using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 1; i < A; i++)
            { 
                if (i * i < A)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of numbers: {count}");
        }
    }
}
