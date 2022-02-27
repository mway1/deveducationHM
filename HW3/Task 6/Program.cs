using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int num1 = 1;
            int num2 = 1;
            int i = 0;
            int sum = 0;
                while (i < N-2)
                {
                    sum = num1 + num2;
                    num1 = num2;
                    num2 = sum;
                    i++;
                }
                Console.WriteLine($"{N} element of the Fibonacci series: {num2}");
        }
    }
}
