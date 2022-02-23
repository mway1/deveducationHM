using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A");
            string numberA = Console.ReadLine();
            int A = Convert.ToInt32(numberA);
            Console.WriteLine("Enter number B");
            string numberB = Console.ReadLine();
            int B = Convert.ToInt32(numberB);

            int result = (((5 * A) + (B * B)) / (B - A));
            Console.WriteLine($"Result = {result}");
        }
    }
}
