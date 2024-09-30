///////////////////////////////////////////////////
/// * Практическая работа № 7                   ///
/// * Сулейманов Максим Андреевич 2-ИСПд        ///
/// * Выполнить Практическую по циклам          ///
///////////////////////////////////////////////////
using System;
namespace практическая_7_вариант_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 7";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            for (; ; ) // повторяющийся цикл который закончиться когда пользователь захочет
            {
                Console.Write("Здраствуйте, введите число M (целочисленное и больше нуля): ");
                try  // проверка на то что правильно введены пременные
                {
                    int M = Convert.ToInt32(Console.ReadLine()); // количество итераций
                    if (M == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("M не может быть ровна нулю");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (M < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("M не может быть отрицательная");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    double Summ = 1; // конечное значение
                    double SummCos = 0; // значение cos
                    double SummSin = 0; // значение 
                    for (int i = 1; i <= M; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            SummCos += Math.Cos(j);
                        }
                        for (int l = 1; l <= i; l++)
                        {
                            SummSin += Math.Sin(l);
                        }
                        Summ = Summ * (SummCos / SummSin);
                        SummCos = 0; 
                        SummSin = 0;
                    }
                    Console.WriteLine("Ответ: " + Math.Round(Summ, 5));
                    Console.Write("Закончить программу? да(Y) нет(N)");
                    string select_key = Console.ReadLine();
                    if (select_key == "Y")
                    {
                        break;
                    }
                    else
                    {
                        if (select_key == "N")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не правильное значение, программа принудительно закончиться");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                catch (System.SystemException DBZE)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(DBZE.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception Ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
        }
    }
}
