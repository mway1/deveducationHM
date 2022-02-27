using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int tmp;
            int count = 0;
            while (A != 0)
            {
                tmp = A % 10;
                A /= 10;
                if (tmp % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Smallest common divisor: {count}");
        }
    }
}
