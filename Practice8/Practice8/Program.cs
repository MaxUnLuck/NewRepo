//////////////////////////////////////////////////////////////
//* Практическая работа № 8                                 //
//* Сулейманов Максим 2ИСПд                                 //
//* 2 группа 7 вариант                                      //                         
//////////////////////////////////////////////////////////////
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Title = "Практическая номер 8";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        while (true)
        {
            try
            {
                Console.Write("Здравствуйте, введите число N:  ");
                string N = Console.ReadLine();
                int count = 0; // нахождение разрядности числа
                int N_ = Convert.ToInt32(N);
                while (0 < N_)
                {
                    N_ = N_ / 10;
                    count++;
                }
                int i = 0; // нахождение количества нулей
                int countofzero = 0;
                while (i < count)
                {
                    if (Convert.ToInt32(N[i].ToString()) == 0)
                    {
                        countofzero++;
                    }
                    i++;
                }
                int intN = Convert.ToInt32(N);
                if (countofzero % 2 == 0)
                {
                    Console.WriteLine("Число нулей четное.");
                    Console.WriteLine($"Выражение равно числу {(Math.Round(Math.Pow(intN, 3) + 1 / (Math.Sqrt(2 * intN + 10)), 5))}.");
                }
                else
                {
                    Console.WriteLine("Число нулей не четное.");
                    Console.WriteLine($"Выражение равно числу {(Math.Round(Math.Pow(intN, -2) + 1 / (Math.Sqrt(2 * intN + 10)), 5))}.");
                }
                Console.Write("Хотите закончить программу? да [Y], нет [N]");
                N = Console.ReadLine();
                if (N == "Y")
                {
                    break;
                }
                else
                {
                    if (N == "N")
                    {
                        continue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введен не правильный символ, допустимы только N и Y.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}