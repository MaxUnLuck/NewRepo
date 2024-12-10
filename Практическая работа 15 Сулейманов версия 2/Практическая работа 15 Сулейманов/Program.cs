using System;
namespace Практическая_работа_15_Сулейманов
{
    internal class Program
    {
        public static void ExeptionWrite(string extext) // вывод сообщения ошибок
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(extext);
            Console.BackgroundColor = ConsoleColor.Black;
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
        static string WriteAndRead(string text, bool isname) // вывод тектса запроса и ввод ответа
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
                    if (isname == true)
                    {
                        bool islegitname = true;
                        for (int i = 0; i < readedtext.Length; i++)
                        {
                            if (!(readedtext[i] >= 'a' && readedtext[i] <= 'z' || readedtext[i] >= 'A' && readedtext[i] <= 'Z' || readedtext[i] >= 'а' && readedtext[i] <= 'я' || readedtext[i] >= 'А' && readedtext[i] <= 'Я')) // Проверяем первый символ ли буква
                            {
                                ExeptionWrite($"Неприемлемый символ [{readedtext[i]}]");
                                islegitname = false;
                            }
                        }
                        if (!islegitname)
                        {
                            {
                                continue;
                            }
                        }
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
        static byte WriteAndReadByte(string text) // вывод тектса запроса и ввод ответа байты
        {
            byte number = 0;
            while (true)
            {
                bool isnoex = false;
                try
                {
                    Console.Write(text);
                    number = Convert.ToByte(Console.ReadLine());
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
            return number;
        }
        class SportsSection
        {
            string sportname;
            string nameofinstruction;
            string timebegin;
            string timeend;
            string adres;
            byte countofstudent;
            byte maxcountofstudent;
            private byte getfreeplace() // вычисление количества свободных мест
            {
                return Convert.ToByte(maxcountofstudent - countofstudent);
            }
          
            public void GetInfo()
            {
                Console.WriteLine("\nСпортивная секция - " + sportname);
                Console.WriteLine("  инструктор: " + nameofinstruction);
                Console.WriteLine("  начало занятий в часах: " + timebegin);
                Console.WriteLine("  конец занятий в часах:  " + timeend); 
                Console.WriteLine("  адресс:" + adres);
                Console.WriteLine("  обучающееся " + countofstudent);
                Console.WriteLine("  свободных мест " + getfreeplace());
            }
            public void SetInfo()
            {
                sportname = WriteAndRead("Введите вид спорта: ", true);
                nameofinstruction = WriteAndRead("Введите имя инструктора: ", true);
                while (true)
                {
                    timebegin = WriteAndRead("Введите время начала в часах: ", false);
                    timeend = WriteAndRead("Введите время конца в часах: ", false);
                    if (!Int32.TryParse(timebegin, out var number1))
                    {
                        ExeptionWrite("Неправильный формат данных.");
                        continue;
                    }
                    if (!Int32.TryParse(timeend, out var number2))
                    {
                        ExeptionWrite("Неправильный формат данных.");
                        continue;
                    }
                    if (!((Convert.ToInt32(timebegin) >= 0 && Convert.ToInt32(timebegin) <= 23) && (Convert.ToInt32(timeend) >= 0 && Convert.ToInt32(timeend) <= 23)))
                    {
                        ExeptionWrite("Час может быть только от 0 до 23.");
                        continue;
                    }
                    if (Convert.ToInt32(timebegin) > Convert.ToInt32(timeend))
                    {
                        ExeptionWrite("Время начало не может быть позже конца");
                        continue;
                    }
                    break;
                }
                adres = WriteAndRead("Введите адресс: ", false);
                while(true)
                {
                    countofstudent = WriteAndReadByte("Сколько в секции учеников: ");
                    maxcountofstudent = WriteAndReadByte("Сколько в секции мест может быть: ");
                    if (maxcountofstudent > countofstudent)
                    {
                        break;
                    }
                    ExeptionWrite("Не может быть обучающихся в секции больше чем мест в секции.");
                }
            }
            public SportsSection()
            {
                SetInfo();
                GetInfo();
            }

        }
        static void Main(string[] args)
        {
            Console.Title = "Практическая 15.";
            while (true)
            {
                Console.Title = "15";
                Console.WriteLine("Здравствуйте это программа по созданию класса спортивная секция!");
                SportsSection section = new SportsSection();
                if (YesOrNo())
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
