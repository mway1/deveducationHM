using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int tmp1=0;
            int tmp2=0;
            bool res = false;

            while (A != 0)
            {
                tmp1 = A % 10;
                for(int i = B; i != 0; i /= 10)
                {
                    tmp2 = i % 10;
                 if (tmp1 == tmp2)
                 {
                        res = true;
                 }
                }
                A /= 10;
            }
            if (res == true)
            {
                Console.WriteLine("ДA");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
        }
    }
}
