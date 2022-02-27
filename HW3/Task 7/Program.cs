using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int nod;
            while(A!=0 && B != 0)
            {
                if (A > B)
                {
                    A = A % B;
                }
                else
                {
                    B = B % A;
                }
            }
            nod = A + B;
            Console.WriteLine($"Smallest common divisor: {nod}");
        }
    }
}
