using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            int maxDivisor = 0;
            for (int i = 1; i < A; i++)
            {
                if (A%i==0 && i!=A)
                {
                    if (i > maxDivisor)
                    {
                        maxDivisor = i;
                    }
                }
            }
            Console.WriteLine($"Maximum divisor: {maxDivisor}");
        }
    }
}
