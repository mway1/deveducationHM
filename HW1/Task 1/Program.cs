using System;

namespace Task_1
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

            int result1 = A / B;
            Console.WriteLine($"Division result = {result1}");
            int result2 = A % B;
            Console.WriteLine($"Remains = {result2}");
        }
    }
}
