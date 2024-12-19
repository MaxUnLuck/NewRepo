////////////////////////////////////////////////
//* Практическая работа № 15                 *//
//* Сулейманов Максим 2ИСПд                  *//
//* 2 группа 7 вариант                       *//                         
////////////////////////////////////////////////
////░░░░░░░░░░░░░░░░░▄█▀▀█▄░░░░░░░░░░░░░░░░░////
////░░░░░░░░░░░░░░░░█▀░░░░▀█░░░░░░░░░░░░░░░░////
////░░░░░░░░░░░░░░░█▀░░▄▄░░▀█░░░░░░░░░░░░░░░////
////░░░░░░░░░░░░░░▄█░▄█▀▀█▄░█▄░░░░░░░░░░░░░░////
////░░░░░░░░░░░░░░█░░▀░░░░▀░░█░░░░░░░░░░░░░░////
////░░░░░░░░▄█▀█░░█░░░░░░░░░░█░░█▀█▄░░░░░░░░////
////░░░░░░░░█░░██▄█░░░░░░░░░░█▄██░░█░░░░░░░░////
////░░░▄▄▄░░█▄▄██▀█░░░░░░░░░░█▀██▄▄█░░▄▄▄░░░////
////░░█░░██▄█▀▀░░░█░░░░░░░░░░█░░░▀▀█▄██░░█░░////
////░░█▄▄█▀▀░░░░░░█░░░░░░░░░░█░░░░░░▀▀█▄▄█░░////
////░▄█▀▀░░░░░░░░░█▄░░░░░░░░▄█░░░░░░░░░▀▀█▄░////
////█▀░░░░░▄▄▄▄▄████░░░░░░░░████▄▄▄▄▄░░░░░░█////
////█▄▄▄█▀▀▀░░░░░░██░░░░░░░░██░░░░░░▀▀▀█▄▄▄█////
////▀▀░░░░░░░░░░░░██░░░░░░░░██░░░░░░░░░░░░▀▀////
////░░░░░░░░░░░░░░░█░░░░░░░░█░░░░░░░░░░░░░░░////
////░░░░░░░░░░░░░░░█░░░░░░░░█░░░░░░░░░░░░░░░////
////░░░░░░░░░░░░░░░█▄▄█▀▀█▄▄█░░░░░░░░░░░░░░░////
////░░░░░░░░░░░░▄▄█▀▀░░░░░░▀▀█▄▄░░░░░░░░░░░░////
////░░░░░░░░░░▄█▀░░░▄▄▄██▄▄▄░░░▀█▄░░░░░░░░░░////
////░░░░░░░░░░█▄▄▄▄▄█▀░░░░▀█▄▄▄▄▄█░░░░░░░░░░////
////////////////////////////////////////////////
//*Программа сортировки вылетов авиакомпании *//
////////////////////////////////////////////////
using System;
namespace Practice_13_Sulemanov
{
    internal class Program
    {
        public static void WriteTop(string nameTop)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ╓─╥─");
            for (int i = 0; i < nameTop.Length; i++)
            {
                Console.Write("─");
            }
            Console.Write("─╥─╖ ");
            Console.Write("\n ║ ║ ");
            Console.Write(nameTop);
            Console.Write(" ║ ║ ");
            Console.Write("\n ╙─╨─");
            for (int i = 0; i < nameTop.Length; i++)
            {
                Console.Write("─");
            }
            Console.Write("─╨─╜ \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        public static void ExeptionWrite(string extext) // вывод сообщения ошибок
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(extext + "!");
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
        static string WriteAndRead(string text, bool isname, bool isnumber) // вывод тектса запроса и ввод ответа
        {
            string readedtext = string.Empty;
            while (true)
            {
                bool isnoex = false;
                try
                {
                    Console.Write(text);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    readedtext = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    if (readedtext == string.Empty) // Проверяем текст есть ли он
                    {
                        ExeptionWrite("Вы не ввели текст");
                        continue;
                    }
                    if (isname == true)
                    {
                        bool islegitname = true;
                        for (int i = 0; i < readedtext.Length; i++)
                        {
                            if (!((readedtext[i] >= 'a' && readedtext[i] <= 'z' || readedtext[i] >= 'A' && readedtext[i] <= 'Z') 
                                || (readedtext[i] >= 'а' && readedtext[i] <= 'я' || readedtext[i] >= 'А' && readedtext[i] <= 'Я'))) // Проверяем все символы они ли буква
                            {
                                ExeptionWrite($"Неприемлемый символ [{readedtext[i]}], можно только латинского алфавита");
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
                    if (!isnumber)
                    {
                        if (isname == false)
                        {
                            if (!((readedtext[0] >= 'a' && readedtext[0] <= 'z' || readedtext[0] >= 'A' && readedtext[0] <= 'Z')
                                    || (readedtext[0] >= 'а' && readedtext[0] <= 'я' || readedtext[0] >= 'А' && readedtext[0] <= 'Я'))) // Проверяем первый символ ли буква
                            {
                                ExeptionWrite($"Неприемлемый символ [{readedtext[0]}], можно только буквы латинского алфавита и русского алфавита");
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

        static double WriteAndReadDouble(string text) // вывод тектса запроса и ввод ответа
        {
            double readedint = 0;
            while (true)
            {
                bool isnoex = false;
                try
                {
                    Console.Write(text);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    readedint = Convert.ToDouble(Console.ReadLine());
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    if (readedint < 0)
                    {
                        ExeptionWrite("Не может быть меньше 0");
                        continue;
                    }
                    if (readedint == 0)
                    {
                        ExeptionWrite("Не может быть равно 0");
                        continue;
                    }
                    if (readedint > 19)
                    {
                        {
                            ExeptionWrite("Не может быть больше 19 часов, топлива не хватит.");
                            continue;
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
            return readedint;
        }
        public struct Airline
        {
            string destination; // пункт назначения
            string flightNumbrer; // номер рейса
            string typeOfPlane; // тип самолета
            double timeOfFlight; // время полета в чесах
            public Airline(string destination_, string flightnumbrer_, string typeofplane_, double timeofflight_)
            {
                destination = destination_;
                flightNumbrer = flightnumbrer_;
                typeOfPlane = typeofplane_;
                timeOfFlight = timeofflight_;
            }
            public char FirstLetterOfFligt() // получения первой буквы из пункта назначения
            {
                return destination[0];
            }
            public string GetTypeOfPlane() // получения первой буквы из пункта назначения
            {
                return typeOfPlane;
            }
            public double GetTimeOfFlight() // получения первой буквы из пункта назначения
            {
                return timeOfFlight;
            }
            public void InfoFlight()
            {
                Console.WriteLine($"Рейс в {destination}" +
                    $"\n  Номер рейса {flightNumbrer}" +
                    $"\n  название самолета {typeOfPlane}" +
                    $"\n  Займет часов {timeOfFlight}");
            }

        }
        public static void Swap(Airline[] airlinest, int firstIndex, int secondIndex)
        {
            Airline temp = airlinest[firstIndex];
            airlinest[firstIndex] = airlinest[secondIndex];
            airlinest[secondIndex] = temp;
        }
        static void Main(string[] args)
        {
            Console.Title = "Max airlines sorting Practice 15";
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Здравствуйте это программа сортировки рейсов авиакомпании!");
                Airline[] airlines = null;
                airlines = new Airline[1];
                int count = 0;
                while (true) // ввод рейсов
                {
                    airlines[count] = new Airline(WriteAndRead("Введите пункт назначения:     ", true, false),
                                                 WriteAndRead("Введите номер рейса:           ", false, true),
                                                  WriteAndRead("Введите тип самолета:         ", false, false),
                                            WriteAndReadDouble("Введите длительность в часах: "));
                    count++;
                    if (!YesOrNo("Вы правильно ввели рейс? если ответите нет то он будет удален."))
                    {
                        Array.Resize(ref airlines, count - 1);
                    }
                    if (!YesOrNo("Хотите добавить новый рейс?"))
                    {
                        break;
                    }
                    else
                    {
                        Array.Resize(ref airlines, count + 1);
                    }
                }
                count = 0;
                for (int j = 0; j < airlines.Length; j++) // ссортировка по алфовиту рейсов
                {
                    for (int i = 0; i < airlines.Length - 1; i++)
                    {
                        if (airlines[i].FirstLetterOfFligt() > airlines[i + 1].FirstLetterOfFligt())
                        {
                            Swap(airlines, i, i + 1);
                        }
                    }
                }
                Console.Clear();
                WriteTop("Список перелетов:");
                for (int j = 0; j < airlines.Length; j++)
                {
                    Console.Write("." + (j + 1) + " [" + airlines[j].FirstLetterOfFligt() + "] ");
                    airlines[j].InfoFlight();
                }
                string searchTypeOfPlane = WriteAndRead("\n\nНапишите тип самолета, полеты которого надо найти: ", false, false);
                bool searching = false;
                WriteTop("Список перелетов с этим типом:");
                for (int j = 0; j < airlines.Length; j++)
                {
                    if (airlines[j].GetTypeOfPlane() == searchTypeOfPlane)
                    {
                        airlines[j].InfoFlight();
                        searching = true;
                    }
                }
                if (!searching)
                {
                    Console.WriteLine($"Полеты с типом самолета {searchTypeOfPlane} не найдены.");
                }
                WriteTop("Самый продолжительный полет:");
                Airline MostLongFly = airlines[0];
                for (int j = 1; j < airlines.Length; j++) // ссортировка по алфовиту рейсов
                {
                    if (airlines[j].GetTimeOfFlight() > MostLongFly.GetTimeOfFlight())
                        MostLongFly = airlines[j];
                }
                MostLongFly.InfoFlight();
                Console.BackgroundColor = ConsoleColor.Black;
                if (YesOrNo()) break;
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
