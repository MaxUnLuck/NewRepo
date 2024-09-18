///////////////////////////////////////////////////////////
//*Практическая 1                                        *                            
//*Сулейманов Максим Андереевич 2-ИСПд                   *           
//*задание: сделать программу по уровнению.              *                                    
///////////////////////////////////////////////////////////
using System;
namespace практическая_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; // обьявление переменных
            Console.Title = "Практическая 1";
            Console.BackgroundColor = ConsoleColor.White; // замена цвета фона на белый
            Console.ForegroundColor = ConsoleColor.Black; // замена цвета шрифта на черный
            Console.WriteLine("Здравствуйте!"); 
            Console.Write("Введите число a = ");
            a = Convert.ToDouble(Console.ReadLine()); // ввод переменных
            Console.Write("Введите число b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число c = ");
            c = Convert.ToDouble(Console.ReadLine());
            double v1 = Math.Pow(10, 3); // возведение переменных в степень
            double v2 = Math.Pow(a, 4);
            double v3 = Math.Pow(b, 0.5);
            double v4 = Math.Pow(c, -3);
            double v5 = Math.Log10(v1 * v2 * v3 * v4); // перемножение всех 4 действий и потом считается lg
            double v6 = 0.4 * Math.Pow(a, -2) * b; // вторая половина уравнения
            double v7 = v5 + v6; // складывание половин уравнения
            Console.WriteLine($"Ответ = {Math.Round(v7, 5)}"); // вывод ответа и округление
            Console.ReadKey();
        }
    }
}
