using System;

namespace Task_3
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
            Console.WriteLine("Enter number C");
            string numberC = Console.ReadLine();
            int C = Convert.ToInt32(numberC);

            if (A > B && A > C)
            {
                if (B > C)
                {
                    Console.WriteLine($"Ascending numbers: {C},{B},{A}");
                }
                else
                {
                    Console.WriteLine($"Ascending numbers: {B},{C},{A}");
                }
            }
            else if (A > B && A < C)
            {
                Console.WriteLine($"Ascending numbers: {B},{A},{C}");
            }
            else if (A < B && A < C)
            {
              if (B > C)
                {
                Console.WriteLine($"Ascending numbers: {A},{C},{B}");
                }
              else
                {
                Console.WriteLine($"Ascending numbers: {A},{B},{C}");
                }
            }
            else 
            {
                Console.WriteLine($"Ascending numbers: {C},{A},{B}");
            }

        }
    }
}
