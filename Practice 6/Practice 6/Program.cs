//////////////////////////////////////////////////////////////
//* Практическая работа № 6                                 //
//* Сулейманов Максим 2ИСПд                                 //
//* 2 группа 7 вариант                                      //                         
//////////////////////////////////////////////////////////////
using System;

namespace Practice5Sulemanov2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6";
            Console.WriteLine("Здравствуйте, пользователь\nЭто программа ввода игральных карт");
            Console.Write("Введите достоинство ");
            int dignity = Convert.ToInt32(Console.ReadLine()); // вводим достоинство от 6 до 14
            Console.Write("Введите масть ");
            int suit = Convert.ToInt32(Console.ReadLine()); // вводим масти от 1 до 4
            switch (dignity)// вывод достоинства
            {
                case (6):
                    Console.Write("Шестерка");
                    break;
                case (7):
                    Console.Write("Семерка");
                    break;
                case (8):
                    Console.Write("Шестерка");
                    break;
                case (9):
                    Console.Write("Девятка");
                    break;
                case (10):
                    Console.Write("Десятка");
                    break;
                case (11):
                    Console.Write("Валлет");
                    break;
                case (12):
                    Console.Write("Дама");
                    break;
                case (13):
                    Console.Write("Король");
                    break;
                case (14):
                    Console.Write("Туз");
                    break;
                default:
                    Console.Write("достоинство не правильно указано,");
                    break;
            }
            switch (suit) // вывод масти
            {
                case (1):
                    Console.Write(" бубны");
                    break;
                case (2):
                    Console.Write(" трефы");
                    break;
                case (3):
                    Console.Write(" черви");
                    break;
                case (4):
                    Console.Write(" пик");
                    break;
                default:
                    Console.Write(", масть не правильно указана");
                    break;
            }
            Console.ReadKey(); // приостанавливаем программу что бы увидить текст считыванием символа
        }
    }
}