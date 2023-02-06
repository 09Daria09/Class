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

        Matrix()
        {
            int maxValue = matrix[0, 0];
            int minValue = matrix[0, 0];
        }
        public void Input()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Введите значение матрицы -> {i + 1} {j + 1}");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }


        
    }
}
