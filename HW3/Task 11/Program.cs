using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int tmp;
            int decade;
            for (int i = 1; i < N; i++)
            {
                int sumeven = 0;//Сумма четных
                int sumodd = 0;//Сумма нечетных
                tmp = i;
                while (tmp != 0)
                {
                    decade =tmp%10;
                    if (tmp % 2 == 0)
                    {
                        sumeven += decade;
                    }
                    else
                    {
                        sumodd += decade;
                    }
                    tmp /= 10;
                }
                if (sumeven > sumodd)
                {
                    Console.WriteLine($"Result: {i}");
                }
            }
        }
    }
}
