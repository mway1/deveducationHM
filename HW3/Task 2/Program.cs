using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            for (int i = A; i < 1000; i+=A)
            {
                if (i % A == 0)
                {
                    Console.WriteLine($"A number divisible by A: {i}");
                }
            }
        }
    }
}
