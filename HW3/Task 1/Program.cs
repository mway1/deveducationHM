using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A:");
            string numberA = Console.ReadLine();
            int A = Convert.ToInt32(numberA);
            Console.WriteLine("Enter number B:");
            string numberB = Console.ReadLine();
            int B = Convert.ToInt32(numberB);

            int number = 1;
            for (int i = 0; i < B; i++)
            {
                number *= A;
            }

            Console.WriteLine($"The result of exponentiation: {number}");
        }
    }
}
