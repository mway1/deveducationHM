using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    static class Variables
    {
        public static int GetSolvingTheFormula(int a, int b)//HW1-Task1
        {
            int result = (((5 * a) + (b * b)) / (b - a));
            return result;
        }
        public static double GetTheRootOfTheEquation(double a, double b, double c)//HW1-Task2
        {
            double x = ((c - b) / a);
            return x;
        }
        public static string GetEquationOfStraightLine(int x1, int y1, int x2, int y2)//HW1-Task5
        {
            int A = (y2 - y1) / (x2 - x1);
            int B = y2 - (A * x2);
            string result = $"y={A}*x+({B})*x";
            return result;
        }

    }
}
