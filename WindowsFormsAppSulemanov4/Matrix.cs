using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSulemanov4
{
    internal class MyMatrix<T>
    {
        uint width;
        uint height;
        T A;
        T B;
        public T[,] matrix;
        public MyMatrix(uint width, uint height, T A, T B)
        {
            this.width = width;
            this.height = height;
            this.A = A;
            this.B = B;
            matrix = new T[width, height];
            DiagonalMinFill(matrix);
            TopFillA(matrix, A);
            BottomFillB(matrix, B);
        }
        void RandomFill()
        {
            Random random = new Random();
            for (int i = 1; i < height; i++) // нахождение минимального числа модуля элемента главной диоганали матрицы
            {
                for (int j = 1; j < width; j++)
                {
                    matrix[i, j] = ;
                }
            }
        }
        void DiagonalMinFill(T[,] matrix)
        {
            T minnum = matrix[0, 0];
            for (int i = 1; i < matrix.Length; i++) // нахождение минимального числа модуля элемента главной диоганали матрицы
            {
                if (Convert.ToInt32(minnum) > Convert.ToInt32(matrix[i, i]))
                {
                    minnum = matrix[i, i];
                }
            }
            for (int i = 1; i < matrix.Length; i++) // заполнение диоганали минимальным элементом
            {
                matrix[i, i] = minnum;
            }
        }
        void TopFillA(T[,] matrix, T element)
        {
            for (int i = 0; i < matrix.Length; i++) // длина диоганали // замена всех элементов матрицы выше главной диоганали на 1
            {
                for (int j = 0; j < matrix.Length; j++) // строка
                {
                    for (int k = 0; k < matrix.Length; k++) // столбец
                    {
                        if (j < k)
                        {
                            matrix[j, k] = element;
                        }
                    }
                }
            }
        }
        void BottomFillB(T[,] matrix, T element)
        {
            for (int i = 0; i < matrix.Length; i++) // длина диоганали // замена всех элементов матрицы ниже главной диоганали на 2
            {
                for (int j = 0; j < matrix.Length; j++) // строка
                {
                    for (int k = 0; k < matrix.Length; k++) // столбец
                    {
                        if (j > k)
                        {
                            matrix[j, k] = element;
                        }
                    }
                }
            }
        }
    }
}
