using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class For
    {
        public static class Practice
        {



            public static void ExeptionWrite(string extext) // вывод сообщения ошибок
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(extext);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }



            static bool YesOrNo() // опрос с ответом да(Y) или нет(N) для бесконечного повторение кода
            {
                string ReadedSymbol = string.Empty;
                while (true)
                {
                    try
                    {
                        Console.Write("Вы хотите закончить программу? да(Y) нет(N) ");
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



            static bool YesOrNo(string text) // опрос с ответом да(Y) или нет(N) но можно свой вопрос задать
            {
                string ReadedSymbol = string.Empty;
                while (true)
                {
                    try
                    {
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



            static string WriteAndRead(string text) // вывод тектса запроса и ввод ответа
            {
                string readedtext = string.Empty;
                while (true)
                {
                    bool isnoex = false;
                    try
                    {
                        Console.Write(text);
                        readedtext = Console.ReadLine();
                        if (readedtext == string.Empty)
                        {
                            ExeptionWrite("Вы не ввели текст");
                            continue;
                        }
                        isnoex = true;
                    }
                    catch (FormatException fx)
                    {
                        isnoex = false;
                        ExeptionWrite(fx.Message);
                    }
                    catch (Exception ex)
                    {
                        isnoex = false;
                        ExeptionWrite(ex.Message);
                    }
                    if (isnoex)
                    {
                        break;
                    }
                }
                return readedtext;
            }



            static int WriteAndReadInt(string text) // вывод тектса запроса и ввод ответа
            {
                int readedint = 0;
                while (true)
                {
                    bool isnoex = false;
                    try
                    {
                        Console.Write(text);
                        readedint = Convert.ToInt32(Console.ReadLine());
                        isnoex = true;
                    }
                    catch (FormatException fx)
                    {
                        isnoex = false;
                        ExeptionWrite(fx.Message);
                    }
                    catch (Exception ex)
                    {
                        isnoex = false;
                        ExeptionWrite(ex.Message);
                    }
                    if (isnoex)
                    {
                        break;
                    }
                }
                return readedint;
            }



            static double WriteAndReadDouble(string text) // вывод тектса запроса и ввод ответа
            {
                double readeddouble = 0;
                while (true)
                {
                    bool isnoex = false;
                    try
                    {
                        Console.Write(text);
                        readeddouble = Convert.ToDouble(Console.ReadLine());
                        isnoex = true;
                    }
                    catch (FormatException fx)
                    {
                        isnoex = false;
                        ExeptionWrite(fx.Message);
                    }
                    catch (Exception ex)
                    {
                        isnoex = false;
                        ExeptionWrite(ex.Message);
                    }
                    if (isnoex)
                    {
                        break;
                    }
                }
                return readeddouble;
            }



        }
    }
}
