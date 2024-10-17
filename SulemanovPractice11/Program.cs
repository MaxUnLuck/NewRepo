using System;
namespace SulemanovPractice11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Практическая ~ 11";
            const int maxascii = 65535;
            while (true)
            {
                try
                {
                    Console.WriteLine("Здравствуйте, вводите строки по очереди, когда закончите введите '/end'.");
                    string strings = "";
                    while (true)
                    {
                        string strings_ = Console.ReadLine();
                        if (strings_ == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("В введеной строке нет символов.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            continue;
                        }
                        if (strings_ == "/end")
                        {
                            break;
                        }
                        strings += strings_;
                    }
                    char[] chars = strings.ToCharArray();
                    int count = 0;
                    for (int i = 1; i < maxascii + 1; i++)
                    {
                        for (int j = 0; j < chars.Length; j++)
                        {
                            if ((int)chars[j] == i)
                            {
                                count++;
                            }
                        }
                        if (count > 0)
                        {
                            Console.WriteLine($"Символ {(char)i} встретился {count} раз.");
                        }
                        count = 0;
                    }
                    try
                    {
                        bool isnoex = false;
                        string choose = "";
                        while (!isnoex)
                        {
                            Console.WriteLine("Хотите закончить программу? да[Y], нет[N].");
                            choose = Console.ReadLine();
                            if (choose != "Y" & choose != "N")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Не правильный текст.");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                break;
                            }
                        }
                        isnoex = false;
                        if (choose == "Y")
                        {
                            break;
                        }
                        else
                        {
                            if (choose == "N")
                            {
                                Console.Clear();
                                continue;
                            }
                        }
                    }
                    catch (FormatException fx)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(fx.Message);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                catch (ArgumentOutOfRangeException aore)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(aore.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
