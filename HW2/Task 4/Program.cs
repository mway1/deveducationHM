using System;

namespace Task_4
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

            Console.WriteLine($"The equation: {A}*X*X +{B}*X+{C}");

            double discriminant;

            discriminant = B * B - 4 * A * C;

            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no roots");
            }
            else if (discriminant == 0)
            {
                double x = ((-B) / (2 * A));
                Console.WriteLine($"Solution of the equation: {x}");
            }
            else
            {
                double x1 = ((-B + Math.Sqrt(discriminant)) / (2 * A));
                double x2 = ((-B - Math.Sqrt(discriminant)) / (2 * A));
                Console.WriteLine($"Solution of the equation: X1={x1},X2={x2}");
            }


        }
    }
}
