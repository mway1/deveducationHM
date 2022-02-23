using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A");
            string numA = Console.ReadLine();
            int A = Convert.ToInt32(numA);
            Console.WriteLine("Enter number B");
            string numB = Console.ReadLine();
            int B = Convert.ToInt32(numB);
            Console.WriteLine("Enter number С");
            string numС = Console.ReadLine();
            double C = Convert.ToDouble(numС);

            double x = ((C - B) / A);

            Console.WriteLine($"Result: {x}");
        }
    }
}
