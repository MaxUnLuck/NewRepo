//////////////////////////////////////////////////////////////
//* Практическая работа № 14                                //
//* Сулейманов Максим 2ИСПд                                 //
//* 2 группа 7 вариант                                      //                         
//////////////////////////////////////////////////////////////

using System;
using System.Diagnostics.Contracts;
using System.IO;


namespace Prctice_14_Sulemanov
{
    internal class Program
    {
        public static void ExeptionWrite(string extext) // вывод сообщения ошибок
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(extext);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        static bool YesOrNo(string text) // опрос с ответом да(Y) или нет(N) но можно свой вопрос задать
        {
            string ReadedSymbol = string.Empty;
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(text + " да(Y) или нет(N)");
                    ReadedSymbol = Console.ReadLine();
                    if (ReadedSymbol == string.Empty)
                    {
                        ExeptionWrite("Вы не ввели символ");
                        continue;
                    }
                    else
                    {
                        if (ReadedSymbol == "y") { return true; }
                        else
                        {
                            if (ReadedSymbol == "n") { return false; }
                            else
                            {
                                if (ReadedSymbol == "Y") { return true; }
                                else
                                {
                                    if (ReadedSymbol == "N") { return false; }
                                    else
                                    {
                                        ExeptionWrite("Вы ввели не тот символ");
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (FormatException fx)
                {
                    ExeptionWrite(fx.Message);
                    continue;
                }
                catch (Exception ex)
                {
                    ExeptionWrite(ex.Message);
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Program create files";
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Программа для сохранения интервала и сравнения.\nВведите ссылку на файл по типу:\n  D:\\Users\\1210N-4\\Documents\\2-ИСП\\Sulemanov practice\\Sulemanov practice\\bin\\Debug\\PR17.txt\nСсылка: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    string Link = Console.ReadLine();
                    string empty = string.Empty;
                    File.WriteAllText(Link, empty);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Напишите n-ое количество чисел в интервале: ");
                    int nnumber = Convert.ToInt32(Console.ReadLine());
                    Random random = new Random();
                    for (int i = 0; i < nnumber; i++)
                    {
                        File.AppendAllText(Link, Convert.ToString(random.Next(-514, 1541) / 100.0) + "\n");
                    }
                    string[] content = File.ReadAllLines(Link);
                    for (int i = 0; i < content.Length; i++)
                    {
                        Console.WriteLine("строка " + (i + 1) + " - " + content[i]);
                    }
                    int Max;
                    int Min;
                    while (true)
                    {
                        Console.WriteLine("Напишите диапозон: ");
                        Console.Write("Минималиная граница: ");
                        Min = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Максимальная граница: ");
                        Max = Convert.ToInt32(Console.ReadLine());
                        if (!(Min > Max))
                        {
                            break;
                        }
                        ExeptionWrite("Не может быть минимум больше максимума.");
                    }
                    int notruecount = 0;
                    notruecount = 0;
                    for (int i = 0; i < content.Length; i++)
                    {
                        if (!(Convert.ToDouble(content[i]) < Max && Convert.ToDouble(content[i]) > Min))
                        {
                            notruecount++;
                        }
                    }
                    Console.WriteLine("Чисел не входящих в новый диапозон: " + notruecount + "\nЧисел не входящих в новый диапозон в процентах: " + Math.Round(((content.Length + 1) / Convert.ToDouble(notruecount)) * 100, 2) + " %");
                    content = File.ReadAllLines(Link);
                    Console.WriteLine($"Содержимое файла {Link}: ");
                    for (int i = 0; i < content.Length; i++)
                    {
                        Console.WriteLine("строка " + (i + 1) + " - " + content[i]);
                    }
                    if (YesOrNo("Закончить программу?"))
                    {
                        break;
                    }
                    Console.Clear();
                }
                catch (FormatException fx)
                {
                    ExeptionWrite(fx.Message);
                }
                catch (Exception ex)
                {
                    ExeptionWrite(ex.Message);
                }
            }
        }
    }
}