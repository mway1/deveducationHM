using System;

namespace Task1
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

            if (A > B)
            {
                Console.WriteLine($"The result of addition = {A+B}");
            }
            else if (A == B)
            {
                Console.WriteLine($"The result of multiplication = {A*B}");
            }
            else
            {
                Console.WriteLine($"The result of subtraction = {A-B}");
            }
            
        }
    }
}
