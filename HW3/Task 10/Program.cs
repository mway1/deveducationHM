using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int tmp;
            int NewNum = 0;
            while (A != 0)
            {
                tmp = A % 10;
                NewNum *= 10;
                NewNum += tmp;
                A /= 10;
            }
            Console.WriteLine($"Reverse number notation: {NewNum}");
        }
    }
}
