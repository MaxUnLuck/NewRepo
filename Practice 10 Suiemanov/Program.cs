////////////////////////////////////////////////////
/// * Практическая работа № 10                   ///
/// * Сулейманов Максим Андреевич 2-ИСПд         ///
/// * Выполнить Практическую дву мерным массивам ///
////////////////////////////////////////////////////
using System;
namespace Practice_10_Suiemanov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичекая №10";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                try
                {
                    Console.WriteLine("Здраствуйте!");
                    Console.Write("Введите какого порядка матрица ");
                    int orderoftable = Convert.ToInt32(Console.ReadLine());
                    if (orderoftable <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Массив не может быть с порядком меньше одного.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    int[,] table = new int[orderoftable, orderoftable];
                    bool isnoex = false;
                    for (int i = 0; i < orderoftable; i++) // Ввод матрицы
                    {
                        for (int j = 0; j < orderoftable; j++)
                        {
                            while (!isnoex)
                            {
                                isnoex = true;
                                try
                                {
                                    Console.Write($"Введите значение элемент строки {i + 1} и столбца {j + 1}: ");
                                    table[i, j] = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (IndexOutOfRangeException iex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(iex.Message);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    isnoex = false;
                                }
                                catch (FormatException fex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(fex.Message);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    isnoex = false;
                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ex.Message);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    isnoex = false;

                                }
                            }
                            isnoex = false;
                        }
                    }
                    Console.WriteLine("Ваша матрица это:");
                    for (int i = 0; i < orderoftable; i++) // вывод исходной матрицы
                    {
                        for (int j = 0; j < orderoftable; j++)
                        {
                            Console.Write($"[{table[i, j]}]");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Ваша матрица но измененная это:");
                    int minnum = table[0, 0];
                    for (int i = 1; i < orderoftable; i++) // нахождение минимального числа модуля элемента главной диоганали матрицы
                    {
                        if (minnum > table[i, i])
                        {
                            minnum = table[i, i];
                        }
                    }
                    for (int i = 0; i < orderoftable; i++) // длина диоганали // замена всех элементов матрицы выше главной диоганали на 1
                    {
                        for (int j = 0; j < orderoftable; j++) // строка
                        {
                            for (int k = 0; k < orderoftable; k++) // столбец
                            {
                                if (j < k)
                                {
                                    table[j, k] = 1;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < orderoftable; i++) // длина диоганали // замена всех элементов матрицы ниже главной диоганали на 2
                    {
                        for (int j = 0; j < orderoftable; j++) // строка
                        {
                            for (int k = 0; k < orderoftable; k++) // столбец
                            {
                                if (j > k)
                                {
                                    table[j, k] = 2;
                                }
                            }
                        }
                    }
                    for (int i = 1; i < orderoftable; i++) // заполнение диоганали минимальным элементом
                    {
                        table[i, i] = minnum;
                    }
                    for (int i = 0; i < orderoftable; i++) // вывод изменненного массива
                    {
                        for (int j = 0; j < orderoftable; j++)
                        {
                            Console.Write($"[{table[i, j]}]");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                catch(IndexOutOfRangeException iex)
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(iex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (FormatException fex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(fex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
