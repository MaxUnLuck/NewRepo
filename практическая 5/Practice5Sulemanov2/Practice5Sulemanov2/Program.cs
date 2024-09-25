//////////////////////////////////////////////////////////////
//* Практическая работа № 5                                 //
//* Сулейманов Максим 2ИСПд                                 //
//* 2 группа 7 вариант                                      //                         
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5Sulemanov2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 5";
            Console.WriteLine("Здравствуйте, пользователь\nЭто программа ввода игральных карт\nВведите достоинство ");
            int Dostoinstvo = Convert.ToInt32(Console.ReadLine()); // вводим достоинство от 6 до 14
            Console.WriteLine("Введите масть ");
            int Mast = Convert.ToInt32(Console.ReadLine()); // вводим масти от 1 до 4
            if (Dostoinstvo == 6) // вывод достоинства
                Console.Write("Шестерка");
            else
                if (Dostoinstvo == 7)
                    Console.Write("Семерка");
                else
                    if (Dostoinstvo == 8)
                        Console.Write("Восьмерки");
                    else
                        if (Dostoinstvo == 9)
                            Console.Write("Девяфтки");
                        else
                            if (Dostoinstvo == 10)
                                Console.Write("Десятки");
                            else
                                if (Dostoinstvo == 11)
                                    Console.Write("Валлет");
                                else
                                    if (Dostoinstvo == 12)
                                        Console.Write("Дама");
                                    else
                                        if (Dostoinstvo == 13)
                                            Console.Write("Король");
                                        else
                                            Console.Write("Туз");
            if (Mast == 1) // вывод масти
                Console.Write(" бубны");
            else
                if (Mast == 2)
                    Console.Write(" трефы");
                else
                    if (Mast == 3)
                        Console.Write(" черви");
                    else
                        Console.Write(" пик");
            Console.ReadKey(); // приостанавливаем программу что бы увидить текст считыванием символа
        }
    }
}
