﻿using System;
using System.Collections.Generic;
using System.Text;

namespace All_Task
{
    public static class IfElse
    {
        public static int GetTheResultOfMathActions(int a, int b)//HW2-Task1
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }
        public static Quarters DetermineInWhichQuarter(int x, int y)//HW2-Task2
        {
            Quarters result;

            if (x > 0 && y > 0)
            {
                result = Quarters.I;
            }
            else if (x < 0 && y > 0)
            {
                result = Quarters.II;
            }
            else if (x < 0 && y < 0)
            {
                result = Quarters.III;
            }
            else if (x > 0 && y < 0)
            {                             
                result = Quarters.IV;
            }
            else
            {
                result = Quarters.OnAxis;
            }
            return result;
        }
        public static int[] SortInAscendingOrder(int a, int b, int c)//HW2-Task3
        {
            int[] sortNum = new int[3];

            if (a > b && a > c)
            {
                if (b > c)
                {
                    sortNum[0] = c;
                    sortNum[1] = b;
                    sortNum[2] = a;
                }
                else
                {
                    sortNum[0] = b;
                    sortNum[1] = c;
                    sortNum[2] = a;
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    sortNum[0] = c;
                    sortNum[1] = a;
                    sortNum[2] = b;
                }
                else
                {
                    sortNum[0] = a;
                    sortNum[1] = c;
                    sortNum[2] = b;
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    sortNum[0] = b;
                    sortNum[1] = a;
                    sortNum[2] = c;
                }
                else
                {
                    sortNum[0] = a;
                    sortNum[1] = b;
                    sortNum[2] = c;
                }
                
            }
            return sortNum;
        }


            public static int FindDiscriminant(int a,int b,int c)//HW2-Task4(Поиск дискриминанта)
        {
            return b * b - 4 * a * c;
        }
        
        public static double[] SolutionOfEquation(int a, int b,int c)//HW2-Task4 
        {
            if (a == 0)
            {
                throw new Exception("a must be > 0");
            }

            double d = FindDiscriminant(a,b,c);
            double x1;
            double x2;

            if (d < 0)
            {

                double[] result = new double[0];
                return result;
            }
            else if (d == 0)
            {
                x1 = (-b) / (2 * a);
                double[] result = new double[1] {x1};
                return result;

            }
            else
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                double[] result = new double[2] {x1,x2};
                return result;
            }
        }



        public static string GetTheNumberInWords(int number)//HW2-Task5
        {
            if (number < 10 || number > 99)
            {
                throw new Exception("the number should be two-digit");
            }
            string result = " ";
            string Dec = " ";
            string Un = " ";
            int Decade = number / 10;
            int Units = number % 10;

            if (number > 19)
            {
                switch (Decade)
                {
                    case 2:
                        Dec = "Двадцать";
                        break;
                    case 3:
                        Dec = "Тридцать";
                        break;
                    case 4:
                        Dec = "Сорок";
                        break;
                    case 5:
                        Dec = "Пятьдесят";
                        break;
                    case 6:
                        Dec = "Шестьдесят";
                        break;
                    case 7:
                        Dec = "Семьдесят";
                        break;
                    case 8:
                        Dec = "Восемьдесят";
                        break;
                    case 9:
                        Dec = "Девяносто";
                        break;

                }
                switch (Units)
                {
                    case 1:
                        Un = "один";
                        break;
                    case 2:
                        Un = "два";
                        break;
                    case 3:
                        Un = "три";
                        break;
                    case 4:
                        Un = "четыре";
                        break;
                    case 5:
                        Un = "пять";
                        break;
                    case 6:
                        Un = "шесть";
                        break;
                    case 7:
                        Un = "семь";
                        break;
                    case 8:
                        Un = "восемь";
                        break;
                    case 9:
                        Un = "девять";
                        break;
                }
                result = Dec +" "+  Un;
            }
            else
            {
                if (number == 10)
                {
                    result = "Десять";
                }
                else if (number == 11)
                {
                    result = "Одиннадцать";
                }
                else if (number == 12)
                {
                    result = "Двенадцать";
                }
                else if (number == 13)
                {
                    result = "Тринадцать";
                }
                else if (number == 14)
                {
                    result = "Четырнадцать";
                }
                else if (number == 15)
                {
                    result = "Пятнадцать";
                }
                else if (number == 16)
                {
                    result = "Шестнадцать";
                }
                else if (number == 17)
                {
                    result = "Семнадцать";
                }
                else if (number == 18)
                {
                    result = "Восемнадцать";
                }
                else if (number == 19)
                {
                    result = "Девятнадцать";
                }
            }
           return result;

        }
    }
}
  
