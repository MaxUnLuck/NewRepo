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
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Program create files";
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nПрограмма для сохранения интервала и сравнения.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (File.Exists("tempfile.txt"))
                    {
                        Console.WriteLine("Файл найден.");
                        if (YesOrNo("Удалить содержимое?"))
                        {
                            File.WriteAllText("tempfile.txt", string.Empty);
                        }
                    }
                    else
                    {
                        File.Create("tempfile.txt");
                        Console.WriteLine("Файл создан.");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Напишите n-ое количество чисел в интервале: ");
                    int nnumber = Convert.ToInt32(Console.ReadLine());
                    Random random = new Random();
                    for (int i = 0; i < nnumber; i++)
                    {
                        File.AppendAllText("tempfile.txt", Convert.ToString(random.Next(-514, 1541) / 100.0) + "\n");
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
                    string[] content = File.ReadAllLines("tempfile.txt");
                    int notruecount = 0;
                    notruecount = 0;
                    for (int i = 0; i < content.Length; i++)
                    {
                        if (!(Convert.ToDouble(content[i]) < Max && Convert.ToDouble(content[i]) > Min))
                        {
                            notruecount++;
                        }
                    }
                    Console.WriteLine("Чисел не входящих в новый диапозон: " + notruecount + "\nЧисел не входящих в новый диапозон в процентах: " + Math.Round(100-(content.Length/Convert.ToDouble(notruecount)), 2) + " %");
                    if (YesOrNo("Закончить программу?"))
                    {
                        break;
                    }
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
