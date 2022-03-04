using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int tmp;
            if (B < A)
            {
                tmp = B;
                B = A;
                A = tmp;
            }
            for (int i = A; i < B; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of numbers divisible by 7: {sum}");
        }
    }
}
