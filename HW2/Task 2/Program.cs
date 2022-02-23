using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the X coordinate");
            string numberX = Console.ReadLine();
            int X = Convert.ToInt32(numberX);
            Console.WriteLine("Enter the Y coordinate");
            string numberY = Console.ReadLine();
            int Y = Convert.ToInt32(numberY);

            Console.WriteLine($"Your point has coordinates: ({X};{Y})");

            if (X > 0 && Y > 0)
            {
                Console.WriteLine($"Your point is in the FIRST quarter");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine($"Your point is in the SECOND quarter");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine($"Your point is in the THIRD quarter");
            }
            else
            {
                Console.WriteLine($"Your point is in the FOURTH quarter");
            }

        }
    }
}
