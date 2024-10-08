//////////////////////////////////////////////////////////////////////////
///* Практическая работа № 9                                           ///
///* Сулейманов Максим Андреевич                                       ///
///* Задание: Сделать программу по заданию с использованием массива    ///
//////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSulemanov9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Title = " |:| Практическая работа №9 |:| ";
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    double[] Numbers = new double[15];
                    Random Rand = new Random();
                    int min_mass, max_mass;
                    Console.WriteLine("Здравствуйте пользователь!");
                    Console.Write("Введите минимальную границу массива ");
                    min_mass = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите максимальную границу массива ");
                    max_mass = Convert.ToInt32(Console.ReadLine());
                    if (min_mass > max_mass)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Пользователь ввёл невозможный интервал, минимальное значение не может быть больше максимального.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    for (int i = 1; i < Numbers.Length; i++) // заполнение массива рандомными числами
                    {
                        Numbers[i] = Rand.Next(min_mass, max_mass + 1);
                    }
                    for (int i = 0; i < Numbers.Length; i++) // расставление по порядку
                    {
                        for (int j = 0; j < Numbers.Length; j++)
                        {
                            if (Numbers[i] < Numbers[j])
                            {
                                double swap = Numbers[i];
                                Numbers[i] = Numbers[j];
                                Numbers[j] = swap;
                            }
                        }
                    }
                    double Min = 0;
                    for (int i = Numbers.Length - 1; i > 0; i--) // поиск минимального и нечетного
                    {
                        if (Numbers[i] % 2 != 0)
                        {
                            Min = Numbers[i];
                            break;
                        }
                    }
                    Numbers[0] = Min;
                    int color = 0;
                    for (int i = 0; i < Numbers.Length; i++) // вывод массива
                    {
                        color++;
                        if (color > 3)
                        {
                            color = 1;
                        }
                        switch (color)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                            case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                }
                            case 3:
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                }
                        };
                        Console.WriteLine($"Значение из массива по номером {i + 1} = {Numbers[i]}");
                    }
                    Console.ReadKey();
                    break;
                }
                catch (FormatException Fex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Fex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
