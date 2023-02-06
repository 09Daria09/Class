using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Matrix
    {
        int[,] matrix = new int[5, 5];
        private int maxValue;
        private int minValue;
        public Matrix()
        {
            maxValue = matrix[0, 0];
            minValue = matrix[0, 0];
        }
        
        public int MaxValue
        {
            get
            {
                return maxValue = matrix.Cast<int>().Max();
            }
        }
        public int MinValue
        {
            get
            {

                return minValue = matrix.Cast<int>().Min();
            }
        }
        public void Input()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Введите значение матрицы (координаты {i + 1} {j + 1}) -> ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        public void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
