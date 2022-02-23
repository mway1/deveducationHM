using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X1");
            string numberX1 = Console.ReadLine();
            int x1 = Convert.ToInt32(numberX1);
            Console.WriteLine("Enter Y1");
            string numberY1 = Console.ReadLine();
            int y1 = Convert.ToInt32(numberY1);
            Console.WriteLine("Enter X2");
            string numberX2 = Console.ReadLine();
            int x2 = Convert.ToInt32(numberX2);
            Console.WriteLine("Enter Y2");
            string numberY2 = Console.ReadLine();
            int y2 = Convert.ToInt32(numberY2);

            int A = (y2 - y1) / (x2 - x1);
            int B = y2 - (A * x2);
            string sign;

            Console.WriteLine($"The equation of a straight line(First variant): y={A}*x+({B})*x");

            if (B >= 0)
            {
                sign = "+";
            }
            else
            {
                sign = " ";
            }

            Console.WriteLine($"The equation of a straight line(Second variant): y={A}*x{sign}{B}*x");

        }
    }
}
