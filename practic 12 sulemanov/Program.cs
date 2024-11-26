////////////////////////////////////////////////
//* Практическая работа № 13                 *//
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
using System.CodeDom.Compiler;
using System.Data;
public class HelloWorld
{
    static void ExeptionWrite(string extext) // вывод сообщения ошибок
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(extext);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
    }
    static bool YesOrNo(string text) // опрос с ответом да(Y) или нет(N)
    {
        string ReadedSymbol = string.Empty;
        while (true)
        {
            try
            {
                Console.Write(text + "да(Y) или нет(N): ");
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
    static string WriteAndReadDuration(string text) // вывод тектса запроса и ввод ответа
    {
        string ReadedText = string.Empty;
        while (true)
        {
            bool isnoex = false;
            try
            {
                Console.Write(text);
                ReadedText = Console.ReadLine();
                if (ReadedText == string.Empty)
                {
                    ExeptionWrite("Вы не ввели текст");
                    continue;
                }
                char[] ReadedTextchar = new char[ReadedText.Length];
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
        return ReadedText;
    }
    static string WriteAndRead(string text) // вывод тектса запроса и ввод ответа
    {
        string ReadedText = string.Empty;
        while (true)
        {
            bool isnoex = false;
            try
            {
                Console.Write(text);
                ReadedText = Console.ReadLine();
                if (ReadedText == string.Empty)
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
        return ReadedText;
    }
    static int WriteAndReadInt(string text) // вывод тектса запроса и ввод ответа
    {
        int ReadedText = 0;
        while (true)
        {
            bool isnoex = false;
            try
            {
                Console.Write(text);
                ReadedText = Convert.ToInt32(Console.ReadLine());
                if (ReadedText < 0)
                {
                    ExeptionWrite("Не может быть отрицательным.");
                    continue;
                }
                if (ReadedText == 0)
                {
                    ExeptionWrite("Не может быть равен нулю.");
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
        return ReadedText;
    }
    struct AirLine
    {
        public string destination;
        public int id;
        public string typeofplane;
        public int durationhour;
        public AirLine(string destination_, int id_, string typeofplane_, int durationhour_) // конструктор
        {
            destination = destination_;
            id = id_;
            typeofplane = typeofplane_;
            durationhour = durationhour_;
        }
        public char Symbol() // возращает первый символ насзвания рейса
        {
            return destination[0];
        }
        public void info() // выводит информацию
        {
            Console.WriteLine($"[{Symbol()}]Рейс:" +
                "\n  В направлении: " + destination +
                "\n  номер рейса: " + id +
                "\n  Будет лететь: " + durationhour +
                "\n  Тип самолета: " + typeofplane);
        }
        //public string GetDestination()
        //{
        //    return destination;
        //}
        //public int Getid()
        //{
        //    return id;
        //}
        //public string GetTypeOfPlane()
        //{
        //    return typeofplane;
        //}
        //public int GetDurationHour()
        //{
        //    return durationhour;
        //}
        //public void SetDestination(string destination_)
        //{
        //    destination = destination_;
        //}
        //public void Setid(int id_)
        //{
        //    id = id_;
        //}
        //public void SetTypeOfPlane(string typeofplane_)
        //{
        //    typeofplane = typeofplane_;
        //}
        //public void SetDurationHour(int durationhour_)
        //{
        //    durationhour = durationhour_;
        //}
    }
    //static void Swap(AirLine first, AirLine second)
    //{
    //    AirLine tempf = first;
    //    AirLine temps = second;
    //    first = temps;
    //    second = tempf;
    //}
    //static void Swap1to2(AirLine first, AirLine second)
    //{
    //    (first, second) = (second, first);
    //}
    //static void SwapAtributes(AirLine first, AirLine second)
    //{
    //    AirLine temp = new AirLine("", 0, "", 0);
    //    temp.SetDestination(first.GetDestination());
    //    temp.Setid(first.Getid());
    //    temp.SetTypeOfPlane(first.GetTypeOfPlane());
    //    temp.SetDurationHour(first.GetDurationHour());
    //    first.SetDestination(second.GetDestination());
    //    first.Setid(second.Getid());
    //    first.SetTypeOfPlane(second.GetTypeOfPlane());
    //    first.SetDurationHour(second.GetDurationHour());
    //    second.SetDestination(temp.GetDestination());
    //    second.SetTypeOfPlane(temp.GetDestination());
    //    second.Setid(temp.Getid());
    //    second.SetDurationHour(temp.GetDurationHour());
    //}

    public static void Main(string[] args)
    {
        Console.Title = "Практическая номер 13";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        while (true)  // бесканечный цикл
        {
            AirLine[] airLines = new AirLine[1];
            int count = 0;
            Console.WriteLine("Здравствуйте это программа выводящая список рейсов!\nВведите пожалуйста рейс(ы).");
            while (true)
            {
                if (YesOrNo("Хотите добавить рейс?"))
                {
                    count++;
                    Array.Resize(ref airLines, count);
                    airLines[count - 1] = new AirLine(WriteAndRead("  Направление с большой буквы: "),
                        WriteAndReadInt("  Номер рейса: "),
                        WriteAndRead("  какое название самолета: "),
                        WriteAndReadInt("  Время полета(часы): "));
                    if (!YesOrNo("Вы правильно ввели рейс? Если нет он будет удален!"))
                    {
                        count--;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int j = 0; j < airLines.Length; j++) // сортировка по алфавиту
            {
                for (int i = 0; i < airLines.Length - 1; i++)
                {
                    if (airLines[i].Symbol() > airLines[i + 1].Symbol())
                    {
                        //(airLines[i], airLines[i + 1]) = (airLines[i + 1], airLines[i]);
                        //swap(airLines[i], airLines[i + 1]);
                        string tempAtr1 = airLines[i].destination;
                        int tempAtr2 = airLines[i].id;
                        string tempAtr3 = airLines[i].typeofplane;
                        int tempAtr4 = airLines[i].durationhour;
                        airLines[i].destination = airLines[i + 1].destination;
                        airLines[i].id = airLines[i + 1].id;
                        airLines[i].typeofplane = airLines[i + 1].typeofplane;
                        airLines[i].durationhour = airLines[i + 1].durationhour;
                        airLines[i + 1].destination = tempAtr1;
                        airLines[i + 1].id = tempAtr2;
                        airLines[i + 1].typeofplane = tempAtr3;
                        airLines[i + 1].durationhour = tempAtr4;
                    }
                }N
            }
            for (int i = 0; i < airLines.Length; i++) // вывод
            {
                airLines[i].info();
            }
            if (YesOrNo("Хотите закончить программу? "))
            {
                break;
            }
            Console.Clear();
        }
    }
}