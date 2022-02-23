using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A");
            string A = Console.ReadLine();
            Console.WriteLine("Enter number B");
            string B = Console.ReadLine();
            string copyA = A;

            A = B;
            B = copyA;

            Console.WriteLine($"New A: {A}");
            Console.WriteLine($"New B: {B}");
        }
    }
}
