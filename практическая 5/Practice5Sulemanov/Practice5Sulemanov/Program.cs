using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5Sulemanov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Masts = {"бубны","трефы","черви","пики"};
            string[] Dostoinstvs = { "шестерка", "семерка", "восьмерка", "девятка", "девятка", "валет", "дама", "король", "туз"};
            Console.WriteLine("Введите масть");
            int Mast = 0;
            bool isTrue = true;
            while (isTrue)
            {
                Mast = Convert.ToInt32(Console.ReadLine());
                if (Mast >= 1 & Mast <= 4)
                {
                    isTrue = false;
                } 
                else
                {
                    Console.WriteLine("некоректное число масти, ещё раз введите");
                }
            }
            Console.WriteLine("Введите достоинство");
            int Dostoinstvo = 0;
            isTrue = true;
            while (isTrue)
            {
                Dostoinstvo = Convert.ToInt32(Console.ReadLine());
                if (Dostoinstvo >= 6 & Dostoinstvo <= 14)
                {
                    isTrue = false;
                }
                else
                {
                    Console.WriteLine("некоректное число достоинства, ещё раз введите");
                }
            }
            Console.WriteLine(Dostoinstvs[Dostoinstvo - 6] + " " + Masts[Mast - 1]);
            Console.ReadKey();
        }
    }
}
