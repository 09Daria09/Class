using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Matrix
    {
        Random random = new Random();
        private int[,] matrix;
        private int maxValue;
        private int minValue;
        private int n;

        public Matrix(int len)
        {
            n = len;
            matrix = new int[n, n];
        }

        public Matrix()
        {
        }

        public int Len
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }
        public int this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
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
        public void InputRand()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1,10);
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"  {matrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Len);
            for (int i = 0; i < a.Len; i++)
            {
                for (int j = 0; j < b.Len; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Len);
            for (int i = 0; i < a.Len; i++)
            {
                for (int j = 0; j < b.Len; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Len);
            for (int i = 0; i < a.Len; i++)
            {
                for (int j = 0; j < b.Len; j++)
                {
                    result[i, j] = a[i, j] * b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, int b)
        {
            Matrix result = new Matrix(a.Len);
            for (int i = 0; i < a.Len; i++)
            {
                for (int j = 0; j < a.Len; j++)
                {
                    result[i, j] = a[i, j] * b;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            bool result;
            for (int i = 0; i < a.Len; i++)
            {
                for (int j = 0; j < a.Len; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        result = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a==b);
        }

    }
}
