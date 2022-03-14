using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace All_Task
{
    public static class Variables
    {

        public static void GetResultsDivRemainder(int a, int b,out int rez1,out int rez2)//HW1-Task1
        {
            if (b == 0)
            {
                throw new Exception(" b must be > 0");
            }
            rez1 = a / b;
            rez2 = a % b;
        }

        public static int GetSolvingTheFormula(int a, int b)//HW1-Task2
        {
            if (a == b)
            {
                throw new Exception(" a must not be equal b ");
            }
            int result = (((5 * a) + (b * b)) / (b - a));
            return result;
        }

        public static void SwapNumbers(int a, int b,out int newA,out int newB)//HW1-Task3
        {
            newA = b;
            newB = a;
        }
        public static double GetTheRootOfTheEquation(double a, double b, double c)//HW1-Task4
        {
            if (a == 0)
            {
                throw new Exception(" a must be > 0");
            }
            double x = ((c - b) / a);
            return x;
        }
        public static string GetEquationOfStraightLine(int x1, int y1, int x2, int y2)//HW1-Task5
        {
            if (x1 == x2)
            {
                throw new Exception(" x1 must not be equal x2");
            }
            int A = (y2 - y1) / (x2 - x1);
            int B = y2 - (A * x2);
            string result = $"y={A}*x+({B})*x";
            return result;
        }

    }
}
