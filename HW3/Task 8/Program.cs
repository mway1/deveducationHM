using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = N;
            int tmp = 0;

            while (Math.Pow(tmp, 3) != N)
            {
                tmp = (a + b) / 2;
                if(Math.Pow(tmp, 3) < N)
                {
                    a = tmp;
                }
                else
                {
                    b = tmp;
                }
            }
            Console.WriteLine($"Result: {tmp}");


        }
    }
}
