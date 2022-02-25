using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            string Dec=" ";
            string Un=" ";

            int Decade = number / 10;
            int Units = number % 10;

            if (number > 19)
            {
                switch (Decade)
                {
                    case 2: Dec = "Двадцать";
                        break;
                    case 3: Dec = "Тридцать";
                        break;
                    case 4: Dec = "Сорок";
                        break;
                    case 5: Dec = "Пятьдесят";
                        break;
                    case 6: Dec = "Шестьдесят";
                        break;
                    case 7: Dec = "Семьдесят";
                        break;
                    case 8: Dec = "Восемьдесят";
                        break;
                    case 9: Dec = "Девяносто";
                        break;

                }
                switch (Units)
                {
                    case 1: Un = "один";
                        break;
                    case 2: Un = "два";
                        break;
                    case 3: Un = "три";
                        break;
                    case 4: Un = "четыре";
                        break;
                    case 5: Un = "пять";
                        break;
                    case 6: Un = "шесть";
                        break;
                    case 7: Un = "семь";
                        break;
                    case 8: Un = "восемь";
                        break;
                    case 9: Un = "девять";
                        break;
                }
                Console.WriteLine($"Your number: {Dec}{Un}");
            }
            else
            {
                if (number == 10) Console.WriteLine("Десять");
                else if (number == 11) Console.WriteLine("Одиннадцать");
                else if (number == 12) Console.WriteLine("Двенадцать");
                else if (number == 13) Console.WriteLine("Тринадцать");
                else if (number == 14) Console.WriteLine("Четырнадцать");
                else if (number == 15) Console.WriteLine("Пятнадцать");
                else if (number == 16) Console.WriteLine("Шестнадцать");
                else if (number == 17) Console.WriteLine("Семнадцать");
                else if (number == 18) Console.WriteLine("Восемнадцать");
                else if (number == 19) Console.WriteLine("Девятнадцать");
            }
        }
    }
}
